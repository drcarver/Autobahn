//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPDDeliveryMethodList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPDDeliveryMethod Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPDDeliveryMethod"> List
         /// </summary>
        public static List<RefPDDeliveryMethod> RefPDDeliveryMethodList = new List<RefPDDeliveryMethod> =
        {
            new RefPDDeliveryMethod { Id=Guid.Parse("f0284499-4446-40bb-aa3e-0e31c96d061c"), Code="", Description="Onsite", Definition="", SortOrder=0 },
            new RefPDDeliveryMethod { Id=Guid.Parse("74652d2f-4ca0-4a08-904d-a363db5c6e57"), Code="", Description="Virtual", Definition="", SortOrder=0 },
            new RefPDDeliveryMethod { Id=Guid.Parse("43fcc0e8-d97f-42d1-9713-fc62af145198"), Code="", Description="Off-Site", Definition="", SortOrder=0 },
            new RefPDDeliveryMethod { Id=Guid.Parse("9a1de68a-d87d-4f43-9ebd-18dabd22684c"), Code="", Description="Conference", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPDDeliveryMethod Pick List
         /// </summary>
        public static List<RefPDDeliveryMethod> RefPDDeliveryMethodPickList = new List<RefPDDeliveryMethod> =
        {
            new RefPDDeliveryMethod { Id=Guid.Parse("f0284499-4446-40bb-aa3e-0e31c96d061c"), Code="", SortOrder=0 },
            new RefPDDeliveryMethod { Id=Guid.Parse("74652d2f-4ca0-4a08-904d-a363db5c6e57"), Code="", SortOrder=0 },
            new RefPDDeliveryMethod { Id=Guid.Parse("43fcc0e8-d97f-42d1-9713-fc62af145198"), Code="", SortOrder=0 },
            new RefPDDeliveryMethod { Id=Guid.Parse("9a1de68a-d87d-4f43-9ebd-18dabd22684c"), Code="", SortOrder=0 },
       };
   }
}
