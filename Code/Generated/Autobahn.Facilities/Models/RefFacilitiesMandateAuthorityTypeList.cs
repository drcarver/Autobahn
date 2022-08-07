//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilitiesMandateAuthorityTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilitiesMandateAuthorityType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilitiesMandateAuthorityTypeModel"> List
         /// </summary>
        public static List<RefFacilitiesMandateAuthorityTypeModel> RefFacilitiesMandateAuthorityTypeList = new List<RefFacilitiesMandateAuthorityTypeModel>
        {
            new RefFacilitiesMandateAuthorityType { Id=Guid.Parse("0b4e951e-6cfe-4660-83fd-d9527db05064"), Code="13390", Description="District/Local", Definition="District/Local is specified as the authority that mandates through law, regulation, or standard that pertains to a specific mandate.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilitiesMandateAuthorityType { Id=Guid.Parse("b720589a-ff3e-44da-96a4-31c3ef630da8"), Code="00859", Description="Federal", Definition="Federal is specified as the authority that mandates through law, regulation, or standard that pertains to a specific mandate.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilitiesMandateAuthorityType { Id=Guid.Parse("272574c5-c2ae-45db-84a7-07d757d09e3f"), Code="00391", Description="State", Definition="State is specified as the authority that mandates through law, regulation, or standard that pertains to a specific mandate.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefFacilitiesMandateAuthorityType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilitiesMandateAuthorityTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilitiesMandateAuthorityType { Id=Guid.Parse("0b4e951e-6cfe-4660-83fd-d9527db05064"), Description="District/Local", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilitiesMandateAuthorityType { Id=Guid.Parse("b720589a-ff3e-44da-96a4-31c3ef630da8"), Description="Federal", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilitiesMandateAuthorityType { Id=Guid.Parse("272574c5-c2ae-45db-84a7-07d757d09e3f"), Description="State", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
