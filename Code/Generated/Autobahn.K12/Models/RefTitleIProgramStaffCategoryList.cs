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
        /// The complete <see cref="RefTitleIProgramStaffCategory"> List
         /// </summary>
        public static List<RefTitleIProgramStaffCategory> RefTitleIProgramStaffCategoryList = new List<RefTitleIProgramStaffCategory> =
        {
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("30f5e640-dcf2-4d86-97ba-97dc081eff90"), Code="Title I Teachers is the category of staff working in a Title I program.", Description="TitleITeacher", Definition="", SortOrder=0 },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("0ca84152-cfa2-4dc5-9122-ef6f00c490d9"), Code="Title I Paraprofessionals is the category of staff working in a Title I program.", Description="TitleIParaprofessional", Definition="", SortOrder=0 },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("37ba50b8-7641-4697-b31f-2e4edc136d35"), Code="Title I Clerical Support Staff is the category of staff working in a Title I program.", Description="TitleISupportStaff", Definition="", SortOrder=0 },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("828e34fb-9996-4748-821c-8f48ab3d1ac5"), Code="Title I Administrators (non-clerical) is the category of staff working in a Title I program.", Description="TitleIAdministrator", Definition="", SortOrder=0 },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("a7b57a77-38e2-4a64-be83-caf5f509b327"), Code="Title I Other Paraprofessionals is the category of staff working in a Title I program.", Description="TitleIOtherParaprofessional", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefTitleIProgramStaffCategory Pick List
         /// </summary>
        public static List<RefTitleIProgramStaffCategory> RefTitleIProgramStaffCategoryPickList = new List<RefTitleIProgramStaffCategory> =
        {
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("30f5e640-dcf2-4d86-97ba-97dc081eff90"), Code="Title I Teachers is the category of staff working in a Title I program.", SortOrder=0 },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("0ca84152-cfa2-4dc5-9122-ef6f00c490d9"), Code="Title I Paraprofessionals is the category of staff working in a Title I program.", SortOrder=0 },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("37ba50b8-7641-4697-b31f-2e4edc136d35"), Code="Title I Clerical Support Staff is the category of staff working in a Title I program.", SortOrder=0 },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("828e34fb-9996-4748-821c-8f48ab3d1ac5"), Code="Title I Administrators (non-clerical) is the category of staff working in a Title I program.", SortOrder=0 },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("a7b57a77-38e2-4a64-be83-caf5f509b327"), Code="Title I Other Paraprofessionals is the category of staff working in a Title I program.", SortOrder=0 },
       };
   }
}
