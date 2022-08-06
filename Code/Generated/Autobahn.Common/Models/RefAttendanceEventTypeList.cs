//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAttendanceEventTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAttendanceEventType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAttendanceEventType"> List
         /// </summary>
        public static List<RefAttendanceEventType> RefAttendanceEventTypeList = new List<RefAttendanceEventType>
        {
            new RefAttendanceEventType { Id=Guid.Parse("26460746-8561-41ef-9127-c128d4c171a0"), Code="DailyAttendance", Description="Daily attendance", Definition="Daily attendance is specified as the type of attendance event.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAttendanceEventType { Id=Guid.Parse("de8803d5-2fa4-4b43-a206-e18b6ab7ca1b"), Code="ClassSectionAttendance", Description="Class/section attendance", Definition="Class/section attendance is specified as the type of attendance event.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAttendanceEventType { Id=Guid.Parse("e04d448d-3274-4503-8c51-11fa68513a78"), Code="ProgramAttendance", Description="Program attendance", Definition="Program attendance is specified as the type of attendance event.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAttendanceEventType { Id=Guid.Parse("45dcec02-db1a-4efd-ad54-25fe76037a80"), Code="ExtracurricularAttendance", Description="Extracurricular attendance", Definition="Extracurricular attendance is specified as the type of attendance event.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefAttendanceEventType Pick List
         /// </summary>
        public static List<RefAttendanceEventType> RefAttendanceEventTypePickList = new List<RefAttendanceEventType>
        {
            new RefAttendanceEventType { Id=Guid.Parse("26460746-8561-41ef-9127-c128d4c171a0"), Code="DailyAttendance", Description="Daily attendance", SortOrder=Convert.ToDecimal("1.00") },
            new RefAttendanceEventType { Id=Guid.Parse("de8803d5-2fa4-4b43-a206-e18b6ab7ca1b"), Code="ClassSectionAttendance", Description="Class/section attendance", SortOrder=Convert.ToDecimal("2.00") },
            new RefAttendanceEventType { Id=Guid.Parse("e04d448d-3274-4503-8c51-11fa68513a78"), Code="ProgramAttendance", Description="Program attendance", SortOrder=Convert.ToDecimal("4.00") },
            new RefAttendanceEventType { Id=Guid.Parse("45dcec02-db1a-4efd-ad54-25fe76037a80"), Code="ExtracurricularAttendance", Description="Extracurricular attendance", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
