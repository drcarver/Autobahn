//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityUtilityProviderTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityUtilityProviderType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityUtilityProviderTypeModel"> List
         /// </summary>
        public static List<RefFacilityUtilityProviderTypeModel> RefFacilityUtilityProviderTypeList = new List<RefFacilityUtilityProviderTypeModel>
        {
            new RefFacilityUtilityProviderType { Id=Guid.Parse("797db424-3a30-433d-89b8-ae570f80cc1b"), Code="02852", Description="Purchased", Definition="Purchased is specified as an indication of how utilities are supplied to a site or a building by a company or provider.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityUtilityProviderType { Id=Guid.Parse("9dc0b001-2f12-4e5b-b666-9e9b42b50129"), Code="02851", Description="Self-generated", Definition="Self-generated is specified as an indication of how utilities are supplied to a site or a building by a company or provider.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefFacilityUtilityProviderType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilityUtilityProviderTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilityUtilityProviderType { Id=Guid.Parse("797db424-3a30-433d-89b8-ae570f80cc1b"), Description="Purchased", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityUtilityProviderType { Id=Guid.Parse("9dc0b001-2f12-4e5b-b666-9e9b42b50129"), Description="Self-generated", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
