//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefProficiencyTargetAypList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefProficiencyTargetAyp Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefProficiencyTargetAypModel"> List
         /// </summary>
        public static List<RefProficiencyTargetAypModel> RefProficiencyTargetAypList = new List<RefProficiencyTargetAypModel>
        {
            new RefProficiencyTargetAyp { Id=Guid.Parse("7cad89b9-7af2-45e4-8244-e8bbcc6de628"), Code="Met", Description="Met: Regular Determination", Definition="The school or district met the proficiency target using the Regular Determination.", SortOrder=Convert.ToDecimal("1.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("965c320c-bec6-4155-a00f-fd0311fc6985"), Code="MetGrowthModel", Description="Met: Growth Model ", Definition="The school or district met the proficiency target using the Growth Model.", SortOrder=Convert.ToDecimal("2.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("74d0e2b2-94b5-4e20-bf7e-0870aab2277b"), Code="MetBecauseSafeHarbor", Description="Met Because of Safe Harbor", Definition="The school or district met the proficiency target using the Because of Safe Harbor.", SortOrder=Convert.ToDecimal("3.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("fd99ed3a-fb07-485f-9369-f029b9c5c336"), Code="DidNotMeetTarget", Description="Did Not Meet Target", Definition="The school or district did NOT meet the proficiency target.", SortOrder=Convert.ToDecimal("4.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("706e4c32-33d1-46c4-8ad6-2b68ed98619b"), Code="TooFewStudents", Description="Too Few Students for Reliability", Definition="Too Few Students for Reliability.", SortOrder=Convert.ToDecimal("5.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("56ab250f-581d-4d80-8d21-62c7535153c6"), Code="NoStudents", Description="No Students in the Sub-group", Definition="No Students in the Sub-group.", SortOrder=Convert.ToDecimal("6.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("b0f9bf85-7680-4c5a-b805-103617ab82cd"), Code="NA", Description="Not applicable", Definition="Not applicable.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefProficiencyTargetAyp Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefProficiencyTargetAypViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefProficiencyTargetAyp { Id=Guid.Parse("7cad89b9-7af2-45e4-8244-e8bbcc6de628"), Description="Met: Regular Determination", SortOrder=Convert.ToDecimal("1.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("965c320c-bec6-4155-a00f-fd0311fc6985"), Description="Met: Growth Model ", SortOrder=Convert.ToDecimal("2.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("74d0e2b2-94b5-4e20-bf7e-0870aab2277b"), Description="Met Because of Safe Harbor", SortOrder=Convert.ToDecimal("3.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("fd99ed3a-fb07-485f-9369-f029b9c5c336"), Description="Did Not Meet Target", SortOrder=Convert.ToDecimal("4.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("706e4c32-33d1-46c4-8ad6-2b68ed98619b"), Description="Too Few Students for Reliability", SortOrder=Convert.ToDecimal("5.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("56ab250f-581d-4d80-8d21-62c7535153c6"), Description="No Students in the Sub-group", SortOrder=Convert.ToDecimal("6.00") },
            new RefProficiencyTargetAyp { Id=Guid.Parse("b0f9bf85-7680-4c5a-b805-103617ab82cd"), Description="Not applicable", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
