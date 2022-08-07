//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIEPAuthorizationDocumentTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIEPAuthorizationDocumentType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIEPAuthorizationDocumentTypeModel"> List
         /// </summary>
        public static List<RefIEPAuthorizationDocumentTypeModel> RefIEPAuthorizationDocumentTypeList = new List<RefIEPAuthorizationDocumentTypeModel>
        {
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("ccfa35d3-c768-4c2b-8402-798ef77db25a"), Code="Amendment", Description="Amendment", Definition="Amendment is specified as the type of Individualized Education Plan document authorized.", SortOrder=Convert.ToDecimal("") },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("cc83eeba-69b4-4aee-a142-0b3734d9d857"), Code="AnnualGoal", Description="Annual Goal", Definition="Annual Goal is specified as the type of Individualized Education Plan document authorized.", SortOrder=Convert.ToDecimal("") },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("2ba708fe-c915-4d1a-940f-43c3a7c4dc8e"), Code="IEP", Description="IEP", Definition="IEP is specified as the type of Individualized Education Plan document authorized.", SortOrder=Convert.ToDecimal("") },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("3568886c-ae2e-4fa4-bfed-9fd7485fb573"), Code="MeasurableObjective", Description="Measurable Objective", Definition="Measurable Objective is specified as the type of Individualized Education Plan document authorized.", SortOrder=Convert.ToDecimal("") },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("5c9a4048-5cc5-4eb6-a559-7fa4dc24e667"), Code="Placement", Description="Placement", Definition="Placement is specified as the type of Individualized Education Plan document authorized.", SortOrder=Convert.ToDecimal("") },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("66b0076e-41b1-41bb-90d8-e3e08842b605"), Code="Revoke", Description="Revoke", Definition="Revoke is specified as the type of Individualized Education Plan document authorized.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefIEPAuthorizationDocumentType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIEPAuthorizationDocumentTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("ccfa35d3-c768-4c2b-8402-798ef77db25a"), Description="Amendment", SortOrder=Convert.ToDecimal("") },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("cc83eeba-69b4-4aee-a142-0b3734d9d857"), Description="Annual Goal", SortOrder=Convert.ToDecimal("") },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("2ba708fe-c915-4d1a-940f-43c3a7c4dc8e"), Description="IEP", SortOrder=Convert.ToDecimal("") },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("3568886c-ae2e-4fa4-bfed-9fd7485fb573"), Description="Measurable Objective", SortOrder=Convert.ToDecimal("") },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("5c9a4048-5cc5-4eb6-a559-7fa4dc24e667"), Description="Placement", SortOrder=Convert.ToDecimal("") },
            new RefIEPAuthorizationDocumentType { Id=Guid.Parse("66b0076e-41b1-41bb-90d8-e3e08842b605"), Description="Revoke", SortOrder=Convert.ToDecimal("") },
       };
   }
}
