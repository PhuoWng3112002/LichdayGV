using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace LichdayGV
{
    public partial class FormLDGV : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["LDGV"].ConnectionString;
        public FormLDGV()
        {
            InitializeComponent();
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
                                    dgv_LDGV.AutoGenerateColumns = false;
                                    dgv_LDGV.DataSource = dv;
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

        private void FormLDGV_Load(object sender, EventArgs e)
        {
            LoadToDataGridView();
            LoadToComboBox();
        }

        private void dgv_LDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_LDGV.CurrentRow.Index;
            tbNgayday.Text = dgv_LDGV.Rows[index].Cells["ngayday"].Value.ToString();
            cbCaday.Text = dgv_LDGV.Rows[index].Cells["caday"].Value.ToString();
            cbGV.Text = dgv_LDGV.Rows[index].Cells["tengv"].Value.ToString();
            cbMon.Text = dgv_LDGV.Rows[index].Cells["tenmon"].Value.ToString();
            cbMalop.Text = dgv_LDGV.Rows[index].Cells["malop"].Value.ToString();
            cbMaP.Text = dgv_LDGV.Rows[index].Cells["maphong"].Value.ToString();
            cbTrangthai.Text = dgv_LDGV.Rows[index].Cells["trangthai"].Value.ToString();
            tbGhichu.Text = dgv_LDGV.Rows[index].Cells["ghichu"].Value.ToString();

        }
        private void LoadToComboBox()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                LoadToDataGridView();
                using (SqlCommand sqlCommand = new SqlCommand("select sMagv,sTengv from GIANGVIEN", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbGV.ValueMember = "sTengv";
                        cbGV.DataSource = dt;
                        cbGV.Text = string.Empty;
                    }

                }

                using (SqlCommand sqlCommand = new SqlCommand("select sMamon,sTenmon from MON", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        /*cbbMaMon.DisplayMember = "sTenmon";*/
                        cbMon.ValueMember = "sTenMon";
                        cbMon.DataSource = dt;
                        cbMon.Text = string.Empty;
                    }

                }
                using (SqlCommand sqlCommand = new SqlCommand("select sMalop from LOP", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbMalop.ValueMember = "sMalop";
                        if (cbMalop.DataSource != null)
                            cbMalop.Enabled = true;
                        cbMalop.DataSource = dt;

                        cbMalop.Text = string.Empty;

                    }

                }

                using (SqlCommand sqlCommand = new SqlCommand("select sMap from PHONG", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbMaP.ValueMember = "sMap";
                        if (cbMaP.DataSource != null)
                            cbMaP.Enabled = true;

                        cbMaP.DataSource = dt;
                        cbMaP.Text = string.Empty;
                    }

                }

                using (SqlCommand sqlCommand = new SqlCommand("pr_caday", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbCaday.ValueMember = "sCaday";
                        cbCaday.DataSource = dt;
                        cbCaday.Text = string.Empty;
                    }

                }

                using (SqlCommand sqlCommand = new SqlCommand("pr_trangthai", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbTrangthai.ValueMember = "sTrangthai";
                        cbTrangthai.DataSource = dt;
                        cbTrangthai.Text = string.Empty;
                    }

                }

            }

        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            tbNgayday.Text = "";
            cbTrangthai.Text = "";
            cbMon.Text = "";
            cbMaP.Text = "";
            cbGV.Text = "";
            cbCaday.Text = "";
            cbMalop.Text = "";
            tbGhichu.Text = "";

            tbNgayday.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát", "Cảnh báo", MessageBoxButtons.OK);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgv_LDGV.CurrentRow.Index;
            string ngayday = dv[index]["dNgayday"].ToString();
            string ten = dv[index]["sTengv"].ToString();
            string caday = dv[index]["sCaday"].ToString();
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa lịch dạy ngày " + ngayday + " ca " + caday + "của giảng viên " + ten + " không ?", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cm = new SqlCommand(
                            "pr_XoaLDGV"
                            , sqlConnection))
                        {

                            cm.CommandType = CommandType.Text;
                            cm.Parameters.AddWithValue("@ngay", Convert.ToDateTime(tbNgayday.Text));
                            cm.Parameters.AddWithValue("@ca", cbCaday.Text);
                            cm.Parameters.AddWithValue("@gv", cbGV.Text);
                            cm.Parameters.AddWithValue("@mon", cbMon.Text);
                            cm.Parameters.AddWithValue("@lop", cbMalop.Text);
                            cm.Parameters.AddWithValue("@phong", cbMaP.Text);
                            sqlConnection.Open();
                            int row_af = cm.ExecuteNonQuery();
                            if (row_af > 0)
                            {
                                MessageBox.Show("Xóa thành công!");
                            }
                        }

                    }
                    tbNgayday.Text = "";
                    cbCaday.Text = "";
                    cbGV.Text = "";
                    cbMon.Text = "";
                    cbMalop.Text = "";
                    cbMaP.Text = "";
                    cbTrangthai.Text = "";
                    tbGhichu.Text = "";
                    LoadToDataGridView();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                if (error.Contains("40"))
                {
                    MessageBox.Show("Lỗi kết nối SQL");
                }
                else
                {
                    MessageBox.Show("Không thể xóa!!!!");
                }


            }

        }

        private void btnThem_Click(object sender, EventArgs e)


        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
                    {
                        /*DataRowView oDataRowView_gv = cbbMaGV.SelectedItem as DataRowView;
                        DataRowView oDataRowView_mon = cbbMaMon.SelectedItem as DataRowView;
                        string magv = string.Empty;
                        string mamon = string.Empty;

                        if (oDataRowView_gv != null)
                        {
                            magv = oDataRowView_gv.Row["sMagv"] as string;
                        }
                        if (oDataRowView_mon != null)
                        {
                            mamon = oDataRowView_mon.Row["sMamon"] as string;
                        }*/
                        string magv = cbGV.Text;
                        string mamon = cbMon.Text;
                        sqlCommand.CommandText = "themLichday";
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@ngayday", Convert.ToDateTime(tbNgayday.Text));

                        sqlCommand.Parameters.AddWithValue("@caday", cbCaday.Text);
                        sqlCommand.Parameters.AddWithValue("@magv", magv);
                        sqlCommand.Parameters.AddWithValue("@mamon", mamon);
                        sqlCommand.Parameters.AddWithValue("@malop", cbMalop.Text);
                        sqlCommand.Parameters.AddWithValue("@map", cbMaP.Text);
                        sqlCommand.Parameters.AddWithValue("@trangthai", cbTrangthai.Text);
                        sqlCommand.Parameters.AddWithValue("@ghichu", tbGhichu.Text);
                        sqlConnection.Open();

                        sqlCommand.ExecuteScalar();

                        //int row_af = sqlCommand.ExecuteNonQuery();

                        //if (row_af > 0)
                        //{
                        //    MessageBox.Show("Thêm thành công!");
                        //}
                    }

                    //tbNgayday.Text = "";
                    //cbCaday.Text = "";
                    //cbGV.Text = "";
                    //cbMon.Text = "";
                    //cbMalop.Text = "";
                    //cbMaP.Text = "";
                    //cbTrangthai.Text = "";
                    //tbGhichu.Text = "";
                    //LoadToDataGridView();
                }
            }
                catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ngay = tbNgayday.Text;
            string ca = cbCaday.Text;
            string gv = cbGV.Text;
            if (tbNgayday.Text == null)
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
            else
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("pr_UpdateLDGV", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@ngay", ngay);
                        sqlCommand.Parameters.AddWithValue("@ca", ca);
                        sqlCommand.Parameters.AddWithValue("@gv", gv);
                        sqlCommand.Parameters.AddWithValue("@mon", cbMon.Text);
                        sqlCommand.Parameters.AddWithValue("@lop", cbMalop.Text);
                        sqlCommand.Parameters.AddWithValue("@phong", cbMaP.Text);
                        sqlCommand.Parameters.AddWithValue("@tt", cbTrangthai.Text);
                        sqlCommand.Parameters.AddWithValue("@gc", tbGhichu.Text);

                        int row = sqlCommand.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("Cập nhật thành công");
                            tbNgayday.Text = "";
                            cbCaday.Text = "";
                            cbGV.Text = "";
                            cbMon.Text = "";
                            cbMalop.Text = "";
                            cbMaP.Text = "";
                            cbTrangthai.Text = "";
                            tbGhichu.Text = "";

                            LoadToDataGridView();
                        }
                    }
                    sqlConnection.Close();
                }
            }


        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
           

                if (tbNgayday.Text == "" && cbGV.Text == "" && cbMon.Text == "" && cbMalop.Text == "" && cbCaday.Text == "" && cbTrangthai.Text == "" && cbMaP.Text == "")
                {
                    MessageBox.Show("Thiếu dữ liệu!");
                }
                else
                {
                    DataRowView oDataRowView_gv = cbGV.SelectedItem as DataRowView;
                    DataRowView oDataRowView_mon = cbMon.SelectedItem as DataRowView;
                    string magv = string.Empty;
                    string mamon = string.Empty;

                    if (oDataRowView_gv != null)
                    {
                        magv = oDataRowView_gv.Row["sMagv"] as string;
                    }
                    if (oDataRowView_mon != null)
                    {
                        mamon = oDataRowView_mon.Row["sMamon"] as string;
                    }
                    string filter = "select*from vv_select_lichday where dNgayday IS NOT NULL";
                    if (tbNgayday.Text != "")
                    {
                        filter = "select*from vv_select_lichday where dNgayday = @cbngayday ";
                    }
 
                    if (cbGV.Text != "")
                    {
                        filter = filter + " and sMagv = @gv ";
                        MessageBox.Show(filter);
                    }
                    if (cbMon.Text != "")
                    {
                        filter = filter + " and sMamon = @mon ";
                    }
                    if (cbCaday.Text != "")
                    {
                        filter = filter + " and sCaday = @ca ";
                    }
                    if (cbMalop.Text != "")
                    {
                        filter = filter + " and sMalop = @lop ";
                    }
                    if (cbTrangthai.Text != "")
                    {
                        filter = filter + " and sTrangthai = @tt ";
                    }
                    if (cbMaP.Text != "")
                    {
                        filter = filter + " and sMap = @phong ";

                    }
                    using (SqlConnection cnn = new SqlConnection(connectionString))
                    {
                        cnn.Open();
                        using (SqlCommand cmd = new SqlCommand(filter, cnn))
                        {
                            cmd.CommandType = CommandType.Text;

                            
                            if (tbNgayday.Text != "")
                                cmd.Parameters.AddWithValue("@cbngayday", Convert.ToDateTime(tbNgayday.Text));

                            cmd.Parameters.AddWithValue("@gv", magv);
                            cmd.Parameters.AddWithValue("@mon", mamon);
                            cmd.Parameters.AddWithValue("@lop", cbMalop.Text);
                            cmd.Parameters.AddWithValue("@ca", cbCaday.Text);
                            cmd.Parameters.AddWithValue("@tt", cbTrangthai.Text);
                            cmd.Parameters.AddWithValue("@phong", cbMaP.Text);
                            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                            {
                                using (DataTable dt = new DataTable("vv_select_lichday"))
                                {
                                    sda.Fill(dt);
                                    dgv_LDGV.DataSource = dt;
                                }
                            }
                        }
                        cnn.Close();
                    }
                }

            


        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var home = new Form1();
            home.Show();
            this.Hide();
        }

        private void phânCôngLịchDạyGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private bool closeForm = true;

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForm = false;
            this.Close();
            Login sh = new Login();
            sh.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mon = new FormMon();
            mon.Show();
            this.Hide();
        }

        private void giảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gv = new FormGiangvien();
            gv.Show();
            this.Hide();
        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lop = new FormLop();
            lop.Show();
            this.Hide();
        }
    }
}
