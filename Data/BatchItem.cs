using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMS.Data
{
  public class BatchItem
  {

    public int TrNo { get; set; }
    public DateTime TrDate { get; set;}
    public string PatNo { get; set; }
    public int Vis { get; set; }
    public int NumCde { get; set; }
    public int Proced { get; set; }
    public int Qty { get; set; }
    public decimal Amt { get; set; }
    public int Pt { get; set; }
    public string Loc { get; set; }
    public int Trc { get; set; }

    public BatchItem(int _TrNo, DateTime _TrDate, string _PatNo, int _Vis, int _NumCde, int _Proced, int _Qty, decimal _Amt, int _Pt, string _Loc, int _Trc)
    {
      TrNo = _TrNo;
      TrDate =  _TrDate;
      PatNo = _PatNo;
      Vis = _Vis;
      NumCde = _NumCde;
      Proced = _Proced;
      Qty = _Qty;
      Amt = _Amt;
      Pt = _Pt;
      Loc = _Loc;
      Trc = _Trc;
    }

  }
}