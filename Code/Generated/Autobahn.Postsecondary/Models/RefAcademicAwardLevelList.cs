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
        /// The complete <see cref="RefAcademicAwardLevel"> List
         /// </summary>
        public static List<RefAcademicAwardLevel> RefAcademicAwardLevelList = new List<RefAcademicAwardLevel>
        {
            new RefAcademicAwardLevel { Id=Guid.Parse("d9c5d5cb-3870-4d39-b1ca-f03f2cbf2fc9"), Code="01", Description="Postsecondary award, certificate, or diploma of less than 1 academic year", Definition="Postsecondary award, certificate, or diploma of less than 1 academic year is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("1.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("8050f22a-25d6-4f46-ad3d-7611c8f8f031"), Code="02", Description="Postsecondary award, certificate, or diploma of at least 1 but less than 2 academic years", Definition="Postsecondary award, certificate, or diploma of at least 1 but less than 2 academic years is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("2.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("f8949296-5559-4b54-a9c6-db1361f75abe"), Code="03", Description="Associate's Degree", Definition="Associate's Degree is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("3.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("f0e4cba7-171f-4020-8ca2-552500ebac5b"), Code="04", Description="Postsecondary award, certificate, or diploma of at least 2 but less than 4 academic  years", Definition="Postsecondary award, certificate, or diploma of at least 2 but less than 4 academic  years is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("30259cca-4993-46ee-9d06-9d3f69ee4b77"), Code="05", Description="Bachelor's Degree", Definition="Bachelor's Degree is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("5.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("7228eb74-db68-42a6-ae05-36ef8e00723e"), Code="06", Description="Postbaccalaureate Certificate", Definition="Postbaccalaureate Certificate is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("6.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("04884ca3-81fc-4258-9c05-022a127f8dcc"), Code="07", Description="Master's Degree", Definition="Master's Degree is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("7.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("b1fb1eab-8f69-4811-9150-90a5d38e92ff"), Code="08", Description="Post-Master's Certificate", Definition="Post-Master's Certificate is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("8.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("0750403f-54cc-41a6-9aaf-9f73dad6a101"), Code="17", Description="Doctor's Degree-Research/Scholarship", Definition="Doctor's Degree-Research/Scholarship is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("9.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("269d7f0f-e36f-4332-af2c-8be523bba4be"), Code="18", Description="Doctor's Degree-Professional Practice", Definition="Doctor's Degree-Professional Practice is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("10.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("e13970ac-0429-4d75-8f89-b9afc3b84fca"), Code="19", Description="Doctor's Degree-Other", Definition="Doctor's Degree-Other is the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study. ", SortOrder=Convert.ToDecimal("11.00") },
        };

        /// <summary>
        /// The RefAcademicAwardLevel Pick List
         /// </summary>
        public static List<RefAcademicAwardLevel> RefAcademicAwardLevelPickList = new List<RefAcademicAwardLevel>
        {
            new RefAcademicAwardLevel { Id=Guid.Parse("d9c5d5cb-3870-4d39-b1ca-f03f2cbf2fc9"), Code="01", Description="Postsecondary award, certificate, or diploma of less than 1 academic year", SortOrder=Convert.ToDecimal("1.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("8050f22a-25d6-4f46-ad3d-7611c8f8f031"), Code="02", Description="Postsecondary award, certificate, or diploma of at least 1 but less than 2 academic years", SortOrder=Convert.ToDecimal("2.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("f8949296-5559-4b54-a9c6-db1361f75abe"), Code="03", Description="Associate's Degree", SortOrder=Convert.ToDecimal("3.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("f0e4cba7-171f-4020-8ca2-552500ebac5b"), Code="04", Description="Postsecondary award, certificate, or diploma of at least 2 but less than 4 academic  years", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("30259cca-4993-46ee-9d06-9d3f69ee4b77"), Code="05", Description="Bachelor's Degree", SortOrder=Convert.ToDecimal("5.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("7228eb74-db68-42a6-ae05-36ef8e00723e"), Code="06", Description="Postbaccalaureate Certificate", SortOrder=Convert.ToDecimal("6.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("04884ca3-81fc-4258-9c05-022a127f8dcc"), Code="07", Description="Master's Degree", SortOrder=Convert.ToDecimal("7.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("b1fb1eab-8f69-4811-9150-90a5d38e92ff"), Code="08", Description="Post-Master's Certificate", SortOrder=Convert.ToDecimal("8.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("0750403f-54cc-41a6-9aaf-9f73dad6a101"), Code="17", Description="Doctor's Degree-Research/Scholarship", SortOrder=Convert.ToDecimal("9.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("269d7f0f-e36f-4332-af2c-8be523bba4be"), Code="18", Description="Doctor's Degree-Professional Practice", SortOrder=Convert.ToDecimal("10.00") },
            new RefAcademicAwardLevel { Id=Guid.Parse("e13970ac-0429-4d75-8f89-b9afc3b84fca"), Code="19", Description="Doctor's Degree-Other", SortOrder=Convert.ToDecimal("11.00") },
       };
   }
}
