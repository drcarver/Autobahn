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
        public static List<RefCharterSchoolType> RefCharterSchoolTypeList = new List<RefCharterSchoolType> =
        {
            new RefCharterSchoolType { Id=Guid.Parse("8ee96a58-0414-40d0-937a-6377daa29245"), Code="A K12 school created by contract between a state's charter authorization board and an entity other than a  college or university.", Description="School", Definition="", SortOrder=0 },
            new RefCharterSchoolType { Id=Guid.Parse("667e278c-8b91-464a-9eee-5fcc8538d09c"), Code="A K12 school created by contract between a college or university and a state's charter authorization board(s).", Description="CollegeUniversity", Definition="", SortOrder=0 },
            new RefCharterSchoolType { Id=Guid.Parse("5c8fc39c-99ed-40f2-a4d0-e83335ffda01"), Code="A school that is not a charter school.", Description="NA", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCharterSchoolType Pick List
         /// </summary>
        public static List<RefCharterSchoolType> RefCharterSchoolTypePickList = new List<RefCharterSchoolType> =
        {
            new RefCharterSchoolType { Id=Guid.Parse("8ee96a58-0414-40d0-937a-6377daa29245"), Code="A K12 school created by contract between a state's charter authorization board and an entity other than a  college or university.", SortOrder=0 },
            new RefCharterSchoolType { Id=Guid.Parse("667e278c-8b91-464a-9eee-5fcc8538d09c"), Code="A K12 school created by contract between a college or university and a state's charter authorization board(s).", SortOrder=0 },
            new RefCharterSchoolType { Id=Guid.Parse("5c8fc39c-99ed-40f2-a4d0-e83335ffda01"), Code="A school that is not a charter school.", SortOrder=0 },
       };
   }
}
