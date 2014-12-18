using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HMS
{
  public partial class Login : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      //if the user did something like hit the login button to force the page to be reloaded
      if (IsPostBack)
      {
        //if the login was good, go on to the main menu page
        if (validateLogin())
        {
          Response.Redirect("MainMenu.aspx");
        }
        else
        {
          //set error messages
          lblInvalidLogin.Text = Constants.ERROR_MSG_INVALID_LOGIN;
        }
      }
      else
      {
        //clear the logged on user from session memory
        Session[Constants.LOGGED_ON_USER] = null;
      }
    }

    /// <summary>
    /// This method validates your login
    /// </summary>
    /// <returns>Boolean</returns>
    private bool validateLogin()
    {
      bool l_Return = false;
      if (txtUser.Text.Trim().ToLower().Equals("pam"))
      {
        if (txtPwd.Text.Trim().Equals("inquiry"))
        {
          //everything checked out, set a session variable with the user's login
          //name in it.  This is used in main.master to determine if a user can
          //view a page or if they get redirected back to this page to login.
          Session[Constants.LOGGED_ON_USER] = txtUser.Text;
          l_Return = true;
        }
      }
      return l_Return;
    }
  }
}