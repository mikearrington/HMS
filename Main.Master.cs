using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HMS
{
  public partial class Main : System.Web.UI.MasterPage
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      //if we don't have a logged on user name for the session, redirect to the login page
      if (!isLoggedOn())
      {
        Response.Redirect("~/Login.aspx");
      }
      //automatically add the current year to the copyright information so it always stays current
      lblCopyrightYear.Text = DateTime.Now.Year.ToString();
      lblLogin.Text = Session[Constants.LOGGED_ON_USER].ToString();
    }

    /// <summary>
    /// Function to determine if the user is logged on
    /// </summary>
    /// <returns>bool</returns>
    private bool isLoggedOn()
    {
      return (Session[Constants.LOGGED_ON_USER] != null);
    }
  }
}