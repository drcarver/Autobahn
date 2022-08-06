//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefInstructionalStaffFacultyTenureList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefInstructionalStaffFacultyTenure Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefInstructionalStaffFacultyTenure"> List
         /// </summary>
        public static List<RefInstructionalStaffFacultyTenure> RefInstructionalStaffFacultyTenureList = new List<RefInstructionalStaffFacultyTenure> =
        {
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("6d3020d4-f94c-4a22-a0ff-ba052815694a"), Code="The staff member is tenured.", Description="Tenured", Definition="", SortOrder=0 },
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("f0b56961-636e-4501-b5f4-2045a95ea57e"), Code="The staff member is on tenure track.", Description="OnTenureTrack", Definition="", SortOrder=0 },
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("ccce26d8-2fdd-4fc2-919f-efab8f9d1ccb"), Code="The staff member is not on tenure track.", Description="NotOnTenureTrack", Definition="", SortOrder=0 },
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("7a94a2b0-6a6e-4ccc-a8ca-c904929cb90e"), Code="The staff member is without faculty status.", Description="WithoutFacultyStatus", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefInstructionalStaffFacultyTenure Pick List
         /// </summary>
        public static List<RefInstructionalStaffFacultyTenure> RefInstructionalStaffFacultyTenurePickList = new List<RefInstructionalStaffFacultyTenure> =
        {
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("6d3020d4-f94c-4a22-a0ff-ba052815694a"), Code="The staff member is tenured.", SortOrder=0 },
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("f0b56961-636e-4501-b5f4-2045a95ea57e"), Code="The staff member is on tenure track.", SortOrder=0 },
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("ccce26d8-2fdd-4fc2-919f-efab8f9d1ccb"), Code="The staff member is not on tenure track.", SortOrder=0 },
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("7a94a2b0-6a6e-4ccc-a8ca-c904929cb90e"), Code="The staff member is without faculty status.", SortOrder=0 },
       };
   }
}
