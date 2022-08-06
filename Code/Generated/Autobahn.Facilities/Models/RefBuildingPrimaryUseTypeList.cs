//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingPrimaryUseTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingPrimaryUseType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingPrimaryUseType"> List
         /// </summary>
        public static List<RefBuildingPrimaryUseType> RefBuildingPrimaryUseTypeList = new List<RefBuildingPrimaryUseType>
        {
            new RefBuildingPrimaryUseType { Id=Guid.Parse("816ccda6-0a82-49ab-9978-25ba925b52d8"), Code="13561", Description="Church", Definition="Church is specified as the primary use type of the building in which a school is located.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("67f62e72-18e6-4f8f-9d95-b50301816a32"), Code="13562", Description="Commercial office building", Definition="Commercial office building is specified as the primary use type of the building in which a school is located.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("3a548805-34f3-4f69-81ff-103a469b3261"), Code="13563", Description="Commercial warehouse", Definition="Commercial warehouse is specified as the primary use type of the building in which a school is located.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("5487f8a2-8992-49c8-8644-6d2ea11600de"), Code="13564", Description="Community center", Definition="Community center is specified as the primary use type of the building in which a school is located.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("3a79ec9d-ba50-42bf-8f49-ab7e9e12207e"), Code="13565", Description="Public school building", Definition="Public school building is specified as the primary use type of the building in which a school is located.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefBuildingPrimaryUseType Pick List
         /// </summary>
        public static List<RefBuildingPrimaryUseType> RefBuildingPrimaryUseTypePickList = new List<RefBuildingPrimaryUseType>
        {
            new RefBuildingPrimaryUseType { Id=Guid.Parse("816ccda6-0a82-49ab-9978-25ba925b52d8"), Code="13561", Description="Church", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("67f62e72-18e6-4f8f-9d95-b50301816a32"), Code="13562", Description="Commercial office building", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("3a548805-34f3-4f69-81ff-103a469b3261"), Code="13563", Description="Commercial warehouse", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("5487f8a2-8992-49c8-8644-6d2ea11600de"), Code="13564", Description="Community center", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("3a79ec9d-ba50-42bf-8f49-ab7e9e12207e"), Code="13565", Description="Public school building", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
