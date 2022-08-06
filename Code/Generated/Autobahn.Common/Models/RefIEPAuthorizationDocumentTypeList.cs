//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIEPAuthorizationDocumentTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIEPAuthorizationDocumentType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIEPAuthorizationDocumentType"> List
         /// </summary>
        public static List<RefIEPAuthorizationDocumentType> RefIEPAuthorizationDocumentTypeList = new List<RefIEPAuthorizationDocumentType> =
        {
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("bf70992d-d5c3-47fc-bf39-87ea2eb79120"), Code="Amendment is specified as the type of Individualized Education Plan document authorized.", Description="Amendment", Definition="", SortOrder=0 },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("d817d7fe-b4f7-4e6e-84ac-473cec6d8b21"), Code="Annual Goal is specified as the type of Individualized Education Plan document authorized.", Description="AnnualGoal", Definition="", SortOrder=0 },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("135e32ae-f150-47d9-b794-e15b72942ca7"), Code="IEP is specified as the type of Individualized Education Plan document authorized.", Description="IEP", Definition="", SortOrder=0 },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("557fc986-9d54-47f6-8ab5-0b62c8c3a7b0"), Code="Measurable Objective is specified as the type of Individualized Education Plan document authorized.", Description="MeasurableObjective", Definition="", SortOrder=0 },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("75f74e45-b024-4481-b5fc-de86591e4e37"), Code="Placement is specified as the type of Individualized Education Plan document authorized.", Description="Placement", Definition="", SortOrder=0 },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("38a93c45-1b89-4a59-8e96-10c1563b8c5a"), Code="Revoke is specified as the type of Individualized Education Plan document authorized.", Description="Revoke", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefIEPAuthorizationDocumentType Pick List
         /// </summary>
        public static List<RefIEPAuthorizationDocumentType> RefIEPAuthorizationDocumentTypePickList = new List<RefIEPAuthorizationDocumentType> =
        {
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("bf70992d-d5c3-47fc-bf39-87ea2eb79120"), Code="Amendment is specified as the type of Individualized Education Plan document authorized.", SortOrder=0 },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("d817d7fe-b4f7-4e6e-84ac-473cec6d8b21"), Code="Annual Goal is specified as the type of Individualized Education Plan document authorized.", SortOrder=0 },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("135e32ae-f150-47d9-b794-e15b72942ca7"), Code="IEP is specified as the type of Individualized Education Plan document authorized.", SortOrder=0 },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("557fc986-9d54-47f6-8ab5-0b62c8c3a7b0"), Code="Measurable Objective is specified as the type of Individualized Education Plan document authorized.", SortOrder=0 },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("75f74e45-b024-4481-b5fc-de86591e4e37"), Code="Placement is specified as the type of Individualized Education Plan document authorized.", SortOrder=0 },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("38a93c45-1b89-4a59-8e96-10c1563b8c5a"), Code="Revoke is specified as the type of Individualized Education Plan document authorized.", SortOrder=0 },
       };
   }
}
