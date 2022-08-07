//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefLevelOfInstitutionList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefLevelOfInstitution Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLevelOfInstitutionModel"> List
         /// </summary>
        public static List<RefLevelOfInstitutionModel> RefLevelOfInstitutionList = new List<RefLevelOfInstitutionModel>
        {
            new RefLevelOfInstitution { Id=Guid.Parse("7ea526ad-85c0-4ac1-9429-57202365fbe8"), Code="FourYear", Description="Four or more years", Definition="The postsecondary institution's highest level of offering is a program of four or more years.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLevelOfInstitution { Id=Guid.Parse("31d033bf-b1b5-4d75-818d-64bbf1539f5d"), Code="TwoToFour", Description="At least 2 but less than 4 years", Definition="The postsecondary institution's highest level of offering is a program of at least 2 but less than 4 years.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLevelOfInstitution { Id=Guid.Parse("0e332d4d-bf08-4636-8060-0a92b70acc23"), Code="LessThanTwo", Description="Less than 2 years (below associate)", Definition="The postsecondary institution's highest level of offering is a program of less than 2 years (below associate).", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefLevelOfInstitution Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLevelOfInstitutionViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLevelOfInstitution { Id=Guid.Parse("7ea526ad-85c0-4ac1-9429-57202365fbe8"), Description="Four or more years", SortOrder=Convert.ToDecimal("1.00") },
            new RefLevelOfInstitution { Id=Guid.Parse("31d033bf-b1b5-4d75-818d-64bbf1539f5d"), Description="At least 2 but less than 4 years", SortOrder=Convert.ToDecimal("2.00") },
            new RefLevelOfInstitution { Id=Guid.Parse("0e332d4d-bf08-4636-8060-0a92b70acc23"), Description="Less than 2 years (below associate)", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
