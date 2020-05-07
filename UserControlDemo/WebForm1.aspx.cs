using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControlDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Click += new EventHandler(Button1_Click);
            CalendarUserControl1.CalendarVisibilityChanged += new calendarvischangedeventhandler(calendar_visibiliychanged);
        }

        protected void calendar_visibiliychanged(object sender, CalendarVisibilityChangedEventArgs e)
        {
            if (e.IsCalendarVisible)
            {
                Response.Write("Calendar is visible");
            }
            else
                Response.Write("Calendar is not visible");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //here CalendarUserControl1 is a diff control and how do we get selected date. To do this we have to declare of this control a property to show selected date.
            Response.Write(CalendarUserControl1.selectedDate);
        }
    }
}