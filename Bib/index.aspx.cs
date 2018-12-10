using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bib
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            // connect to 
           
            //create SQL statement
            string statement = "SELECT * FROM bib ";
            string where = "WHERE ";
            if (name.Text.Length > 0)
            {
                statement += where;
                statement += "FirstName like '" + name.Text + "%'";
                where = " AND ";
            }
            if (lname.Text.Length > 0)
            {
                statement += where;
                statement += "SurName like '" + lname.Text + "%'";
                where = " AND ";
            }
            if (title.Text.Length > 0)
            {
                statement += where;
                statement += "Title like '%" + title.Text + "%'";
                where = " AND ";
            }
            if (name1.Text.Length > 0)
            {
                statement += where;
                statement += "FirstName1 like '" + name1.Text + "%'";
                where = " AND ";
            }
            if (lname1.Text.Length > 0)
            {
                statement += where;
                statement += "SurName1 like '" + lname1.Text + "%'";
                where = " AND ";
            }
            
            if (isbn.Text.Length > 0)
            {
                statement += where;
                statement += "ISSN like '" + isbn.Text + "%'";
                where = " AND ";
            }
            if (date.Text.Length > 0)
            {
                statement += where;
                statement += "PubDate like '" + date.Text + "%'";
                where = " AND ";
            }

            // create connection with DB

            SqlConnection conn = new SqlConnection(
               ConfigurationManager.ConnectionStrings["TestCS"].ConnectionString);


            conn.Open();


            
            SqlCommand cmd = new SqlCommand(statement);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            
           

            string temp1 = " ";
            string temp2 = " ";
            string temp3 = " ";
            string temp4 = " ";
            string temp5 = " ";
            string temp6 = " ";
            string temp7 = " ";
            string temp8 = " ";
            string temp9 = "";
            string temp10 = "";

            //read from db

            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                temp1 += reader["FirstName"].ToString();
                temp1 += "<br/>";

                temp2 += reader["SurName"].ToString();
                temp2 += "<br/>";

                temp3 += reader["Title"].ToString();
                temp3 += "<br/>";

                temp4 += reader["FirstName1"].ToString();
                temp4 += "<br/>";

                temp5 += reader["SurName1"].ToString();
                temp5 += "<br/>";

                temp6 += reader["BiblioSet_KeyTitle"].ToString();
                temp6 += "<br/>";

                temp7 += reader["ISSN"].ToString();
                temp7 += "<br/>";

                temp8 += reader["PubDate"].ToString();
                temp8 += "<br/>";

                temp9 += reader["Page"].ToString();
                temp9 += "<br/>";

                // output based on Library standard

                temp10 += reader["SurName"].ToString();
                temp10 += ", ";
                temp10 += reader["FirstName"].ToString();
                temp10 += "  ";
                temp10 += "<br/>";
                temp10 += reader["Title"].ToString();
                temp10 += ". / ";
                temp10 += reader["SurName"].ToString();
                temp10 += " ";
                temp10 += reader["FirstName"].ToString();
                temp10 += " - Bibliografija: ";
                temp10 += reader["Page"].ToString();
                temp10 += "<br/>";
                temp10 += " <br/>";





            }



            conn.Close();

            test10.Text = temp10;


        }
    }
}