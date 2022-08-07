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
        /// The complete <see cref="RefActivityTimeMeasurementTypeModel"> List
         /// </summary>
        public static List<RefActivityTimeMeasurementTypeModel> RefActivityTimeMeasurementTypeList = new List<RefActivityTimeMeasurementTypeModel>
        {
            new RefActivityTimeMeasurementType { Id=Guid.Parse("0000a3b1-3139-4f88-8bdc-da533c6a296d"), Code="WeeklyHours", Description="Weekly hours", Definition="Weekly hours is specified as the type of measurement for the amount of time the student participated in the events and procedures of an activity.", SortOrder=Convert.ToDecimal("1.00") },
            new RefActivityTimeMeasurementType { Id=Guid.Parse("606f350a-309f-4411-8105-abf00cb867c3"), Code="YearlyWeeks", Description="Yearly weeks", Definition="Yearly weeks is specified as the type of measurement for the amount of time the student participated in the events and procedures of an activity.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefActivityTimeMeasurementType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefActivityTimeMeasurementTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefActivityTimeMeasurementType { Id=Guid.Parse("0000a3b1-3139-4f88-8bdc-da533c6a296d"), Description="Weekly hours", SortOrder=Convert.ToDecimal("1.00") },
            new RefActivityTimeMeasurementType { Id=Guid.Parse("606f350a-309f-4411-8105-abf00cb867c3"), Description="Yearly weeks", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
