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
        public static List<RefRecordStatusCreatorEntity> RefRecordStatusCreatorEntityList = new List<RefRecordStatusCreatorEntity> =
        {
            new RefRecordStatusCreatorEntity { Id=Guid.Parse("811e0c61-1e83-4e66-b89b-9c382db49c7c"), Code="An Organization created the Record Status Type.", Description="Organization", Definition="", SortOrder=0 },
            new RefRecordStatusCreatorEntity { Id=Guid.Parse("fafd2d7e-bf29-4d0f-9aa1-03791679c319"), Code="A Person created the Record Status Type.", Description="Person", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefRecordStatusCreatorEntity Pick List
         /// </summary>
        public static List<RefRecordStatusCreatorEntity> RefRecordStatusCreatorEntityPickList = new List<RefRecordStatusCreatorEntity> =
        {
            new RefRecordStatusCreatorEntity { Id=Guid.Parse("811e0c61-1e83-4e66-b89b-9c382db49c7c"), Code="An Organization created the Record Status Type.", SortOrder=0 },
            new RefRecordStatusCreatorEntity { Id=Guid.Parse("fafd2d7e-bf29-4d0f-9aa1-03791679c319"), Code="A Person created the Record Status Type.", SortOrder=0 },
       };
   }
}
