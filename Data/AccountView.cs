using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMS.Data
{
  public class AccountView
  {
    public string   AccountNumber { get; set; }
    public string   Name          { get; set; }
    public string   Sex           { get; set; }
    public string   DRNO          { get; set; }
    public DateTime DOB           { get; set; }
    public DateTime LastVisit     { get; set; }
    public string   Flag          { get; set; }
    public decimal  Balance       { get; set; }
    public string   Address1      { get; set; }
    public string   CityStateZip  { get; set; }


    public AccountView(string _AccountNumber, 
                       string _Name, 
                       string _Sex, 
                       string _DRNO, 
                       DateTime _DOB, 
                       DateTime _LastVisit, 
                       string _Flag,
                       decimal _Balance, 
                       string _Address1, 
                       string _CityStateZip)
    {
      AccountNumber = _AccountNumber;
      Name          = _Name;
      Sex           = _Sex;
      DRNO          = _DRNO;
      DOB           = _DOB;
      LastVisit     = _LastVisit;
      Flag          = _Flag;
      Balance       = _Balance;
      Address1      = _Address1;
      CityStateZip  = _CityStateZip;
    }

    public AccountView(string webData)
    {
      string[] l_Data    = webData.Split('|');
      AccountNumber  = l_Data[0];
      Name      = l_Data[1];
      Sex       = l_Data[2];
      DRNO      = l_Data[3];
      string l_DOB       = l_Data[4];
      string l_LastVisit = l_Data[5];
      string l_Flag      = l_Data[6];
      string l_Balance   = l_Data[7];
      Address1     = l_Data[8];
      CityStateZip = l_Data[9];
      DateTime l_DOBVal;
      DateTime l_LastVisitVal;
      decimal l_BalanceVal;
      DateTime.TryParse(l_DOB, out l_DOBVal );
      DateTime.TryParse(l_LastVisit, out l_LastVisitVal);
      decimal.TryParse(l_Balance, out l_BalanceVal);
      DOB = l_DOBVal;
      LastVisit = l_LastVisitVal;
      Balance = l_BalanceVal;
    }
  }
}