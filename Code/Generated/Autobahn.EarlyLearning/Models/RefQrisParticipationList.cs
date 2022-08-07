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
        /// The complete <see cref="RefQrisParticipationModel"> List
         /// </summary>
        public static List<RefQrisParticipationModel> RefQrisParticipationList = new List<RefQrisParticipationModel>
        {
            new RefQrisParticipation { Id=Guid.Parse("360df187-cedc-4860-9f1c-f178ac2d4555"), Code="Yes", Description="Yes", Definition="Yes: Provider does participate in the QRIS", SortOrder=Convert.ToDecimal("1.00") },
            new RefQrisParticipation { Id=Guid.Parse("e09ed7ec-1182-438a-9637-0fd3751429ba"), Code="No", Description="No", Definition="No: Provider is eligible, but does not participate in the QRIS", SortOrder=Convert.ToDecimal("2.00") },
            new RefQrisParticipation { Id=Guid.Parse("9f6cc9d7-466e-439e-b052-c5e105602380"), Code="NotEligible", Description="Not Eligible", Definition="The State has an operating QRIS in the provider's area, but the provider is not eligible to participate", SortOrder=Convert.ToDecimal("3.00") },
            new RefQrisParticipation { Id=Guid.Parse("877d4b2c-2d45-4e10-b743-5fa4d74bb431"), Code="NoOperatingQRIS", Description="No Operating QRIS", Definition="The State does not have an operating QRIS in the provider's area", SortOrder=Convert.ToDecimal("4.00") },
            new RefQrisParticipation { Id=Guid.Parse("ce02a2fb-b18d-40ca-9fe6-430797b1f291"), Code="InformationUnavailable", Description="Information Unavailable", Definition="The State has an operating QRIS in the provider's area, but information is currently unavailable at the provider level", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefQrisParticipation Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefQrisParticipationViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefQrisParticipation { Id=Guid.Parse("360df187-cedc-4860-9f1c-f178ac2d4555"), Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefQrisParticipation { Id=Guid.Parse("e09ed7ec-1182-438a-9637-0fd3751429ba"), Description="No", SortOrder=Convert.ToDecimal("2.00") },
            new RefQrisParticipation { Id=Guid.Parse("9f6cc9d7-466e-439e-b052-c5e105602380"), Description="Not Eligible", SortOrder=Convert.ToDecimal("3.00") },
            new RefQrisParticipation { Id=Guid.Parse("877d4b2c-2d45-4e10-b743-5fa4d74bb431"), Description="No Operating QRIS", SortOrder=Convert.ToDecimal("4.00") },
            new RefQrisParticipation { Id=Guid.Parse("ce02a2fb-b18d-40ca-9fe6-430797b1f291"), Description="Information Unavailable", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
