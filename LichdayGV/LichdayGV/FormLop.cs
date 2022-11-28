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
    public partial class FormLop : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["LDGV"].ConnectionString;

        private DataView dv = new DataView();

        public FormLop()
        {
            InitializeComponent();
        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phânCôngLịchDạyGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private bool closeForm = true;

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            closeForm = false;
            this.Close();
            Login sh = new Login();
            sh.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var home = new Form1();
            home.Show();
            this.Hide();
        }

        private void phânCôngGiảngDạyGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ldgv = new FormLDGV();
            ldgv.Show();
            this.Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void LoadToDataGridView(string filter = "")
        {
            string querySelect = "select*from  LOP";
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
                            using (DataTable LOP = new DataTable())
                            {
                                adapter.Fill(LOP);
                                if (LOP.Rows.Count > 0)
                                {
                                    dv = LOP.DefaultView;
                                    if (filter != null)
                                    {
                                        dv.RowFilter = filter;
                                    }
                                    dgv_Lop.AutoGenerateColumns = false;
                                    dgv_Lop.DataSource = dv;
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

        private void FormLop_Load(object sender, EventArgs e)
        {
            LoadToDataGridView();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mon = new FormMon();
            mon.Show();
            this.Hide();
        }

        private void quảnLýGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gv = new FormGiangvien();
            gv.Show();
            this.Hide();
        }

        private void dgv_Lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_Lop.CurrentRow.Index;
            tbMalop.Text = dgv_Lop.Rows[index].Cells["malop"].Value.ToString();
            tbSoSV.Text = dgv_Lop.Rows[index].Cells["sosv"].Value.ToString();
        }
    }
}
