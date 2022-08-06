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
        public static List<RefProficiencyTargetAyp> RefProficiencyTargetAypList = new List<RefProficiencyTargetAyp> =
        {
            new RefProficiencyTargetAyp { Id=Guid.Parse("742642d3-59a0-4918-9113-69affdb4624b"), Code="The school or district met the proficiency target using the Regular Determination.", Description="Met", Definition="", SortOrder=0 },
            new RefProficiencyTargetAyp { Id=Guid.Parse("10566d70-55a7-48ef-b303-8d45607f1599"), Code="The school or district met the proficiency target using the Growth Model.", Description="MetGrowthModel", Definition="", SortOrder=0 },
            new RefProficiencyTargetAyp { Id=Guid.Parse("ae826cd6-b705-4165-907c-28c6803cea05"), Code="The school or district met the proficiency target using the Because of Safe Harbor.", Description="MetBecauseSafeHarbor", Definition="", SortOrder=0 },
            new RefProficiencyTargetAyp { Id=Guid.Parse("8ad811b1-f3be-40af-993b-6d35c7a49180"), Code="The school or district did NOT meet the proficiency target.", Description="DidNotMeetTarget", Definition="", SortOrder=0 },
            new RefProficiencyTargetAyp { Id=Guid.Parse("af5362c8-1153-4a2a-9bf1-412084310c21"), Code="Too Few Students for Reliability.", Description="TooFewStudents", Definition="", SortOrder=0 },
            new RefProficiencyTargetAyp { Id=Guid.Parse("439a19af-59fe-411a-9e54-660af4a1e6d5"), Code="No Students in the Sub-group.", Description="NoStudents", Definition="", SortOrder=0 },
            new RefProficiencyTargetAyp { Id=Guid.Parse("e9783ae6-1c97-431d-bbcd-9ba878f9d00f"), Code="Not applicable.", Description="NA", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefProficiencyTargetAyp Pick List
         /// </summary>
        public static List<RefProficiencyTargetAyp> RefProficiencyTargetAypPickList = new List<RefProficiencyTargetAyp> =
        {
            new RefProficiencyTargetAyp { Id=Guid.Parse("742642d3-59a0-4918-9113-69affdb4624b"), Code="The school or district met the proficiency target using the Regular Determination.", SortOrder=0 },
            new RefProficiencyTargetAyp { Id=Guid.Parse("10566d70-55a7-48ef-b303-8d45607f1599"), Code="The school or district met the proficiency target using the Growth Model.", SortOrder=0 },
            new RefProficiencyTargetAyp { Id=Guid.Parse("ae826cd6-b705-4165-907c-28c6803cea05"), Code="The school or district met the proficiency target using the Because of Safe Harbor.", SortOrder=0 },
            new RefProficiencyTargetAyp { Id=Guid.Parse("8ad811b1-f3be-40af-993b-6d35c7a49180"), Code="The school or district did NOT meet the proficiency target.", SortOrder=0 },
            new RefProficiencyTargetAyp { Id=Guid.Parse("af5362c8-1153-4a2a-9bf1-412084310c21"), Code="Too Few Students for Reliability.", SortOrder=0 },
            new RefProficiencyTargetAyp { Id=Guid.Parse("439a19af-59fe-411a-9e54-660af4a1e6d5"), Code="No Students in the Sub-group.", SortOrder=0 },
            new RefProficiencyTargetAyp { Id=Guid.Parse("e9783ae6-1c97-431d-bbcd-9ba878f9d00f"), Code="Not applicable.", SortOrder=0 },
       };
   }
}
