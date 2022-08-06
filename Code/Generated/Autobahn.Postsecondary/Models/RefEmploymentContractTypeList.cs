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
        public static List<RefEmploymentContractType> RefEmploymentContractTypeList = new List<RefEmploymentContractType> =
        {
            new RefEmploymentContractType { Id=Guid.Parse("155ea633-d18f-40ac-b0a9-7ce6d4b96598"), Code="Multi-year employment contract is specified.", Description="Multi-year", Definition="", SortOrder=0 },
            new RefEmploymentContractType { Id=Guid.Parse("30c460b4-a620-4a2f-a269-76c551afccec"), Code="Annual employment contract is specified.", Description="Annual", Definition="", SortOrder=0 },
            new RefEmploymentContractType { Id=Guid.Parse("3c01486e-0f45-4969-aee7-63fa72408854"), Code="Less than annual employment contract is specified.", Description="LessThanAnnual", Definition="", SortOrder=0 },
            new RefEmploymentContractType { Id=Guid.Parse("fc7ff567-03b0-496d-9a3f-6650d9e35535"), Code="Not applicable is specified as the contact type.", Description="NotApplicable", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefEmploymentContractType Pick List
         /// </summary>
        public static List<RefEmploymentContractType> RefEmploymentContractTypePickList = new List<RefEmploymentContractType> =
        {
            new RefEmploymentContractType { Id=Guid.Parse("155ea633-d18f-40ac-b0a9-7ce6d4b96598"), Code="Multi-year employment contract is specified.", SortOrder=0 },
            new RefEmploymentContractType { Id=Guid.Parse("30c460b4-a620-4a2f-a269-76c551afccec"), Code="Annual employment contract is specified.", SortOrder=0 },
            new RefEmploymentContractType { Id=Guid.Parse("3c01486e-0f45-4969-aee7-63fa72408854"), Code="Less than annual employment contract is specified.", SortOrder=0 },
            new RefEmploymentContractType { Id=Guid.Parse("fc7ff567-03b0-496d-9a3f-6650d9e35535"), Code="Not applicable is specified as the contact type.", SortOrder=0 },
       };
   }
}
