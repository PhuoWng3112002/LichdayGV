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
using System.Data.SqlClient;

namespace LichdayGV
{
    public partial class FormMon : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["LDGV"].ConnectionString;

        private DataView dv = new DataView();


        public FormMon()
        {
            InitializeComponent();
        }

        private void phânCôngLịchDạyGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ldgv = new FormLDGV();
            ldgv.Show();
            this.Hide();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var home = new Form1();
            home.Show();
            this.Hide();
        }

        private void quảnLýGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gv = new FormGiangvien();
            gv.Show();
            this.Hide();
        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lop = new FormLop();
            lop.Show();
            this.Hide();
        }
        private bool closeForm = true;
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            closeForm = false;
            this.Close();
            Login sh = new Login();
            sh.Show();
        }

        //
        private void LoadToDataGridView(string filter = "")
        {
            string querySelect = "select*from  MON";
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
                            using (DataTable MON = new DataTable())
                            {
                                adapter.Fill(MON);
                                if (MON.Rows.Count > 0)
                                {
                                    dv = MON.DefaultView;
                                    if (filter != null)
                                    {
                                        dv.RowFilter = filter;
                                    }
                                    dgv_Mon.AutoGenerateColumns = false;
                                    dgv_Mon.DataSource = dv;
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

        private void FormMon_Load(object sender, EventArgs e)
        {
            LoadToDataGridView();
        }

        private void dgv_Mon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_Mon.CurrentRow.Index;
            tbMamon.Text = dgv_Mon.Rows[index].Cells["mamon"].Value.ToString();
            tbTenmon.Text = dgv_Mon.Rows[index].Cells["tenmon"].Value.ToString();
            tbTin.Text = dgv_Mon.Rows[index].Cells["sotinchi"].Value.ToString();
        }
    }
}
