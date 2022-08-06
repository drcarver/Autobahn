//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefOrganizationRelationshipList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefOrganizationRelationship Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefOrganizationRelationship"> List
         /// </summary>
        public static List<RefOrganizationRelationship> RefOrganizationRelationshipList = new List<RefOrganizationRelationship> =
        {
            new RefOrganizationRelationship { Id=Guid.Parse("ebf0be16-0045-457c-b0cf-3bf01ec6ff8f"), Code="The primary entity with legal authority to create or close the organization.", Description="AuthorizingBody", Definition="", SortOrder=0 },
            new RefOrganizationRelationship { Id=Guid.Parse("6adc4981-8b34-4b94-a02f-c570b3753ab3"), Code="The entity responsible for operating the organization.", Description="OperatingBody", Definition="", SortOrder=0 },
            new RefOrganizationRelationship { Id=Guid.Parse("c6d82e1f-bf58-4655-beb4-be5e73336323"), Code="The secondary entity with legal authority to create or close the organization.", Description="SecondaryAuthorizingBody", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefOrganizationRelationship Pick List
         /// </summary>
        public static List<RefOrganizationRelationship> RefOrganizationRelationshipPickList = new List<RefOrganizationRelationship> =
        {
            new RefOrganizationRelationship { Id=Guid.Parse("ebf0be16-0045-457c-b0cf-3bf01ec6ff8f"), Code="The primary entity with legal authority to create or close the organization.", SortOrder=0 },
            new RefOrganizationRelationship { Id=Guid.Parse("6adc4981-8b34-4b94-a02f-c570b3753ab3"), Code="The entity responsible for operating the organization.", SortOrder=0 },
            new RefOrganizationRelationship { Id=Guid.Parse("c6d82e1f-bf58-4655-beb4-be5e73336323"), Code="The secondary entity with legal authority to create or close the organization.", SortOrder=0 },
       };
   }
}
