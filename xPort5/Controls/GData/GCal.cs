using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

using Google.GData.Calendar;
using Google.GData.Client;
using Google.GData.Extensions;

namespace xPort5.Controls.GData
{
    public class GCal
    {
        public static CalendarService GetService()
        {
            CalendarService calService = new CalendarService("xPort5");

            Utility.SysInfo sysInfo = Utility.SysInfo.Load();
            calService.setUserCredentials(sysInfo.FactoryGDocsAccount, sysInfo.FactoryGDocsPassword);

            return calService;
        }

        public static EventFeed GetEvents(int year, int month)
        {
            CalendarService service = GetService();

            DateTime fromDate = new DateTime(year, month, 1);
            DateTime toDate = (((fromDate.AddMonths(1)).AddDays(-1)).AddHours(23)).AddMinutes(59);

            EventQuery eventQurey = new EventQuery();
            Utility.SysInfo sysInfo = Utility.SysInfo.Load();

            eventQurey.Uri = new Uri(String.Format("http://www.google.com/calendar/feeds/{0}/private/full", sysInfo.FactoryGDocsAccount));

            eventQurey.StartTime = fromDate;
            eventQurey.EndTime = toDate;

            EventFeed eventFeed = service.Query(eventQurey);

            return eventFeed;
        }

        public static bool CreateEvent(Guid memberId)
        {
            bool result = false;

            //DAL.Member member = DAL.Member.Load(memberId);
            //if (member != null)
            //{
            //    CalendarService service = GetService();

            //    EventEntry entry = new EventEntry();

            //    // What
            //    // Set the title and content of the entry.
            //    entry.Title.Text = String.Format("{0} {1}", member.MemberCode, member.MemberName);
            //    entry.Content.Content = "Membership Expiry Date";

            //    // Where
            //    // Set a location for the event.
            //    //Where eventLocation = new Where();
            //    //eventLocation.ValueString = "South Tennis Courts";
            //    //entry.Locations.Add(eventLocation);

            //    // When
            //    DateTime expiryDate = new DateTime(member.ExpiryDate.Year, member.ExpiryDate.Month, member.ExpiryDate.Day, 0, 0, 0);
            //    When eventTime = new When(expiryDate, expiryDate.AddHours(24), true);
            //    entry.Times.Add(eventTime);

            //    Uri postUri = new Uri("http://www.google.com/calendar/feeds/default/private/full");

            //    // Send the request and receive the response:
            //    AtomEntry insertedEntry = service.Insert(postUri, entry);

            //    result = true;
            //}

            return result;
        }
    }
}
