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
    public partial class Login : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["LDGV"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tbTK.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string name = tbTK.Text;
            string pass = tbMK.Text;
            if(name=="admin")
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("", cnn))
                    {
                        cmd.CommandText = "insert into tbl_user values ( @ma, @tg )";
                        cmd.Parameters.AddWithValue("@ma", "admin");
                        cmd.Parameters.AddWithValue("@tg", DateTime.Now);

                        cnn.Open();
                        int row_af = cmd.ExecuteNonQuery();
                        //if (row_af > 0)
                        //{
                        //    MessageBox.Show("Thêm thành công!");
                        //}
                    }
                }
                Form1 wlc = new Form1();
                wlc.Show();
                this.Hide();

            }    
            else
            {
                var tkb = new TKB(tbTK.Text);
                tkb.Show();
                this.Hide();

                //using (SqlConnection cnn = new SqlConnection(connectionString))
                //{
                //    using (SqlCommand cmd = new SqlCommand("", cnn))
                //    {
                //        cmd.CommandText = "insert into tbl_user values ( @ma, @tg )";
                //        cmd.Parameters.AddWithValue("@ma", "admin");
                //        cmd.Parameters.AddWithValue("@tg", DateTime.Now);

                //        cnn.Open();
                //        int row_af = cmd.ExecuteNonQuery();
                //        //if (row_af > 0)
                //        //{
                //        //    MessageBox.Show("Thêm thành công!");
                //        //}
                //    }
                //}
                //TKB tkb = new TKB();
                //tkb.Show();
                //this.Hide();


            }
        }
                private ErrorProvider errorProvider = new ErrorProvider();


        private void tbTK_Validating(object sender, CancelEventArgs e)
        {
            if(tbTK.Text!="GV1" && tbTK.Text != "GV2" && tbTK.Text != "GV3" && tbTK.Text != "GV4" && tbTK.Text != "GV5" && tbTK.Text != "GV6" && tbTK.Text != "GV7" && tbTK.Text != "GV8" && tbTK.Text != "GV9" && tbTK.Text != "GV10" && tbTK.Text != "admin")
            {
                e.Cancel = true;
                errorProvider.SetError(tbTK, "Tài khoản không tồn tại");

            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbTK, null);
            }
        }

        private void reportDocument1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
