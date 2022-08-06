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
        public static List<RefEmploymentSeparationType> RefEmploymentSeparationTypeList = new List<RefEmploymentSeparationType> =
        {
            new RefEmploymentSeparationType { Id=Guid.Parse("8b21ec18-3a84-4f00-ba93-55ca075b7718"), Code="Involuntary separation is the type of separation occurring between a person and the organization.", Description="Involuntary", Definition="", SortOrder=0 },
            new RefEmploymentSeparationType { Id=Guid.Parse("538f52ed-63c2-4e0a-ad4e-6869af2ec02e"), Code="Mutual agreement is the type of separation occurring between a person and the organization.", Description="MutualAgreement", Definition="", SortOrder=0 },
            new RefEmploymentSeparationType { Id=Guid.Parse("3baeb1e7-82f2-4882-b4a2-bf09bc1c804a"), Code="The type of separation occurring between a person and the organization is in a category not yet defined in CEDS.", Description="Other", Definition="", SortOrder=0 },
            new RefEmploymentSeparationType { Id=Guid.Parse("b44b7752-86df-45b0-9e3d-e5ad9911d7ab"), Code="Voluntary separation is the type of separation occurring between a person and the organization.", Description="Voluntary", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefEmploymentSeparationType Pick List
         /// </summary>
        public static List<RefEmploymentSeparationType> RefEmploymentSeparationTypePickList = new List<RefEmploymentSeparationType> =
        {
            new RefEmploymentSeparationType { Id=Guid.Parse("8b21ec18-3a84-4f00-ba93-55ca075b7718"), Code="Involuntary separation is the type of separation occurring between a person and the organization.", SortOrder=0 },
            new RefEmploymentSeparationType { Id=Guid.Parse("538f52ed-63c2-4e0a-ad4e-6869af2ec02e"), Code="Mutual agreement is the type of separation occurring between a person and the organization.", SortOrder=0 },
            new RefEmploymentSeparationType { Id=Guid.Parse("3baeb1e7-82f2-4882-b4a2-bf09bc1c804a"), Code="The type of separation occurring between a person and the organization is in a category not yet defined in CEDS.", SortOrder=0 },
            new RefEmploymentSeparationType { Id=Guid.Parse("b44b7752-86df-45b0-9e3d-e5ad9911d7ab"), Code="Voluntary separation is the type of separation occurring between a person and the organization.", SortOrder=0 },
       };
   }
}
