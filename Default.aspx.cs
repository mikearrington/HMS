using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HMS
{
  public partial class Default : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      //default.aspx is the default page to look for in this project when
      // a user goes to http://yourserver.
      //this is simply a placeholder to redirect a user to login.aspx page
      Response.Redirect("login.aspx");
    }
  }
}