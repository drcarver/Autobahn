//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefProficiencyTargetAypList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefProficiencyTargetAyp Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefProficiencyTargetAyp"> List
         /// </summary>
        public static List<RefProficiencyTargetAyp> RefProficiencyTargetAypList = new List<RefProficiencyTargetAyp>
        {
            new RefProficiencyTargetAyp { Id=Guid.Parse("488050bf-0778-4b9f-8a58-83904be1cca6"), Code="Met", Description="Met: Regular Determination", Definition="The school or district met the proficiency target using the Regular Determination.", SortOrder=Convert.ToDecimal("1.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("8b53c809-f5bd-4e12-aeb1-b556ea086136"), Code="MetGrowthModel", Description="Met: Growth Model ", Definition="The school or district met the proficiency target using the Growth Model.", SortOrder=Convert.ToDecimal("2.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("0e084e75-43be-49ea-983a-051b888afe2a"), Code="MetBecauseSafeHarbor", Description="Met Because of Safe Harbor", Definition="The school or district met the proficiency target using the Because of Safe Harbor.", SortOrder=Convert.ToDecimal("3.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("f7e06323-3f1d-42cf-9d20-1ad85b312d14"), Code="DidNotMeetTarget", Description="Did Not Meet Target", Definition="The school or district did NOT meet the proficiency target.", SortOrder=Convert.ToDecimal("4.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("9ea61958-1fc4-4076-afeb-74f8c8162d66"), Code="TooFewStudents", Description="Too Few Students for Reliability", Definition="Too Few Students for Reliability.", SortOrder=Convert.ToDecimal("5.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("d3aa06a3-7c5f-4aa2-acf6-211ce54b5b8c"), Code="NoStudents", Description="No Students in the Sub-group", Definition="No Students in the Sub-group.", SortOrder=Convert.ToDecimal("6.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("1ba2611d-bad5-4a11-96f0-7e7ee032505b"), Code="NA", Description="Not applicable", Definition="Not applicable.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefProficiencyTargetAyp Pick List
         /// </summary>
        public static List<RefProficiencyTargetAyp> RefProficiencyTargetAypPickList = new List<RefProficiencyTargetAyp>
        {
            new RefProficiencyTargetAyp { Id=Guid.Parse("488050bf-0778-4b9f-8a58-83904be1cca6"), Code="Met", Description="Met: Regular Determination", SortOrder=Convert.ToDecimal("1.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("8b53c809-f5bd-4e12-aeb1-b556ea086136"), Code="MetGrowthModel", Description="Met: Growth Model ", SortOrder=Convert.ToDecimal("2.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("0e084e75-43be-49ea-983a-051b888afe2a"), Code="MetBecauseSafeHarbor", Description="Met Because of Safe Harbor", SortOrder=Convert.ToDecimal("3.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("f7e06323-3f1d-42cf-9d20-1ad85b312d14"), Code="DidNotMeetTarget", Description="Did Not Meet Target", SortOrder=Convert.ToDecimal("4.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("9ea61958-1fc4-4076-afeb-74f8c8162d66"), Code="TooFewStudents", Description="Too Few Students for Reliability", SortOrder=Convert.ToDecimal("5.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("d3aa06a3-7c5f-4aa2-acf6-211ce54b5b8c"), Code="NoStudents", Description="No Students in the Sub-group", SortOrder=Convert.ToDecimal("6.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("1ba2611d-bad5-4a11-96f0-7e7ee032505b"), Code="NA", Description="Not applicable", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
