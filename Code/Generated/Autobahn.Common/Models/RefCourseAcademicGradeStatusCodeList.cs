//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCourseAcademicGradeStatusCodeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCourseAcademicGradeStatusCode Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseAcademicGradeStatusCodeModel"> List
         /// </summary>
        public static List<RefCourseAcademicGradeStatusCodeModel> RefCourseAcademicGradeStatusCodeList = new List<RefCourseAcademicGradeStatusCodeModel>
        {
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("f199482e-2554-4443-af89-a15521748510"), Code="AuditedCourse", Description="Audited or visited the course", Definition="Audited or visited the course is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("b7bc36c0-59eb-4b20-83a4-16f6f2ff2914"), Code="HonorsGrade", Description="Honors grade", Definition="Honors grade is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("7888c4b5-5b38-4c1d-8331-01c7791396e0"), Code="Incomplete", Description="Incomplete", Definition="Incomplete is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("79efd669-3123-44ea-b7e4-217407bd2ab7"), Code="IncompleteNotResolvedFail", Description="Incomplete Not Resolved Fail", Definition="Failing/no pass/unsatisfactory grade awarded because incomplete not resolved satisfactorily is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("7.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("9581c22c-42a7-4fbd-9441-d194a0f14114"), Code="InProgress", Description="In Progress", Definition="Current enrollment course in progress, permanent grade not yet assigned is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("9.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("c8fff70c-4d68-4219-96ce-7621b1f8720a"), Code="NotYetReported", Description="Not Yet Reported", Definition="No grade reported yet by instructor (although the course has ended) is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("11.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("59f5820d-fe44-4805-8ce3-288e56fe9fec"), Code="OtherFail", Description="Other Fail", Definition="Other not passing/unsatisfactory grade not described by other options is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("13.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("a1b01640-4d5e-44bc-961c-8b4b60f7fd5e"), Code="OtherPass", Description="Other Pass", Definition="Other passing/satisfactory grade not described by other options is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("15.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("5d9c6362-778c-4ed5-9014-acc4e95ec1c5"), Code="PassFailFail", Description="Pass-Fail : Fail", Definition="Failing grade in a course (credit or non-credit) which is normally, or based on student option, given a pass/fail or satisfactory/unsatisfactory designation is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("17.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("3112a30c-837f-49f0-a21d-ca6883de1aaf"), Code="PassFailPass", Description="Pass-Fail : Pass", Definition="Passing grade in a course (credit or non-credit) which is normally, or based on student option, given a pass/fail or satisfactory/unsatisfactory designation is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("19.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("5571a705-9b54-4a0b-bdcd-bba2895d389d"), Code="TransferNoGrade", Description="Transfer No Grade", Definition="Transfer credit; grade not carried on receiving institution's transcript is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("21.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("a5528375-de93-4177-a503-9a9e4c2aa180"), Code="Withdrew", Description="Withdrew", Definition="Withdrew is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("23.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("15f019d7-836f-4a46-a1cb-ac608581c0d0"), Code="WithdrewFailing", Description="Withdrew failing", Definition="Withdrew failing is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("25.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("15adf281-de9b-4094-a705-6f13f1266d1f"), Code="WithdrewNoPenalty", Description="Withdrew No Penalty", Definition="Withdrew without penalty or pass/fail designation is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("27.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("9af84e5c-c410-478e-b4d0-4d60e12e4bab"), Code="WithdrewPassing", Description="Withdrew passing", Definition="Withdrew passing is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("29.00") },
        };

        /// <summary>
        /// The Reference RefCourseAcademicGradeStatusCode Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCourseAcademicGradeStatusCodeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("f199482e-2554-4443-af89-a15521748510"), Description="Audited or visited the course", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("b7bc36c0-59eb-4b20-83a4-16f6f2ff2914"), Description="Honors grade", SortOrder=Convert.ToDecimal("3.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("7888c4b5-5b38-4c1d-8331-01c7791396e0"), Description="Incomplete", SortOrder=Convert.ToDecimal("5.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("79efd669-3123-44ea-b7e4-217407bd2ab7"), Description="Incomplete Not Resolved Fail", SortOrder=Convert.ToDecimal("7.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("9581c22c-42a7-4fbd-9441-d194a0f14114"), Description="In Progress", SortOrder=Convert.ToDecimal("9.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("c8fff70c-4d68-4219-96ce-7621b1f8720a"), Description="Not Yet Reported", SortOrder=Convert.ToDecimal("11.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("59f5820d-fe44-4805-8ce3-288e56fe9fec"), Description="Other Fail", SortOrder=Convert.ToDecimal("13.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("a1b01640-4d5e-44bc-961c-8b4b60f7fd5e"), Description="Other Pass", SortOrder=Convert.ToDecimal("15.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("5d9c6362-778c-4ed5-9014-acc4e95ec1c5"), Description="Pass-Fail : Fail", SortOrder=Convert.ToDecimal("17.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("3112a30c-837f-49f0-a21d-ca6883de1aaf"), Description="Pass-Fail : Pass", SortOrder=Convert.ToDecimal("19.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("5571a705-9b54-4a0b-bdcd-bba2895d389d"), Description="Transfer No Grade", SortOrder=Convert.ToDecimal("21.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("a5528375-de93-4177-a503-9a9e4c2aa180"), Description="Withdrew", SortOrder=Convert.ToDecimal("23.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("15f019d7-836f-4a46-a1cb-ac608581c0d0"), Description="Withdrew failing", SortOrder=Convert.ToDecimal("25.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("15adf281-de9b-4094-a705-6f13f1266d1f"), Description="Withdrew No Penalty", SortOrder=Convert.ToDecimal("27.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("9af84e5c-c410-478e-b4d0-4d60e12e4bab"), Description="Withdrew passing", SortOrder=Convert.ToDecimal("29.00") },
       };
   }
}
