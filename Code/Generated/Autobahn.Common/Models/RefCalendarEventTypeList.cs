//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCalendarEventTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCalendarEventType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCalendarEventType"> List
         /// </summary>
        public static List<RefCalendarEventType> RefCalendarEventTypeList = new List<RefCalendarEventType>
        {
            new RefCalendarEventType { Id=Guid.Parse("8e5f41f8-cea7-4405-b059-f7c643f3e6ef"), Code="EmergencyDay", Description="Emergency day", Definition="Emergency day is specified as the  type of scheduled or unscheduled calendar event.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCalendarEventType { Id=Guid.Parse("b3685436-6b84-4cbd-ad65-50637c0b772d"), Code="Holiday", Description="Holiday", Definition="Holiday is specified as the  type of scheduled or unscheduled calendar event.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCalendarEventType { Id=Guid.Parse("d75d9a94-72cb-4bed-b854-4d3cb1d32512"), Code="InstructionalDay", Description="Instructional day", Definition="Instructional day is specified as the type of scheduled or unscheduled calendar event.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCalendarEventType { Id=Guid.Parse("2020aa32-2136-46e2-9d07-940aa8bca55a"), Code="Other", Description="Other", Definition="Other is specified as the  type of scheduled or unscheduled calendar event.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCalendarEventType { Id=Guid.Parse("f831f9bc-4a17-4bf5-a400-7c3eac519fa9"), Code="Strike", Description="Strike", Definition="Strike is specified as the  type of scheduled or unscheduled calendar event.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCalendarEventType { Id=Guid.Parse("19998666-343e-42b5-985e-13580d2bb117"), Code="LateArrivalEarlyDismissal", Description="Student late arrival/early dismissal", Definition="Student late arrival/early dismissal is specified as the  type of scheduled or unscheduled calendar event.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCalendarEventType { Id=Guid.Parse("a2d13398-4953-46f2-a861-8f42ce69ba91"), Code="TeacherOnlyDay", Description="Teacher only day", Definition="Teacher only day is specified as the  type of scheduled or unscheduled calendar event.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefCalendarEventType Pick List
         /// </summary>
        public static List<RefCalendarEventType> RefCalendarEventTypePickList = new List<RefCalendarEventType>
        {
            new RefCalendarEventType { Id=Guid.Parse("8e5f41f8-cea7-4405-b059-f7c643f3e6ef"), Code="EmergencyDay", Description="Emergency day", SortOrder=Convert.ToDecimal("1.00") },
            new RefCalendarEventType { Id=Guid.Parse("b3685436-6b84-4cbd-ad65-50637c0b772d"), Code="Holiday", Description="Holiday", SortOrder=Convert.ToDecimal("2.00") },
            new RefCalendarEventType { Id=Guid.Parse("d75d9a94-72cb-4bed-b854-4d3cb1d32512"), Code="InstructionalDay", Description="Instructional day", SortOrder=Convert.ToDecimal("3.00") },
            new RefCalendarEventType { Id=Guid.Parse("2020aa32-2136-46e2-9d07-940aa8bca55a"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("4.00") },
            new RefCalendarEventType { Id=Guid.Parse("f831f9bc-4a17-4bf5-a400-7c3eac519fa9"), Code="Strike", Description="Strike", SortOrder=Convert.ToDecimal("5.00") },
            new RefCalendarEventType { Id=Guid.Parse("19998666-343e-42b5-985e-13580d2bb117"), Code="LateArrivalEarlyDismissal", Description="Student late arrival/early dismissal", SortOrder=Convert.ToDecimal("6.00") },
            new RefCalendarEventType { Id=Guid.Parse("a2d13398-4953-46f2-a861-8f42ce69ba91"), Code="TeacherOnlyDay", Description="Teacher only day", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
