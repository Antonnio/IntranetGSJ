﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SignalRTest
{
    public partial class SimpleChat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string todo = Logic.General.Monitoreo.imprimeTodo(2);


            Label1.Text = todo;

            if (Logic.General.Monitoreo.divi > 0)
            {
                Label2.Text = todo;
            }
            //Session["idMonitoreoUltimoPublicado"] = "";
            
        }
    }
}