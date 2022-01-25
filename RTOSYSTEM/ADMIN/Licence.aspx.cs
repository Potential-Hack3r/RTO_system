﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace RTOSYSTEM.ADMIN
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\RTO_SYSTEM\\RTOSYSTEM\\RTOSYSTEM\\App_Data\\RTODATABSE\\RTO_DATABASE.mdf;Integrated Security=True;User Instance=True";
            con.ConnectionString = constr;
            cmd.Connection = con;
            if (!IsPostBack)
            {
                try
                {
                    con.Open();
                    cmd.CommandText = "select * from Driving_License";
                    da.SelectCommand = cmd;
                    int i = cmd.ExecuteNonQuery();
                   
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        GridView1.DataSource = ds.Tables[0];
                        GridView1.DataBind();
                    }
                    else
                    {
                        GridView1.DataSource = String.Empty;
                    }

                }
                catch (Exception ex)
                {
                    Response.Write(ex);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.Visible = false;
            try
            {
                con.Open();
                
                cmd.CommandText = "select * from Driving_License where user_id='" + TextBox1.Text + "'";
                int i = cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                   
                    GridView2.DataSource = ds.Tables[0];
                    GridView2.DataBind();

                }
                else
                {
                    Response.Write("<script>alert('There Is no Records')</script>");
                }

            }
            catch (Exception ex)
            {
              
                Response.Write(ex);
            }
            finally
            {
                con.Close();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
