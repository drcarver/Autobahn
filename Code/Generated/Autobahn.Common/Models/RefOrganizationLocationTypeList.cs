//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefOrganizationLocationTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefOrganizationLocationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefOrganizationLocationType"> List
         /// </summary>
        public static List<RefOrganizationLocationType> RefOrganizationLocationTypeList = new List<RefOrganizationLocationType> =
        {
            new RefOrganizationLocationType { Id=Guid.Parse("1e18d8ea-0a3e-4e22-bbda-80e9d2bbda53"), Code="Mailing is specified as the type of address listed for an organization.", Description="Mailing", Definition="", SortOrder=0 },
            new RefOrganizationLocationType { Id=Guid.Parse("18fd2375-9d77-4357-97d5-b5f0349b4f89"), Code="Physical is specified as the type of address listed for an organization.", Description="Physical", Definition="", SortOrder=0 },
            new RefOrganizationLocationType { Id=Guid.Parse("a10bbc0e-8fd2-4e01-985a-7ad04065928c"), Code="Shipping is specified as the type of address listed for an organization.", Description="Shipping", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefOrganizationLocationType Pick List
         /// </summary>
        public static List<RefOrganizationLocationType> RefOrganizationLocationTypePickList = new List<RefOrganizationLocationType> =
        {
            new RefOrganizationLocationType { Id=Guid.Parse("1e18d8ea-0a3e-4e22-bbda-80e9d2bbda53"), Code="Mailing is specified as the type of address listed for an organization.", SortOrder=0 },
            new RefOrganizationLocationType { Id=Guid.Parse("18fd2375-9d77-4357-97d5-b5f0349b4f89"), Code="Physical is specified as the type of address listed for an organization.", SortOrder=0 },
            new RefOrganizationLocationType { Id=Guid.Parse("a10bbc0e-8fd2-4e01-985a-7ad04065928c"), Code="Shipping is specified as the type of address listed for an organization.", SortOrder=0 },
       };
   }
}
