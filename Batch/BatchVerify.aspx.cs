using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HMS.Data;

namespace HMS.Batch
{
  public partial class BatchVerify : System.Web.UI.Page
  {
    List<BatchItem> m_Batch;

    protected void Page_Load(object sender, EventArgs e)
    {
            if (IsPostBack)
      {
        //go get data
        getData();
        //force the grid to refresh and bind with the data you just got
        grdBatch.DataSource = m_Batch;
        grdBatch.DataBind();
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
      m_Batch = new List<BatchItem>();
      m_Batch.Add(new BatchItem(33731, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33732, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33733, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33734, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33735, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33736, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33737, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33738, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33739, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33740, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33741, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33742, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33743, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33744, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33745, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33746, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33747, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33748, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33749, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33750, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33751, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33752, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33753, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33754, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33755, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33756, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33757, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33758, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
      m_Batch.Add(new BatchItem(33759, new DateTime(2014,8,22,0,0,0), "39100895588", 1, 70450, 70450, 1, 142.0m , 32, "03", 3));
    }

    protected void grdBatch_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
      //using Linq to skip over x rows of data and take the next y rows (you also have to convert it back to a list
      //as Linq turns it into a var (sort of unknown but anything goes) object
      m_Batch = m_Batch.Skip(grdBatch.PageSize * e.NewPageIndex).Take(grdBatch.PageSize).ToList<BatchItem>();
      grdBatch.PageIndex = e.NewPageIndex;
      grdBatch.DataBind();
    }

    protected void grdBatch_RowDataBound(object sender, GridViewRowEventArgs e)
    {
       if (e.Row.RowType == DataControlRowType.DataRow)
    {
        e.Row.Style["cursor"] = "pointer";
        e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(grdBatch, "Select$" + e.Row.RowIndex);
        e.Row.ToolTip = "Click to select this row.";
    }
    }
  }
}