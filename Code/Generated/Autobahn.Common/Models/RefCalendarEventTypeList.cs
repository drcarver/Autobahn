//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCalendarEventTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCalendarEventType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCalendarEventTypeModel"> List
         /// </summary>
        public static List<RefCalendarEventTypeModel> RefCalendarEventTypeList = new List<RefCalendarEventTypeModel>
        {
            new RefCalendarEventType { Id=Guid.Parse("8e731548-c9e6-4f43-9a6f-077b390c73a2"), Code="EmergencyDay", Description="Emergency day", Definition="Emergency day is specified as the  type of scheduled or unscheduled calendar event.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCalendarEventType { Id=Guid.Parse("0e2a0e42-7121-42e8-b7dd-693357adfb3d"), Code="Holiday", Description="Holiday", Definition="Holiday is specified as the  type of scheduled or unscheduled calendar event.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCalendarEventType { Id=Guid.Parse("1b22f35d-f634-49c0-a91d-2a1ccf4691e4"), Code="InstructionalDay", Description="Instructional day", Definition="Instructional day is specified as the type of scheduled or unscheduled calendar event.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCalendarEventType { Id=Guid.Parse("46de7432-6a9d-4dab-8442-e876e4180bfe"), Code="Other", Description="Other", Definition="Other is specified as the  type of scheduled or unscheduled calendar event.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCalendarEventType { Id=Guid.Parse("8f0efedb-3764-4762-8070-b9a4abeb64b2"), Code="Strike", Description="Strike", Definition="Strike is specified as the  type of scheduled or unscheduled calendar event.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCalendarEventType { Id=Guid.Parse("16c951bf-50f7-489d-b009-11505ace2743"), Code="LateArrivalEarlyDismissal", Description="Student late arrival/early dismissal", Definition="Student late arrival/early dismissal is specified as the  type of scheduled or unscheduled calendar event.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCalendarEventType { Id=Guid.Parse("329e05a3-2920-48e4-a70d-e25bbc9df79e"), Code="TeacherOnlyDay", Description="Teacher only day", Definition="Teacher only day is specified as the  type of scheduled or unscheduled calendar event.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefCalendarEventType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCalendarEventTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCalendarEventType { Id=Guid.Parse("8e731548-c9e6-4f43-9a6f-077b390c73a2"), Description="Emergency day", SortOrder=Convert.ToDecimal("1.00") },
            new RefCalendarEventType { Id=Guid.Parse("0e2a0e42-7121-42e8-b7dd-693357adfb3d"), Description="Holiday", SortOrder=Convert.ToDecimal("2.00") },
            new RefCalendarEventType { Id=Guid.Parse("1b22f35d-f634-49c0-a91d-2a1ccf4691e4"), Description="Instructional day", SortOrder=Convert.ToDecimal("3.00") },
            new RefCalendarEventType { Id=Guid.Parse("46de7432-6a9d-4dab-8442-e876e4180bfe"), Description="Other", SortOrder=Convert.ToDecimal("4.00") },
            new RefCalendarEventType { Id=Guid.Parse("8f0efedb-3764-4762-8070-b9a4abeb64b2"), Description="Strike", SortOrder=Convert.ToDecimal("5.00") },
            new RefCalendarEventType { Id=Guid.Parse("16c951bf-50f7-489d-b009-11505ace2743"), Description="Student late arrival/early dismissal", SortOrder=Convert.ToDecimal("6.00") },
            new RefCalendarEventType { Id=Guid.Parse("329e05a3-2920-48e4-a70d-e25bbc9df79e"), Description="Teacher only day", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
