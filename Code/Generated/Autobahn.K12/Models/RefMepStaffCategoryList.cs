//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefMepStaffCategoryList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefMepStaffCategory Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMepStaffCategory"> List
         /// </summary>
        public static List<RefMepStaffCategory> RefMepStaffCategoryList = new List<RefMepStaffCategory>
        {
            new RefMepStaffCategory { Id=Guid.Parse("5e3ac647-e8e1-4b3a-bc5e-9b1ad2bae562"), Code="Teachers", Description="Teachers", Definition="Teachers is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepStaffCategory { Id=Guid.Parse("ac8528c8-fb3b-4ca1-a536-be7dd67c96cc"), Code="Paraprofessionals", Description="Paraprofessionals", Definition="Paraprofessionals  is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("2.00") },
            new RefMepStaffCategory { Id=Guid.Parse("67a8b227-7c7a-4c95-9262-aa4620486285"), Code="Counselors", Description="Counselors", Definition="Counselors is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefMepStaffCategory { Id=Guid.Parse("c800ac93-9f90-4496-8b91-c7d4c796cc88"), Code="Administrators", Description="Administrators", Definition="Administrators is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("4.00") },
            new RefMepStaffCategory { Id=Guid.Parse("9aca83ab-4e9c-429f-9303-07b2c0d275ec"), Code="Recruiters", Description="Recruiters", Definition="Recruiters is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("5.00") },
            new RefMepStaffCategory { Id=Guid.Parse("dfd843ee-885e-4143-abbd-b541876517fa"), Code="RecordsTransferStaff", Description="Records Transfer Staff", Definition="Records Transfer Staff is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The RefMepStaffCategory Pick List
         /// </summary>
        public static List<RefMepStaffCategory> RefMepStaffCategoryPickList = new List<RefMepStaffCategory>
        {
            new RefMepStaffCategory { Id=Guid.Parse("5e3ac647-e8e1-4b3a-bc5e-9b1ad2bae562"), Code="Teachers", Description="Teachers", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepStaffCategory { Id=Guid.Parse("ac8528c8-fb3b-4ca1-a536-be7dd67c96cc"), Code="Paraprofessionals", Description="Paraprofessionals", SortOrder=Convert.ToDecimal("2.00") },
            new RefMepStaffCategory { Id=Guid.Parse("67a8b227-7c7a-4c95-9262-aa4620486285"), Code="Counselors", Description="Counselors", SortOrder=Convert.ToDecimal("3.00") },
            new RefMepStaffCategory { Id=Guid.Parse("c800ac93-9f90-4496-8b91-c7d4c796cc88"), Code="Administrators", Description="Administrators", SortOrder=Convert.ToDecimal("4.00") },
            new RefMepStaffCategory { Id=Guid.Parse("9aca83ab-4e9c-429f-9303-07b2c0d275ec"), Code="Recruiters", Description="Recruiters", SortOrder=Convert.ToDecimal("5.00") },
            new RefMepStaffCategory { Id=Guid.Parse("dfd843ee-885e-4143-abbd-b541876517fa"), Code="RecordsTransferStaff", Description="Records Transfer Staff", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
