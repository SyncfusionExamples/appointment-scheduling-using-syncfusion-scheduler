using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ScheduleSample
{
    public class AppointmentTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DayAppointmentTemplate { get; set; }
        public DataTemplate AllDayAppointmentTemplate { get; set; }

        public AppointmentTemplateSelector()
        {
            this.DayAppointmentTemplate = new DataTemplate(typeof(DayAppointmentTemplate));
            this.AllDayAppointmentTemplate = new DataTemplate(typeof(AllDayTemplate));
        }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if ((item as Meeting).IsAllDay)
                return this.AllDayAppointmentTemplate;
            else
                return this.DayAppointmentTemplate;
        }
    }
}
