//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityConstructionDateTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityConstructionDateType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityConstructionDateType"> List
         /// </summary>
        public static List<RefFacilityConstructionDateType> RefFacilityConstructionDateTypeList = new List<RefFacilityConstructionDateType>
        {
            new RefFacilityConstructionDateType { Id=Guid.Parse("1631f8fe-6f1a-4132-910f-1079dcf926b5"), Code="02420", Description="Actual", Definition="Construction was completed as judged by the owner putting the building or improvement into use.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityConstructionDateType { Id=Guid.Parse("b0183e4d-62ed-4595-be1c-00d5883979e5"), Code="02421", Description="Estimated", Definition="The new building, addition, or improvement is expected to be completed so the owner is able to put the building or improvement into use.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefFacilityConstructionDateType Pick List
         /// </summary>
        public static List<RefFacilityConstructionDateType> RefFacilityConstructionDateTypePickList = new List<RefFacilityConstructionDateType>
        {
            new RefFacilityConstructionDateType { Id=Guid.Parse("1631f8fe-6f1a-4132-910f-1079dcf926b5"), Code="02420", Description="Actual", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityConstructionDateType { Id=Guid.Parse("b0183e4d-62ed-4595-be1c-00d5883979e5"), Code="02421", Description="Estimated", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
