//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefTitleIProgramStaffCategoryList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefTitleIProgramStaffCategory Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTitleIProgramStaffCategoryModel"> List
         /// </summary>
        public static List<RefTitleIProgramStaffCategoryModel> RefTitleIProgramStaffCategoryList = new List<RefTitleIProgramStaffCategoryModel>
        {
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("82b940a9-1767-464b-9587-21ac307eb971"), Code="TitleITeacher", Description="Title I Teachers", Definition="Title I Teachers is the category of staff working in a Title I program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("8c32a614-1660-43c2-a2a8-195e44d4f91d"), Code="TitleIParaprofessional", Description="Title I Paraprofessionals ", Definition="Title I Paraprofessionals is the category of staff working in a Title I program.", SortOrder=Convert.ToDecimal("2.00") },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("ec6c956f-731e-4bb0-a77a-6926a32721de"), Code="TitleISupportStaff", Description="Title I Clerical Support Staff", Definition="Title I Clerical Support Staff is the category of staff working in a Title I program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("b5f94984-a439-4387-ad4c-722a3ff503c3"), Code="TitleIAdministrator", Description="Title I Administrators (non-clerical)", Definition="Title I Administrators (non-clerical) is the category of staff working in a Title I program.", SortOrder=Convert.ToDecimal("4.00") },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("74eed7a4-1873-47dc-aee1-f8eb53f99a0a"), Code="TitleIOtherParaprofessional", Description="Title I Other Paraprofessionals", Definition="Title I Other Paraprofessionals is the category of staff working in a Title I program.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefTitleIProgramStaffCategory Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefTitleIProgramStaffCategoryViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("82b940a9-1767-464b-9587-21ac307eb971"), Description="Title I Teachers", SortOrder=Convert.ToDecimal("1.00") },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("8c32a614-1660-43c2-a2a8-195e44d4f91d"), Description="Title I Paraprofessionals ", SortOrder=Convert.ToDecimal("2.00") },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("ec6c956f-731e-4bb0-a77a-6926a32721de"), Description="Title I Clerical Support Staff", SortOrder=Convert.ToDecimal("3.00") },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("b5f94984-a439-4387-ad4c-722a3ff503c3"), Description="Title I Administrators (non-clerical)", SortOrder=Convert.ToDecimal("4.00") },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("74eed7a4-1873-47dc-aee1-f8eb53f99a0a"), Description="Title I Other Paraprofessionals", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
