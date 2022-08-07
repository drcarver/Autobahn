//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPDActivityLevelList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPDActivityLevel Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPDActivityLevelModel"> List
         /// </summary>
        public static List<RefPDActivityLevelModel> RefPDActivityLevelList = new List<RefPDActivityLevelModel>
        {
            new RefPDActivityLevel { Id=Guid.Parse("2dfa08ea-5736-45a6-9b92-021800dd3d29"), Code="Beginner", Description="Beginner", Definition="The level of expertise for the professional development activity is beginner.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDActivityLevel { Id=Guid.Parse("4bee5973-2554-4e31-a477-9184d81d136d"), Code="Intermediate", Description="Intermediate", Definition="The level of expertise for the professional development activity is intermediate.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPDActivityLevel { Id=Guid.Parse("c1d8e823-548b-4f7d-9567-ff53f6b1a384"), Code="Advanced", Description="Advanced", Definition="The level of expertise for the professional development activity is advanced.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The Reference RefPDActivityLevel Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPDActivityLevelViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPDActivityLevel { Id=Guid.Parse("2dfa08ea-5736-45a6-9b92-021800dd3d29"), Description="Beginner", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDActivityLevel { Id=Guid.Parse("4bee5973-2554-4e31-a477-9184d81d136d"), Description="Intermediate", SortOrder=Convert.ToDecimal("4.00") },
            new RefPDActivityLevel { Id=Guid.Parse("c1d8e823-548b-4f7d-9567-ff53f6b1a384"), Description="Advanced", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
