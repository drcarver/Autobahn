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
        public static List<RefStaffCompensationSourceType> RefStaffCompensationSourceTypeList = new List<RefStaffCompensationSourceType>
        {
            new RefStaffCompensationSourceType { Id=Guid.Parse("f3e2bc5f-2383-472b-9654-d4fed318cb72"), Code="K12School", Description="K12 School", Definition="The K12 School is the source for the staff compensation a person receives.", SortOrder=Convert.ToDecimal("1.00") },
            new RefStaffCompensationSourceType { Id=Guid.Parse("29fc1800-eeb2-4622-a402-e9d2411193fd"), Code="LEA", Description="Local Education Agency", Definition="The Local Education Agency is the source for the staff compensation a person receives.", SortOrder=Convert.ToDecimal("2.00") },
            new RefStaffCompensationSourceType { Id=Guid.Parse("2ec5a07e-cdf6-4ac3-bf07-b990fd744358"), Code="State", Description="State", Definition="The State is the source for the staff compensation a person receives.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefStaffCompensationSourceType Pick List
         /// </summary>
        public static List<RefStaffCompensationSourceType> RefStaffCompensationSourceTypePickList = new List<RefStaffCompensationSourceType>
        {
            new RefStaffCompensationSourceType { Id=Guid.Parse("f3e2bc5f-2383-472b-9654-d4fed318cb72"), Code="K12School", Description="K12 School", SortOrder=Convert.ToDecimal("1.00") },
            new RefStaffCompensationSourceType { Id=Guid.Parse("29fc1800-eeb2-4622-a402-e9d2411193fd"), Code="LEA", Description="Local Education Agency", SortOrder=Convert.ToDecimal("2.00") },
            new RefStaffCompensationSourceType { Id=Guid.Parse("2ec5a07e-cdf6-4ac3-bf07-b990fd744358"), Code="State", Description="State", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
