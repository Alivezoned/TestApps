using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace ChessAlivezoned
{
    public partial class HostsEditor : Form
    {
        private String ConString = Properties.Settings.Default.DatabseMainConnectionString;
        private String header = "";

        public HostsEditor()
        {
            InitializeComponent();
        }

        private void HostsEditor_Load(object sender, EventArgs e)
        {
            txt_link2.Enabled = false;
            txt_address.Text = "127.0.0.1";
        }

        private void txt_link1_TextChanged(object sender, EventArgs e)
        {
            String txt = txt_link1.Text.ToString().Trim();
            txt_link2.Text = "www." + txt;
            txt_link2.Enabled = true;
        }

        private void btn_add_site_Click(object sender, EventArgs e)
        {
            String link1    = txt_link1.Text.ToString().Trim();
            String link2    = txt_link2.Text.ToString().Trim();
            String address  = txt_address.Text.ToString().Trim();

            if (link1.Length > 0 && link2.Length > 0 && address.Length > 0)
            {
                if (InsertData(link1, link2, address))
                {
                    MessageBox.Show(link1 + " Added");
                }
                else
                {
                    MessageBox.Show("Error");
                }
                ClearForm();
                MessageBox.Show(SelectData("select * from hosts", 1));
                txt_address.Text = "127.0.0.1";
            }
        }

        private void ClearForm()
        {
            txt_link1.Clear();
            txt_link2.Clear();
            txt_address.Clear();
        }

        private void WriteFile()
        {

        }

        private Boolean InsertData(String link1, String link2, String address)
        {
            Boolean success = false;
            using (SqlCeConnection c = new SqlCeConnection(ConString))
            {
                c.Open();
                String query = "insert into hosts(site_link_1, site_link_2, address, visible) values (@val1, @val2, @val3, @val4)";
                using (SqlCeCommand cmd = new SqlCeCommand(query,c))
                {
                    cmd.Parameters.AddWithValue("@val1", link1);
                    cmd.Parameters.AddWithValue("@val2", link2);
                    cmd.Parameters.AddWithValue("@val3", address);
                    cmd.Parameters.AddWithValue("@val4", "1");
                    cmd.CommandType = System.Data.CommandType.Text;
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        success = true;
                    }
                }
                c.Close();
            }
            return success;
        }

        private String SelectData(String query, int col)
        {
            StringBuilder data = new StringBuilder();
            using (SqlCeConnection c = new SqlCeConnection(ConString))
            {
                c.Open();
                SqlCeCommand cmd = new SqlCeCommand(query, c);
                SqlCeDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (col == 0)
                        {
                            Int32 id = reader.GetInt32(col);
                            data.AppendLine(id.ToString());
                        }
                        else
                        {
                            String d = reader.GetString(col);
                            data.AppendLine(d);
                        }
                    }
                c.Close();
            }
            return data.ToString();
        }

        // Sets the Header for the Hosts File.
        private void SetHeader()
        {
            header = @"
# Copyright (c) 1993-2009 Microsoft Corp.
#
# This is a sample HOSTS file used by Microsoft TCP/IP for Windows.
#
# This file contains the mappings of IP addresses to host names. Each
# entry should be kept on an individual line. The IP address should
# be placed in the first column followed by the corresponding host name.
# The IP address and the host name should be separated by at least one
# space.
#
# Additionally, comments (such as these) may be inserted on individual
# lines or following the machine name denoted by a '#' symbol.
#
# For example:
#
#      102.54.94.97     rhino.acme.com          # source server
#       38.25.63.10     x.acme.com              # x client host

# localhost name resolution is handled within DNS itself.

#	::1             localhost
";
        }
    }
}
