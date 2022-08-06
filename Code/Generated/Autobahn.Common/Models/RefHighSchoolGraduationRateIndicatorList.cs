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
        public static List<RefHighSchoolGraduationRateIndicator> RefHighSchoolGraduationRateIndicatorList = new List<RefHighSchoolGraduationRateIndicator> =
        {
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("6aeca324-7e4d-4643-b734-b408b2611101"), Code="The school or district met the High School Graduation Rate goal in accordance with state definition for the purposes of determining AYP.", Description="MetGoal", Definition="", SortOrder=0 },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("c4c0a79a-09e7-419f-8194-523db5356a19"), Code="The school or district met the High School Graduation Rate target in accordance with state definition for the purposes of determining AYP.", Description="MetTarget", Definition="", SortOrder=0 },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("7c352896-84af-4fbe-b3e6-e9f00979e61a"), Code="The school or district did not meet the high school graduation rate indicator for a student subgroup or for all students.", Description="DidNotMeet", Definition="", SortOrder=0 },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("3878a946-571c-452d-8efc-8c71b73aefa6"), Code="The number of students in the school or district or for a student subgroup was less than the minimum group size outlines in a state's consolidated accountability workbook necessary required to reliably calculate the high school graduation rate indicator.", Description="TooFewStudents", Definition="", SortOrder=0 },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("26aa349d-c6a8-4ddb-9b7a-6fbde414d9c4"), Code="There are no students in the student subgroup for determining the High School Graduation Rate.", Description="NoStudents", Definition="", SortOrder=0 },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("4c2cab02-a7f0-4878-8ade-e06a4fffe0ac"), Code="The high school graduation rate indicator status is not applicable.", Description="NA", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefHighSchoolGraduationRateIndicator Pick List
         /// </summary>
        public static List<RefHighSchoolGraduationRateIndicator> RefHighSchoolGraduationRateIndicatorPickList = new List<RefHighSchoolGraduationRateIndicator> =
        {
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("6aeca324-7e4d-4643-b734-b408b2611101"), Code="The school or district met the High School Graduation Rate goal in accordance with state definition for the purposes of determining AYP.", SortOrder=0 },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("c4c0a79a-09e7-419f-8194-523db5356a19"), Code="The school or district met the High School Graduation Rate target in accordance with state definition for the purposes of determining AYP.", SortOrder=0 },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("7c352896-84af-4fbe-b3e6-e9f00979e61a"), Code="The school or district did not meet the high school graduation rate indicator for a student subgroup or for all students.", SortOrder=0 },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("3878a946-571c-452d-8efc-8c71b73aefa6"), Code="The number of students in the school or district or for a student subgroup was less than the minimum group size outlines in a state's consolidated accountability workbook necessary required to reliably calculate the high school graduation rate indicator.", SortOrder=0 },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("26aa349d-c6a8-4ddb-9b7a-6fbde414d9c4"), Code="There are no students in the student subgroup for determining the High School Graduation Rate.", SortOrder=0 },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("4c2cab02-a7f0-4878-8ade-e06a4fffe0ac"), Code="The high school graduation rate indicator status is not applicable.", SortOrder=0 },
       };
   }
}
