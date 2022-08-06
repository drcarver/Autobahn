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
        public static List<RefCalendarEventType> RefCalendarEventTypeList = new List<RefCalendarEventType> =
        {
            new RefCalendarEventType { Id=Guid.Parse("f62760b3-2971-4d9f-b193-d3e44290f7d8"), Code="Emergency day is specified as the  type of scheduled or unscheduled calendar event.", Description="EmergencyDay", Definition="", SortOrder=0 },
            new RefCalendarEventType { Id=Guid.Parse("d291bb1e-db7d-4e9e-9457-b2f81ee26810"), Code="Holiday is specified as the  type of scheduled or unscheduled calendar event.", Description="Holiday", Definition="", SortOrder=0 },
            new RefCalendarEventType { Id=Guid.Parse("6b5b3c8d-941f-4d7c-864c-85e0c2c875bb"), Code="Instructional day is specified as the type of scheduled or unscheduled calendar event.", Description="InstructionalDay", Definition="", SortOrder=0 },
            new RefCalendarEventType { Id=Guid.Parse("084862ff-e00a-41b1-a5d4-520913aa0881"), Code="Other is specified as the  type of scheduled or unscheduled calendar event.", Description="Other", Definition="", SortOrder=0 },
            new RefCalendarEventType { Id=Guid.Parse("da652f4f-2a87-4266-aaad-41eb611c1651"), Code="Strike is specified as the  type of scheduled or unscheduled calendar event.", Description="Strike", Definition="", SortOrder=0 },
            new RefCalendarEventType { Id=Guid.Parse("666b8af7-3d29-4336-b650-21f6f9d7ec22"), Code="Student late arrival/early dismissal is specified as the  type of scheduled or unscheduled calendar event.", Description="LateArrivalEarlyDismissal", Definition="", SortOrder=0 },
            new RefCalendarEventType { Id=Guid.Parse("481e2fe3-e7e6-4d40-9584-379a6d271a1e"), Code="Teacher only day is specified as the  type of scheduled or unscheduled calendar event.", Description="TeacherOnlyDay", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCalendarEventType Pick List
         /// </summary>
        public static List<RefCalendarEventType> RefCalendarEventTypePickList = new List<RefCalendarEventType> =
        {
            new RefCalendarEventType { Id=Guid.Parse("f62760b3-2971-4d9f-b193-d3e44290f7d8"), Code="Emergency day is specified as the  type of scheduled or unscheduled calendar event.", SortOrder=0 },
            new RefCalendarEventType { Id=Guid.Parse("d291bb1e-db7d-4e9e-9457-b2f81ee26810"), Code="Holiday is specified as the  type of scheduled or unscheduled calendar event.", SortOrder=0 },
            new RefCalendarEventType { Id=Guid.Parse("6b5b3c8d-941f-4d7c-864c-85e0c2c875bb"), Code="Instructional day is specified as the type of scheduled or unscheduled calendar event.", SortOrder=0 },
            new RefCalendarEventType { Id=Guid.Parse("084862ff-e00a-41b1-a5d4-520913aa0881"), Code="Other is specified as the  type of scheduled or unscheduled calendar event.", SortOrder=0 },
            new RefCalendarEventType { Id=Guid.Parse("da652f4f-2a87-4266-aaad-41eb611c1651"), Code="Strike is specified as the  type of scheduled or unscheduled calendar event.", SortOrder=0 },
            new RefCalendarEventType { Id=Guid.Parse("666b8af7-3d29-4336-b650-21f6f9d7ec22"), Code="Student late arrival/early dismissal is specified as the  type of scheduled or unscheduled calendar event.", SortOrder=0 },
            new RefCalendarEventType { Id=Guid.Parse("481e2fe3-e7e6-4d40-9584-379a6d271a1e"), Code="Teacher only day is specified as the  type of scheduled or unscheduled calendar event.", SortOrder=0 },
       };
   }
}
