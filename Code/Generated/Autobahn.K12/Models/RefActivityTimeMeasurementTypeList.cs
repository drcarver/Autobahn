//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefActivityTimeMeasurementTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefActivityTimeMeasurementType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefActivityTimeMeasurementType"> List
         /// </summary>
        public static List<RefActivityTimeMeasurementType> RefActivityTimeMeasurementTypeList = new List<RefActivityTimeMeasurementType> =
        {
            new RefActivityTimeMeasurementType { Id=Guid.Parse("7fb90177-bd35-4793-af91-e6a5cd9d21c6"), Code="Weekly hours is specified as the type of measurement for the amount of time the student participated in the events and procedures of an activity.", Description="WeeklyHours", Definition="", SortOrder=0 },
            new RefActivityTimeMeasurementType { Id=Guid.Parse("778de321-6bc5-47c8-94e2-5bfd70885a1f"), Code="Yearly weeks is specified as the type of measurement for the amount of time the student participated in the events and procedures of an activity.", Description="YearlyWeeks", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefActivityTimeMeasurementType Pick List
         /// </summary>
        public static List<RefActivityTimeMeasurementType> RefActivityTimeMeasurementTypePickList = new List<RefActivityTimeMeasurementType> =
        {
            new RefActivityTimeMeasurementType { Id=Guid.Parse("7fb90177-bd35-4793-af91-e6a5cd9d21c6"), Code="Weekly hours is specified as the type of measurement for the amount of time the student participated in the events and procedures of an activity.", SortOrder=0 },
            new RefActivityTimeMeasurementType { Id=Guid.Parse("778de321-6bc5-47c8-94e2-5bfd70885a1f"), Code="Yearly weeks is specified as the type of measurement for the amount of time the student participated in the events and procedures of an activity.", SortOrder=0 },
       };
   }
}
