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
        public static List<RefTitleIProgramStaffCategory> RefTitleIProgramStaffCategoryList = new List<RefTitleIProgramStaffCategory>
        {
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("ba43d8da-a385-4f65-9f07-b0d45ee5608b"), Code="TitleITeacher", Description="Title I Teachers", Definition="Title I Teachers is the category of staff working in a Title I program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("859c0467-7e65-4e02-ade8-2561d8c659fe"), Code="TitleIParaprofessional", Description="Title I Paraprofessionals ", Definition="Title I Paraprofessionals is the category of staff working in a Title I program.", SortOrder=Convert.ToDecimal("2.00") },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("4b099f63-213b-4d82-ab66-91a04962685f"), Code="TitleISupportStaff", Description="Title I Clerical Support Staff", Definition="Title I Clerical Support Staff is the category of staff working in a Title I program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("d7bfee21-2f28-4b7d-aac4-2d71f2b38fae"), Code="TitleIAdministrator", Description="Title I Administrators (non-clerical)", Definition="Title I Administrators (non-clerical) is the category of staff working in a Title I program.", SortOrder=Convert.ToDecimal("4.00") },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("4e2deda6-8617-479f-ba11-a73dc7c807dd"), Code="TitleIOtherParaprofessional", Description="Title I Other Paraprofessionals", Definition="Title I Other Paraprofessionals is the category of staff working in a Title I program.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefTitleIProgramStaffCategory Pick List
         /// </summary>
        public static List<RefTitleIProgramStaffCategory> RefTitleIProgramStaffCategoryPickList = new List<RefTitleIProgramStaffCategory>
        {
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("ba43d8da-a385-4f65-9f07-b0d45ee5608b"), Code="TitleITeacher", Description="Title I Teachers", SortOrder=Convert.ToDecimal("1.00") },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("859c0467-7e65-4e02-ade8-2561d8c659fe"), Code="TitleIParaprofessional", Description="Title I Paraprofessionals ", SortOrder=Convert.ToDecimal("2.00") },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("4b099f63-213b-4d82-ab66-91a04962685f"), Code="TitleISupportStaff", Description="Title I Clerical Support Staff", SortOrder=Convert.ToDecimal("3.00") },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("d7bfee21-2f28-4b7d-aac4-2d71f2b38fae"), Code="TitleIAdministrator", Description="Title I Administrators (non-clerical)", SortOrder=Convert.ToDecimal("4.00") },
            new RefTitleIProgramStaffCategory { Id=Guid.Parse("4e2deda6-8617-479f-ba11-a73dc7c807dd"), Code="TitleIOtherParaprofessional", Description="Title I Other Paraprofessionals", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
