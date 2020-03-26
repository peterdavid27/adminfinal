using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {

        public SqlConnection cn = new SqlConnection("Data Source=JOANFERNANDEZ;Initial Catalog=Login;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            string query = "select count(*) from Cliente where Usuario= @usuario and Clave = @password";
            SqlCommand cm = new SqlCommand(query, cn);
            cm.Parameters.AddWithValue("@usuario", TextBox1.Text);
            cm.Parameters.AddWithValue("@password", TextBox2.Text);

           
            bool correcto = Convert.ToInt32(cm.ExecuteScalar()) > 0;

            if (correcto)
            {
              
                Response.RedirectToRoute("Default");

            }
            else
            {
                Label1.Text = "Su usuario o contraseña son incorrectos ";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox1.Focus();

            }
            cn.Close();

        }
    }
}