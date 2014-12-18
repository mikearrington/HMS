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
    List<AccountView> m_Accounts;

    protected void Page_Load(object sender, EventArgs e)
    {
      if (IsPostBack)
      {
        //go get data
        getData();
        //force the grid to refresh and bind with the data you just got
        grdInquiry.DataSource = m_Accounts;
        grdInquiry.DataBind();
      }
      else
      {
        string l_InqType = Request.Params["Inq"];
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
    public void getData()
    {
      buildMockData();
    }

    /// <summary>
    /// This is a dummy routine used to set some data until we get the real data
    /// </summary>
    public void buildMockData()
    {
      m_Accounts = new List<AccountView>();
      m_Accounts.Add(new AccountView("R9", "LINDA KELLNER", "F", "1", new DateTime(1956,9,20), DateTime.MinValue, 0, "9020 STONY POINT PARKWAY", "SUITE 165", "RICHMOND", "VA", "23235"));
      m_Accounts.Add(new AccountView("R8", "LINDA KELLNER", "F", "1", new DateTime(1956,9,20), new DateTime(2013,2,5), 0, "9020 STONY POINT PARKWAY", "SUITE 165", "RICHMOND", "VA", "23235"));
      m_Accounts.Add(new AccountView("R19347", "LINDA KELLNER", "F", "1", new DateTime(1956,9,20), new DateTime(2012,6,28), 0, "9020 STONY POINT PARKWAY", "SUITE 165", "RICHMOND", "VA", "23235"));
      m_Accounts.Add(new AccountView("R4616", "LINDA KELLNER", "F", "1", new DateTime(1956,9,20), new DateTime(2012,7,1), 0, "9020 STONY POINT PARKWAY", "SUITE 165", "RICHMOND", "VA", "23235"));
      m_Accounts.Add(new AccountView("R4615", "LINDA KELLNER", "F", "1", new DateTime(1956,9,20), new DateTime(2012,2,1), 0, "9020 STONY POINT PARKWAY", "SUITE 165", "RICHMOND", "VA", "23235"));
      m_Accounts.Add(new AccountView("15214", "LINDA KELLNER", "F", "1", new DateTime(1956,9,20), new DateTime(2011,2,11), 0, "9020 STONY POINT PARKWAY", "SUITE 165", "RICHMOND", "VA", "23235"));
      m_Accounts.Add(new AccountView("1234567", "LINDA KELLNER", "F", "1", new DateTime(1956,9,20), new DateTime(2012,7,24), 0, "9020 STONY POINT PARKWAY", "SUITE 165", "RICHMOND", "VA", "23235"));
      m_Accounts.Add(new AccountView("1956", "LINDA KELLNER", "F", "1", new DateTime(1956,9,20), new DateTime(2011,4,2), 0, "9020 STONY POINT PARKWAY", "SUITE 165", "RICHMOND", "VA", "23235"));
      m_Accounts.Add(new AccountView("L101", "LINDA KELLNER", "F", "1", new DateTime(1956,9,20), new DateTime(2011,4,20), 0, "9020 STONY POINT PARKWAY", "SUITE 165", "RICHMOND", "VA", "23235"));
    }

    protected void grdInquiryByAcronym_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
      //using Linq to skip over x rows of data and take the next y rows (you also have to convert it back to a list
      //as Linq turns it into a var (sort of unknown but anything goes) object
      m_Accounts = m_Accounts.Skip(grdInquiry.PageSize * e.NewPageIndex).Take(grdInquiry.PageSize).ToList<AccountView>();
      grdInquiry.PageIndex = e.NewPageIndex;
      grdInquiry.DataBind();
    }
  }
}