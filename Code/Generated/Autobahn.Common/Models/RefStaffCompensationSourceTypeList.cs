//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefStaffCompensationSourceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefStaffCompensationSourceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefStaffCompensationSourceType"> List
         /// </summary>
        public static List<RefStaffCompensationSourceType> RefStaffCompensationSourceTypeList = new List<RefStaffCompensationSourceType> =
        {
            new RefStaffCompensationSourceType { Id=Guid.Parse("4da96026-fc80-41fa-82d2-1286a3517fef"), Code="The K12 School is the source for the staff compensation a person receives.", Description="K12School", Definition="", SortOrder=0 },
            new RefStaffCompensationSourceType { Id=Guid.Parse("e8d551e8-4a85-493f-ae01-3f87fcd2967c"), Code="The Local Education Agency is the source for the staff compensation a person receives.", Description="LEA", Definition="", SortOrder=0 },
            new RefStaffCompensationSourceType { Id=Guid.Parse("5d2f6daa-8af8-4244-8c77-7c2a8c0f23c4"), Code="The State is the source for the staff compensation a person receives.", Description="State", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefStaffCompensationSourceType Pick List
         /// </summary>
        public static List<RefStaffCompensationSourceType> RefStaffCompensationSourceTypePickList = new List<RefStaffCompensationSourceType> =
        {
            new RefStaffCompensationSourceType { Id=Guid.Parse("4da96026-fc80-41fa-82d2-1286a3517fef"), Code="The K12 School is the source for the staff compensation a person receives.", SortOrder=0 },
            new RefStaffCompensationSourceType { Id=Guid.Parse("e8d551e8-4a85-493f-ae01-3f87fcd2967c"), Code="The Local Education Agency is the source for the staff compensation a person receives.", SortOrder=0 },
            new RefStaffCompensationSourceType { Id=Guid.Parse("5d2f6daa-8af8-4244-8c77-7c2a8c0f23c4"), Code="The State is the source for the staff compensation a person receives.", SortOrder=0 },
       };
   }
}
