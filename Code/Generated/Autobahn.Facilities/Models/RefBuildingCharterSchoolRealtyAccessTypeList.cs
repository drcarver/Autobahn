//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingCharterSchoolRealtyAccessTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingCharterSchoolRealtyAccessType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingCharterSchoolRealtyAccessTypeModel"> List
         /// </summary>
        public static List<RefBuildingCharterSchoolRealtyAccessTypeModel> RefBuildingCharterSchoolRealtyAccessTypeList = new List<RefBuildingCharterSchoolRealtyAccessTypeModel>
        {
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("4e1e38b0-131b-4a68-8143-6475d17a20c6"), Code="13691", Description="Leasehold", Definition="Legal interest in real property acquired by a tenant (lessee) when he/she enters into a rental agreement with the owner of the property (landlord or lessor). Normally for a fixed period of time at a specified price, without transfer of ownership.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("f40dfb07-08a7-49d4-8fa1-09de0914d9ad"), Code="13692", Description="Ownership by Charter Non-Profit Corporation", Definition="The charter non-profit corporation owns the facility and pays for the expenses, including the mortgage payments, utilities, maintenance, and repairs.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("a02d7ed9-9f60-4275-9e68-412d5eec06f2"), Code="13693", Description="Third Party Non-Profit Ownership", Definition="A third party non-profit corporation owns the facility where the charter school operates in.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("4aeb3fe9-824f-4bfb-9fba-d11492f3c44c"), Code="14907", Description="Third-party public sector ownership", Definition="Third-party public sector ownership is specified as the type of real estate vehicle through which a public charter school has access and control of its building space.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefBuildingCharterSchoolRealtyAccessType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingCharterSchoolRealtyAccessTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("4e1e38b0-131b-4a68-8143-6475d17a20c6"), Description="Leasehold", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("f40dfb07-08a7-49d4-8fa1-09de0914d9ad"), Description="Ownership by Charter Non-Profit Corporation", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("a02d7ed9-9f60-4275-9e68-412d5eec06f2"), Description="Third Party Non-Profit Ownership", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("4aeb3fe9-824f-4bfb-9fba-d11492f3c44c"), Description="Third-party public sector ownership", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
