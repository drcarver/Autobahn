//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefSchoolLevelList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefSchoolLevel Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefSchoolLevel"> List
         /// </summary>
        public static List<RefSchoolLevel> RefSchoolLevelList = new List<RefSchoolLevel> =
        {
            new RefSchoolLevel { Id=Guid.Parse("71572eaa-b27f-436a-8417-a9cecd89f92c"), Code="Adult is an education level that the education institution serves.", Description="00013", Definition="", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("d56743fb-be12-48ea-bf65-39a3cf5e7147"), Code="The institution serves all levels.", Description="01302", Definition="", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("4782365f-3c59-491f-8a4a-21d703f57b31"), Code="Elementary is an education level that the education institution serves.", Description="01304", Definition="", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("eda24d78-bfa9-49d9-b38d-782cd7f2f95b"), Code="High school is an education level that the education institution serves.", Description="02402", Definition="", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("07ad9e9e-46d9-46c3-a9f7-e2b688af2291"), Code="Infant/toddler is an education level that the education institution serves.", Description="00787", Definition="", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("ddf57ca7-ec10-42d1-bb1c-6986c1ccad46"), Code="Intermediate is an education level that the education institution serves.", Description="02399", Definition="", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("6336e511-675f-408f-8d5d-91c560908a22"), Code="Junior high school is an education level that the education institution serves.", Description="02602", Definition="", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("0debfeef-dcb1-48a8-b062-57a58a395057"), Code="Middle is an education level that the education institution serves.", Description="02400", Definition="", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("be26c19f-6139-4dd7-874d-c49668263bab"), Code="Pre-kindergarten/early childhood is an education level that the education institution serves.", Description="01981", Definition="", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("87ad00cd-7de4-48a4-b959-b0afe25122d5"), Code="Primary is an education level that the education institution serves.", Description="02397", Definition="", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("a6090d58-dbd0-49d1-a544-9035980f97fd"), Code="Secondary is an education level that the education institution serves.", Description="02403", Definition="", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("9c6ba03f-df2f-4943-8205-8daa4992c483"), Code="Joint secondary and postsecondary is an education level that the education institution serves.", Description="73066", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefSchoolLevel Pick List
         /// </summary>
        public static List<RefSchoolLevel> RefSchoolLevelPickList = new List<RefSchoolLevel> =
        {
            new RefSchoolLevel { Id=Guid.Parse("71572eaa-b27f-436a-8417-a9cecd89f92c"), Code="Adult is an education level that the education institution serves.", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("d56743fb-be12-48ea-bf65-39a3cf5e7147"), Code="The institution serves all levels.", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("4782365f-3c59-491f-8a4a-21d703f57b31"), Code="Elementary is an education level that the education institution serves.", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("eda24d78-bfa9-49d9-b38d-782cd7f2f95b"), Code="High school is an education level that the education institution serves.", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("07ad9e9e-46d9-46c3-a9f7-e2b688af2291"), Code="Infant/toddler is an education level that the education institution serves.", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("ddf57ca7-ec10-42d1-bb1c-6986c1ccad46"), Code="Intermediate is an education level that the education institution serves.", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("6336e511-675f-408f-8d5d-91c560908a22"), Code="Junior high school is an education level that the education institution serves.", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("0debfeef-dcb1-48a8-b062-57a58a395057"), Code="Middle is an education level that the education institution serves.", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("be26c19f-6139-4dd7-874d-c49668263bab"), Code="Pre-kindergarten/early childhood is an education level that the education institution serves.", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("87ad00cd-7de4-48a4-b959-b0afe25122d5"), Code="Primary is an education level that the education institution serves.", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("a6090d58-dbd0-49d1-a544-9035980f97fd"), Code="Secondary is an education level that the education institution serves.", SortOrder=0 },
            new RefSchoolLevel { Id=Guid.Parse("9c6ba03f-df2f-4943-8205-8daa4992c483"), Code="Joint secondary and postsecondary is an education level that the education institution serves.", SortOrder=0 },
       };
   }
}
