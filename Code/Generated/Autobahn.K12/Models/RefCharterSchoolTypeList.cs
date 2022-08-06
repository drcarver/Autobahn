//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefCharterSchoolTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefCharterSchoolType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCharterSchoolType"> List
         /// </summary>
        public static List<RefCharterSchoolType> RefCharterSchoolTypeList = new List<RefCharterSchoolType>
        {
            new RefCharterSchoolType { Id=Guid.Parse("a781fcd0-c46b-4ec5-b768-015ec371a6d6"), Code="School", Description="School Charter", Definition="A K12 school created by contract between a state's charter authorization board and an entity other than a  college or university.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCharterSchoolType { Id=Guid.Parse("0836c70d-0e23-4f6e-a607-e2d1ddde650f"), Code="CollegeUniversity", Description="College/University Charter", Definition="A K12 school created by contract between a college or university and a state's charter authorization board(s).", SortOrder=Convert.ToDecimal("2.00") },
            new RefCharterSchoolType { Id=Guid.Parse("c234c05a-ed02-4709-bcc4-18aa170a0c89"), Code="NA", Description="Not a Charter School", Definition="A school that is not a charter school.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefCharterSchoolType Pick List
         /// </summary>
        public static List<RefCharterSchoolType> RefCharterSchoolTypePickList = new List<RefCharterSchoolType>
        {
            new RefCharterSchoolType { Id=Guid.Parse("a781fcd0-c46b-4ec5-b768-015ec371a6d6"), Code="School", Description="School Charter", SortOrder=Convert.ToDecimal("1.00") },
            new RefCharterSchoolType { Id=Guid.Parse("0836c70d-0e23-4f6e-a607-e2d1ddde650f"), Code="CollegeUniversity", Description="College/University Charter", SortOrder=Convert.ToDecimal("2.00") },
            new RefCharterSchoolType { Id=Guid.Parse("c234c05a-ed02-4709-bcc4-18aa170a0c89"), Code="NA", Description="Not a Charter School", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
