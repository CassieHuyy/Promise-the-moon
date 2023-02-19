using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OutpacientDystem
{
    public partial class frm_Connection : Form
    {
        public frm_Connection()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=OpsDemo;Integrated Security=sspi";
            sqlConnection.Open();
            MessageBox.Show
                ($"连接状态：{sqlConnection.State.ToString()}" +
                $"\n工作站标识：{sqlConnection.WorkstationId}" +
                $"\n服务器地址：{sqlConnection.DataSource}" +
                $"\n服务器版本：{sqlConnection.ServerVersion}" +
                $"\n数据库名称：{sqlConnection.Database}" +
                $"\n\n(单机【确定】后将关闭sql连接)");
            sqlConnection.Close();
            MessageBox.Show
                ($"连接状态：{sqlConnection.State.ToString()}");
        }
    }
}
