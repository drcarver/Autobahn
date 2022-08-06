//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTeacherEducationCredentialExamList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefTeacherEducationCredentialExam Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTeacherEducationCredentialExam"> List
         /// </summary>
        public static List<RefTeacherEducationCredentialExam> RefTeacherEducationCredentialExamList = new List<RefTeacherEducationCredentialExam>
        {
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("19ac5d2c-7c9a-47a8-a1d7-32d25836e0a8"), Code="PraxisI", Description="Praxis I", Definition="Praxis I examination is/was used to assess teacher candidate's knowledge and skills.", SortOrder=Convert.ToDecimal("1.00") },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("3444dbb3-969b-44a2-858c-c8f9e6377adf"), Code="PraxisII", Description="Praxis II", Definition="Praxis II examination is/was used to assess teacher candidate's knowledge and skills.", SortOrder=Convert.ToDecimal("2.00") },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("3fda4145-e3a2-4db1-b946-cd86b35aeac9"), Code="ACTFL", Description="ACTFL", Definition="ACTFL is/was used to assess teacher candidate's knowledge and skills.", SortOrder=Convert.ToDecimal("3.00") },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("dce2c778-cde3-4b90-a4cf-c3fea643c67c"), Code="StateExam", Description="State Exam", Definition="State Exam is/was used to assess teacher candidate's knowledge and skills.", SortOrder=Convert.ToDecimal("4.00") },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("161c3876-8262-43f3-8b08-554c4ce4d7ab"), Code="Other", Description="Other", Definition="An examination used to assess teacher candidate's knowledge and skills is of a type not yet included in CEDS.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefTeacherEducationCredentialExam Pick List
         /// </summary>
        public static List<RefTeacherEducationCredentialExam> RefTeacherEducationCredentialExamPickList = new List<RefTeacherEducationCredentialExam>
        {
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("19ac5d2c-7c9a-47a8-a1d7-32d25836e0a8"), Code="PraxisI", Description="Praxis I", SortOrder=Convert.ToDecimal("1.00") },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("3444dbb3-969b-44a2-858c-c8f9e6377adf"), Code="PraxisII", Description="Praxis II", SortOrder=Convert.ToDecimal("2.00") },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("3fda4145-e3a2-4db1-b946-cd86b35aeac9"), Code="ACTFL", Description="ACTFL", SortOrder=Convert.ToDecimal("3.00") },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("dce2c778-cde3-4b90-a4cf-c3fea643c67c"), Code="StateExam", Description="State Exam", SortOrder=Convert.ToDecimal("4.00") },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("161c3876-8262-43f3-8b08-554c4ce4d7ab"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
