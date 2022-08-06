//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefRecordStatusCreatorEntityList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefRecordStatusCreatorEntity Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefRecordStatusCreatorEntity"> List
         /// </summary>
        public static List<RefRecordStatusCreatorEntity> RefRecordStatusCreatorEntityList = new List<RefRecordStatusCreatorEntity>
        {
            new RefRecordStatusCreatorEntity { Id=Guid.Parse("8746c203-68bc-4e24-8aa5-21118fb6b143"), Code="Organization", Description="Organization", Definition="An Organization created the Record Status Type.", SortOrder=Convert.ToDecimal("1.00") },
            new RefRecordStatusCreatorEntity { Id=Guid.Parse("ad8f8013-a3a1-41cb-ae1e-737a981c297a"), Code="Person", Description="Person", Definition="A Person created the Record Status Type.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefRecordStatusCreatorEntity Pick List
         /// </summary>
        public static List<RefRecordStatusCreatorEntity> RefRecordStatusCreatorEntityPickList = new List<RefRecordStatusCreatorEntity>
        {
            new RefRecordStatusCreatorEntity { Id=Guid.Parse("8746c203-68bc-4e24-8aa5-21118fb6b143"), Code="Organization", Description="Organization", SortOrder=Convert.ToDecimal("1.00") },
            new RefRecordStatusCreatorEntity { Id=Guid.Parse("ad8f8013-a3a1-41cb-ae1e-737a981c297a"), Code="Person", Description="Person", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
