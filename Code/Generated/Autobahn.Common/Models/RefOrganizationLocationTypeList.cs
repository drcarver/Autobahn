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
        public static List<RefOrganizationLocationType> RefOrganizationLocationTypeList = new List<RefOrganizationLocationType>
        {
            new RefOrganizationLocationType { Id=Guid.Parse("e2f8abba-e694-4c7d-b709-a07ddba5395c"), Code="Mailing", Description="Mailing", Definition="Mailing is specified as the type of address listed for an organization.", SortOrder=Convert.ToDecimal("1.00") },
            new RefOrganizationLocationType { Id=Guid.Parse("66526fda-4760-43c6-97d7-79cb70049397"), Code="Physical", Description="Physical", Definition="Physical is specified as the type of address listed for an organization.", SortOrder=Convert.ToDecimal("2.00") },
            new RefOrganizationLocationType { Id=Guid.Parse("1550520d-22fd-44bd-b32a-620e32bb146e"), Code="Shipping", Description="Shipping", Definition="Shipping is specified as the type of address listed for an organization.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefOrganizationLocationType Pick List
         /// </summary>
        public static List<RefOrganizationLocationType> RefOrganizationLocationTypePickList = new List<RefOrganizationLocationType>
        {
            new RefOrganizationLocationType { Id=Guid.Parse("e2f8abba-e694-4c7d-b709-a07ddba5395c"), Code="Mailing", Description="Mailing", SortOrder=Convert.ToDecimal("1.00") },
            new RefOrganizationLocationType { Id=Guid.Parse("66526fda-4760-43c6-97d7-79cb70049397"), Code="Physical", Description="Physical", SortOrder=Convert.ToDecimal("2.00") },
            new RefOrganizationLocationType { Id=Guid.Parse("1550520d-22fd-44bd-b32a-620e32bb146e"), Code="Shipping", Description="Shipping", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
