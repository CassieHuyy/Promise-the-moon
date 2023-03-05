using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace MedicalSystem
{
    public partial class registration : Form
    {
       // public long medicalid;
        public registration()
        {
            InitializeComponent();
            splitContainer1_Panel2_Paint();
        }

        private void btnCreatepatient_Click(object sender, EventArgs e)
        {
            register register = new register();
            register.Show();
            this.Close();
        }

        private void btnsearchpatient_Click(object sender, EventArgs e)
        {
            searchpatient searchpatient = new searchpatient();
            searchpatient.Show();
            this.Close();

        }

        private void btnregisterationback_Click(object sender, EventArgs e)
        {
            Desktop desktop = new Desktop();
            desktop.Show();
            this.Close();
        }

        public  void btnFresh_Click(object sender, EventArgs e)
        {
            searchpatient searchpatient = new searchpatient();
            txtmedicalid.Text = searchpatient.MedicalCardId.ToString();
            txbname.Text = searchpatient.PatientNAME;
            txbpaytype.Text = searchpatient.PAYTYPE;
            txbpinying.Text = searchpatient.pinying;
        }

        private void cmbOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbregisterDoctor.DataSource = null;
            cmbregisterDoctor.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
           "Server=(Local);Database=MedicalSystem;Integrated Security=sspi";
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText =
            "SELECT D.DoctorName FROM tb_OFFICE AS O, tb_Doctors AS D WHERE O.OFFICEID= D.OFFICEID  AND O.OFFICENAME='" + cmbOffice.Text.ToString() + "'; ";
           
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand.CommandText, sqlConnection);
            DataSet dS = new DataSet();
            sqlDataAdapter.Fill(dS, "DoctorName");
            cmbregisterDoctor.DataSource = dS.Tables["DoctorName"];
            cmbregisterDoctor.DisplayMember = "DoctorName";
            sqlConnection.Close();
        }

        public  void splitContainer1_Panel2_Paint()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
           "Server=(Local);Database=MedicalSystem;Integrated Security=sspi";
            SqlCommand sqlCommand = new SqlCommand();
            SqlCommand sqlCommand2 = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand2.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM tb_OFFICE;";
            sqlCommand2.CommandText = "SELECT * FROM tb_RegisterType;";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter2.SelectCommand = sqlCommand2;
            DataTable officetable = new DataTable();
            DataTable registerTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(officetable);
            this.cmbOffice.DataSource = officetable;
            this.cmbOffice.DisplayMember = "OFFICENAME";
            this.cmbOffice.ValueMember = "OFFICEID";
            sqlConnection.Close();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
           "Server=(Local);Database=MedicalSystem;Integrated Security=sspi";
            SqlCommand sqlCommand = new SqlCommand();
            SqlCommand sqlCommand2 = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand2.Connection = sqlConnection;
            sqlCommand.CommandText =
                "INSERT INTO tb_Register (PatientNAME, MedicalCardId, OFFICEID, RegisterTypeNo, DoctorName, PRICE, registerTime) VALUES (@PatientNAME, @MedicalCardId,@OFFICEID,@RegisterTypeNo,@DoctorName,@PRICE,@registerTime); ";

            sqlCommand2.CommandText = "SELECT @@IDENTITY";
           // medicalid =Convert.ToInt64(this.txtmedicalid.Text.ToString());
            sqlCommand.Parameters.AddWithValue("@PatientNAME", this.txbname.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@MedicalCardId", Convert.ToInt64(this.txtmedicalid.Text));
            sqlCommand.Parameters.AddWithValue("@OFFICEID", Convert.ToInt16(this.cmbOffice.SelectedValue));
           sqlCommand.Parameters.AddWithValue("@RegisterTypeNo",this.txtregisterType.Text);
            sqlCommand.Parameters.AddWithValue("@DoctorName", this.cmbregisterDoctor.Text.ToString());
            sqlCommand.Parameters.AddWithValue("@PRICE", this.txbregistermoney.Text.ToString());
            sqlCommand.Parameters.AddWithValue("@registerTime", dateTimePicker1.Value.ToShortDateString()); 
            sqlConnection.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();
            int mdnumber =Convert.ToInt32(sqlCommand2.ExecuteScalar());
            if (rowAffected == 1)
            {
                MessageBox.Show(
      $"您的挂号数为:{mdnumber}",
      "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                this.Close();
                Desktop desktop = new Desktop();
                desktop.Show();
                this.Close();
            }
            sqlConnection.Close();

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void cmbregistertype_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    SqlConnection sqlConnection = new SqlConnection();
        //    sqlConnection.ConnectionString =
        //   "Server=(Local);Database=MedicalSystem;Integrated Security=sspi";
        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.Connection = sqlConnection;
        //    sqlConnection.Open();
        //    sqlCommand.CommandText = "SELECT PRICE FROM tb_RegisterType  WHERE RegisterTypeName='" + cmbregistertype.Text.ToString() + "'; ";
        //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        //    if (sqlDataReader.Read())
        //    {
        //        this.txbregistermoney.Text = sqlDataReader["PRICE"].ToString();
        //    }
        //   // float price= (float)(sqlCommand.ExecuteScalar());
        //    //this.txbregistermoney.Text = price.ToString();
        //    sqlConnection.Close();
        //}

        private void cmbregisterDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Server=(Local);Database=MedicalSystem;Integrated Security=sspi;";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT RT.RegisterTypeName,RT.PRICE FROM tb_Doctors AS D" +
                                    "  JOIN tb_RegisterType AS RT ON RT.RegisterTypeNo = D.RegisterTypeNo " +
                                    "  WHERE DoctorName = '"+this.cmbregisterDoctor.Text.ToString()+"';";
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                this.txtregisterType.Text = sqlDataReader["RegisterTypeName"].ToString();
                this.txbregistermoney.Text = sqlDataReader["PRICE"].ToString();
            }
            sqlConnection.Close();
          
        }
    }
}
