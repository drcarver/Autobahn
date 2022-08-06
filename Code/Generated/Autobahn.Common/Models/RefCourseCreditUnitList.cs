//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCourseCreditUnitList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCourseCreditUnit Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseCreditUnit"> List
         /// </summary>
        public static List<RefCourseCreditUnit> RefCourseCreditUnitList = new List<RefCourseCreditUnit>
        {
            new RefCourseCreditUnit { Id=Guid.Parse("d18376aa-8ef4-4312-9892-5a4632aeac05"), Code="NoCredit", Description="No Credit", Definition="No Credit is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("a7143af1-c539-4dca-bd2c-dc86249c5c31"), Code="Quarter", Description="Quarter ", Definition="Quarter is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("dca651de-25fd-4153-9908-eebea32cf167"), Code="Semester", Description="Semester ", Definition="Semester is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("3c2b0a4b-a9d5-4197-bcd7-6b02b387ac2b"), Code="Units", Description="Units ", Definition="Units is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("03a9be99-e302-4cb4-b2d2-98bb470f6801"), Code="CarnegieUnits", Description="Carnegie Units ", Definition="Carnegie Units is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("1a98a14d-bc78-4a2d-bbde-d0b43d48afaf"), Code="ContinuingEducationUnits", Description="Continuing Education Units ", Definition="Continuing Education Units is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("0b218abc-db27-4de4-a8be-99b865a02db3"), Code="ClockHours", Description="Clock Hours ", Definition="Clock Hours is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("7.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("6a72878e-5aaf-47ad-bd41-08064cd81a7d"), Code="Other", Description="Other", Definition="Other is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("771f14e6-488e-4fec-9503-fe57cb7f6584"), Code="Unreported", Description="Unreported", Definition="Unreported is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The RefCourseCreditUnit Pick List
         /// </summary>
        public static List<RefCourseCreditUnit> RefCourseCreditUnitPickList = new List<RefCourseCreditUnit>
        {
            new RefCourseCreditUnit { Id=Guid.Parse("d18376aa-8ef4-4312-9892-5a4632aeac05"), Code="NoCredit", Description="No Credit", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("a7143af1-c539-4dca-bd2c-dc86249c5c31"), Code="Quarter", Description="Quarter ", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("dca651de-25fd-4153-9908-eebea32cf167"), Code="Semester", Description="Semester ", SortOrder=Convert.ToDecimal("3.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("3c2b0a4b-a9d5-4197-bcd7-6b02b387ac2b"), Code="Units", Description="Units ", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("03a9be99-e302-4cb4-b2d2-98bb470f6801"), Code="CarnegieUnits", Description="Carnegie Units ", SortOrder=Convert.ToDecimal("5.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("1a98a14d-bc78-4a2d-bbde-d0b43d48afaf"), Code="ContinuingEducationUnits", Description="Continuing Education Units ", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("0b218abc-db27-4de4-a8be-99b865a02db3"), Code="ClockHours", Description="Clock Hours ", SortOrder=Convert.ToDecimal("7.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("6a72878e-5aaf-47ad-bd41-08064cd81a7d"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("771f14e6-488e-4fec-9503-fe57cb7f6584"), Code="Unreported", Description="Unreported", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
