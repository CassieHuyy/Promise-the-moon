using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OutpacientDystem
{
    public partial class frm_Connection_Config : Form
    {
        public frm_Connection_Config()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            if (ConfigurationManager.ConnectionStrings["Sql"] != null)
            {
                SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
                sqlConnectionStringBuilder.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
                this.txb_Server.Text = sqlConnectionStringBuilder.DataSource;
                this.txb_Database.Text = sqlConnectionStringBuilder.InitialCatalog;
                this.ckb_IsWindowsAuthentication.Checked = sqlConnectionStringBuilder.IntegratedSecurity;
            }
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            sqlConnection.Open();
            MessageBox.Show
                ($"连接状态：{sqlConnection.State.ToString()}" +
                 $"\n工作站标识：{sqlConnection.WorkstationId}" +
                 $"\n服务器地址：{sqlConnection.DataSource}" +
                 $"\n服务器版本：{sqlConnection.ServerVersion}" +
                 $"\n数据库名称：{sqlConnection.Database}" +
                 $"\n\n（单击【确定】后将关闭SQL连接）");
            sqlConnection.Close();
        }
    }
}
