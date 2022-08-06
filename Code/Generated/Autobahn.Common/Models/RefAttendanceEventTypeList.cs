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
        public static List<RefAttendanceEventType> RefAttendanceEventTypeList = new List<RefAttendanceEventType> =
        {
            new RefAttendanceEventType { Id=Guid.Parse("92a6f80f-82cf-4961-a5b1-4ac97d438646"), Code="Daily attendance is specified as the type of attendance event.", Description="DailyAttendance", Definition="", SortOrder=0 },
            new RefAttendanceEventType { Id=Guid.Parse("91ccaee4-497b-4b2f-ad0b-7fdca6bdf8c6"), Code="Class/section attendance is specified as the type of attendance event.", Description="ClassSectionAttendance", Definition="", SortOrder=0 },
            new RefAttendanceEventType { Id=Guid.Parse("d6ec1c1d-1c27-4877-a7af-765525bf5098"), Code="Program attendance is specified as the type of attendance event.", Description="ProgramAttendance", Definition="", SortOrder=0 },
            new RefAttendanceEventType { Id=Guid.Parse("ddba2ced-586f-40af-b6be-1ef7b9ed8906"), Code="Extracurricular attendance is specified as the type of attendance event.", Description="ExtracurricularAttendance", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAttendanceEventType Pick List
         /// </summary>
        public static List<RefAttendanceEventType> RefAttendanceEventTypePickList = new List<RefAttendanceEventType> =
        {
            new RefAttendanceEventType { Id=Guid.Parse("92a6f80f-82cf-4961-a5b1-4ac97d438646"), Code="Daily attendance is specified as the type of attendance event.", SortOrder=0 },
            new RefAttendanceEventType { Id=Guid.Parse("91ccaee4-497b-4b2f-ad0b-7fdca6bdf8c6"), Code="Class/section attendance is specified as the type of attendance event.", SortOrder=0 },
            new RefAttendanceEventType { Id=Guid.Parse("d6ec1c1d-1c27-4877-a7af-765525bf5098"), Code="Program attendance is specified as the type of attendance event.", SortOrder=0 },
            new RefAttendanceEventType { Id=Guid.Parse("ddba2ced-586f-40af-b6be-1ef7b9ed8906"), Code="Extracurricular attendance is specified as the type of attendance event.", SortOrder=0 },
       };
   }
}
