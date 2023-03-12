using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MedicalSystem
{
    public partial class Pharmacy : Form
    {
        public Pharmacy()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                 "Server=(Local);Database=MedicalSystem;Integrated Security=sspi";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM tb_Pharmacy;";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable PharmacytTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(PharmacytTable);
            sqlConnection.Close();
            this.dgv_Parmacy.DataSource = PharmacytTable;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(Local);Database=MedicalSystem;Integrated Security=sspi";
            SqlCommand insertCommand = new SqlCommand();
            insertCommand.Connection = sqlConnection;
            insertCommand.CommandText =
                "INSERT tb_Pharmacy" +
                 "(DrugNo,Drug,Content,Unit)" +
                 " VALUES(@DrugNo,@Drug,@Content,@Unit);";
            insertCommand.Parameters.Add("@DrugNo", SqlDbType.Char, 4, "DrugNo");
            insertCommand.Parameters.Add("@Drug", SqlDbType.VarChar, 0, "Drug");
            insertCommand.Parameters.Add("@Content", SqlDbType.VarChar, 0, "Content");
            insertCommand.Parameters.Add("@Unit", SqlDbType.VarChar, 0, "Unit");
            SqlCommand updateCommand = new SqlCommand();
            updateCommand.Connection = sqlConnection;
            updateCommand.CommandText =
                "UPDATE tb_Pharmacy" +
                 " SET DrugNo=@NewDrugNo,Drug=@Drug,Content=@Content,Unit=@Unit" +
                 " WHERE DrugNo=@OldDrugNo;";
            updateCommand.Parameters.Add("@NewDrugNo", SqlDbType.Char, 4, "DrugNo");
            updateCommand.Parameters.Add("@Drug", SqlDbType.VarChar, 0, "Drug");
            updateCommand.Parameters.Add("@Content", SqlDbType.VarChar, 0, "Content");
            updateCommand.Parameters.Add("@Unit", SqlDbType.VarChar, 0, "Unit");
            updateCommand.Parameters.Add("@OldDrugNo", SqlDbType.Char, 4, "DrugNo");
            updateCommand.Parameters["@OldDrugNo"].SourceVersion = DataRowVersion.Original;
            SqlCommand deleteCommand = new SqlCommand();
            deleteCommand.Connection = sqlConnection;
            deleteCommand.CommandText =
                "DELETE tb_Pharmacy WHERE DrugNo=@DrugNo;";
            deleteCommand.Parameters.Add("@DrugNo", SqlDbType.Char, 4, "DrugNo");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.InsertCommand = insertCommand;
            sqlDataAdapter.UpdateCommand = updateCommand;
            sqlDataAdapter.DeleteCommand = deleteCommand;
            DataTable ParmacyTable = (DataTable)this.dgv_Parmacy.DataSource;
            sqlConnection.Open();
            int rowAffected = sqlDataAdapter.Update(ParmacyTable);
            sqlConnection.Close();
            MessageBox.Show($"更新{rowAffected}行。");
        }
    }
}
