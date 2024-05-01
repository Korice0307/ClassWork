using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1108
{
    public partial class Wellet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String itemStr = Request["chk1"];
            char[] charList = { ',', ',' };
            string[] items = itemStr.Split(charList);
            int price = 0, all = 0;
            string priceStr;
            demo.Text = "<ul>";
            for(int i = 0; i < items.Length; i++)
            {
                demo.Text += "<li>" + items[i] + "<li>";
                priceStr = "";
                int pos = items[i].IndexOf("NT");
                for(int j = 0; j < items[i].Length; j++)
                {
                    if (Char.IsDigit(items[i][j]))
                    {
                        priceStr += items[i][j];
                    }
                }
                price = Convert.ToInt32(priceStr);
                
            }
            demo.Text += all;
        }
    }
}