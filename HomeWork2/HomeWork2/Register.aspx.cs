using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeWork2
{
    public partial class Register : System.Web.UI.Page
    {
        string acc;
        string pwd;
        int le;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            acc = TextBox1.Text;
            pwd = TextBox2.Text;
            le = acc.Length;
            if (String.IsNullOrEmpty(acc) || String.IsNullOrEmpty(pwd))
            {
                Label1.Text = "帳號或密碼不能為空";
            }
            else if (le < 6)
                Label1.Text = "帳號需只少為6個字元";
            else if (!char.IsLetter(acc, 0))
                Label1.Text = "帳號自首須為英文";
            else if (!char.IsUpper(acc, 0))
                Label1.Text = "帳號字首須為大寫";
            else if (acc == pwd)
                Label1.Text = "帳號密碼不能相同";
            else
                Label1.Text = "登入成功";
        }
    }
}