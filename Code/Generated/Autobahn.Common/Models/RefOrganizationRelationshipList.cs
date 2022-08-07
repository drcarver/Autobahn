//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefOrganizationRelationshipList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefOrganizationRelationship Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefOrganizationRelationshipModel"> List
         /// </summary>
        public static List<RefOrganizationRelationshipModel> RefOrganizationRelationshipList = new List<RefOrganizationRelationshipModel>
        {
            new RefOrganizationRelationship { Id=Guid.Parse("ade6cdd9-12ad-4ee3-b029-e5276f6f28b3"), Code="AuthorizingBody", Description="Authorizing Body", Definition="The primary entity with legal authority to create or close the organization.", SortOrder=Convert.ToDecimal("1.00") },
            new RefOrganizationRelationship { Id=Guid.Parse("267c7863-04a4-4877-80a4-9bf67205f6d2"), Code="OperatingBody", Description="Operating Body", Definition="The entity responsible for operating the organization.", SortOrder=Convert.ToDecimal("2.00") },
            new RefOrganizationRelationship { Id=Guid.Parse("2359860a-5f41-4901-b8d2-ab9be304eed6"), Code="SecondaryAuthorizingBody", Description="Secondary Authorizing Body", Definition="The secondary entity with legal authority to create or close the organization.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefOrganizationRelationship Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefOrganizationRelationshipViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefOrganizationRelationship { Id=Guid.Parse("ade6cdd9-12ad-4ee3-b029-e5276f6f28b3"), Description="Authorizing Body", SortOrder=Convert.ToDecimal("1.00") },
            new RefOrganizationRelationship { Id=Guid.Parse("267c7863-04a4-4877-80a4-9bf67205f6d2"), Description="Operating Body", SortOrder=Convert.ToDecimal("2.00") },
            new RefOrganizationRelationship { Id=Guid.Parse("2359860a-5f41-4901-b8d2-ab9be304eed6"), Description="Secondary Authorizing Body", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
