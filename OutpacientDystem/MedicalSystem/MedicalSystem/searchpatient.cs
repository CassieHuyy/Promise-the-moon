using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MedicalSystem
{
    public partial class searchpatient : Form
    {
        public static long MedicalCardId;
        public static string PatientNAME;
        public static string PAYTYPE;
        public static string pinying;
        private DataTable PatientTable;
        public searchpatient()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.dgv_patient.AllowUserToAddRows = false;
            this.dgv_patient.RowHeadersVisible = false;
            this.dgv_patient.BackgroundColor = Color.White;
            this.dgv_patient.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            registration registration = new registration();
            registration.Show();
            this.Close();
        }
        public string GetSex(object value)
        {
            if (value.ToString() == "1")
            {
                return "女";
            }
            else
            {
                return "男";
            }
        }
        public void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
           "Server=(Local);Database=MedicalSystem;Integrated Security=sspi";
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT MedicalCardId,PatientNAME,pinying," +
                                     "  Case GENDER WHEN '1' THEN '男' Else '女' End As GENDER," +
                                     "  BIRTHDATE,AGE,NATIONALITY,PROVINCE,CITY,ADDRESS,TEL,IDCARD,PAYTYPE,MARRYSITUATION,registerTime FROM tb_PATIENTINFOR WHERE pinying=@pinying;";
            sqlCommand.Parameters.AddWithValue("@pinying", this.txbpingyin.Text);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable patientTable = new DataTable();
            sqlDataAdapter.Fill(patientTable);
            this.PatientTable = patientTable;
            this.dgv_patient.Columns.Clear();
            this.dgv_patient.DataSource = patientTable;
            this.dgv_patient.Columns["MedicalCardId"].ReadOnly = true;
            this.dgv_patient.Columns["MedicalCardId"].HeaderText = "医保卡号";
            this.dgv_patient.Columns["PatientNAME"].HeaderText = "患者姓名";
            this.dgv_patient.Columns["pinying"].HeaderText = "拼音";
            this.dgv_patient.Columns["GENDER"].HeaderText = "性别";
            this.dgv_patient.Columns["BIRTHDATE"].HeaderText = "生日";
            this.dgv_patient.Columns["AGE"].HeaderText = "年龄";
            this.dgv_patient.Columns["PROVINCE"].HeaderText = "省份";
            this.dgv_patient.Columns["CITY"].HeaderText = "县市";
            this.dgv_patient.Columns["ADDRESS"].HeaderText = "具体地址";
            this.dgv_patient.Columns["TEL"].HeaderText = "电话号码";
            this.dgv_patient.Columns["IDCARD"].HeaderText = "身份证号";
            this.dgv_patient.Columns["PAYTYPE"].HeaderText = "计费类型";
            this.dgv_patient.Columns["NATIONALITY"].HeaderText = "国籍";
            this.dgv_patient.Columns["MARRYSITUATION"].HeaderText = "婚姻状况";
            this.dgv_patient.Columns["registerTime"].HeaderText = "登记时间";
            GetSex("GENDER");
            sqlConnection.Close();
        }

        private void searchpatient_Load(object sender, EventArgs e)
        {
           
        }

        private void dgv_patient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnchosen_Click(object sender, EventArgs e)
        {
            MedicalCardId = Convert.ToInt64(dgv_patient.CurrentRow.Cells["MedicalCardId"].Value.ToString());
            PatientNAME = dgv_patient.CurrentRow.Cells["PatientNAME"].Value.ToString();
            pinying = dgv_patient.CurrentRow.Cells["pinying"].Value.ToString();
            PAYTYPE = dgv_patient.CurrentRow.Cells["PAYTYPE"].Value.ToString();
            registration registration = new registration();
            registration.Show();
            this.Close();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                 "Server=(Local);Database=MedicalSystem;Integrated Security=sspi";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM tb_PATIENTINFOR;";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable pacientTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(pacientTable);
            sqlConnection.Close();
            this.dgv_patient.DataSource = pacientTable;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(Local);Database=MedicalSystem;Integrated Security=sspi";
            SqlCommand insertCommand = new SqlCommand();
            insertCommand.Connection = sqlConnection;
            insertCommand.CommandText =
                "INSERT tb_PATIENTINFOR" +
                 "(MedicalCardId,PatientNAME,pinying,GENDER,BIRTHDATE,AGE，NATIONALITY，PROVINCE，CITY，ADDRESS，TEL，IDCARD，PAYTYPE，MARRYSITUATION，registerTime，Photo)" +
                 " VALUES(@MedicalCardId,@PatientNAME,@pinying,@GENDER,@BIRTHDATE,@AGE，@NATIONALITY，@PROVINCE，@CITY，@ADDRESS，@TEL，@IDCARD，@PAYTYPE，@MARRYSITUATION，@registerTime，@Photo);";
            insertCommand.Parameters.Add("@MedicalCardId", SqlDbType.BigInt, 8, "MedicalCardId");
            insertCommand.Parameters.Add("@PatientNAME", SqlDbType.VarChar, 0, "PatientNAME");
            insertCommand.Parameters.Add("@pinying", SqlDbType.VarChar, 0, "pinying");
            insertCommand.Parameters.Add("@GENDER", SqlDbType.Bit, 0, "GENDER");
            insertCommand.Parameters.Add("@BIRTHDATE", SqlDbType.DateTime, 0, "BIRTHDATE");
            insertCommand.Parameters.Add("@AGE", SqlDbType.Int, 0, "AGE");
            insertCommand.Parameters.Add("@NATIONALITY", SqlDbType.VarChar, 0, "NATIONALITY");
            insertCommand.Parameters.Add("@CITY", SqlDbType.VarChar, 0, "CITY");
            insertCommand.Parameters.Add("@ADDRESS", SqlDbType.VarChar, 0, "ADDRESS");
            insertCommand.Parameters.Add("@TEL", SqlDbType.VarChar, 0, "TEL");
            insertCommand.Parameters.Add("@IDCARD", SqlDbType.VarChar, 0, "IDCARD");
            insertCommand.Parameters.Add("@PAYTYPE", SqlDbType.VarChar, 0, "PAYTYPE");
            insertCommand.Parameters.Add("@MARRYSITUATION", SqlDbType.VarChar, 0, "MARRYSITUATION");
            insertCommand.Parameters.Add("@registerTime", SqlDbType.DateTime, 0, "registerTime");
            insertCommand.Parameters.Add("@Photo", SqlDbType.VarBinary, 0, "Photo");
            SqlCommand updateCommand = new SqlCommand();
            updateCommand.Connection = sqlConnection;
            updateCommand.CommandText =
                "UPDATE tb_PATIENTINFOR" +
                 " SET MedicalCardId=@NewMedicalCardId,PatientNAME=@PatientNAME,pinying=@pinying,GENDER=@GENDER,BIRTHDATE=@BIRTHDATE,AGE=@AGE,NATIONALITY=@NATIONALITY,CITY=@CITY,ADDRESS=@ADDRESS,TEL=@TEL,IDCARD=@IDCARD,PAYTYPE=@PAYTYPE,MARRYSITUATION=@MARRYSITUATION,registerTime=@registerTime,Photo=@Photo" +
                 " WHERE MedicalCardId=@OldMedicalCardId;";
            updateCommand.Parameters.Add("@NewMedicalCardId", SqlDbType.BigInt, 8, "MedicalCardId");
            updateCommand.Parameters.Add("@PatientNAME", SqlDbType.VarChar, 0, "PatientNAME");
            updateCommand.Parameters.Add("@pinying", SqlDbType.VarChar, 0, "pinying");
            updateCommand.Parameters.Add("@GENDER", SqlDbType.Bit, 0, "GENDER");
            updateCommand.Parameters.Add("@BIRTHDATE", SqlDbType.DateTime, 0, "BIRTHDATE");
            updateCommand.Parameters.Add("@AGE", SqlDbType.Int, 0, "AGE");
            updateCommand.Parameters.Add("@NATIONALITY", SqlDbType.VarChar, 0, "NATIONALITY");
            updateCommand.Parameters.Add("@CITY", SqlDbType.VarChar, 0, "CITY");
            updateCommand.Parameters.Add("@ADDRESS", SqlDbType.VarChar, 0, "ADDRESS");
            updateCommand.Parameters.Add("@TEL", SqlDbType.VarChar, 0, "TEL");
            updateCommand.Parameters.Add("@IDCARD", SqlDbType.VarChar, 0, "IDCARD");
            updateCommand.Parameters.Add("@PAYTYPE", SqlDbType.VarChar, 0, "PAYTYPE");
            updateCommand.Parameters.Add("@MARRYSITUATION", SqlDbType.VarChar, 0, "MARRYSITUATION");
            updateCommand.Parameters.Add("@registerTime", SqlDbType.DateTime, 0, "registerTime");
            updateCommand.Parameters.Add("@Photo", SqlDbType.VarBinary, 0, "Photo");
            updateCommand.Parameters.Add("@OldMedicalCardId", SqlDbType.BigInt, 8, "MedicalCardId");
            updateCommand.Parameters["@OldMedicalCardId"].SourceVersion = DataRowVersion.Original;
            SqlCommand deleteCommand = new SqlCommand();
            deleteCommand.Connection = sqlConnection;
            deleteCommand.CommandText =
                "DELETE tb_PATIENTINFOR WHERE MedicalCardId=@MedicalCardId;";
            deleteCommand.Parameters.Add("@MedicalCardId",SqlDbType.BigInt,8,"MedicalCardId");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.InsertCommand = insertCommand;
            sqlDataAdapter.UpdateCommand = updateCommand;
            sqlDataAdapter.DeleteCommand = deleteCommand;
            DataTable patientTable = (DataTable)this.dgv_patient.DataSource;
            sqlConnection.Open();
            int rowAffected = sqlDataAdapter.Update(patientTable);
            sqlConnection.Close();
            MessageBox.Show($"更新{rowAffected}行。");
        }
    }
}

