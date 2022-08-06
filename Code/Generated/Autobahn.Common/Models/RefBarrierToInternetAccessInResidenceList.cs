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
        public static List<RefBarrierToInternetAccessInResidence> RefBarrierToInternetAccessInResidenceList = new List<RefBarrierToInternetAccessInResidence>
        {
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("bb5fd770-d8f3-4b3f-a418-9dad401d9599"), Code="NotAffordable", Description="Not Affordable", Definition="The student cannot access the internet in their primary place of residence because internet service is not affordable.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("e2eee9e5-b84f-4ce5-8eb3-0dec5d4b5f29"), Code="NotAvailable", Description="Not Available", Definition="The student cannot access the internet in their primary place of residence because internet service is not available.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("c999b519-b7f9-4a67-af82-b108477c4b25"), Code="NotDesired", Description="Not Desired", Definition="The student cannot access the internet in their primary place of residence because the parent or guardian chooses not to subscribe to internet service.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("bc706fa6-0b31-43f4-beb8-1103e8379094"), Code="Other", Description="Other", Definition="The reason why a student cannot access the internet in their primary place of residence is not yet defined.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefBarrierToInternetAccessInResidence Pick List
         /// </summary>
        public static List<RefBarrierToInternetAccessInResidence> RefBarrierToInternetAccessInResidencePickList = new List<RefBarrierToInternetAccessInResidence>
        {
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("bb5fd770-d8f3-4b3f-a418-9dad401d9599"), Code="NotAffordable", Description="Not Affordable", SortOrder=Convert.ToDecimal("1.00") },
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("e2eee9e5-b84f-4ce5-8eb3-0dec5d4b5f29"), Code="NotAvailable", Description="Not Available", SortOrder=Convert.ToDecimal("2.00") },
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("c999b519-b7f9-4a67-af82-b108477c4b25"), Code="NotDesired", Description="Not Desired", SortOrder=Convert.ToDecimal("3.00") },
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("bc706fa6-0b31-43f4-beb8-1103e8379094"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
