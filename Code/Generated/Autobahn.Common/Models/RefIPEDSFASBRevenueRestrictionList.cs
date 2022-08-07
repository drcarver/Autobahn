//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIPEDSFASBRevenueRestrictionList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIPEDSFASBRevenueRestriction Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIPEDSFASBRevenueRestrictionModel"> List
         /// </summary>
        public static List<RefIPEDSFASBRevenueRestrictionModel> RefIPEDSFASBRevenueRestrictionList = new List<RefIPEDSFASBRevenueRestrictionModel>
        {
            new RefIPEDSFASBRevenueRestriction { Id=Guid.Parse("bf4ebe42-df1d-457d-937f-a678795ed575"), Code="PermanentlyRestricted", Description="Permanently Restricted", Definition="Used for reporting revenues that must be maintained in perpetuity due to a donor-imposed restriction.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenueRestriction { Id=Guid.Parse("55aa9088-ded4-4009-b681-10dda5d94141"), Code="TemporarilyRestricted", Description="Temporarily Restricted", Definition="Used for reporting revenues that are subject to limitation by donor specification as to use or the time when use may occur (such as a later period of time or after specified events have occurred).", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenueRestriction { Id=Guid.Parse("4dd664d0-bda5-493d-b24d-7e7351aa3770"), Code="Unrestricted", Description="Unrestricted", Definition="Used for reporting revenues that are not subject to limitations by a donor-imposed restriction.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefIPEDSFASBRevenueRestriction Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIPEDSFASBRevenueRestrictionViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIPEDSFASBRevenueRestriction { Id=Guid.Parse("bf4ebe42-df1d-457d-937f-a678795ed575"), Description="Permanently Restricted", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenueRestriction { Id=Guid.Parse("55aa9088-ded4-4009-b681-10dda5d94141"), Description="Temporarily Restricted", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenueRestriction { Id=Guid.Parse("4dd664d0-bda5-493d-b24d-7e7351aa3770"), Description="Unrestricted", SortOrder=Convert.ToDecimal("") },
       };
   }
}
