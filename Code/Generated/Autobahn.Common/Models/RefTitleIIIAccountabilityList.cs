//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTitleIIIAccountabilityList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefTitleIIIAccountability Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTitleIIIAccountabilityModel"> List
         /// </summary>
        public static List<RefTitleIIIAccountabilityModel> RefTitleIIIAccountabilityList = new List<RefTitleIIIAccountabilityModel>
        {
            new RefTitleIIIAccountability { Id=Guid.Parse("ed74fb8e-4074-423a-a5d1-8795605774db"), Code="PROGRESS", Description="Making progress", Definition="The student is making progress toward English proficiency.", SortOrder=Convert.ToDecimal("1.00") },
            new RefTitleIIIAccountability { Id=Guid.Parse("2b9cca2d-52ce-4e07-b9f9-4c2e94d3aa30"), Code="NOPROGRESS", Description="Did not make progress", Definition="The student did not make progress toward English proficiency.", SortOrder=Convert.ToDecimal("2.00") },
            new RefTitleIIIAccountability { Id=Guid.Parse("2d1ba04e-a47d-4003-9480-a1853fb1b184"), Code="PROFICIENT", Description="Attained proficiency", Definition="The student attained English proficiency.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefTitleIIIAccountability Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefTitleIIIAccountabilityViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefTitleIIIAccountability { Id=Guid.Parse("ed74fb8e-4074-423a-a5d1-8795605774db"), Description="Making progress", SortOrder=Convert.ToDecimal("1.00") },
            new RefTitleIIIAccountability { Id=Guid.Parse("2b9cca2d-52ce-4e07-b9f9-4c2e94d3aa30"), Description="Did not make progress", SortOrder=Convert.ToDecimal("2.00") },
            new RefTitleIIIAccountability { Id=Guid.Parse("2d1ba04e-a47d-4003-9480-a1853fb1b184"), Description="Attained proficiency", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
