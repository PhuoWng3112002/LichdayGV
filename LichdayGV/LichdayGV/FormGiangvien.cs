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
    public partial class FormGiangvien : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["LDGV"].ConnectionString;

        private DataView dv = new DataView();

        public FormGiangvien()
        {
            InitializeComponent();
        }

             private bool closeForm = true;
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
        closeForm = false;
            this.Close();
        Login sh = new Login();
        sh.Show();
        }

        private void phânCôngLịchDạyGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ldgv = new FormLDGV();
            ldgv.Show();
            this.Hide();

        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lop = new FormLop();
            lop.Show();
            this.Hide();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var home = new Form1();
            home.Show();
            this.Hide();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mon = new FormMon();
            mon.Show();
            this.Hide();
        }

        private void LoadToDataGridView(string filter = "")
        {
            string querySelect = "select*from  GIANGVIEN";
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
                            using (DataTable GV = new DataTable())
                            {
                                adapter.Fill(GV);
                                if (GV.Rows.Count > 0)
                                {
                                    dv = GV.DefaultView;
                                    if (filter != null)
                                    {
                                        dv.RowFilter = filter;
                                    }
                                    dgv_GV.AutoGenerateColumns = false;
                                    dgv_GV.DataSource = dv;
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
        private void LoadToComboBox()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                LoadToDataGridView();
                using (SqlCommand sqlCommand = new SqlCommand("pr_chucvu", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbChucvu.ValueMember = "sChucvu";
                        cbChucvu.DataSource = dt;
                        cbChucvu.Text = string.Empty;
                    }

                }

            }
        }

            private void FormGiangvien_Load(object sender, EventArgs e)
        {
            LoadToDataGridView();
            LoadToComboBox();
        }

        private void dgv_GV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_GV.CurrentRow.Index;
            tbMagv.Text = dgv_GV.Rows[index].Cells["magv"].Value.ToString();
            tbTengv.Text = dgv_GV.Rows[index].Cells["tengv"].Value.ToString();
            tbNgaysinh.Text = dgv_GV.Rows[index].Cells["ngaysinh"].Value.ToString();
            tbDiachi.Text = dgv_GV.Rows[index].Cells["diachi"].Value.ToString();
            tbSDT.Text = dgv_GV.Rows[index].Cells["sdt"].Value.ToString();
            cbChucvu.Text = dgv_GV.Rows[index].Cells["chucvu"].Value.ToString();

            if ((string)dv[index]["sGioitinh"] == "Nam")
            {
                rb_nam.Checked = true;
            }
            else 
            {
                rb_nu.Checked = true;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Crystal_Report_Viewer crtgv = new Crystal_Report_Viewer();
            crtgv.Show();
        }
    }
}
