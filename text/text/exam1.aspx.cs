using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace exam
{
    public partial class exam1 : System.Web.UI.Page
    {
        private string connectionString = "YourConnectionString";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                LoadPrizes();
            }
        }

        private void LoadPrizes()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();


                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Items", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);


                rptPrizes.DataSource = dt;
                rptPrizes.DataBind();
            }
        }

        protected void BT_Click(object sender, EventArgs e)
        {

            Random rd = new Random();
            int select = rd.Next(rptPrizes.Items.Count);


            RepeaterItem selectItem = rptPrizes.Items[select];
            Label lblPrize = selectItem.FindControl("lblSelectedPrize") as Label;
            Image imgPrize = selectItem.FindControl("imgSelectedPrize") as Image;


            lblPrize.Text = "恭喜你抽中了：" + (selectItem.DataItem as DataRowView)["items"].ToString();
            imgPrize.ImageUrl = (selectItem.DataItem as DataRowView)["IMAG"].ToString();
        }
    }
}
