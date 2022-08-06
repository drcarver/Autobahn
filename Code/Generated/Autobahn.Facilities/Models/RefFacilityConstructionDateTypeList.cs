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
        public static List<RefFacilityConstructionDateType> RefFacilityConstructionDateTypeList = new List<RefFacilityConstructionDateType> =
        {
            new RefFacilityConstructionDateType { Id=Guid.Parse("e151cca6-5ea6-4aaa-a74b-376162dac4cb"), Code="Construction was completed as judged by the owner putting the building or improvement into use.", Description="02420", Definition="", SortOrder=0 },
            new RefFacilityConstructionDateType { Id=Guid.Parse("f2b817bb-28c4-4e29-ba0b-9b3a60bad5f9"), Code="The new building, addition, or improvement is expected to be completed so the owner is able to put the building or improvement into use.", Description="02421", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFacilityConstructionDateType Pick List
         /// </summary>
        public static List<RefFacilityConstructionDateType> RefFacilityConstructionDateTypePickList = new List<RefFacilityConstructionDateType> =
        {
            new RefFacilityConstructionDateType { Id=Guid.Parse("e151cca6-5ea6-4aaa-a74b-376162dac4cb"), Code="Construction was completed as judged by the owner putting the building or improvement into use.", SortOrder=0 },
            new RefFacilityConstructionDateType { Id=Guid.Parse("f2b817bb-28c4-4e29-ba0b-9b3a60bad5f9"), Code="The new building, addition, or improvement is expected to be completed so the owner is able to put the building or improvement into use.", SortOrder=0 },
       };
   }
}
