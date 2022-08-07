//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefEmploymentContractTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefEmploymentContractType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEmploymentContractTypeModel"> List
         /// </summary>
        public static List<RefEmploymentContractTypeModel> RefEmploymentContractTypeList = new List<RefEmploymentContractTypeModel>
        {
            new RefEmploymentContractType { Id=Guid.Parse("64996d2a-b619-4aa5-9292-37494444bdd9"), Code="Multi-year", Description="Multi-year", Definition="Multi-year employment contract is specified.", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmploymentContractType { Id=Guid.Parse("54cb0e84-6a66-4a26-84f6-44bd2275f0eb"), Code="Annual", Description="Annual", Definition="Annual employment contract is specified.", SortOrder=Convert.ToDecimal("2.00") },
            new RefEmploymentContractType { Id=Guid.Parse("bfed1284-f49a-4e46-b76e-54254de4f173"), Code="LessThanAnnual", Description="Less than annual", Definition="Less than annual employment contract is specified.", SortOrder=Convert.ToDecimal("3.00") },
            new RefEmploymentContractType { Id=Guid.Parse("a213604c-9e1f-44ab-94f5-4bd2d5ae04d6"), Code="NotApplicable", Description="Not applicable", Definition="Not applicable is specified as the contact type.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefEmploymentContractType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefEmploymentContractTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefEmploymentContractType { Id=Guid.Parse("64996d2a-b619-4aa5-9292-37494444bdd9"), Description="Multi-year", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmploymentContractType { Id=Guid.Parse("54cb0e84-6a66-4a26-84f6-44bd2275f0eb"), Description="Annual", SortOrder=Convert.ToDecimal("2.00") },
            new RefEmploymentContractType { Id=Guid.Parse("bfed1284-f49a-4e46-b76e-54254de4f173"), Description="Less than annual", SortOrder=Convert.ToDecimal("3.00") },
            new RefEmploymentContractType { Id=Guid.Parse("a213604c-9e1f-44ab-94f5-4bd2d5ae04d6"), Description="Not applicable", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
