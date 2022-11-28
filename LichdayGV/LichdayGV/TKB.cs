using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LichdayGV
{
    public partial class TKB : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["LDGV"].ConnectionString;

        public TKB(string text)
        {
            InitializeComponent();
            label1.Text = text;
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filter = " sMagv IS NOT NULL";
            filter += string.Format(" AND sMagv LIKE {0}", label1.Text);
        }

        bool closeForm = true;
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForm = false;
            this.Close();
            Login sh = new Login();
            sh.Show();
        }
        private DataView dv = new DataView();
        private void LoadToDataGridView(string filter = "")
        {
                string querySelect = "select_LDGV";

                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand sqlCommand = new SqlCommand(querySelect, sqlConnection))
                        {

    
                        sqlCommand.CommandType = CommandType.Text;
                            using (SqlDataAdapter adapter = new SqlDataAdapter())
                            {
                                adapter.SelectCommand = sqlCommand;
                                using (DataTable LDGV = new DataTable())
                                {
                                    adapter.Fill(LDGV);
                                    if (LDGV.Rows.Count > 0)
                                    { 
                                        dv = LDGV.DefaultView;
                                        if (filter != null)
                                        {
                                            dv.RowFilter = filter;
                                        }
                                        dgv_TKB.AutoGenerateColumns = false;
                                        dgv_TKB.DataSource = dv;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Khong ton tai ban ghi nao");
                                    }
                                }
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }


        

        private void TKB_Load(object sender, EventArgs e)
        {

            string filter = " sMagv IS NOT NULL";
            filter += string.Format(" AND sMagv LIKE '{0}'", label1.Text);

            LoadToDataGridView(filter);
        }

        private void lịchDạyChungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadToDataGridView();

        }

        private void lịchDạyCủaTôiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filter = " sMagv IS NOT NULL";
            filter += string.Format(" AND sMagv LIKE '{0}'",label1.Text);

            LoadToDataGridView(filter);
        }

        private void lịchDạyChungToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoadToDataGridView();

        }

        private void lịchDạyCủaTôiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string filter = " sMagv IS NOT NULL";
            filter += string.Format(" AND sMagv LIKE '{0}'", label1.Text);

            LoadToDataGridView(filter);

        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            closeForm = false;
            this.Close();
            Login sh = new Login();
            sh.Show();

        }
    }
}
