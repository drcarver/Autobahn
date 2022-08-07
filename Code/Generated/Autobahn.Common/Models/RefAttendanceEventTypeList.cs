//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAttendanceEventTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAttendanceEventType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAttendanceEventTypeModel"> List
         /// </summary>
        public static List<RefAttendanceEventTypeModel> RefAttendanceEventTypeList = new List<RefAttendanceEventTypeModel>
        {
            new RefAttendanceEventType { Id=Guid.Parse("7c33f7f8-bddd-4835-bfb9-eb2cf5b32ab7"), Code="DailyAttendance", Description="Daily attendance", Definition="Daily attendance is specified as the type of attendance event.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAttendanceEventType { Id=Guid.Parse("3f2e378d-f4b5-46fb-83c8-5b5a969a1d76"), Code="ClassSectionAttendance", Description="Class/section attendance", Definition="Class/section attendance is specified as the type of attendance event.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAttendanceEventType { Id=Guid.Parse("7ea046c4-aade-49e1-827d-dcf1fbe72ebf"), Code="ProgramAttendance", Description="Program attendance", Definition="Program attendance is specified as the type of attendance event.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAttendanceEventType { Id=Guid.Parse("b18e5999-ba3c-44a2-aa12-4610255487ef"), Code="ExtracurricularAttendance", Description="Extracurricular attendance", Definition="Extracurricular attendance is specified as the type of attendance event.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefAttendanceEventType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAttendanceEventTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAttendanceEventType { Id=Guid.Parse("7c33f7f8-bddd-4835-bfb9-eb2cf5b32ab7"), Description="Daily attendance", SortOrder=Convert.ToDecimal("1.00") },
            new RefAttendanceEventType { Id=Guid.Parse("3f2e378d-f4b5-46fb-83c8-5b5a969a1d76"), Description="Class/section attendance", SortOrder=Convert.ToDecimal("2.00") },
            new RefAttendanceEventType { Id=Guid.Parse("7ea046c4-aade-49e1-827d-dcf1fbe72ebf"), Description="Program attendance", SortOrder=Convert.ToDecimal("4.00") },
            new RefAttendanceEventType { Id=Guid.Parse("b18e5999-ba3c-44a2-aa12-4610255487ef"), Description="Extracurricular attendance", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
