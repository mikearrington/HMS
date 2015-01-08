using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HMS.Data;

namespace HMS.Inquiry
{
  public partial class InqAcro : System.Web.UI.Page
  {
    AccountViews m_Accounts;

    protected void Page_Load(object sender, EventArgs e)
    {
      string l_InqType = Request.Params["Inq"];
      if (IsPostBack)
      {
        //go get data
          getData(l_InqType);

        //force the grid to refresh and bind with the data you just got
        grdInquiry.DataSource = m_Accounts;
        grdInquiry.DataBind();
      }
      else
      {
        
        if (!string.IsNullOrWhiteSpace(l_InqType))
        {
          switch (l_InqType.Trim().ToLower())
          {
            case "a":
              placeAcronym.Visible = true;
              lblHeader.Text = "ACRONYM INQUIRY";
              break;
            case "s":
              placeSSN.Visible = true;
              lblHeader.Text = "SOCIAL SECURITY NUMBER INQUIRY";
              break;
            case "p":
              placePolicy.Visible = true;
              lblHeader.Text = "POLICY INQUIRY";
              break;
            case "m":
              placeMRN.Visible = true;
              lblHeader.Text = "MEDICAL RECORD NUMBER INQUIRY";
              break;
          }
        }
      }
    }

    /// <summary>
    /// This is where the data comes from
    /// </summary>
    public void getData(string inquiryType)
    {
     connectOnOBjects(inquiryType);
    }

  

    protected void grdInquiryByAcronym_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
      //using Linq to skip over x rows of data and take the next y rows (you also have to convert it back to a list
      //as Linq turns it into a var (sort of unknown but anything goes) object
      m_Accounts = m_Accounts.Skip(grdInquiry.PageSize * e.NewPageIndex).Take(grdInquiry.PageSize).ToList<AccountView>() as AccountViews;
      //m_Accounts = m_Accounts.Where(a=>a.AccountNumber.Equals("34344")).ToList<AccountView>() as AccountViews;
      grdInquiry.PageIndex = e.NewPageIndex;
      grdInquiry.DataBind();
    }

    public void connectOnOBjects(string inquiryType)
    {
        OBJECTSONLib.UnioaifCtrl onObjects;
        onObjects = new OBJECTSONLib.UnioaifCtrl();
        onObjects.AccountPath = "WEB.BASE.THIN";
        onObjects.HostName = "10.11.11.10";
        if (onObjects.Connect())
        {
            var gSubRoutine = onObjects.Subroutine("ACRO.INQ", 6);
            //ACRO.INQ TAKES LOGON, ACRO, FIRSTNAME, DOB, DATA, ERRORMSG
            gSubRoutine.setArg(0, "WEB.BASE"); //LOGON
            gSubRoutine.setArg(1, txtAcronym.Text.ToUpper().Trim()); //ACRO
            gSubRoutine.setArg(2, txtAcronymFirstName.Text.ToUpper().Trim()); //FIRSTNAME - OPTIONAL - FORMAT IS MM/DD/YYYY
            gSubRoutine.setArg(3, txtAcronymDOB.Text.Trim()); //DOB - OPTIONAL
            gSubRoutine.setArg(4, ""); //DATA LEAVE BLANK - THIS IS WHERE THE ATTRIBUTE FOR THE RETURN VALUES
            gSubRoutine.setArg(5, ""); //ERROR LEAVE BLANK - ERROR MESSAGE WILL BE PASSED BACK HERE
            gSubRoutine.call();
            string strText = gSubRoutine.getArg(4);
            m_Accounts = new AccountViews(strText);
            onObjects.Disconnect();

        }
        else
        {
            string x = "not connected";
        }
    }
  }
}