//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefStudentEnrollmentAccessTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefStudentEnrollmentAccessType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefStudentEnrollmentAccessTypeModel"> List
         /// </summary>
        public static List<RefStudentEnrollmentAccessTypeModel> RefStudentEnrollmentAccessTypeList = new List<RefStudentEnrollmentAccessTypeModel>
        {
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("307100aa-ab5e-41b6-9798-92ba0b7230ab"), Code="75027", Description="Feeder school rights", Definition="Feeder school rights is specified as the designation of how students secure access to age appropriate public schools, or publicly funded charter or private schools.", SortOrder=Convert.ToDecimal("1.00") },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("cd46fb23-d85e-4dee-b30e-9d779c8b5eab"), Code="75028", Description="Geographic right", Definition="Geographic right is specified as the designation of how students secure access to age appropriate public schools, or publicly funded charter or private schools.", SortOrder=Convert.ToDecimal("2.00") },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("38f737ad-38dc-4131-8c6d-4eef3cf19abb"), Code="75029", Description="Lottery", Definition="Lottery is specified as the designation of how students secure access to age appropriate public schools, or publicly funded charter or private schools.", SortOrder=Convert.ToDecimal("3.00") },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("83ea92b8-7e89-445b-9898-d6c9d9161684"), Code="75030", Description="Policy preference", Definition="Policy that modifies student assignment based on preferences associated with such things as walk distances, racial or ethnic diversity, and family risk factors.", SortOrder=Convert.ToDecimal("4.00") },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("5ab7375e-5f5b-4bb1-a7df-7c7b4562b391"), Code="75031", Description="Selective admissions", Definition="Selective admissions is specified as the designation of how students secure access to age appropriate public schools, or publicly funded charter or private schools.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefStudentEnrollmentAccessType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefStudentEnrollmentAccessTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("307100aa-ab5e-41b6-9798-92ba0b7230ab"), Description="Feeder school rights", SortOrder=Convert.ToDecimal("1.00") },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("cd46fb23-d85e-4dee-b30e-9d779c8b5eab"), Description="Geographic right", SortOrder=Convert.ToDecimal("2.00") },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("38f737ad-38dc-4131-8c6d-4eef3cf19abb"), Description="Lottery", SortOrder=Convert.ToDecimal("3.00") },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("83ea92b8-7e89-445b-9898-d6c9d9161684"), Description="Policy preference", SortOrder=Convert.ToDecimal("4.00") },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("5ab7375e-5f5b-4bb1-a7df-7c7b4562b391"), Description="Selective admissions", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
