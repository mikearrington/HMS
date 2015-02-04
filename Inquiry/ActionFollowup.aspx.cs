using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HMS.Data;

namespace HMS.Inquiry
{
    public partial class ActionFollowup : System.Web.UI.Page
    {
        ActionFollowUpViews m_FollowViews;
        protected void Page_Load(object sender, EventArgs e)
        {
           if (IsPostBack)
            {
                //go get data
                getData();
                //force the grid to refresh and bind with the data you just got
                grdPatFollowUp.DataSource = m_FollowViews;
                grdPatFollowUp.DataBind();
                lblHeader.Text = "PATIENT ACTION FOLLOW UP";
            }
        }
        /// <summary>
        /// This is where the data comes from
        /// </summary>
        public void getData()
        {
            connectOnOBjects();
        }
        protected void grdInquiryByAcronym_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //using Linq to skip over x rows of data and take the next y rows (you also have to convert it back to a list
            //as Linq turns it into a var (sort of unknown but anything goes) object
            m_FollowViews = m_FollowViews.Skip(grdPatFollowUp.PageSize * e.NewPageIndex).Take(grdPatFollowUp.PageSize).ToList<ActionFollowUpView>() as ActionFollowUpViews;
            //m_Accounts = m_Accounts.Where(a=>a.AccountNumber.Equals("34344")).ToList<AccountView>() as AccountViews;
            grdPatFollowUp.PageIndex = e.NewPageIndex;
            grdPatFollowUp.DataBind();
        }

        public void connectOnOBjects()
        {
            OBJECTSONLib.UnioaifCtrl onObjects;
            onObjects = new OBJECTSONLib.UnioaifCtrl();
            onObjects.AccountPath = "WEB.BASE.THIN";
            onObjects.HostName = "10.11.11.10";
            if (onObjects.Connect())
            {
                var gSubRoutine = onObjects.Subroutine("DELQ.ACT.INQ", 6);
                //ACRO.INQ TAKES LOGON, ACRO, FIRSTNAME, DOB, DATA, ERRORMSG
                gSubRoutine.setArg(0, "WEB.BASE"); //LOGON
                gSubRoutine.setArg(1, txtAccount.Text.ToUpper().Trim()); //ACRO
                gSubRoutine.setArg(2, ""); //FLAG - THIS IS WHAT SCREEN IS NEXT - POSSIBLE RESPONSES = "", I. VO, 3 OR 4
                gSubRoutine.setArg(3, ""); //MSG - THIS
                gSubRoutine.setArg(4, ""); //DATA LEAVE BLANK - THIS IS WHERE THE ATTRIBUTE FOR THE RETURN VALUES
                gSubRoutine.setArg(5, ""); //ERROR LEAVE BLANK - ERROR MESSAGE WILL BE PASSED BACK HERE
                gSubRoutine.call();
                //add a check here if empty - pjp
                string strText = gSubRoutine.getArg(4);
                int intPipe = strText.IndexOf("|");
                string strInsured = strText.Substring(0,intPipe);
                string strGridText = strText.Substring(intPipe + 1);
                lblPatientName.Text = "Patient: " + strInsured;
                m_FollowViews = new ActionFollowUpViews(strGridText);
                onObjects.Disconnect();

            }
            else
            {
                string x = "not connected";
            }
        }
    }
}