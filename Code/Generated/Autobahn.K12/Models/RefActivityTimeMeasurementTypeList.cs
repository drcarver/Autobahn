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
        public static List<RefActivityTimeMeasurementType> RefActivityTimeMeasurementTypeList = new List<RefActivityTimeMeasurementType>
        {
            new RefActivityTimeMeasurementType { Id=Guid.Parse("ae6f7aae-642c-4d2f-8595-16d090161a52"), Code="WeeklyHours", Description="Weekly hours", Definition="Weekly hours is specified as the type of measurement for the amount of time the student participated in the events and procedures of an activity.", SortOrder=Convert.ToDecimal("1.00") },
            new RefActivityTimeMeasurementType { Id=Guid.Parse("197464d0-6f46-4229-a92b-e30ce3ee7a6d"), Code="YearlyWeeks", Description="Yearly weeks", Definition="Yearly weeks is specified as the type of measurement for the amount of time the student participated in the events and procedures of an activity.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefActivityTimeMeasurementType Pick List
         /// </summary>
        public static List<RefActivityTimeMeasurementType> RefActivityTimeMeasurementTypePickList = new List<RefActivityTimeMeasurementType>
        {
            new RefActivityTimeMeasurementType { Id=Guid.Parse("ae6f7aae-642c-4d2f-8595-16d090161a52"), Code="WeeklyHours", Description="Weekly hours", SortOrder=Convert.ToDecimal("1.00") },
            new RefActivityTimeMeasurementType { Id=Guid.Parse("197464d0-6f46-4229-a92b-e30ce3ee7a6d"), Code="YearlyWeeks", Description="Yearly weeks", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
