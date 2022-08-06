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
        public static List<RefTitleIProgramType> RefTitleIProgramTypeList = new List<RefTitleIProgramType>
        {
            new RefTitleIProgramType { Id=Guid.Parse("3117ab0f-8147-4d71-970b-f6cadfcc3489"), Code="TargetedAssistanceProgram", Description="Public Targeted Assistance Program", Definition="The type of Title I program offered in the school or district Is Public Targeted Assistance Program", SortOrder=Convert.ToDecimal("1.00") },
            new RefTitleIProgramType { Id=Guid.Parse("a231ef5a-be09-49e8-8ac4-22b0d3a995cf"), Code="SchoolwideProgram", Description="Public Schoolwide Program", Definition="The type of Title I program offered in the school or district Is Public Schoolwide Program", SortOrder=Convert.ToDecimal("2.00") },
            new RefTitleIProgramType { Id=Guid.Parse("e8d42575-7728-40d4-98cf-699194a87846"), Code="PrivateSchoolStudents", Description="Private School Students Participating", Definition="The type of Title I program offered in the school or district Is Private School Students Participating", SortOrder=Convert.ToDecimal("3.00") },
            new RefTitleIProgramType { Id=Guid.Parse("aef35d48-bf04-4119-b4d6-c6d966803839"), Code="LocalNeglectedProgram", Description="Local Neglected Program", Definition="The type of Title I program offered in the school or district Is Local Neglected Program", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefTitleIProgramType Pick List
         /// </summary>
        public static List<RefTitleIProgramType> RefTitleIProgramTypePickList = new List<RefTitleIProgramType>
        {
            new RefTitleIProgramType { Id=Guid.Parse("3117ab0f-8147-4d71-970b-f6cadfcc3489"), Code="TargetedAssistanceProgram", Description="Public Targeted Assistance Program", SortOrder=Convert.ToDecimal("1.00") },
            new RefTitleIProgramType { Id=Guid.Parse("a231ef5a-be09-49e8-8ac4-22b0d3a995cf"), Code="SchoolwideProgram", Description="Public Schoolwide Program", SortOrder=Convert.ToDecimal("2.00") },
            new RefTitleIProgramType { Id=Guid.Parse("e8d42575-7728-40d4-98cf-699194a87846"), Code="PrivateSchoolStudents", Description="Private School Students Participating", SortOrder=Convert.ToDecimal("3.00") },
            new RefTitleIProgramType { Id=Guid.Parse("aef35d48-bf04-4119-b4d6-c6d966803839"), Code="LocalNeglectedProgram", Description="Local Neglected Program", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
