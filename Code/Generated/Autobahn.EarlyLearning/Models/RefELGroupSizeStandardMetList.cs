//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefELGroupSizeStandardMetList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefELGroupSizeStandardMet Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefELGroupSizeStandardMetModel"> List
         /// </summary>
        public static List<RefELGroupSizeStandardMetModel> RefELGroupSizeStandardMetList = new List<RefELGroupSizeStandardMetModel>
        {
            new RefELGroupSizeStandardMet { Id=Guid.Parse("a666b575-f55f-432c-9e0c-6a4140bf7e11"), Code="Infants", Description="Meets or exceeds standards for infants", Definition="Meets or exceeds NAEYC or NAFCC standards for infant group sizes.", SortOrder=Convert.ToDecimal("1.00") },
            new RefELGroupSizeStandardMet { Id=Guid.Parse("080408d0-c4ed-41c0-9edb-0740e3f69cb4"), Code="Toddlers", Description="Meets or exceeds standards for toddlers", Definition="Meets or exceeds NAEYC or NAFCC standards for toddler group sizes. ", SortOrder=Convert.ToDecimal("2.00") },
            new RefELGroupSizeStandardMet { Id=Guid.Parse("31fdca73-da38-4762-b61b-c45e64c9c6e1"), Code="Preschoolers", Description="Meets or exceeds standards for preschoolers", Definition="Meets or exceeds NAEYC or NAFCC standards for preschooler group sizes.", SortOrder=Convert.ToDecimal("3.00") },
            new RefELGroupSizeStandardMet { Id=Guid.Parse("4656a8b7-6aea-427f-90de-f49820127e3f"), Code="School-Age", Description="Meets or exceeds standards for school-age", Definition="Meets or exceeds NAEYC or NAFCC standards for school-age group sizes.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefELGroupSizeStandardMet Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefELGroupSizeStandardMetViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefELGroupSizeStandardMet { Id=Guid.Parse("a666b575-f55f-432c-9e0c-6a4140bf7e11"), Description="Meets or exceeds standards for infants", SortOrder=Convert.ToDecimal("1.00") },
            new RefELGroupSizeStandardMet { Id=Guid.Parse("080408d0-c4ed-41c0-9edb-0740e3f69cb4"), Description="Meets or exceeds standards for toddlers", SortOrder=Convert.ToDecimal("2.00") },
            new RefELGroupSizeStandardMet { Id=Guid.Parse("31fdca73-da38-4762-b61b-c45e64c9c6e1"), Description="Meets or exceeds standards for preschoolers", SortOrder=Convert.ToDecimal("3.00") },
            new RefELGroupSizeStandardMet { Id=Guid.Parse("4656a8b7-6aea-427f-90de-f49820127e3f"), Description="Meets or exceeds standards for school-age", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
