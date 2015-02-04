using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMS.Data
{
  public class ActionFollowUpView
  {
  public string   TRNumber { get; set; }
  public DateTime ActDate  { get; set; }
  public string   No       { get; set; }
  public string   Action   { get; set; }
  public string   INIT     { get; set; }
   


  public ActionFollowUpView(string _TRNUmber,
                            DateTime _ActDate,
                            string _No, 
                            string _Action,
                            string _INIT)
  {
    TRNumber =  _TRNUmber;
    ActDate =   _ActDate;
    No =        _No;
    Action =    _Action;
    INIT =      _INIT;
  }

  public ActionFollowUpView(string webData)
  {
    string[] l_Data    = webData.Split('|');
    TRNumber  = l_Data[0];
    string l_ActDate = l_Data[1];
    No = l_Data[2];
    Action = l_Data[3];
    INIT = l_Data[4];
    DateTime l_ActDateVal;
    DateTime.TryParse(l_ActDate, out l_ActDateVal);
    ActDate = l_ActDateVal;
   }
  }
}