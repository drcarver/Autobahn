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
        public static List<RefBuildingCharterSchoolRealtyAccessType> RefBuildingCharterSchoolRealtyAccessTypeList = new List<RefBuildingCharterSchoolRealtyAccessType>
        {
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("271fcb02-f0a4-4e08-a5c5-a59a293a0cf2"), Code="13691", Description="Leasehold", Definition="Legal interest in real property acquired by a tenant (lessee) when he/she enters into a rental agreement with the owner of the property (landlord or lessor). Normally for a fixed period of time at a specified price, without transfer of ownership.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("467b10a2-4098-46a3-9e39-bf62c943c467"), Code="13692", Description="Ownership by Charter Non-Profit Corporation", Definition="The charter non-profit corporation owns the facility and pays for the expenses, including the mortgage payments, utilities, maintenance, and repairs.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("c088537e-9c57-475b-9058-c9e67b2f70f4"), Code="13693", Description="Third Party Non-Profit Ownership", Definition="A third party non-profit corporation owns the facility where the charter school operates in.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("bb21de0b-94c0-42b0-b1d2-6e329529e40c"), Code="14907", Description="Third-party public sector ownership", Definition="Third-party public sector ownership is specified as the type of real estate vehicle through which a public charter school has access and control of its building space.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefBuildingCharterSchoolRealtyAccessType Pick List
         /// </summary>
        public static List<RefBuildingCharterSchoolRealtyAccessType> RefBuildingCharterSchoolRealtyAccessTypePickList = new List<RefBuildingCharterSchoolRealtyAccessType>
        {
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("271fcb02-f0a4-4e08-a5c5-a59a293a0cf2"), Code="13691", Description="Leasehold", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("467b10a2-4098-46a3-9e39-bf62c943c467"), Code="13692", Description="Ownership by Charter Non-Profit Corporation", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("c088537e-9c57-475b-9058-c9e67b2f70f4"), Code="13693", Description="Third Party Non-Profit Ownership", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCharterSchoolRealtyAccessType { Id=Guid.Parse("bb21de0b-94c0-42b0-b1d2-6e329529e40c"), Code="14907", Description="Third-party public sector ownership", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
