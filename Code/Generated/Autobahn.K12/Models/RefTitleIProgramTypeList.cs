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
        /// The complete <see cref="RefTitleIProgramTypeModel"> List
         /// </summary>
        public static List<RefTitleIProgramTypeModel> RefTitleIProgramTypeList = new List<RefTitleIProgramTypeModel>
        {
            new RefTitleIProgramType { Id=Guid.Parse("03fe959f-477d-4827-897a-100ad1fa4610"), Code="TargetedAssistanceProgram", Description="Public Targeted Assistance Program", Definition="The type of Title I program offered in the school or district Is Public Targeted Assistance Program", SortOrder=Convert.ToDecimal("1.00") },
            new RefTitleIProgramType { Id=Guid.Parse("0a4b3757-6d53-4edf-adc6-88f3cc6b1b3a"), Code="SchoolwideProgram", Description="Public Schoolwide Program", Definition="The type of Title I program offered in the school or district Is Public Schoolwide Program", SortOrder=Convert.ToDecimal("2.00") },
            new RefTitleIProgramType { Id=Guid.Parse("7a43fe71-ca41-46fb-be5e-de718f1826a8"), Code="PrivateSchoolStudents", Description="Private School Students Participating", Definition="The type of Title I program offered in the school or district Is Private School Students Participating", SortOrder=Convert.ToDecimal("3.00") },
            new RefTitleIProgramType { Id=Guid.Parse("c955befb-03f8-4340-9cc8-848cb6d2a7aa"), Code="LocalNeglectedProgram", Description="Local Neglected Program", Definition="The type of Title I program offered in the school or district Is Local Neglected Program", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefTitleIProgramType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefTitleIProgramTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefTitleIProgramType { Id=Guid.Parse("03fe959f-477d-4827-897a-100ad1fa4610"), Description="Public Targeted Assistance Program", SortOrder=Convert.ToDecimal("1.00") },
            new RefTitleIProgramType { Id=Guid.Parse("0a4b3757-6d53-4edf-adc6-88f3cc6b1b3a"), Description="Public Schoolwide Program", SortOrder=Convert.ToDecimal("2.00") },
            new RefTitleIProgramType { Id=Guid.Parse("7a43fe71-ca41-46fb-be5e-de718f1826a8"), Description="Private School Students Participating", SortOrder=Convert.ToDecimal("3.00") },
            new RefTitleIProgramType { Id=Guid.Parse("c955befb-03f8-4340-9cc8-848cb6d2a7aa"), Description="Local Neglected Program", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
