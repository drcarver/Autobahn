//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefTitleIProgramTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefTitleIProgramType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTitleIProgramType"> List
         /// </summary>
        public static List<RefTitleIProgramType> RefTitleIProgramTypeList = new List<RefTitleIProgramType> =
        {
            new RefTitleIProgramType { Id=Guid.Parse("d3732d3a-4450-4ba7-b87b-66999ba13d97"), Code="The type of Title I program offered in the school or district Is Public Targeted Assistance Program", Description="TargetedAssistanceProgram", Definition="", SortOrder=0 },
            new RefTitleIProgramType { Id=Guid.Parse("df4b7e56-d719-415a-a5ec-36710e321f5c"), Code="The type of Title I program offered in the school or district Is Public Schoolwide Program", Description="SchoolwideProgram", Definition="", SortOrder=0 },
            new RefTitleIProgramType { Id=Guid.Parse("63572e9c-654a-47ba-b487-51fbd6fcd680"), Code="The type of Title I program offered in the school or district Is Private School Students Participating", Description="PrivateSchoolStudents", Definition="", SortOrder=0 },
            new RefTitleIProgramType { Id=Guid.Parse("88c24549-7539-49b0-854a-10a9c7785dec"), Code="The type of Title I program offered in the school or district Is Local Neglected Program", Description="LocalNeglectedProgram", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefTitleIProgramType Pick List
         /// </summary>
        public static List<RefTitleIProgramType> RefTitleIProgramTypePickList = new List<RefTitleIProgramType> =
        {
            new RefTitleIProgramType { Id=Guid.Parse("d3732d3a-4450-4ba7-b87b-66999ba13d97"), Code="The type of Title I program offered in the school or district Is Public Targeted Assistance Program", SortOrder=0 },
            new RefTitleIProgramType { Id=Guid.Parse("df4b7e56-d719-415a-a5ec-36710e321f5c"), Code="The type of Title I program offered in the school or district Is Public Schoolwide Program", SortOrder=0 },
            new RefTitleIProgramType { Id=Guid.Parse("63572e9c-654a-47ba-b487-51fbd6fcd680"), Code="The type of Title I program offered in the school or district Is Private School Students Participating", SortOrder=0 },
            new RefTitleIProgramType { Id=Guid.Parse("88c24549-7539-49b0-854a-10a9c7785dec"), Code="The type of Title I program offered in the school or district Is Local Neglected Program", SortOrder=0 },
       };
   }
}
