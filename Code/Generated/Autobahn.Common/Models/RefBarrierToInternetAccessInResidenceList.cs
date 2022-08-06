//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefBarrierToInternetAccessInResidenceList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefBarrierToInternetAccessInResidence Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBarrierToInternetAccessInResidence"> List
         /// </summary>
        public static List<RefBarrierToInternetAccessInResidence> RefBarrierToInternetAccessInResidenceList = new List<RefBarrierToInternetAccessInResidence> =
        {
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("f3d938d0-a7fb-47e6-a439-74ae63729760"), Code="The student cannot access the internet in their primary place of residence because internet service is not affordable.", Description="NotAffordable", Definition="", SortOrder=0 },
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("a0a4e952-0f4a-4ae1-af77-1ab657ced761"), Code="The student cannot access the internet in their primary place of residence because internet service is not available.", Description="NotAvailable", Definition="", SortOrder=0 },
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("04ff2339-2afb-4489-bda0-5d7b216e9be2"), Code="The student cannot access the internet in their primary place of residence because the parent or guardian chooses not to subscribe to internet service.", Description="NotDesired", Definition="", SortOrder=0 },
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("92654af3-c8ca-476b-89c3-62df78d91e34"), Code="The reason why a student cannot access the internet in their primary place of residence is not yet defined.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefBarrierToInternetAccessInResidence Pick List
         /// </summary>
        public static List<RefBarrierToInternetAccessInResidence> RefBarrierToInternetAccessInResidencePickList = new List<RefBarrierToInternetAccessInResidence> =
        {
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("f3d938d0-a7fb-47e6-a439-74ae63729760"), Code="The student cannot access the internet in their primary place of residence because internet service is not affordable.", SortOrder=0 },
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("a0a4e952-0f4a-4ae1-af77-1ab657ced761"), Code="The student cannot access the internet in their primary place of residence because internet service is not available.", SortOrder=0 },
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("04ff2339-2afb-4489-bda0-5d7b216e9be2"), Code="The student cannot access the internet in their primary place of residence because the parent or guardian chooses not to subscribe to internet service.", SortOrder=0 },
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("92654af3-c8ca-476b-89c3-62df78d91e34"), Code="The reason why a student cannot access the internet in their primary place of residence is not yet defined.", SortOrder=0 },
       };
   }
}
