using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beacher
{
    public partial class DesignSave : Form
    {
        public event SaveClicked SaveClick;
        public delegate void SaveClicked(string DesignName);

        public event OpenClicked OpenClick;
        public delegate void OpenClicked(string DesignName);

        public string Action = string.Empty;

        public DesignSave()
        {
            InitializeComponent();
        }

        private void DesignSave_Load(object sender, EventArgs e)
        {
            using (DataStuffLight dsl = new DataStuffLight())
            {
                DataTable dt = dsl.GetDesignNames();

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            cbDesignName.Items.Add(row["DesignName"].ToString());
                        }
                    }
                }
            }

            if (Action == "Save")
            {
                cmdSave.Visible = true;
                cmdOpen.Visible = false;
            }
            else
            {
                cmdSave.Visible = false;
                cmdOpen.Visible = true;
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (cbDesignName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter or select a design name.", "Beacher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SaveClick?.Invoke(cbDesignName.Text);

            this.Close();
        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            if (cbDesignName.Text.Trim() == "")
            {
                MessageBox.Show("Please select a design name to open.", "Beacher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            OpenClick?.Invoke(cbDesignName.Text);

            this.Close();
        }
    }
}
