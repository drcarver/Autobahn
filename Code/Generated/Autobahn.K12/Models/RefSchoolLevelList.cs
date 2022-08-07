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
        /// The complete <see cref="RefSchoolLevelModel"> List
         /// </summary>
        public static List<RefSchoolLevelModel> RefSchoolLevelList = new List<RefSchoolLevelModel>
        {
            new RefSchoolLevel { Id=Guid.Parse("cb14ec48-8f02-40b8-8e1e-f0056cc77719"), Code="00013", Description="Adult", Definition="Adult is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("1.00") },
            new RefSchoolLevel { Id=Guid.Parse("a697c55b-1368-4100-82e5-accee84cc495"), Code="01302", Description="All levels", Definition="The institution serves all levels.", SortOrder=Convert.ToDecimal("2.00") },
            new RefSchoolLevel { Id=Guid.Parse("94b05d03-de74-4ea5-ab66-a2557fa27747"), Code="01304", Description="Elementary", Definition="Elementary is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("3.00") },
            new RefSchoolLevel { Id=Guid.Parse("44368505-f54c-4f14-a2d2-37596a0a9234"), Code="02402", Description="High school", Definition="High school is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("4.00") },
            new RefSchoolLevel { Id=Guid.Parse("c8bed838-7ea5-49d3-bfb0-907dd4335e13"), Code="00787", Description="Infant/toddler", Definition="Infant/toddler is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("5.00") },
            new RefSchoolLevel { Id=Guid.Parse("584447ee-37bd-4cc6-8c4c-bb8c7279bb35"), Code="02399", Description="Intermediate", Definition="Intermediate is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("6.00") },
            new RefSchoolLevel { Id=Guid.Parse("aff211eb-0adb-4ee8-8ad5-bff25075695d"), Code="02602", Description="Junior high school", Definition="Junior high school is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("7.00") },
            new RefSchoolLevel { Id=Guid.Parse("6537f481-fb9c-4b1d-8ba4-4587ebe04e71"), Code="02400", Description="Middle", Definition="Middle is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("8.00") },
            new RefSchoolLevel { Id=Guid.Parse("a9c7a053-bf59-48d2-b040-cd2683c2bbd3"), Code="01981", Description="Pre-kindergarten/early childhood", Definition="Pre-kindergarten/early childhood is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("9.00") },
            new RefSchoolLevel { Id=Guid.Parse("5a5ed012-f791-4e46-ad11-b3fc31223280"), Code="02397", Description="Primary", Definition="Primary is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("10.00") },
            new RefSchoolLevel { Id=Guid.Parse("ccb81117-6fd4-440e-be1c-4865bd6c420d"), Code="02403", Description="Secondary", Definition="Secondary is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("11.00") },
            new RefSchoolLevel { Id=Guid.Parse("45245f60-d481-484b-8e2c-334d1998f26a"), Code="73066", Description="Joint secondary and postsecondary", Definition="Joint secondary and postsecondary is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("12.00") },
        };

        /// <summary>
        /// The Reference RefSchoolLevel Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefSchoolLevelViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefSchoolLevel { Id=Guid.Parse("cb14ec48-8f02-40b8-8e1e-f0056cc77719"), Description="Adult", SortOrder=Convert.ToDecimal("1.00") },
            new RefSchoolLevel { Id=Guid.Parse("a697c55b-1368-4100-82e5-accee84cc495"), Description="All levels", SortOrder=Convert.ToDecimal("2.00") },
            new RefSchoolLevel { Id=Guid.Parse("94b05d03-de74-4ea5-ab66-a2557fa27747"), Description="Elementary", SortOrder=Convert.ToDecimal("3.00") },
            new RefSchoolLevel { Id=Guid.Parse("44368505-f54c-4f14-a2d2-37596a0a9234"), Description="High school", SortOrder=Convert.ToDecimal("4.00") },
            new RefSchoolLevel { Id=Guid.Parse("c8bed838-7ea5-49d3-bfb0-907dd4335e13"), Description="Infant/toddler", SortOrder=Convert.ToDecimal("5.00") },
            new RefSchoolLevel { Id=Guid.Parse("584447ee-37bd-4cc6-8c4c-bb8c7279bb35"), Description="Intermediate", SortOrder=Convert.ToDecimal("6.00") },
            new RefSchoolLevel { Id=Guid.Parse("aff211eb-0adb-4ee8-8ad5-bff25075695d"), Description="Junior high school", SortOrder=Convert.ToDecimal("7.00") },
            new RefSchoolLevel { Id=Guid.Parse("6537f481-fb9c-4b1d-8ba4-4587ebe04e71"), Description="Middle", SortOrder=Convert.ToDecimal("8.00") },
            new RefSchoolLevel { Id=Guid.Parse("a9c7a053-bf59-48d2-b040-cd2683c2bbd3"), Description="Pre-kindergarten/early childhood", SortOrder=Convert.ToDecimal("9.00") },
            new RefSchoolLevel { Id=Guid.Parse("5a5ed012-f791-4e46-ad11-b3fc31223280"), Description="Primary", SortOrder=Convert.ToDecimal("10.00") },
            new RefSchoolLevel { Id=Guid.Parse("ccb81117-6fd4-440e-be1c-4865bd6c420d"), Description="Secondary", SortOrder=Convert.ToDecimal("11.00") },
            new RefSchoolLevel { Id=Guid.Parse("45245f60-d481-484b-8e2c-334d1998f26a"), Description="Joint secondary and postsecondary", SortOrder=Convert.ToDecimal("12.00") },
       };
   }
}
