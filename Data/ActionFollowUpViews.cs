﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace HMS.Data
{
    public class ActionFollowUpViews : List<ActionFollowUpView>
    {
        public ActionFollowUpViews(string webData)
    {
      //create a string reader.  it's more efficient with large strings
      using (StringReader l_reader = new StringReader(webData))
      {
        while (true)
        {
          //read a line
          string l_Line = l_reader.ReadLine();
          if (!string.IsNullOrWhiteSpace(l_Line))
          {
            //if we read data, create a new line item
              ActionFollowUpView l_View = new ActionFollowUpView(l_Line);
            //add it to the List object
            this.Add(l_View);
          }
          else
          {
            break;
          }
        }
        //close the string reader
        l_reader.Close();
      }
    }
    }
}