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
        public static List<RefTeacherEducationCredentialExam> RefTeacherEducationCredentialExamList = new List<RefTeacherEducationCredentialExam> =
        {
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("4efe2beb-f689-4e3d-b870-507362d47b1d"), Code="Praxis I examination is/was used to assess teacher candidate's knowledge and skills.", Description="PraxisI", Definition="", SortOrder=0 },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("65f3a09e-a51e-4a58-a7c4-2946fc3721ce"), Code="Praxis II examination is/was used to assess teacher candidate's knowledge and skills.", Description="PraxisII", Definition="", SortOrder=0 },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("fb318877-7885-49f9-a14d-d7c75f0d12f9"), Code="ACTFL is/was used to assess teacher candidate's knowledge and skills.", Description="ACTFL", Definition="", SortOrder=0 },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("bb715bd6-267b-4102-8c0e-8a4b7bad2dcd"), Code="State Exam is/was used to assess teacher candidate's knowledge and skills.", Description="StateExam", Definition="", SortOrder=0 },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("b8fc40cd-9a6a-45f3-99f7-8b2bd1e6bfd6"), Code="An examination used to assess teacher candidate's knowledge and skills is of a type not yet included in CEDS.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefTeacherEducationCredentialExam Pick List
         /// </summary>
        public static List<RefTeacherEducationCredentialExam> RefTeacherEducationCredentialExamPickList = new List<RefTeacherEducationCredentialExam> =
        {
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("4efe2beb-f689-4e3d-b870-507362d47b1d"), Code="Praxis I examination is/was used to assess teacher candidate's knowledge and skills.", SortOrder=0 },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("65f3a09e-a51e-4a58-a7c4-2946fc3721ce"), Code="Praxis II examination is/was used to assess teacher candidate's knowledge and skills.", SortOrder=0 },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("fb318877-7885-49f9-a14d-d7c75f0d12f9"), Code="ACTFL is/was used to assess teacher candidate's knowledge and skills.", SortOrder=0 },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("bb715bd6-267b-4102-8c0e-8a4b7bad2dcd"), Code="State Exam is/was used to assess teacher candidate's knowledge and skills.", SortOrder=0 },
            new RefTeacherEducationCredentialExam { Id=Guid.Parse("b8fc40cd-9a6a-45f3-99f7-8b2bd1e6bfd6"), Code="An examination used to assess teacher candidate's knowledge and skills is of a type not yet included in CEDS.", SortOrder=0 },
       };
   }
}
