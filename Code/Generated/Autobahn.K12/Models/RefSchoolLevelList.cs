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
        public static List<RefSchoolLevel> RefSchoolLevelList = new List<RefSchoolLevel>
        {
            new RefSchoolLevel { Id=Guid.Parse("e830a060-51d6-40aa-bd95-a471fb172225"), Code="00013", Description="Adult", Definition="Adult is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("1.00") },
            new RefSchoolLevel { Id=Guid.Parse("97b5b564-ede4-49aa-8d63-3625f19c4077"), Code="01302", Description="All levels", Definition="The institution serves all levels.", SortOrder=Convert.ToDecimal("2.00") },
            new RefSchoolLevel { Id=Guid.Parse("c7d2d42c-6450-4966-84cf-f6c8d222e0a6"), Code="01304", Description="Elementary", Definition="Elementary is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("3.00") },
            new RefSchoolLevel { Id=Guid.Parse("e3983143-dead-46fe-9bba-ea9351140248"), Code="02402", Description="High school", Definition="High school is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("4.00") },
            new RefSchoolLevel { Id=Guid.Parse("5166a49c-4439-4b18-b1b8-2392d534b8bf"), Code="00787", Description="Infant/toddler", Definition="Infant/toddler is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("5.00") },
            new RefSchoolLevel { Id=Guid.Parse("a5e2a268-26f9-4295-aa19-a043082baa5c"), Code="02399", Description="Intermediate", Definition="Intermediate is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("6.00") },
            new RefSchoolLevel { Id=Guid.Parse("596ddab0-00cd-4529-9603-5fa32e8eda1d"), Code="02602", Description="Junior high school", Definition="Junior high school is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("7.00") },
            new RefSchoolLevel { Id=Guid.Parse("8eae5510-5595-4ad1-896a-4e39ded48672"), Code="02400", Description="Middle", Definition="Middle is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("8.00") },
            new RefSchoolLevel { Id=Guid.Parse("12ab7d70-f0dd-4efb-b5ff-50dc3d6c70c1"), Code="01981", Description="Pre-kindergarten/early childhood", Definition="Pre-kindergarten/early childhood is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("9.00") },
            new RefSchoolLevel { Id=Guid.Parse("1c3c2a30-210d-4539-84f7-188ca51dd19f"), Code="02397", Description="Primary", Definition="Primary is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("10.00") },
            new RefSchoolLevel { Id=Guid.Parse("80a61f41-0d0e-491c-be3d-55e82878f2f3"), Code="02403", Description="Secondary", Definition="Secondary is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("11.00") },
            new RefSchoolLevel { Id=Guid.Parse("4bd1afe3-d749-406f-bc19-551811f3c061"), Code="73066", Description="Joint secondary and postsecondary", Definition="Joint secondary and postsecondary is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("12.00") },
        };

        /// <summary>
        /// The RefSchoolLevel Pick List
         /// </summary>
        public static List<RefSchoolLevel> RefSchoolLevelPickList = new List<RefSchoolLevel>
        {
            new RefSchoolLevel { Id=Guid.Parse("e830a060-51d6-40aa-bd95-a471fb172225"), Code="00013", Description="Adult", SortOrder=Convert.ToDecimal("1.00") },
            new RefSchoolLevel { Id=Guid.Parse("97b5b564-ede4-49aa-8d63-3625f19c4077"), Code="01302", Description="All levels", SortOrder=Convert.ToDecimal("2.00") },
            new RefSchoolLevel { Id=Guid.Parse("c7d2d42c-6450-4966-84cf-f6c8d222e0a6"), Code="01304", Description="Elementary", SortOrder=Convert.ToDecimal("3.00") },
            new RefSchoolLevel { Id=Guid.Parse("e3983143-dead-46fe-9bba-ea9351140248"), Code="02402", Description="High school", SortOrder=Convert.ToDecimal("4.00") },
            new RefSchoolLevel { Id=Guid.Parse("5166a49c-4439-4b18-b1b8-2392d534b8bf"), Code="00787", Description="Infant/toddler", SortOrder=Convert.ToDecimal("5.00") },
            new RefSchoolLevel { Id=Guid.Parse("a5e2a268-26f9-4295-aa19-a043082baa5c"), Code="02399", Description="Intermediate", SortOrder=Convert.ToDecimal("6.00") },
            new RefSchoolLevel { Id=Guid.Parse("596ddab0-00cd-4529-9603-5fa32e8eda1d"), Code="02602", Description="Junior high school", SortOrder=Convert.ToDecimal("7.00") },
            new RefSchoolLevel { Id=Guid.Parse("8eae5510-5595-4ad1-896a-4e39ded48672"), Code="02400", Description="Middle", SortOrder=Convert.ToDecimal("8.00") },
            new RefSchoolLevel { Id=Guid.Parse("12ab7d70-f0dd-4efb-b5ff-50dc3d6c70c1"), Code="01981", Description="Pre-kindergarten/early childhood", SortOrder=Convert.ToDecimal("9.00") },
            new RefSchoolLevel { Id=Guid.Parse("1c3c2a30-210d-4539-84f7-188ca51dd19f"), Code="02397", Description="Primary", SortOrder=Convert.ToDecimal("10.00") },
            new RefSchoolLevel { Id=Guid.Parse("80a61f41-0d0e-491c-be3d-55e82878f2f3"), Code="02403", Description="Secondary", SortOrder=Convert.ToDecimal("11.00") },
            new RefSchoolLevel { Id=Guid.Parse("4bd1afe3-d749-406f-bc19-551811f3c061"), Code="73066", Description="Joint secondary and postsecondary", SortOrder=Convert.ToDecimal("12.00") },
       };
   }
}
