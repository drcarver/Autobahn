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
        public static List<RefIEPAuthorizationDocumentType> RefIEPAuthorizationDocumentTypeList = new List<RefIEPAuthorizationDocumentType>
        {
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("3b482d41-c563-4fde-a7f4-18e6743e9cb8"), Code="Amendment", Description="Amendment", Definition="Amendment is specified as the type of Individualized Education Plan document authorized.", SortOrder=Convert.ToDecimal("") },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("550b1863-85b3-4f01-bd75-c429157d4d1a"), Code="AnnualGoal", Description="Annual Goal", Definition="Annual Goal is specified as the type of Individualized Education Plan document authorized.", SortOrder=Convert.ToDecimal("") },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("adc51b8d-2cb2-4552-a737-23bb870ebe7b"), Code="IEP", Description="IEP", Definition="IEP is specified as the type of Individualized Education Plan document authorized.", SortOrder=Convert.ToDecimal("") },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("d40620d8-32b9-408b-b39b-f2c675df276f"), Code="MeasurableObjective", Description="Measurable Objective", Definition="Measurable Objective is specified as the type of Individualized Education Plan document authorized.", SortOrder=Convert.ToDecimal("") },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("936c69ac-d7fd-4559-b1d9-6207cf54be60"), Code="Placement", Description="Placement", Definition="Placement is specified as the type of Individualized Education Plan document authorized.", SortOrder=Convert.ToDecimal("") },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("a8475847-0c16-4d7f-a456-a7a7a960711a"), Code="Revoke", Description="Revoke", Definition="Revoke is specified as the type of Individualized Education Plan document authorized.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefIEPAuthorizationDocumentType Pick List
         /// </summary>
        public static List<RefIEPAuthorizationDocumentType> RefIEPAuthorizationDocumentTypePickList = new List<RefIEPAuthorizationDocumentType>
        {
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("3b482d41-c563-4fde-a7f4-18e6743e9cb8"), Code="Amendment", Description="Amendment", SortOrder=Convert.ToDecimal("") },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("550b1863-85b3-4f01-bd75-c429157d4d1a"), Code="AnnualGoal", Description="Annual Goal", SortOrder=Convert.ToDecimal("") },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("adc51b8d-2cb2-4552-a737-23bb870ebe7b"), Code="IEP", Description="IEP", SortOrder=Convert.ToDecimal("") },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("d40620d8-32b9-408b-b39b-f2c675df276f"), Code="MeasurableObjective", Description="Measurable Objective", SortOrder=Convert.ToDecimal("") },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("936c69ac-d7fd-4559-b1d9-6207cf54be60"), Code="Placement", Description="Placement", SortOrder=Convert.ToDecimal("") },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("a8475847-0c16-4d7f-a456-a7a7a960711a"), Code="Revoke", Description="Revoke", SortOrder=Convert.ToDecimal("") },
       };
   }
}
