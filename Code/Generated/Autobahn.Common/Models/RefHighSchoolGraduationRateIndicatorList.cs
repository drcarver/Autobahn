//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefHighSchoolGraduationRateIndicatorList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefHighSchoolGraduationRateIndicator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefHighSchoolGraduationRateIndicator"> List
         /// </summary>
        public static List<RefHighSchoolGraduationRateIndicator> RefHighSchoolGraduationRateIndicatorList = new List<RefHighSchoolGraduationRateIndicator>
        {
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("966836a8-b5e0-41c0-9ce4-26735459cccb"), Code="MetGoal", Description="Met (Goal)", Definition="The school or district met the High School Graduation Rate goal in accordance with state definition for the purposes of determining AYP.", SortOrder=Convert.ToDecimal("1.00") },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("388f57a1-62b9-46f6-95aa-b5de097841f0"), Code="MetTarget", Description="Met (Target)", Definition="The school or district met the High School Graduation Rate target in accordance with state definition for the purposes of determining AYP.", SortOrder=Convert.ToDecimal("2.00") },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("5f2e7286-09b1-4938-9eb2-ed4fe159eef9"), Code="DidNotMeet", Description="Did Not Meet", Definition="The school or district did not meet the high school graduation rate indicator for a student subgroup or for all students.", SortOrder=Convert.ToDecimal("3.00") },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("1b29d5e3-8927-4d45-b266-869cf4c92dec"), Code="TooFewStudents", Description="Too Few Students", Definition="The number of students in the school or district or for a student subgroup was less than the minimum group size outlines in a state's consolidated accountability workbook necessary required to reliably calculate the high school graduation rate indicator.", SortOrder=Convert.ToDecimal("4.00") },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("fb6503ef-6c1a-4885-97d7-ae133277a928"), Code="NoStudents", Description="There are no students in a student subgroup. ", Definition="There are no students in the student subgroup for determining the High School Graduation Rate.", SortOrder=Convert.ToDecimal("5.00") },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("97880cac-4b8c-4265-bfa8-2ceb99fe2bf4"), Code="NA", Description="Not applicable", Definition="The high school graduation rate indicator status is not applicable.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The RefHighSchoolGraduationRateIndicator Pick List
         /// </summary>
        public static List<RefHighSchoolGraduationRateIndicator> RefHighSchoolGraduationRateIndicatorPickList = new List<RefHighSchoolGraduationRateIndicator>
        {
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("966836a8-b5e0-41c0-9ce4-26735459cccb"), Code="MetGoal", Description="Met (Goal)", SortOrder=Convert.ToDecimal("1.00") },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("388f57a1-62b9-46f6-95aa-b5de097841f0"), Code="MetTarget", Description="Met (Target)", SortOrder=Convert.ToDecimal("2.00") },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("5f2e7286-09b1-4938-9eb2-ed4fe159eef9"), Code="DidNotMeet", Description="Did Not Meet", SortOrder=Convert.ToDecimal("3.00") },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("1b29d5e3-8927-4d45-b266-869cf4c92dec"), Code="TooFewStudents", Description="Too Few Students", SortOrder=Convert.ToDecimal("4.00") },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("fb6503ef-6c1a-4885-97d7-ae133277a928"), Code="NoStudents", Description="There are no students in a student subgroup. ", SortOrder=Convert.ToDecimal("5.00") },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("97880cac-4b8c-4265-bfa8-2ceb99fe2bf4"), Code="NA", Description="Not applicable", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
