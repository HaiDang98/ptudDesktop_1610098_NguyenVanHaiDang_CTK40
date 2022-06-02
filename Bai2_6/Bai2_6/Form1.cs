using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_6
{
    public partial class fmSinhVien : Form
    {
        public fmSinhVien()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinhVienDataSet1.dsSinhVien' table. You can move, or remove it, as needed.
            this.dsSinhVienTableAdapter1.Fill(this.sinhVienDataSet1.dsSinhVien);
            // TODO: This line of code loads data into the 'sinhVienDataSet.dsSinhVien' table. You can move, or remove it, as needed.
            this.dsSinhVienTableAdapter.Fill(this.sinhVienDataSet.dsSinhVien);
            string conectionString = "Data Source=DESKTOP-EI43SN4;Initial Catalog=SinhVien;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(conectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "SELECT [MSSV],[HoVaTen],[Lop] FROM [dsSinhVien] ";
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            this.DisplaySinhVien(sqlDataReader);
            sqlConnection.Close();
            sqlConnection.Dispose();
            this.loadLop();
        }

        private void loadLop()
        {
            string conectionString = "Data Source=DESKTOP-EI43SN4;Initial Catalog=SinhVien;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [Lop] FROM [dsSinhVien] ";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();
            cbbLop.DataSource = dt;
            cbbLop.DisplayMember = " Lop";
            cbbLop.ValueMember = "Lop";
        }

        private void DisplaySinhVien(SqlDataReader sqlDataReader)
        {
            lvDSSinhVien.Items.Clear();
            while (sqlDataReader.Read())
            {
                ListViewItem item = new ListViewItem(sqlDataReader["MSSV"].ToString());
                item.SubItems.Add(sqlDataReader["HoVaTen"].ToString());
                item.SubItems.Add(sqlDataReader["Lop"].ToString());
                lvDSSinhVien.Items.Add(item);

            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtHoVaTen.Text = "";
            lvDSSinhVien.Items.Clear();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            this.dsSinhVienTableAdapter1.Fill(this.sinhVienDataSet1.dsSinhVien);
            // TODO: This line of code loads data into the 'sinhVienDataSet.dsSinhVien' table. You can move, or remove it, as needed.
            this.dsSinhVienTableAdapter.Fill(this.sinhVienDataSet.dsSinhVien);
            string conectionString = "Data Source=DESKTOP-EI43SN4;Initial Catalog=SinhVien;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(conectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "SELECT [MSSV],[HoVaTen],[Lop] FROM [dsSinhVien] ";
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            this.DisplaySinhVien(sqlDataReader);
            sqlConnection.Close();
            sqlConnection.Dispose();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") // empty input mssv
            {
                MessageBox.Show("Chua Nhap Ma So Sinh Vien");
            }
            else
            {
                string MSSV = txtID.Text;
                //Kiem tra MSSv nay da nam trong danh sach chua
                string conectionString = "Data Source=DESKTOP-EI43SN4;Initial Catalog=SinhVien;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(conectionString);
                string query1 = "SELECT * FROM dsSinhVien WHERE MSSV = @MSSV";
                SqlCommand command1 = new SqlCommand(query1, sqlConnection);
                command1.Parameters.Add("@MSSV", txtID.Text);
                sqlConnection.Open();
                SqlCommand command;
                //SqlCommand commandInsertGlobal;

                SqlDataAdapter adapter = new SqlDataAdapter(command1);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                int SVDaCoTrongDB = dt.Rows.Count;

                if (SVDaCoTrongDB > 0)//sinh vien da ton tai; chi cap nhat 
                {
                    MessageBox.Show("Da ton tai");
                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    String query = "UPDATE dsSinhVien SET HoVaTen = @HoVaTen, Lop=@Lop WHERE MSSV = @MSSV";
                    SqlCommand commandUpdate = new SqlCommand(query, sqlConnection);
                    commandUpdate.Parameters.Add("@MSSV", txtID.Text);
                    commandUpdate.Parameters.Add("@HoVaTen", txtHoVaTen.Text);
                    commandUpdate.Parameters.Add("@Lop", cbbLop.Text);
                    int numOfRowsEffected = commandUpdate.ExecuteNonQuery();
                    if (numOfRowsEffected > 0)
                    {
                        MessageBox.Show("Cap nhat thong tin cua sinh vien da ton tai thanh cong");
                        this.dsSinhVienTableAdapter1.Fill(this.sinhVienDataSet1.dsSinhVien);
                        // TODO: This line of code loads data into the 'sinhVienDataSet.dsSinhVien' table. You can move, or remove it, as needed.
                        this.dsSinhVienTableAdapter.Fill(this.sinhVienDataSet.dsSinhVien);
                        string conection = "Data Source=DESKTOP-EI43SN4;Initial Catalog=SinhVien;Integrated Security=True";
                        SqlConnection _conection = new SqlConnection(conection);
                        SqlCommand cmd = _conection.CreateCommand();
                        string _query = "SELECT [MSSV],[HoVaTen],[Lop] FROM [dsSinhVien] ";
                        cmd.CommandText = _query;
                        _conection.Open();
                        SqlDataReader sqlDataReader = cmd.ExecuteReader();
                        this.DisplaySinhVien(sqlDataReader);
                        _conection.Close();
                        _conection.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Da co loi xay ra khi cap nhat thong tin cua SV da co");
                    }

                }
                else// sinh vien chua co trong danh sach; tao moi
                {
                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    String query = "INSERT INTO dsSinhVien (MSSV,HoVaTen,Lop) VALUES (@MSSV,@HoVaTen,@Lop)";

                    SqlCommand commandInsert = new SqlCommand(query, sqlConnection);
                    commandInsert.Parameters.Add("@MSSV", txtID.Text);
                    commandInsert.Parameters.Add("@HoVaTen", txtHoVaTen.Text);
                    commandInsert.Parameters.Add("@Lop", cbbLop.Text);
                    command = commandInsert;
                    int numOfRowsEffected = commandInsert.ExecuteNonQuery();
                    if (numOfRowsEffected == 1)
                    {
                        MessageBox.Show("Cap nhat thanh cong sinh vien moi");
                        this.dsSinhVienTableAdapter1.Fill(this.sinhVienDataSet1.dsSinhVien);
                        // TODO: This line of code loads data into the 'sinhVienDataSet.dsSinhVien' table. You can move, or remove it, as needed.
                        this.dsSinhVienTableAdapter.Fill(this.sinhVienDataSet.dsSinhVien);
                        string conection = "Data Source=DESKTOP-EI43SN4;Initial Catalog=SinhVien;Integrated Security=True";
                        SqlConnection _conection = new SqlConnection(conection);
                        SqlCommand cmd = _conection.CreateCommand();
                        string _query = "SELECT [MSSV],[HoVaTen],[Lop] FROM [dsSinhVien] ";
                        cmd.CommandText = _query;
                        _conection.Open();
                        SqlDataReader sqlDataReader = cmd.ExecuteReader();
                        this.DisplaySinhVien(sqlDataReader);
                        _conection.Close();
                        _conection.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Da co loi xay ra khi cap nhat sinh vien moi");
                    }


                }
                //sqlConnection.Open();


                sqlConnection.Close();




            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string word = txtSearchWord.Text;
            if (word != null)
            {
                // TODO: This line of code loads data into the 'sinhVienDataSet1.dsSinhVien' table. You can move, or remove it, as needed.
                this.dsSinhVienTableAdapter1.Fill(this.sinhVienDataSet1.dsSinhVien);
                // TODO: This line of code loads data into the 'sinhVienDataSet.dsSinhVien' table. You can move, or remove it, as needed.
                this.dsSinhVienTableAdapter.Fill(this.sinhVienDataSet.dsSinhVien);
                string conectionString = "Data Source=DESKTOP-EI43SN4;Initial Catalog=SinhVien;Integrated Security=True";

                SqlConnection sqlConnection = new SqlConnection(conectionString);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                sqlCommand.Parameters.Add("@word", word);
                string query = "SELECT  [MSSV],[HoVaTen],[Lop] FROM [dsSinhVien] WHERE HoVaTen LIKE '%'+@word+'%' ";
                sqlCommand.CommandText = query;
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                this.DisplaySinhVien(sqlDataReader);
                sqlConnection.Close();
                sqlConnection.Dispose();

            }
            else
            {
                MessageBox.Show("Nhap Ten sinh vien can tim");
            }
        }
    }
}
