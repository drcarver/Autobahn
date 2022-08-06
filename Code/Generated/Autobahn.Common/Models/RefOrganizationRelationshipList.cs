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
        public static List<RefOrganizationRelationship> RefOrganizationRelationshipList = new List<RefOrganizationRelationship>
        {
            new RefOrganizationRelationship { Id=Guid.Parse("79b97a51-d245-4eef-8c38-34393f884cbd"), Code="AuthorizingBody", Description="Authorizing Body", Definition="The primary entity with legal authority to create or close the organization.", SortOrder=Convert.ToDecimal("1.00") },
            new RefOrganizationRelationship { Id=Guid.Parse("8e8685cc-c859-44ae-97f4-c824b9f9fae5"), Code="OperatingBody", Description="Operating Body", Definition="The entity responsible for operating the organization.", SortOrder=Convert.ToDecimal("2.00") },
            new RefOrganizationRelationship { Id=Guid.Parse("5331bd3d-db3f-44e9-ac0b-331cbc834eb0"), Code="SecondaryAuthorizingBody", Description="Secondary Authorizing Body", Definition="The secondary entity with legal authority to create or close the organization.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefOrganizationRelationship Pick List
         /// </summary>
        public static List<RefOrganizationRelationship> RefOrganizationRelationshipPickList = new List<RefOrganizationRelationship>
        {
            new RefOrganizationRelationship { Id=Guid.Parse("79b97a51-d245-4eef-8c38-34393f884cbd"), Code="AuthorizingBody", Description="Authorizing Body", SortOrder=Convert.ToDecimal("1.00") },
            new RefOrganizationRelationship { Id=Guid.Parse("8e8685cc-c859-44ae-97f4-c824b9f9fae5"), Code="OperatingBody", Description="Operating Body", SortOrder=Convert.ToDecimal("2.00") },
            new RefOrganizationRelationship { Id=Guid.Parse("5331bd3d-db3f-44e9-ac0b-331cbc834eb0"), Code="SecondaryAuthorizingBody", Description="Secondary Authorizing Body", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
