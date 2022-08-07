//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTeacherEducationCredentialExamList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefTeacherEducationCredentialExam Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTeacherEducationCredentialExamModel"> List
         /// </summary>
        public static List<RefTeacherEducationCredentialExamModel> RefTeacherEducationCredentialExamList = new List<RefTeacherEducationCredentialExamModel>
        {
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("a909fbbd-4d63-4f97-af72-688314bdb5aa"), Code="PraxisI", Description="Praxis I", Definition="Praxis I examination is/was used to assess teacher candidate's knowledge and skills.", SortOrder=Convert.ToDecimal("1.00") },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("450032ae-f0db-4640-93cc-f480042d2432"), Code="PraxisII", Description="Praxis II", Definition="Praxis II examination is/was used to assess teacher candidate's knowledge and skills.", SortOrder=Convert.ToDecimal("2.00") },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("ba1ae43f-fb5c-4a18-8a85-243562d6cb2f"), Code="ACTFL", Description="ACTFL", Definition="ACTFL is/was used to assess teacher candidate's knowledge and skills.", SortOrder=Convert.ToDecimal("3.00") },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("ece3143c-79ce-482c-80f2-36072484efc8"), Code="StateExam", Description="State Exam", Definition="State Exam is/was used to assess teacher candidate's knowledge and skills.", SortOrder=Convert.ToDecimal("4.00") },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("41b8d95b-9d72-40a3-ac8c-1cd4ee513e7a"), Code="Other", Description="Other", Definition="An examination used to assess teacher candidate's knowledge and skills is of a type not yet included in CEDS.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefTeacherEducationCredentialExam Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefTeacherEducationCredentialExamViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("a909fbbd-4d63-4f97-af72-688314bdb5aa"), Description="Praxis I", SortOrder=Convert.ToDecimal("1.00") },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("450032ae-f0db-4640-93cc-f480042d2432"), Description="Praxis II", SortOrder=Convert.ToDecimal("2.00") },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("ba1ae43f-fb5c-4a18-8a85-243562d6cb2f"), Description="ACTFL", SortOrder=Convert.ToDecimal("3.00") },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("ece3143c-79ce-482c-80f2-36072484efc8"), Description="State Exam", SortOrder=Convert.ToDecimal("4.00") },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("41b8d95b-9d72-40a3-ac8c-1cd4ee513e7a"), Description="Other", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
