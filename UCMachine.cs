using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beacher
{
    public partial class UCMachine : UserControl
    {
        public event ToolboxChanged ToolboxChange;
        public delegate void ToolboxChanged();

        public event SaveClicked SaveClick;
        public delegate void SaveClicked(string MachineX, string MachineY, string StartCode, string EndCode, string DefaultSpeed, string BitmapSpeed);

        public UCMachine()
        {
            InitializeComponent();
        }

        private void UCMachine_Load(object sender, EventArgs e)
        {
            this.Height = toolStrip1.Height;
            tssbOpenClose.Image = imageList2.Images[0];
        }

        private void LoadData()
        {
            using (DataStuffLight dsl = new DataStuffLight())
            {
                DataTable dt = dsl.GetMachineSettings();

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            switch (row["SettingName"].ToString())
                            {
                                case "MachineSizeX":

                                    tMachineX.Text = row["SettingValue"].ToString();
                                    break;

                                case "MachineSizeY":

                                    tMachineY.Text = row["SettingValue"].ToString();
                                    break;

                                case "MachineStartCode":

                                    tMachineStartCode.Text = row["SettingValue"].ToString();
                                    break;

                                case "MachineEndCode":

                                    tMachineEndCode.Text = row["SettingValue"].ToString();
                                    break;

                                case "MachineDefaultSpeed":

                                    tDefaultSpeed.Text = row["SettingValue"].ToString();
                                    break;

                                case "MachineBitmapSpeed":

                                    tBitmapSpeed.Text = row["SettingValue"].ToString();
                                    break;

                                default:
                                    break;
                            }
                        }
                    }
                }

            }
        }
        private void cmdSaveSettings_Click(object sender, EventArgs e)
        {
            using (DataStuffLight dsl = new DataStuffLight())
            {
                dsl.DeleteSettings();

                dsl.SaveSetting("MachineSizeX", tMachineX.Text);
                dsl.SaveSetting("MachineSizeY", tMachineY.Text);
                dsl.SaveSetting("MachineStartCode", tMachineStartCode.Text);
                dsl.SaveSetting("MachineEndCode", tMachineEndCode.Text);
                dsl.SaveSetting("MachineDefaultSpeed", tDefaultSpeed.Text);
                dsl.SaveSetting("MachineBitmapSpeed", tBitmapSpeed.Text);

                MessageBox.Show("Machine settings saved.", "Machine Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SaveClick?.Invoke(tMachineX.Text, tMachineY.Text, tMachineStartCode.Text, tMachineEndCode.Text, tDefaultSpeed.Text, tBitmapSpeed.Text);
            }
        }

        private void tssbOpenClose_Click(object sender, EventArgs e)
        {
            if (this.Height > toolStrip1.Height + 100)
            {
                this.Height = toolStrip1.Height;
                tssbOpenClose.Image = imageList2.Images[0];
            }
            else
            {
                this.Height = 508;

                tssbOpenClose.Image = imageList2.Images[1];

                LoadData();
            }

            ToolboxChange?.Invoke();
        }
    }
}
