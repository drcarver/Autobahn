//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefGradePointAverageDomainList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefGradePointAverageDomain Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefGradePointAverageDomainModel"> List
         /// </summary>
        public static List<RefGradePointAverageDomainModel> RefGradePointAverageDomainList = new List<RefGradePointAverageDomainModel>
        {
            new RefGradePointAverageDomain { Id=Guid.Parse("773bfcf1-bbed-4f89-9f34-d487131775c2"), Code="HighSchool", Description="High School", Definition="High School is the domain to which the Grade Point Average is referencing.", SortOrder=Convert.ToDecimal("1.00") },
            new RefGradePointAverageDomain { Id=Guid.Parse("def7df48-961a-4b26-8766-fa0934b1fb04"), Code="PSUndergraduate", Description="Postsecondary Undergraduate", Definition="Postsecondary Undergraduate is the domain to which the Grade Point Average is referencing.", SortOrder=Convert.ToDecimal("2.00") },
            new RefGradePointAverageDomain { Id=Guid.Parse("91cab78f-7d8d-4917-a12a-5a44106ecbaa"), Code="PSTransfer", Description="Postsecondary Transfer Institution", Definition="Postsecondary Transfer Institution is the domain to which the Grade Point Average is referencing.", SortOrder=Convert.ToDecimal("3.00") },
            new RefGradePointAverageDomain { Id=Guid.Parse("06a6df9e-a862-40f9-829d-3e31d905b856"), Code="PSGraduate", Description="Postsecondary Graduate", Definition="Postsecondary Graduate is the domain to which the Grade Point Average is referencing.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefGradePointAverageDomain Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefGradePointAverageDomainViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefGradePointAverageDomain { Id=Guid.Parse("773bfcf1-bbed-4f89-9f34-d487131775c2"), Description="High School", SortOrder=Convert.ToDecimal("1.00") },
            new RefGradePointAverageDomain { Id=Guid.Parse("def7df48-961a-4b26-8766-fa0934b1fb04"), Description="Postsecondary Undergraduate", SortOrder=Convert.ToDecimal("2.00") },
            new RefGradePointAverageDomain { Id=Guid.Parse("91cab78f-7d8d-4917-a12a-5a44106ecbaa"), Description="Postsecondary Transfer Institution", SortOrder=Convert.ToDecimal("3.00") },
            new RefGradePointAverageDomain { Id=Guid.Parse("06a6df9e-a862-40f9-829d-3e31d905b856"), Description="Postsecondary Graduate", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
