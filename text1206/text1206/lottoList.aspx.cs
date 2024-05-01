using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace text1206
{
    public partial class lottoList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] lottoList = new int[6];
            Random num = new Random();
            int temp;
            List<int> used = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                do
                {
                    temp = num.Next(1, 49);
                } while (used.Contains(temp));
                
                lottoList[i] = temp;
                used.Add(temp);
            }
            Array.Sort(lottoList);
            foreach(int x in lottoList)
            {
                Label1.Text += "<li>" +x;
            }
            
            
        }
    }
}