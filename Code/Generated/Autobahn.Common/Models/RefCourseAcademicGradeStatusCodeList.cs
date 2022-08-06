//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCourseAcademicGradeStatusCodeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCourseAcademicGradeStatusCode Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseAcademicGradeStatusCode"> List
         /// </summary>
        public static List<RefCourseAcademicGradeStatusCode> RefCourseAcademicGradeStatusCodeList = new List<RefCourseAcademicGradeStatusCode> =
        {
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("e8fa350c-d205-48eb-bec6-e1c3d4d85f3f"), Code="Audited or visited the course is specified as additional information regarding the context of the given grade.", Description="AuditedCourse", Definition="", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("96f1c467-655e-40a6-9e9d-ac11051423bf"), Code="Honors grade is specified as additional information regarding the context of the given grade.", Description="HonorsGrade", Definition="", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("55a3c011-fe2c-4d28-b856-c006b3c6dfc8"), Code="Incomplete is specified as additional information regarding the context of the given grade.", Description="Incomplete", Definition="", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("14e15fee-2f47-42aa-8da7-63c19ee1ab6f"), Code="Failing/no pass/unsatisfactory grade awarded because incomplete not resolved satisfactorily is specified as additional information regarding the context of the given grade.", Description="IncompleteNotResolvedFail", Definition="", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("2c759795-cf36-417b-bff6-035cb7a011b2"), Code="Current enrollment course in progress, permanent grade not yet assigned is specified as additional information regarding the context of the given grade.", Description="InProgress", Definition="", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("9848c30b-28e4-4e36-947a-9b8be49ea12c"), Code="No grade reported yet by instructor (although the course has ended) is specified as additional information regarding the context of the given grade.", Description="NotYetReported", Definition="", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("2aa68ea6-0c17-4ade-bb27-542f7dd6b75c"), Code="Other not passing/unsatisfactory grade not described by other options is specified as additional information regarding the context of the given grade.", Description="OtherFail", Definition="", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("23883c44-10d7-4e42-84e3-c885c6662f53"), Code="Other passing/satisfactory grade not described by other options is specified as additional information regarding the context of the given grade.", Description="OtherPass", Definition="", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("bceabbcb-7116-4a01-adbe-6953a34dedbb"), Code="Failing grade in a course (credit or non-credit) which is normally, or based on student option, given a pass/fail or satisfactory/unsatisfactory designation is specified as additional information regarding the context of the given grade.", Description="PassFailFail", Definition="", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("f4fbd664-fefe-4d83-99d1-1bfd6a7afeaa"), Code="Passing grade in a course (credit or non-credit) which is normally, or based on student option, given a pass/fail or satisfactory/unsatisfactory designation is specified as additional information regarding the context of the given grade.", Description="PassFailPass", Definition="", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("bb61508e-b884-4adb-8460-9c25ac392b7f"), Code="Transfer credit; grade not carried on receiving institution's transcript is specified as additional information regarding the context of the given grade.", Description="TransferNoGrade", Definition="", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("03109fdc-fa6e-4617-a21a-87936c8411c5"), Code="Withdrew is specified as additional information regarding the context of the given grade.", Description="Withdrew", Definition="", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("d057b57f-da53-4017-8d8a-fdc68a117e00"), Code="Withdrew failing is specified as additional information regarding the context of the given grade.", Description="WithdrewFailing", Definition="", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("e2811983-6f93-498b-857e-e47c197cf39b"), Code="Withdrew without penalty or pass/fail designation is specified as additional information regarding the context of the given grade.", Description="WithdrewNoPenalty", Definition="", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("94713c64-9168-4c0c-9c10-3f951c780b55"), Code="Withdrew passing is specified as additional information regarding the context of the given grade.", Description="WithdrewPassing", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCourseAcademicGradeStatusCode Pick List
         /// </summary>
        public static List<RefCourseAcademicGradeStatusCode> RefCourseAcademicGradeStatusCodePickList = new List<RefCourseAcademicGradeStatusCode> =
        {
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("e8fa350c-d205-48eb-bec6-e1c3d4d85f3f"), Code="Audited or visited the course is specified as additional information regarding the context of the given grade.", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("96f1c467-655e-40a6-9e9d-ac11051423bf"), Code="Honors grade is specified as additional information regarding the context of the given grade.", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("55a3c011-fe2c-4d28-b856-c006b3c6dfc8"), Code="Incomplete is specified as additional information regarding the context of the given grade.", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("14e15fee-2f47-42aa-8da7-63c19ee1ab6f"), Code="Failing/no pass/unsatisfactory grade awarded because incomplete not resolved satisfactorily is specified as additional information regarding the context of the given grade.", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("2c759795-cf36-417b-bff6-035cb7a011b2"), Code="Current enrollment course in progress, permanent grade not yet assigned is specified as additional information regarding the context of the given grade.", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("9848c30b-28e4-4e36-947a-9b8be49ea12c"), Code="No grade reported yet by instructor (although the course has ended) is specified as additional information regarding the context of the given grade.", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("2aa68ea6-0c17-4ade-bb27-542f7dd6b75c"), Code="Other not passing/unsatisfactory grade not described by other options is specified as additional information regarding the context of the given grade.", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("23883c44-10d7-4e42-84e3-c885c6662f53"), Code="Other passing/satisfactory grade not described by other options is specified as additional information regarding the context of the given grade.", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("bceabbcb-7116-4a01-adbe-6953a34dedbb"), Code="Failing grade in a course (credit or non-credit) which is normally, or based on student option, given a pass/fail or satisfactory/unsatisfactory designation is specified as additional information regarding the context of the given grade.", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("f4fbd664-fefe-4d83-99d1-1bfd6a7afeaa"), Code="Passing grade in a course (credit or non-credit) which is normally, or based on student option, given a pass/fail or satisfactory/unsatisfactory designation is specified as additional information regarding the context of the given grade.", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("bb61508e-b884-4adb-8460-9c25ac392b7f"), Code="Transfer credit; grade not carried on receiving institution's transcript is specified as additional information regarding the context of the given grade.", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("03109fdc-fa6e-4617-a21a-87936c8411c5"), Code="Withdrew is specified as additional information regarding the context of the given grade.", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("d057b57f-da53-4017-8d8a-fdc68a117e00"), Code="Withdrew failing is specified as additional information regarding the context of the given grade.", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("e2811983-6f93-498b-857e-e47c197cf39b"), Code="Withdrew without penalty or pass/fail designation is specified as additional information regarding the context of the given grade.", SortOrder=0 },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("94713c64-9168-4c0c-9c10-3f951c780b55"), Code="Withdrew passing is specified as additional information regarding the context of the given grade.", SortOrder=0 },
       };
   }
}
