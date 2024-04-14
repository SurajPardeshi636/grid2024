using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace gridview_data_show
{
    public partial class FindEmpDetailsByID : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                GridView();
            }

        }

        void GridView()
        {

            string Empid = TextBox1.Text.Trim();
            string str = @"Data Source=SURAJ\SQLEXPRESS; Initial Catalog=Emp;Integrated Security=True";
            SqlConnection sc = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("empIDdetails", sc);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Empid", Empid);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            // DataSet ds = new DataSet();
            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView();
        }
    }
}