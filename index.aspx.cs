using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testAIBVC
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "testserveraibvc.database.windows.net";
                builder.UserID = "aibvctest";
                builder.Password = "AIBVC1!a";
                builder.InitialCatalog = "test";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * ");
                    sb.Append("FROM [dbo].[persone]; ");
                    String sql = sb.ToString();
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    connection.Close();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        provaSQL.InnerText += dt.Rows[i][0].ToString() + " " + dt.Rows[i][1].ToString() + " " +  dt.Rows[i][2].ToString() + "\n";
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "testserveraibvc.database.windows.net";
                builder.UserID = "aibvctest";
                builder.Password = "AIBVC1!a";
                builder.InitialCatalog = "test";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("INSERT INTO persone (nome, cognome) VALUES (@nome, @cognome);");
                    String sqli = sb.ToString();
                    SqlCommand cmd = new SqlCommand(sqli, connection);
                    SqlParameter p1 = new SqlParameter("@nome", lblNome.Value);
                    SqlParameter p2 = new SqlParameter("@cognome", lblCognome.Value);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}