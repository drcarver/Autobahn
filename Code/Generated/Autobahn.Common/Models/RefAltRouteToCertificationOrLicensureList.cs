//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAltRouteToCertificationOrLicensureList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAltRouteToCertificationOrLicensure Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAltRouteToCertificationOrLicensureModel"> List
         /// </summary>
        public static List<RefAltRouteToCertificationOrLicensureModel> RefAltRouteToCertificationOrLicensureList = new List<RefAltRouteToCertificationOrLicensureModel>
        {
            new RefAltRouteToCertificationOrLicensure { Id=Guid.Parse("ba5b2a44-3566-429e-a775-db2326ec034c"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefAltRouteToCertificationOrLicensure { Id=Guid.Parse("7f0474cc-b11b-46d0-a1f3-0f3c5c505718"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefAltRouteToCertificationOrLicensure { Id=Guid.Parse("05016f66-5e0f-4a4a-b58a-a1c38ea061d0"), Code="NA", Description="Not applicable", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefAltRouteToCertificationOrLicensure Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAltRouteToCertificationOrLicensureViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAltRouteToCertificationOrLicensure { Id=Guid.Parse("ba5b2a44-3566-429e-a775-db2326ec034c"), Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefAltRouteToCertificationOrLicensure { Id=Guid.Parse("7f0474cc-b11b-46d0-a1f3-0f3c5c505718"), Description="No", SortOrder=Convert.ToDecimal("2.00") },
            new RefAltRouteToCertificationOrLicensure { Id=Guid.Parse("05016f66-5e0f-4a4a-b58a-a1c38ea061d0"), Description="Not applicable", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
