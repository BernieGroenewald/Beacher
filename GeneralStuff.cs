using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beacher
{
    public class GeneralStuff
    {
        double MaxX = 0;
        double MaxY = 0;

        public enum SpiralType
        {
            Linear,
            Quadratic,
            Cubic,
            Exponential
        }

        public double MachineMaxX
        {
            get 
            {
                return MaxX;
            }
            set
            {
                MaxX = value;
            }
        }

        public double MachineMaxY
        {
            get
            {
                return MaxY;
            }
            set
            {
                MaxY = value;
            }
        }

        public struct Vertex
        {
            public double x;
            public double y;
            public double Speed;
        }

        public Vertex Rotate(Vertex vertex, double AngleDegrees)
        {
            double Angle = Math.PI / 180 * AngleDegrees;

            Vertex v;

            v.x = vertex.x * Math.Cos(Angle) - vertex.y * Math.Sin(Angle);
            v.y = vertex.x * Math.Sin(Angle) + vertex.y * Math.Cos(Angle);
            v.Speed = vertex.Speed;

            return v;
        }

        public Vertex Scale(Vertex vertex, double ScalePercent)
        {
            double scale = ScalePercent / 100;

            Vertex v;

            v.x = vertex.x * scale;
            v.y = vertex.y * scale;
            v.Speed = vertex.Speed;

            return v;
        }

        public Vertex Offset(Vertex vertex, double OffsetX, double OffsetY)
        {
            Vertex v;

            v.x = vertex.x + OffsetX;
            v.y = vertex.y + OffsetY;
            v.Speed = vertex.Speed;

            return v;
        }

        public Vertex Track(Vertex vertex, bool TrackGrowEnabled, int LoopIndex)
        {
            //let angle = data.trackLength * loop_index / 16 * 2.0 * Math.PI;
            //let radius = 1.0;
            //if (data.trackGrowEnabled)
            //{
            //    radius = 1.0 + loop_index / 10.0 * data.trackGrow / 100.0;
            //}
            //return {
            //    x: vertex.x + radius * data.trackValue * Math.cos(angle),
            //    y: vertex.y + radius * data.trackValue * Math.sin(angle),
            //    f: vertex.f, // Why do I still have f in here?
            //  };

            return vertex;
        }

        public List<VertexPoint> PolygonPoints(double StartX, double StartY, int NumberOfSides, double Length, int PartOfPattern)
        {
            List<VertexPoint> points = new List<VertexPoint>();
            VertexPoint LastValid = new VertexPoint();

            for (int i = 0; i <= NumberOfSides; i++)
            {
                double Angle = Math.PI * 2.0 / NumberOfSides * (0.5 + i);

                VertexPoint vp = new VertexPoint();

                vp.x = StartX + (Length * Math.Cos(Angle));
                vp.y = StartY + (Length * Math.Sin(Angle));

                LastValid = WithinBounds(vp.x, vp.y);
                LastValid.PartOfPattern = PartOfPattern;
                LastValid.PatternType = "Polygon";

                points.Add(LastValid);
            }

            return points;
        }

        private double ToRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        public List<VertexPoint> GetPolySpiralPoints(double StartX, double StartY, double AngleIncrement, double Length, int Revolutions, int PartOfPattern, string StopAt, double IncrementSide)
        {
            bool FinishBorder = false;

            List<VertexPoint> points = new List<VertexPoint>();

            VertexPoint StartPoint = new VertexPoint();

            VertexPoint LastValid = new VertexPoint();
            
            StartPoint.x = StartX;
            StartPoint.y = StartY;
            StartPoint.PartOfPattern = PartOfPattern;
            StartPoint.PatternType = "Spiral";


            double x1 = StartX;
            double y1 = StartY;
            double angle = AngleIncrement;

            for (int i = 0; i < Revolutions; i++)
            {
                double x2 = x1 + Math.Cos(angle) * Length;
                double y2 = y1 - Math.Sin(angle) * Length;

                x1 = x2;
                y1 = y2;

                Length += IncrementSide;

                angle = (angle + AngleIncrement) % (Math.PI * 2);

                VertexPoint vp = new VertexPoint();

                vp.x = x1;
                vp.y = y1;

                if ((LastValid.x != vp.x) && (LastValid.y != vp.y))
                {
                    LastValid = WithinBounds(vp.x, vp.y);
                    LastValid.PartOfPattern = PartOfPattern;
                    LastValid.PatternType = "PolySpiral";

                    points.Add(LastValid);

                    if (FinishBorder)
                    {
                        if (IsNearBorder(vp, vp, StartPoint, StopAt))
                        {
                            break;
                        }
                    }
                }
            }
             
            return points;
        }

        public List<VertexPoint> GetSpiralPoints(double StartX, double StartY, double A, double angle_offset, double max_r, int PartOfPattern, string StopAt, string Direction, string ToInOut, SpiralType Spiral)
        {
            bool FinishBorder = false;
            
            List<VertexPoint> points = new List<VertexPoint>();

            VertexPoint StartPoint = new VertexPoint();

            VertexPoint LastValid = new VertexPoint();

            const double dtheta = (5 * Math.PI / 180);    // Five degrees.

            StartPoint.x = StartX;
            StartPoint.y = StartY;
            StartPoint.PartOfPattern = PartOfPattern;
            StartPoint.PatternType = "Spiral";
            
            for (double theta = 0; ; theta += dtheta)
            {
                double r = 0;

                switch (Spiral)
                {
                    case SpiralType.Linear:
                        r = A * theta;
                        break;

                    case SpiralType.Cubic:
                        r = A * theta * theta * theta;
                        break;

                    case SpiralType.Exponential:
                        r = (Math.Pow(theta / 180 * Math.PI, Math.E)) * A;
                        break;

                    case SpiralType.Quadratic:
                        r = A * theta * theta;
                        break;

                    default:
                        break;
                }

                // Convert to Cartesian coordinates.
                double x, y;

                PolarToCartesianRev(r, theta + angle_offset, out x, out y);
                
                VertexPoint vp = new VertexPoint();

                // Center.
                vp.x += StartX + x;
                vp.y += StartY + y;
                
                if ((LastValid.x != vp.x) && (LastValid.y != vp.y))
                {
                    LastValid = WithinBounds(vp.x, vp.y);
                    LastValid.PartOfPattern = PartOfPattern;
                    LastValid.PatternType = "Spiral";

                    points.Add(LastValid);

                    if (FinishBorder)
                    {
                        if (IsNearBorder(vp, vp, StartPoint, StopAt))
                        {
                            break;
                        }
                    }
                }

                // If we have gone far enough, stop.

                if (r > max_r)
                {
                    if (StopAt != "None")
                    {
                        FinishBorder = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return points;
        }

        public List<VertexPoint> GetTurtleMove(double StartX, double StartY, double NewAngle, double MoveLength, int PartOfPattern)
        {
            double DrawAngle = 0;

            if (NewAngle <= 180)
            {
                DrawAngle = 180 - NewAngle;
            }
            else
            {
                DrawAngle = 360 - (NewAngle - 180);
            }
            
            List<VertexPoint> points = new List<VertexPoint>();

            VertexPoint StartPoint = new VertexPoint();

            VertexPoint LastValid = new VertexPoint();

            StartPoint.x = StartX;
            StartPoint.y = StartY;
            StartPoint.PartOfPattern = PartOfPattern;
            StartPoint.PatternType = "Turtle Forward";

            double AngleRadians = DrawAngle * Math.PI / 180;

            double NewX = StartX + (MoveLength * Math.Sin(AngleRadians));
            double NewY = StartY + (MoveLength * Math.Cos(AngleRadians));

            VertexPoint vp = new VertexPoint();
            
            vp.x = NewX;
            vp.y = NewY;

            if ((LastValid.x != vp.x) && (LastValid.y != vp.y))
            {
                LastValid = WithinBounds(vp.x, vp.y);
                LastValid.PartOfPattern = PartOfPattern;
                LastValid.PatternType = "Turtle Forward";

                points.Add(LastValid);
            }

            return points;
        }

        public List<VertexPoint> GetTurtleOffset(double StartX, double StartY, double Angle, double OffsetLengthX, double OffsetLengthY, int PartOfPattern)
        {
            double DrawAngle = 0;

            if (Angle <= 180)
            {
                DrawAngle = 180 - Angle;
            }
            else
            {
                DrawAngle = 360 - (Angle - 180);
            }

            List<VertexPoint> points = new List<VertexPoint>();

            VertexPoint StartPoint = new VertexPoint();

            VertexPoint LastValid = new VertexPoint();

            StartPoint.x = StartX;
            StartPoint.y = StartY;
            StartPoint.PartOfPattern = PartOfPattern;
            StartPoint.PatternType = "Turtle Offset";

            double AngleRadians = DrawAngle * Math.PI / 180;

            double NewX = StartX + (OffsetLengthX * Math.Sin(AngleRadians));
            double NewY = StartY + (OffsetLengthY * Math.Cos(AngleRadians));

            VertexPoint vp = new VertexPoint();

            vp.x = NewX;
            vp.y = NewY;

            if ((LastValid.x != vp.x) && (LastValid.y != vp.y))
            {
                LastValid = WithinBounds(vp.x, vp.y);
                LastValid.PartOfPattern = PartOfPattern;
                LastValid.PatternType = "Turtle Forward";

                points.Add(LastValid);
            }

            return points;
        }

        public List<VertexPoint> GetWiperLeftRight(double StartX, double StartY, double Offset, int PartOfPattern)
        {
            List<VertexPoint> points = new List<VertexPoint>();
            double CurX = 0;
            double CurY = 0;

            CurX = StartX;
            CurY = StartY;
            
            while (CurY <= MaxY)
            {
                VertexPoint vp = new VertexPoint();

                if (MaxX > CurX)
                {
                    vp.x = MaxX;
                    CurX = MaxX;
                }
                else
                {
                    CurX = 0;
                }
                
                vp.y = CurY;
                vp.PartOfPattern = PartOfPattern;
                vp.PatternType = "Wiper";

                points.Add(vp);

                CurY += Offset;

                VertexPoint vpOffset = new VertexPoint();

                vpOffset.x = CurX;
                vpOffset.y = CurY;
                vpOffset.PartOfPattern = PartOfPattern;
                vpOffset.PatternType = "Wiper";

                points.Add(vpOffset);
            }

            return points;
        }

        public List<VertexPoint> GetWiperInsideOut(double StartX, double StartY, double Offset, int PartOfPattern)
        {
            List<VertexPoint> points = new List<VertexPoint>();
            double CurX = 0;
            double CurY = 0;
            int Incrementer = 1;
            double FactorX = 1;
            double FactorY = 1;

            CurX = MaxX / 2;
            CurY = MaxY / 2;

            if (MaxX > MaxY)
            {
                FactorX = MaxX / MaxY;
            }

            if (MaxY > MaxX)
            {
                FactorY = MaxY / MaxX;
            }

            VertexPoint vp1 = new VertexPoint();
            
            vp1.y = CurY;
            vp1.x = CurX;
            vp1.PartOfPattern = PartOfPattern;
            vp1.PatternType = "Wiper";

            points.Add(vp1);

            while ((CurY <= MaxY) && (CurX <= MaxX) && (CurY > 0) && (CurX > 0))
            {
                VertexPoint vp2 = new VertexPoint();

                CurX = CurX - (Offset * Incrementer * FactorX);

                vp2.x = CurX;
                vp2.y = CurY;
                vp2.PartOfPattern = PartOfPattern;
                vp2.PatternType = "Wiper";

                points.Add(vp2);

                VertexPoint vp3 = new VertexPoint();

                CurY = CurY - (Offset * Incrementer * FactorY);

                vp3.x = CurX;
                vp3.y = CurY;
                vp3.PartOfPattern = PartOfPattern;
                vp3.PatternType = "Wiper";

                points.Add(vp3);

                Incrementer += 1;

                VertexPoint vp4 = new VertexPoint();

                CurX = CurX + (Offset * Incrementer * FactorX);

                vp4.x = CurX;
                vp4.y = CurY;
                vp4.PartOfPattern = PartOfPattern;
                vp4.PatternType = "Wiper";

                points.Add(vp4);

                VertexPoint vp5 = new VertexPoint();

                CurY = CurY + (Offset * Incrementer * FactorY);

                vp5.x = CurX;
                vp5.y = CurY;
                vp5.PartOfPattern = PartOfPattern;
                vp5.PatternType = "Wiper";

                points.Add(vp5);

                Incrementer += 1;
            }

            return points;
        }

        public List<VertexPoint> GetWiperOutsideIn(double StartX, double StartY, double Offset, int PartOfPattern)
        {
            List<VertexPoint> points = new List<VertexPoint>();
            double CurX = 0;
            double CurY = 0;
            int Incrementer = 1;

            CurX = 0;
            CurY = 0;

            VertexPoint vp1 = new VertexPoint();

            vp1.y = CurY;
            vp1.x = CurX;
            vp1.PartOfPattern = PartOfPattern;
            vp1.PatternType = "Wiper";

            points.Add(vp1);
            

            while ((CurY < (MaxY / 2)) && (CurX < (MaxX / 2)))
            {
                VertexPoint vp2 = new VertexPoint();

                CurX = MaxX - (Offset * Incrementer);

                vp2.x = CurX;
                vp2.y = CurY;
                vp2.PartOfPattern = PartOfPattern;
                vp2.PatternType = "Wiper";

                points.Add(vp2);

                VertexPoint vp3 = new VertexPoint();

                CurY = MaxY - (Offset * Incrementer);

                vp3.x = CurX;
                vp3.y = CurY;
                vp3.PartOfPattern = PartOfPattern;
                vp3.PatternType = "Wiper";

                points.Add(vp3);

                Incrementer += 1;

                VertexPoint vp4 = new VertexPoint();

                CurX = (Offset * Incrementer);

                vp4.x = CurX;
                vp4.y = CurY;
                vp4.PartOfPattern = PartOfPattern;
                vp4.PatternType = "Wiper";

                points.Add(vp4);

                VertexPoint vp5 = new VertexPoint();

                CurY = (Offset * Incrementer);

                vp5.x = CurX;
                vp5.y = CurY;
                vp5.PartOfPattern = PartOfPattern;
                vp5.PatternType = "Wiper";

                points.Add(vp5);

                Incrementer += 1;
            }

            return points;
        }

        public List<VertexPoint> GetWiperDiagonal(double StartX, double StartY, double Offset, int PartOfPattern)
        {
            List<VertexPoint> points = new List<VertexPoint>();
            double CurX = 0;
            double CurY = 0;
            double LastCurX = 0;
            double LastCurY = 0;
            double EndX = 0;
            double EndY = 0;
            double FactorX = 1;
            double FactorY = 1;

            CurX = StartX;
            CurY = StartY;

            if (MaxX > MaxY)
            {
                FactorX = MaxX / MaxY;
            }

            if (MaxY > MaxX)
            {
                FactorY = MaxY / MaxX;
            }

            while ((LastCurY < MaxY) && (LastCurX < MaxX))
            {
                VertexPoint vp1 = new VertexPoint();

                CurX = LastCurX + (Offset * FactorX);
                LastCurX = CurX;
                CurY = StartY;

                vp1.x = CurX;
                vp1.y = CurY;
                vp1.PartOfPattern = PartOfPattern;
                vp1.PatternType = "Wiper";

                points.Add(vp1);

                VertexPoint vp2 = new VertexPoint();

                CurY = LastCurY + (Offset * FactorY);
                LastCurY = CurY;
                CurX = StartX;

                vp2.x = CurX;
                vp2.y = CurY;
                vp2.PartOfPattern = PartOfPattern;
                vp2.PatternType = "Wiper";

                points.Add(vp2);

                VertexPoint vp3 = new VertexPoint();

                CurY = LastCurY + (Offset * FactorY);
                LastCurY = CurY;
                CurX = StartX;

                vp3.x = CurX;
                vp3.y = CurY;
                vp3.PartOfPattern = PartOfPattern;
                vp3.PatternType = "Wiper";

                EndX = CurX;
                EndY = CurY;

                points.Add(vp3);

                VertexPoint vp4 = new VertexPoint();

                CurX = LastCurX + (Offset * FactorX);
                LastCurX = CurX;
                CurY = StartY;

                vp4.x = CurX;
                vp4.y = CurY;
                vp4.PartOfPattern = PartOfPattern;
                vp4.PatternType = "Wiper";

                points.Add(vp4);
            }

            VertexPoint vp5 = new VertexPoint();

            CurX = LastCurX + (Offset * FactorX);
            LastCurX = CurX;
            CurY = StartY;

            vp5.x = EndX;
            vp5.y = EndY;
            vp5.PartOfPattern = PartOfPattern;
            vp5.PatternType = "Wiper";

            points.Add(vp5);

            LastCurX = 0;
            LastCurY = 0;
            CurX = StartX;
            CurY = MaxY;

            while (LastCurX < MaxX)
            {
                VertexPoint vp1 = new VertexPoint();

                CurX = LastCurX + (Offset * FactorX);
                LastCurX = CurX;
                CurY = MaxY;

                vp1.x = CurX;
                vp1.y = CurY;
                vp1.PartOfPattern = PartOfPattern;
                vp1.PatternType = "Wiper";

                points.Add(vp1);

                VertexPoint vp2 = new VertexPoint();

                CurY = LastCurY + (Offset * FactorY);
                LastCurY = CurY;
                CurX = MaxX;

                vp2.x = CurX;
                vp2.y = CurY;
                vp2.PartOfPattern = PartOfPattern;
                vp2.PatternType = "Wiper";

                points.Add(vp2);

                VertexPoint vp3 = new VertexPoint();

                CurY = LastCurY + (Offset * FactorY);
                LastCurY = CurY;
                CurX = MaxX;

                vp3.x = CurX;
                vp3.y = CurY;
                vp3.PartOfPattern = PartOfPattern;
                vp3.PatternType = "Wiper";

                points.Add(vp3);

                VertexPoint vp4 = new VertexPoint();

                CurX = LastCurX + (Offset * FactorX);
                LastCurX = CurX;
                CurY = MaxY;

                vp4.x = CurX;
                vp4.y = CurY;
                vp4.PartOfPattern = PartOfPattern;
                vp4.PatternType = "Wiper";

                points.Add(vp4);
            }

            return points;
        }

        public List<VertexPoint> GetWiperUpDown(double StartX, double StartY, double Offset, int PartOfPattern)
        {
            List<VertexPoint> points = new List<VertexPoint>();
            double CurX = 0;
            double CurY = 0;

            CurX = StartX;
            CurY = StartY;

            while (CurX <= MaxX)
            {
                VertexPoint vp = new VertexPoint();

                if (MaxY > CurY)
                {
                    vp.y = MaxY;
                    CurY = MaxY;
                }
                else
                {
                    CurY = 0;
                }

                vp.x = CurX;
                vp.PartOfPattern = PartOfPattern;
                vp.PatternType = "Wiper";

                points.Add(vp);

                CurX += Offset;

                VertexPoint vpOffset = new VertexPoint();

                vpOffset.y = CurY;
                vpOffset.x = CurX;
                vpOffset.PartOfPattern = PartOfPattern;
                vpOffset.PatternType = "Wiper";

                points.Add(vpOffset);
            }

            return points;
        }

        private bool IsNearBorder(VertexPoint vp, VertexPoint Border, VertexPoint Start, string StopAt)
        {
            double OffSet = 5;
            
            Border = new VertexPoint();

            Border = vp;

            if (StopAt == "Vertical")
            {
                if (vp.x >= MaxX / 2)
                {
                    if (vp.x >= Start.x)
                    {
                        if (vp.y <= Start.y)
                        {
                            if (Start.y - vp.y <= (MaxY * OffSet) / 100)
                            {
                                Border.y = Start.y;
                                Border.x = MaxX;
                                return true;
                            }
                        }
                    }
                }
                else
                {
                    if (vp.x <= Start.x)
                    {
                        if (vp.y <= Start.y)
                        {
                            if (Start.y - vp.y <= (MaxY * OffSet) / 100)
                            {
                                Border.y = Start.y;
                                Border.x = 0;
                                return true;
                            }
                        }
                    }
                }
            }
            else
            {
                if (vp.y >= MaxY / 2)
                {
                    if (vp.y >= Start.y)
                    {
                        if (vp.x <= Start.x)
                        {
                            if (Start.x - vp.x <= (MaxX * OffSet) / 100)
                            {
                                Border.x = Start.x;
                                Border.y = MaxY;
                                return true;
                            }
                        }
                    }
                }
                else
                {
                    if (vp.y <= Start.y)
                    {
                        if (vp.x <= Start.x)
                        {
                            if (Start.x - vp.x <= (MaxX * OffSet) / 100)
                            {
                                Border.x = Start.x;
                                Border.y = 0;
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }
        private VertexPoint WithinBounds(double PointX, double PointY)
        {
            VertexPoint NearestBorder = new VertexPoint();

            NearestBorder.x = PointX;
            NearestBorder.y = PointY;

            if (PointX > MaxX)
            {
                NearestBorder.x = MaxX;
            }

            if (PointX < 0)
            {
                NearestBorder.x = 0;
            }


            if (PointY > MaxY)
            {
                NearestBorder.y = MaxY;
            }

            if (PointY < 0)
            {
                NearestBorder.y = 0;
            }

            return NearestBorder;
        }

        private void PolarToCartesian(double r, double theta, out double x, out double y)
        {
            x = (r * Math.Cos(theta));
            y = (r * Math.Sin(theta));
        }

        private void PolarToCartesianRev(double r, double theta, out double x, out double y)
        {
            x = (r * Math.Cos(theta));
            y = (r * Math.Sin(theta));
        }
    }
}
