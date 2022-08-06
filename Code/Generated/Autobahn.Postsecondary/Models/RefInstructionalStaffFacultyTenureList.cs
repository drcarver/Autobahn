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
        public static List<RefInstructionalStaffFacultyTenure> RefInstructionalStaffFacultyTenureList = new List<RefInstructionalStaffFacultyTenure>
        {
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("a6d68ffd-2c55-4240-852a-73c648d169e5"), Code="Tenured", Description="Tenured", Definition="The staff member is tenured.", SortOrder=Convert.ToDecimal("1.00") },
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("eed5483e-b1e9-441d-bbbd-301fc60c45c3"), Code="OnTenureTrack", Description="On tenure track", Definition="The staff member is on tenure track.", SortOrder=Convert.ToDecimal("2.00") },
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("f1338cc6-d921-4c68-8b14-5ceb73ad0c89"), Code="NotOnTenureTrack", Description="Not on tenure track", Definition="The staff member is not on tenure track.", SortOrder=Convert.ToDecimal("3.00") },
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("c459bbb5-62f0-4e31-bec3-724740ed09f8"), Code="WithoutFacultyStatus", Description="Without faculty status", Definition="The staff member is without faculty status.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefInstructionalStaffFacultyTenure Pick List
         /// </summary>
        public static List<RefInstructionalStaffFacultyTenure> RefInstructionalStaffFacultyTenurePickList = new List<RefInstructionalStaffFacultyTenure>
        {
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("a6d68ffd-2c55-4240-852a-73c648d169e5"), Code="Tenured", Description="Tenured", SortOrder=Convert.ToDecimal("1.00") },
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("eed5483e-b1e9-441d-bbbd-301fc60c45c3"), Code="OnTenureTrack", Description="On tenure track", SortOrder=Convert.ToDecimal("2.00") },
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("f1338cc6-d921-4c68-8b14-5ceb73ad0c89"), Code="NotOnTenureTrack", Description="Not on tenure track", SortOrder=Convert.ToDecimal("3.00") },
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("c459bbb5-62f0-4e31-bec3-724740ed09f8"), Code="WithoutFacultyStatus", Description="Without faculty status", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
