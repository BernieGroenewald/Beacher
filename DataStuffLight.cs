using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace Beacher
{
    public class DataStuffLight : MarshalByRefObject, IDisposable
    {
        string ConnectionString = GlobalStatic.ConnectionString;

        public bool LoadDataStore(string DBFile)
        {
            bool TablesCreated = false;
            bool DBCreated = false;

            try
            {
                if (CreateDatabase(DBFile))
                {
                    DBCreated = true;
                    CreateTables();
                    TablesCreated = true;
                }
                else
                {
                    CreateTables();
                    TablesCreated = true;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return DBCreated && TablesCreated;
        }

        private bool CreateDatabase(string DBFile)
        {
            try
            {
                if (!File.Exists(DBFile))
                {
                    SQLiteConnection.CreateFile(DBFile);
                    return true;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return false;
        }

        public bool TestConnection(string ConnStr)
        {
            try
            {
                using (SQLiteConnection c = new SQLiteConnection(ConnStr))
                {
                    c.Open();
                    c.Close();

                    return true;
                }
            }

            catch (Exception ex)
            {
                return false;
            }
        }

        private void ExecuteNonQuery(string SQL)
        {
            try
            {
                using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                {
                    c.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(SQL, c))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool CreateTables()
        {
            bool TableCreated = false;

            try
            {
                if (!TableExist("DesignData"))
                {
                    string sql = "create table DesignData (DesignName varchar(200), PartOfPattern int, PatternType varchar(100), XPos numeric, YPos numeric, SequenceNo int)";
                    ExecuteNonQuery(sql);
                    TableCreated = true;
                }

                if (!TableExist("MachineSetting"))
                {
                    string sql = "create table MachineSetting (SettingName varchar(200), SettingValue varchar(1024))";
                    ExecuteNonQuery(sql);
                    TableCreated = true;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return TableCreated;
        }

        private bool TableExist(string tableName)
        {
            bool IsExistingTable = false;

            string sql = "select name from sqlite_master where type = 'table' and name = '" + tableName + "'";

            try
            {
                using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                {
                    c.Open();

                    using (SQLiteCommand command = new SQLiteCommand(sql, c))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsExistingTable = true;
                                break;
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return IsExistingTable;
        }

        public DataTable GetDesign(string DesignName)
        {
            string sql = "select DesignName, PartOfPattern, PatternType, XPos, YPos " +
                         "from DesignData " +
                         "where DesignName = '" + DesignName + "' order by SequenceNo";

            try
            {
                using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                {
                    c.Open();

                    using (SQLiteDataAdapter myDa = new SQLiteDataAdapter(sql, c))
                    {
                        DataTable myDt = new DataTable();

                        myDa.Fill(myDt);

                        return myDt;
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetMachineSettings()
        {
            string sql = "select SettingName, SettingValue " +
                         "from MachineSetting";

            try
            {
                using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                {
                    c.Open();

                    using (SQLiteDataAdapter myDa = new SQLiteDataAdapter(sql, c))
                    {
                        DataTable myDt = new DataTable();

                        myDa.Fill(myDt);

                        return myDt;
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetDesignNames()
        {
            string sql = "select distinct DesignName " +
                         "from DesignData " +
                         "order by DesignName";

            try
            {
                using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                {
                    c.Open();

                    using (SQLiteDataAdapter myDa = new SQLiteDataAdapter(sql, c))
                    {
                        DataTable myDt = new DataTable();

                        myDa.Fill(myDt);

                        return myDt;
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SaveDesign(string DesignName, int PartOfPattern, string PatternType, double XPos, double YPos, int Sequence)
        {
            string sql = "insert into DesignData (DesignName, PartOfPattern, PatternType, XPos, YPos, SequenceNo) " +
                         "select '" + DesignName + "', " + PartOfPattern + ", '" + PatternType + "', " + XPos + ", " + YPos + ", " + Sequence;

            try
            {
                using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                {
                    c.Open();

                    using (SQLiteDataAdapter myDa = new SQLiteDataAdapter(sql, c))
                    {
                        DataTable myDt = new DataTable();

                        myDa.Fill(myDt);

                        return true;
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SaveSetting(string SettingName, string SettingValue)
        {
            string sql = "insert into MachineSetting (SettingName, SettingValue) " +
                         "select '" + SettingName + "', '" + SettingValue + "'";

            try
            {
                using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                {
                    c.Open();

                    using (SQLiteDataAdapter myDa = new SQLiteDataAdapter(sql, c))
                    {
                        DataTable myDt = new DataTable();

                        myDa.Fill(myDt);

                        return true;
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteDesign(string DesignName)
        {
            string sql = "delete from DesignData " +
                         "where DesignName = '" + DesignName + "'";

            try
            {
                using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                {
                    c.Open();

                    using (SQLiteDataAdapter myDa = new SQLiteDataAdapter(sql, c))
                    {
                        DataTable myDt = new DataTable();

                        myDa.Fill(myDt);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteSettings()
        {
            string sql = "delete from MachineSetting";

            try
            {
                using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                {
                    c.Open();

                    using (SQLiteDataAdapter myDa = new SQLiteDataAdapter(sql, c))
                    {
                        DataTable myDt = new DataTable();

                        myDa.Fill(myDt);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int GetNextId(string SQL)
        {
            try
            {
                using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                {
                    c.Open();

                    using (SQLiteDataAdapter myDa = new SQLiteDataAdapter(SQL, c))
                    {
                        DataTable myDt = new DataTable();

                        myDa.Fill(myDt);

                        if (myDt != null)
                        {
                            if (myDt.Rows.Count > 0)
                            {
                                return Convert.ToInt32(myDt.Rows[0][0].ToString()) + 1;
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return -1;
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
