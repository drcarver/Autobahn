//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefTuitionUnitList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefTuitionUnit Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTuitionUnitModel"> List
         /// </summary>
        public static List<RefTuitionUnitModel> RefTuitionUnitList = new List<RefTuitionUnitModel>
        {
            new RefTuitionUnit { Id=Guid.Parse("3dd51a0a-e6a6-446c-83e0-240da4075e45"), Code="PerTerm", Description="Per Term", Definition="Tuition is being charged Per Term.", SortOrder=Convert.ToDecimal("1.00") },
            new RefTuitionUnit { Id=Guid.Parse("b5ff4fa7-352b-435e-8fbe-0e651e219b7f"), Code="PerYear", Description="Per Year", Definition="Tuition is being charged Per Year.", SortOrder=Convert.ToDecimal("2.00") },
            new RefTuitionUnit { Id=Guid.Parse("52855633-7f48-4f95-88db-2787d4780b27"), Code="PerProgram", Description="Per Program", Definition="Tuition is being charged Per Program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefTuitionUnit { Id=Guid.Parse("11acd521-bfac-49a2-81f6-8bbfee9bcdbf"), Code="PerCourse", Description="Per Course", Definition="Tuition is being charged Per Course.", SortOrder=Convert.ToDecimal("4.00") },
            new RefTuitionUnit { Id=Guid.Parse("920c51aa-9c71-4d41-881c-560d560a785b"), Code="PerCredit", Description="Per Credit", Definition="Tuition is being charged Per Credit.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefTuitionUnit Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefTuitionUnitViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefTuitionUnit { Id=Guid.Parse("3dd51a0a-e6a6-446c-83e0-240da4075e45"), Description="Per Term", SortOrder=Convert.ToDecimal("1.00") },
            new RefTuitionUnit { Id=Guid.Parse("b5ff4fa7-352b-435e-8fbe-0e651e219b7f"), Description="Per Year", SortOrder=Convert.ToDecimal("2.00") },
            new RefTuitionUnit { Id=Guid.Parse("52855633-7f48-4f95-88db-2787d4780b27"), Description="Per Program", SortOrder=Convert.ToDecimal("3.00") },
            new RefTuitionUnit { Id=Guid.Parse("11acd521-bfac-49a2-81f6-8bbfee9bcdbf"), Description="Per Course", SortOrder=Convert.ToDecimal("4.00") },
            new RefTuitionUnit { Id=Guid.Parse("920c51aa-9c71-4d41-881c-560d560a785b"), Description="Per Credit", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
