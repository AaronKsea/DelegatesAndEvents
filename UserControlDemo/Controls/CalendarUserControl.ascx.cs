using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControlDemo
{
    public delegate void calendarvischangedeventhandler(object sender, CalendarVisibilityChangedEventArgs eventArgs);
    public partial class CalendarUserControl : System.Web.UI.UserControl
    {
        public event  calendarvischangedeventhandler CalendarVisibilityChanged;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.Visible = false;
            }
        }

        protected void ImgBtn_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
                CalendarVisibilityChangedEventArgs eventArgs = new CalendarVisibilityChangedEventArgs(false);
                CalendarVisibilityChanged(this, eventArgs);
            }
            else
            {
                Calendar1.Visible = true;
                CalendarVisibilityChangedEventArgs eventArgs = new CalendarVisibilityChangedEventArgs(false);
                CalendarVisibilityChanged(this, eventArgs);
            }
        }

   

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtDate.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }

        public string selectedDate
        {
            get
            {
                return txtDate.Text;
            }
            set
            {
                txtDate.Text = value;
            }
        }

    }
    //since there is no such event when calendar visibility is changed, we will have to raise a custom event
    //here is how to do it https://csharp-video-tutorials.blogspot.com/2013/01/raising-custom-events-from-user.html
    //step1: create CalendarVisibilityChangedEventArgs  class that will contain the events data

    public class CalendarVisibilityChangedEventArgs : EventArgs
    {
        private bool _isCalendarVisible;
        public bool IsCalendarVisible
        {
            get
            {
                return this._isCalendarVisible;
            }
        }
        public CalendarVisibilityChangedEventArgs(bool isCalendarVisible)
        {
            this._isCalendarVisible = isCalendarVisible;
        }
    }

}