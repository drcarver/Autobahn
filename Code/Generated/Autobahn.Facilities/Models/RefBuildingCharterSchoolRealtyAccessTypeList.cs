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
        /// The complete <see cref="RefBuildingCharterSchoolRealtyAccessType"> List
         /// </summary>
        public static List<RefBuildingCharterSchoolRealtyAccessType> RefBuildingCharterSchoolRealtyAccessTypeList = new List<RefBuildingCharterSchoolRealtyAccessType> =
        {
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("089128db-32aa-488a-8d75-a23e3e7ff25b"), Code="Legal interest in real property acquired by a tenant (lessee) when he/she enters into a rental agreement with the owner of the property (landlord or lessor). Normally for a fixed period of time at a specified price, without transfer of ownership.", Description="13691", Definition="", SortOrder=0 },
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("2e87493f-658f-4b8a-9fd1-0187d5021167"), Code="The charter non-profit corporation owns the facility and pays for the expenses, including the mortgage payments, utilities, maintenance, and repairs.", Description="13692", Definition="", SortOrder=0 },
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("ed48df22-d135-48fd-abac-5e08643f967d"), Code="A third party non-profit corporation owns the facility where the charter school operates in.", Description="13693", Definition="", SortOrder=0 },
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("250dbba7-5b38-41b6-a383-3ec5291007fa"), Code="Third-party public sector ownership is specified as the type of real estate vehicle through which a public charter school has access and control of its building space.", Description="14907", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefBuildingCharterSchoolRealtyAccessType Pick List
         /// </summary>
        public static List<RefBuildingCharterSchoolRealtyAccessType> RefBuildingCharterSchoolRealtyAccessTypePickList = new List<RefBuildingCharterSchoolRealtyAccessType> =
        {
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("089128db-32aa-488a-8d75-a23e3e7ff25b"), Code="Legal interest in real property acquired by a tenant (lessee) when he/she enters into a rental agreement with the owner of the property (landlord or lessor). Normally for a fixed period of time at a specified price, without transfer of ownership.", SortOrder=0 },
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("2e87493f-658f-4b8a-9fd1-0187d5021167"), Code="The charter non-profit corporation owns the facility and pays for the expenses, including the mortgage payments, utilities, maintenance, and repairs.", SortOrder=0 },
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("ed48df22-d135-48fd-abac-5e08643f967d"), Code="A third party non-profit corporation owns the facility where the charter school operates in.", SortOrder=0 },
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("250dbba7-5b38-41b6-a383-3ec5291007fa"), Code="Third-party public sector ownership is specified as the type of real estate vehicle through which a public charter school has access and control of its building space.", SortOrder=0 },
       };
   }
}
