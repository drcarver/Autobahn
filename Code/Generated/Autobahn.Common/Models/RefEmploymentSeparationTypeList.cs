//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEmploymentSeparationTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEmploymentSeparationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEmploymentSeparationType"> List
         /// </summary>
        public static List<RefEmploymentSeparationType> RefEmploymentSeparationTypeList = new List<RefEmploymentSeparationType>
        {
            new RefEmploymentSeparationType { Id=Guid.Parse("7baf93eb-a91f-4e52-8ee1-50eb072bc429"), Code="Involuntary", Description="Involuntary separation", Definition="Involuntary separation is the type of separation occurring between a person and the organization.", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmploymentSeparationType { Id=Guid.Parse("0f617a3e-cd22-4c2f-bc31-0318b7d43908"), Code="MutualAgreement", Description="Mutual agreement", Definition="Mutual agreement is the type of separation occurring between a person and the organization.", SortOrder=Convert.ToDecimal("2.00") },
            new RefEmploymentSeparationType { Id=Guid.Parse("97479d9e-a66e-442c-88d5-8197cb19ed5a"), Code="Other", Description="Other", Definition="The type of separation occurring between a person and the organization is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("3.00") },
            new RefEmploymentSeparationType { Id=Guid.Parse("3183aabe-04d1-41ab-8496-410a56144621"), Code="Voluntary", Description="Voluntary separation", Definition="Voluntary separation is the type of separation occurring between a person and the organization.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefEmploymentSeparationType Pick List
         /// </summary>
        public static List<RefEmploymentSeparationType> RefEmploymentSeparationTypePickList = new List<RefEmploymentSeparationType>
        {
            new RefEmploymentSeparationType { Id=Guid.Parse("7baf93eb-a91f-4e52-8ee1-50eb072bc429"), Code="Involuntary", Description="Involuntary separation", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmploymentSeparationType { Id=Guid.Parse("0f617a3e-cd22-4c2f-bc31-0318b7d43908"), Code="MutualAgreement", Description="Mutual agreement", SortOrder=Convert.ToDecimal("2.00") },
            new RefEmploymentSeparationType { Id=Guid.Parse("97479d9e-a66e-442c-88d5-8197cb19ed5a"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("3.00") },
            new RefEmploymentSeparationType { Id=Guid.Parse("3183aabe-04d1-41ab-8496-410a56144621"), Code="Voluntary", Description="Voluntary separation", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
