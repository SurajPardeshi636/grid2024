using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;



namespace gridview_data_show.GridViewForms
{
    public partial class GridViewUseToKey : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadGrid();
            }
        }

        void LoadGrid()
        {
            string start = txtstrt.Text.Trim();
            string strend = txtend.Text.Trim();

            string str = @"Data Source=SURAJ\SQLEXPRESS; Initial Catalog=Emp;Integrated Security=True";
            SqlConnection sc = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("SearchEmployeesByRange", sc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@StartEmpID", start);
            cmd.Parameters.AddWithValue("@EndEmpID", strend);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}