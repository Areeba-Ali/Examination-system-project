using System.Data.SqlClient;

namespace forom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            
                con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True";
                
            
            SqlCommand cmd = new SqlCommand(("Insert into dbo.form(Username,Password) Values ('" + txtUser + "','" + txtPassword + "')"));
            
                con.Open();
               var v= cmd.EndExecuteNonQuery;
               MessageBox.Show("Your data has been entered successfully");
            con.Close();
        }
    }
}