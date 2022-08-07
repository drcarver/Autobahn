//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefStaffCompensationSourceTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefStaffCompensationSourceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefStaffCompensationSourceTypeModel"> List
         /// </summary>
        public static List<RefStaffCompensationSourceTypeModel> RefStaffCompensationSourceTypeList = new List<RefStaffCompensationSourceTypeModel>
        {
            new RefStaffCompensationSourceType { Id=Guid.Parse("1cc978a4-c086-4921-af97-4389d012bba9"), Code="K12School", Description="K12 School", Definition="The K12 School is the source for the staff compensation a person receives.", SortOrder=Convert.ToDecimal("1.00") },
            new RefStaffCompensationSourceType { Id=Guid.Parse("a6bfcf06-5624-458c-937e-7ebfa7085776"), Code="LEA", Description="Local Education Agency", Definition="The Local Education Agency is the source for the staff compensation a person receives.", SortOrder=Convert.ToDecimal("2.00") },
            new RefStaffCompensationSourceType { Id=Guid.Parse("5e57b3ae-431e-48ae-ba89-4a70ab3bad79"), Code="State", Description="State", Definition="The State is the source for the staff compensation a person receives.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefStaffCompensationSourceType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefStaffCompensationSourceTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefStaffCompensationSourceType { Id=Guid.Parse("1cc978a4-c086-4921-af97-4389d012bba9"), Description="K12 School", SortOrder=Convert.ToDecimal("1.00") },
            new RefStaffCompensationSourceType { Id=Guid.Parse("a6bfcf06-5624-458c-937e-7ebfa7085776"), Description="Local Education Agency", SortOrder=Convert.ToDecimal("2.00") },
            new RefStaffCompensationSourceType { Id=Guid.Parse("5e57b3ae-431e-48ae-ba89-4a70ab3bad79"), Description="State", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
