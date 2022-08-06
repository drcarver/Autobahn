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
        /// The complete <see cref="RefEmploymentContractType"> List
         /// </summary>
        public static List<RefEmploymentContractType> RefEmploymentContractTypeList = new List<RefEmploymentContractType>
        {
            new RefEmploymentContractType { Id=Guid.Parse("7e3242cc-70bb-42fe-8755-a0a63ccb209a"), Code="Multi-year", Description="Multi-year", Definition="Multi-year employment contract is specified.", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmploymentContractType { Id=Guid.Parse("50851c0f-982a-49b8-bc61-245e03401bdd"), Code="Annual", Description="Annual", Definition="Annual employment contract is specified.", SortOrder=Convert.ToDecimal("2.00") },
            new RefEmploymentContractType { Id=Guid.Parse("c8cdc6fd-6b6c-458b-80c5-ed25349dd001"), Code="LessThanAnnual", Description="Less than annual", Definition="Less than annual employment contract is specified.", SortOrder=Convert.ToDecimal("3.00") },
            new RefEmploymentContractType { Id=Guid.Parse("fd6d7f83-ccdb-49eb-b4d7-3d531431ed6a"), Code="NotApplicable", Description="Not applicable", Definition="Not applicable is specified as the contact type.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefEmploymentContractType Pick List
         /// </summary>
        public static List<RefEmploymentContractType> RefEmploymentContractTypePickList = new List<RefEmploymentContractType>
        {
            new RefEmploymentContractType { Id=Guid.Parse("7e3242cc-70bb-42fe-8755-a0a63ccb209a"), Code="Multi-year", Description="Multi-year", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmploymentContractType { Id=Guid.Parse("50851c0f-982a-49b8-bc61-245e03401bdd"), Code="Annual", Description="Annual", SortOrder=Convert.ToDecimal("2.00") },
            new RefEmploymentContractType { Id=Guid.Parse("c8cdc6fd-6b6c-458b-80c5-ed25349dd001"), Code="LessThanAnnual", Description="Less than annual", SortOrder=Convert.ToDecimal("3.00") },
            new RefEmploymentContractType { Id=Guid.Parse("fd6d7f83-ccdb-49eb-b4d7-3d531431ed6a"), Code="NotApplicable", Description="Not applicable", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
