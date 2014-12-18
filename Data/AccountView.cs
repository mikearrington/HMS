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
    public decimal  Balance       { get; set; }
    public string   Address1      { get; set; }
    public string   Address2      { get; set; }
    public string   City          { get; set; }
    public string   State         { get; set; }
    public string   Zip           { get; set; }


    public AccountView(string _AccountNumber, 
                       string _Name, 
                       string _Sex, 
                       string _DRNO, 
                       DateTime _DOB, 
                       DateTime _LastVisit, 
                       decimal _Balance, 
                       string _Address1, 
                       string _Address2, 
                       string _City, 
                       string _State, 
                       string _Zip)
    {
      AccountNumber = _AccountNumber;
      Name          = _Name;
      Sex           = _Sex;
      DRNO          = _DRNO;
      DOB           = _DOB;
      LastVisit     = _LastVisit;
      Balance       = _Balance;
      Address1      = _Address1;
      Address2      = _Address2;
      City          = _City;
      State         = _State;
      Zip           = _Zip;
    }
  }
}