//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefAcademicAwardLevelList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefAcademicAwardLevel Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAcademicAwardLevelModel"> List
         /// </summary>
        public static List<RefAcademicAwardLevelModel> RefAcademicAwardLevelList = new List<RefAcademicAwardLevelModel>
        {
            new RefAcademicAwardLevel { Id=Guid.Parse("cdf06764-34b4-4874-8234-d3a3fe9d4903"), Code="01", Description="Postsecondary award, certificate, or diploma of less than 1 academic year", Definition="Postsecondary award, certificate, or diploma of less than 1 academic year is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("1.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("023ec649-eac7-410a-a7e2-ad7524679c90"), Code="02", Description="Postsecondary award, certificate, or diploma of at least 1 but less than 2 academic years", Definition="Postsecondary award, certificate, or diploma of at least 1 but less than 2 academic years is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("2.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("60a40665-eb6c-42cb-ae54-7698f4fefa64"), Code="03", Description="Associate's Degree", Definition="Associate's Degree is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("3.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("c5d5e993-f658-49a7-bf66-bd4764d0ee66"), Code="04", Description="Postsecondary award, certificate, or diploma of at least 2 but less than 4 academic  years", Definition="Postsecondary award, certificate, or diploma of at least 2 but less than 4 academic  years is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("fc89ee3d-ab01-4a12-bd1a-afaf1cf88d38"), Code="05", Description="Bachelor's Degree", Definition="Bachelor's Degree is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("5.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("6db449c2-3c78-4663-b137-684db0472963"), Code="06", Description="Postbaccalaureate Certificate", Definition="Postbaccalaureate Certificate is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("6.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("c6bf5863-e881-49f7-bb4d-050cfb68ecaf"), Code="07", Description="Master's Degree", Definition="Master's Degree is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("7.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("f059a6ca-70c2-49a3-a427-c0873ec20f43"), Code="08", Description="Post-Master's Certificate", Definition="Post-Master's Certificate is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("8.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("46cac019-6643-4370-9cbe-8011d3551041"), Code="17", Description="Doctor's Degree-Research/Scholarship", Definition="Doctor's Degree-Research/Scholarship is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("9.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("04daa492-11c7-4c96-8db9-07b8e8e16928"), Code="18", Description="Doctor's Degree-Professional Practice", Definition="Doctor's Degree-Professional Practice is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("10.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("ce4816db-937b-4ef5-85de-884c52d97a94"), Code="19", Description="Doctor's Degree-Other", Definition="Doctor's Degree-Other is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("11.00") },
        };

        /// <summary>
        /// The Reference RefAcademicAwardLevel Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAcademicAwardLevelViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAcademicAwardLevel { Id=Guid.Parse("cdf06764-34b4-4874-8234-d3a3fe9d4903"), Description="Postsecondary award, certificate, or diploma of less than 1 academic year", SortOrder=Convert.ToDecimal("1.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("023ec649-eac7-410a-a7e2-ad7524679c90"), Description="Postsecondary award, certificate, or diploma of at least 1 but less than 2 academic years", SortOrder=Convert.ToDecimal("2.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("60a40665-eb6c-42cb-ae54-7698f4fefa64"), Description="Associate's Degree", SortOrder=Convert.ToDecimal("3.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("c5d5e993-f658-49a7-bf66-bd4764d0ee66"), Description="Postsecondary award, certificate, or diploma of at least 2 but less than 4 academic  years", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("fc89ee3d-ab01-4a12-bd1a-afaf1cf88d38"), Description="Bachelor's Degree", SortOrder=Convert.ToDecimal("5.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("6db449c2-3c78-4663-b137-684db0472963"), Description="Postbaccalaureate Certificate", SortOrder=Convert.ToDecimal("6.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("c6bf5863-e881-49f7-bb4d-050cfb68ecaf"), Description="Master's Degree", SortOrder=Convert.ToDecimal("7.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("f059a6ca-70c2-49a3-a427-c0873ec20f43"), Description="Post-Master's Certificate", SortOrder=Convert.ToDecimal("8.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("46cac019-6643-4370-9cbe-8011d3551041"), Description="Doctor's Degree-Research/Scholarship", SortOrder=Convert.ToDecimal("9.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("04daa492-11c7-4c96-8db9-07b8e8e16928"), Description="Doctor's Degree-Professional Practice", SortOrder=Convert.ToDecimal("10.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("ce4816db-937b-4ef5-85de-884c52d97a94"), Description="Doctor's Degree-Other", SortOrder=Convert.ToDecimal("11.00") },
       };
   }
}
