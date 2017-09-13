using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Account
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetData();
            }

        }

        private void GetData()
        {
            using (SqlConnection con = new SqlConnection("Data Source=PRADEEP\\SQLEXPRESS;Initial Catalog=Account;Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand("Select * from Accounts", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr["AccountNumber"].ToString() == "A1")
                    {
                        Label1.Text = "A1";
                        Label5.Text = rdr["Balance"].ToString();
                        Label3.Text = rdr["CustomerName"].ToString();

                    }
                    else
                    {
                        Label2.Text = "A2";
                        Label6.Text = rdr["Balance"].ToString();
                        Label4.Text = rdr["CustomerName"].ToString();
                    }
                }



            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=PRADEEP\\SQLEXPRESS;Initial Catalog=Account;Integrated Security=True;"))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    
                    SqlCommand cmd = new SqlCommand("update Accounts set Balance=Balance-10 where AccountNumber='A1'", con,transaction);
                 
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("update Accounts set Balance=Balance+10 where AccountNumber='A2'", con,transaction);
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    Label7.Text = "Transaction Succesful";
                    Label7.ForeColor = System.Drawing.Color.Green;

                }
                catch
                {
                    transaction.Rollback();
                    Label7.Text = "Transaction failed";
                    Label7.ForeColor = System.Drawing.Color.Red;

                }
                GetData();
            }
        }
    }
}