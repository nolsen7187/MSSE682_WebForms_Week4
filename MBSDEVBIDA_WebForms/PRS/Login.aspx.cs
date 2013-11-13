using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DAL;
using System.Configuration;
using System.Data.Entity;


public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {        
        SqlConnection dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AXMbsDevEntities"].ConnectionString);
        dbConnection.Open();
        string userNameLookupSQLStatement = "select * from MBSWBWEBUSERCONTACT where WEBLOGON = '" + TextBoxUserName.Text + "'";
        SqlCommand checkUserName = new SqlCommand(userNameLookupSQLStatement, dbConnection);
        string temp = checkUserName.ExecuteScalar().ToString();//Convert.ToInt32(checkUserName.ExecuteScalar().ToString());
        if (checkUserName != null)
        {
            //Added Week 3 Comment
            string passwordLookupSQLStatement = "Select WEBPASSWORD from MBSWBWEBUSERCONTACT where WEBPASSWORD = '" + TextBoxPassword.Text + "'";
            SqlCommand checkPassword= new SqlCommand(passwordLookupSQLStatement, dbConnection);

            string password = checkPassword.ExecuteScalar().ToString();
            dbConnection.Close();
            if(password == TextBoxPassword.Text)
            {
                Session["New"] = TextBoxUserName.Text;
                Response.Redirect("Secure.aspx");
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Invalid Password";
            }
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "Invalid Username";
        }      
    }
}