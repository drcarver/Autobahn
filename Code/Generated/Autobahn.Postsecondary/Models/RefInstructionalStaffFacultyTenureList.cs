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
        /// The complete <see cref="RefInstructionalStaffFacultyTenureModel"> List
         /// </summary>
        public static List<RefInstructionalStaffFacultyTenureModel> RefInstructionalStaffFacultyTenureList = new List<RefInstructionalStaffFacultyTenureModel>
        {
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("9f46f545-1040-4138-8339-3894054cfae6"), Code="Tenured", Description="Tenured", Definition="The staff member is tenured.", SortOrder=Convert.ToDecimal("1.00") },
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("85332ee4-cf05-4c58-abd4-84a9556aa5ba"), Code="OnTenureTrack", Description="On tenure track", Definition="The staff member is on tenure track.", SortOrder=Convert.ToDecimal("2.00") },
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("138be278-85f9-4927-bf2e-d7e605e6e572"), Code="NotOnTenureTrack", Description="Not on tenure track", Definition="The staff member is not on tenure track.", SortOrder=Convert.ToDecimal("3.00") },
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("15bba337-9bc1-48e5-bab7-ff26d89c0142"), Code="WithoutFacultyStatus", Description="Without faculty status", Definition="The staff member is without faculty status.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefInstructionalStaffFacultyTenure Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefInstructionalStaffFacultyTenureViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("9f46f545-1040-4138-8339-3894054cfae6"), Description="Tenured", SortOrder=Convert.ToDecimal("1.00") },
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("85332ee4-cf05-4c58-abd4-84a9556aa5ba"), Description="On tenure track", SortOrder=Convert.ToDecimal("2.00") },
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("138be278-85f9-4927-bf2e-d7e605e6e572"), Description="Not on tenure track", SortOrder=Convert.ToDecimal("3.00") },
            new RefInstructionalStaffFacultyTenure { Id=Guid.Parse("15bba337-9bc1-48e5-bab7-ff26d89c0142"), Description="Without faculty status", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
