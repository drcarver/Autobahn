//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefQrisParticipationList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefQrisParticipation Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefQrisParticipation"> List
         /// </summary>
        public static List<RefQrisParticipation> RefQrisParticipationList = new List<RefQrisParticipation>
        {
            new RefQrisParticipation { Id=Guid.Parse("362d2f2f-7823-44b2-9f34-087405c167da"), Code="Yes", Description="Yes", Definition="Yes: Provider does participate in the QRIS", SortOrder=Convert.ToDecimal("1.00") },
            new RefQrisParticipation { Id=Guid.Parse("0dbe12bd-06cd-45d2-a622-458f53e7daba"), Code="No", Description="No", Definition="No: Provider is eligible, but does not participate in the QRIS", SortOrder=Convert.ToDecimal("2.00") },
            new RefQrisParticipation { Id=Guid.Parse("168441f0-ff1c-442e-8e6d-b794334f1131"), Code="NotEligible", Description="Not Eligible", Definition="The State has an operating QRIS in the provider's area, but the provider is not eligible to participate", SortOrder=Convert.ToDecimal("3.00") },
            new RefQrisParticipation { Id=Guid.Parse("1e527853-2b75-4a30-b43d-a1c0d74f04a8"), Code="NoOperatingQRIS", Description="No Operating QRIS", Definition="The State does not have an operating QRIS in the provider's area", SortOrder=Convert.ToDecimal("4.00") },
            new RefQrisParticipation { Id=Guid.Parse("79b8df93-0849-4056-b48a-5d8156ffe151"), Code="InformationUnavailable", Description="Information Unavailable", Definition="The State has an operating QRIS in the provider's area, but information is currently unavailable at the provider level", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefQrisParticipation Pick List
         /// </summary>
        public static List<RefQrisParticipation> RefQrisParticipationPickList = new List<RefQrisParticipation>
        {
            new RefQrisParticipation { Id=Guid.Parse("362d2f2f-7823-44b2-9f34-087405c167da"), Code="Yes", Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefQrisParticipation { Id=Guid.Parse("0dbe12bd-06cd-45d2-a622-458f53e7daba"), Code="No", Description="No", SortOrder=Convert.ToDecimal("2.00") },
            new RefQrisParticipation { Id=Guid.Parse("168441f0-ff1c-442e-8e6d-b794334f1131"), Code="NotEligible", Description="Not Eligible", SortOrder=Convert.ToDecimal("3.00") },
            new RefQrisParticipation { Id=Guid.Parse("1e527853-2b75-4a30-b43d-a1c0d74f04a8"), Code="NoOperatingQRIS", Description="No Operating QRIS", SortOrder=Convert.ToDecimal("4.00") },
            new RefQrisParticipation { Id=Guid.Parse("79b8df93-0849-4056-b48a-5d8156ffe151"), Code="InformationUnavailable", Description="Information Unavailable", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
