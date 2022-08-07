//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefBarrierToInternetAccessInResidenceList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefBarrierToInternetAccessInResidence Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBarrierToInternetAccessInResidenceModel"> List
         /// </summary>
        public static List<RefBarrierToInternetAccessInResidenceModel> RefBarrierToInternetAccessInResidenceList = new List<RefBarrierToInternetAccessInResidenceModel>
        {
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("7fec5bd5-57c3-410f-9997-ad65ab1e589d"), Code="NotAffordable", Description="Not Affordable", Definition="The student cannot access the internet in their primary place of residence because internet service is not affordable.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("d2d9bb5d-b416-4c8e-9413-b99c4328b80a"), Code="NotAvailable", Description="Not Available", Definition="The student cannot access the internet in their primary place of residence because internet service is not available.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("031b2026-57a1-4bfa-b432-c895b32d26a0"), Code="NotDesired", Description="Not Desired", Definition="The student cannot access the internet in their primary place of residence because the parent or guardian chooses not to subscribe to internet service.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("55b44d1a-277f-427d-bb06-2b22ccb7ed4d"), Code="Other", Description="Other", Definition="The reason why a student cannot access the internet in their primary place of residence is not yet defined.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBarrierToInternetAccessInResidence Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBarrierToInternetAccessInResidenceViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("7fec5bd5-57c3-410f-9997-ad65ab1e589d"), Description="Not Affordable", SortOrder=Convert.ToDecimal("1.00") },
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("d2d9bb5d-b416-4c8e-9413-b99c4328b80a"), Description="Not Available", SortOrder=Convert.ToDecimal("2.00") },
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("031b2026-57a1-4bfa-b432-c895b32d26a0"), Description="Not Desired", SortOrder=Convert.ToDecimal("3.00") },
            new RefBarrierToInternetAccessInResidence { Id=Guid.Parse("55b44d1a-277f-427d-bb06-2b22ccb7ed4d"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
