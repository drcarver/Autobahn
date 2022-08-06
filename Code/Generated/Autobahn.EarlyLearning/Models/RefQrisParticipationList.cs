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
        public static List<RefQrisParticipation> RefQrisParticipationList = new List<RefQrisParticipation> =
        {
            new RefQrisParticipation { Id=Guid.Parse("626b5eee-f30d-431c-8eb6-a34d956b0c77"), Code="Yes: Provider does participate in the QRIS", Description="Yes", Definition="", SortOrder=0 },
            new RefQrisParticipation { Id=Guid.Parse("5bb63628-5f21-4664-90a1-bed35da284c1"), Code="No: Provider is eligible, but does not participate in the QRIS", Description="No", Definition="", SortOrder=0 },
            new RefQrisParticipation { Id=Guid.Parse("e87e3472-683f-46c2-9c03-c6d633473b06"), Code="The State has an operating QRIS in the provider's area, but the provider is not eligible to participate", Description="NotEligible", Definition="", SortOrder=0 },
            new RefQrisParticipation { Id=Guid.Parse("a5f853f2-fa00-431c-9c17-ef6d9fe7f8f4"), Code="The State does not have an operating QRIS in the provider's area", Description="NoOperatingQRIS", Definition="", SortOrder=0 },
            new RefQrisParticipation { Id=Guid.Parse("43426416-205e-416e-9cef-a34f43d7404c"), Code="The State has an operating QRIS in the provider's area, but information is currently unavailable at the provider level", Description="InformationUnavailable", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefQrisParticipation Pick List
         /// </summary>
        public static List<RefQrisParticipation> RefQrisParticipationPickList = new List<RefQrisParticipation> =
        {
            new RefQrisParticipation { Id=Guid.Parse("626b5eee-f30d-431c-8eb6-a34d956b0c77"), Code="Yes: Provider does participate in the QRIS", SortOrder=0 },
            new RefQrisParticipation { Id=Guid.Parse("5bb63628-5f21-4664-90a1-bed35da284c1"), Code="No: Provider is eligible, but does not participate in the QRIS", SortOrder=0 },
            new RefQrisParticipation { Id=Guid.Parse("e87e3472-683f-46c2-9c03-c6d633473b06"), Code="The State has an operating QRIS in the provider's area, but the provider is not eligible to participate", SortOrder=0 },
            new RefQrisParticipation { Id=Guid.Parse("a5f853f2-fa00-431c-9c17-ef6d9fe7f8f4"), Code="The State does not have an operating QRIS in the provider's area", SortOrder=0 },
            new RefQrisParticipation { Id=Guid.Parse("43426416-205e-416e-9cef-a34f43d7404c"), Code="The State has an operating QRIS in the provider's area, but information is currently unavailable at the provider level", SortOrder=0 },
       };
   }
}
