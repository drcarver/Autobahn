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
        public static List<RefCourseAcademicGradeStatusCode> RefCourseAcademicGradeStatusCodeList = new List<RefCourseAcademicGradeStatusCode>
        {
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("0397f8f5-d0ca-4eb9-a5cd-82bdb6bd8497"), Code="AuditedCourse", Description="Audited or visited the course", Definition="Audited or visited the course is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("4d36abd4-b46b-4176-9911-fe8d232582b5"), Code="HonorsGrade", Description="Honors grade", Definition="Honors grade is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("4c0bebed-e873-42d4-91a4-1b9ebed95f49"), Code="Incomplete", Description="Incomplete", Definition="Incomplete is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("4456d1c5-e1f3-4c63-804d-6efd30aeba0e"), Code="IncompleteNotResolvedFail", Description="Incomplete Not Resolved Fail", Definition="Failing/no pass/unsatisfactory grade awarded because incomplete not resolved satisfactorily is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("7.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("c5a5b467-558a-4747-a1f4-47da19a59157"), Code="InProgress", Description="In Progress", Definition="Current enrollment course in progress, permanent grade not yet assigned is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("9.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("639d340c-7ea9-4afd-bf5d-e600ed0fe3a5"), Code="NotYetReported", Description="Not Yet Reported", Definition="No grade reported yet by instructor (although the course has ended) is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("11.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("a96f5f4d-6910-4281-b260-002fa46bf4fe"), Code="OtherFail", Description="Other Fail", Definition="Other not passing/unsatisfactory grade not described by other options is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("13.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("abb846c9-8789-4819-92bc-537552be92a9"), Code="OtherPass", Description="Other Pass", Definition="Other passing/satisfactory grade not described by other options is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("15.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("921e17ae-4527-4ac7-a389-72f98b21fe77"), Code="PassFailFail", Description="Pass-Fail : Fail", Definition="Failing grade in a course (credit or non-credit) which is normally, or based on student option, given a pass/fail or satisfactory/unsatisfactory designation is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("17.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("2aa7164a-c04f-42e2-a3a0-6cef21240307"), Code="PassFailPass", Description="Pass-Fail : Pass", Definition="Passing grade in a course (credit or non-credit) which is normally, or based on student option, given a pass/fail or satisfactory/unsatisfactory designation is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("19.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("384ca13c-1e0e-4b94-8da5-3eb06a58194a"), Code="TransferNoGrade", Description="Transfer No Grade", Definition="Transfer credit; grade not carried on receiving institution's transcript is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("21.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("878f5325-06e4-4780-8e35-a92658bc5b76"), Code="Withdrew", Description="Withdrew", Definition="Withdrew is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("23.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("f4ca5b50-f5eb-4b17-b5cf-6abb7f5aab37"), Code="WithdrewFailing", Description="Withdrew failing", Definition="Withdrew failing is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("25.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("e865502e-0556-4df9-9791-bfe2f6528778"), Code="WithdrewNoPenalty", Description="Withdrew No Penalty", Definition="Withdrew without penalty or pass/fail designation is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("27.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("1ec03c45-7230-44ee-aff3-67a0371e7b85"), Code="WithdrewPassing", Description="Withdrew passing", Definition="Withdrew passing is specified as additional information regarding the context of the given grade.", SortOrder=Convert.ToDecimal("29.00") },
        };

        /// <summary>
        /// The RefCourseAcademicGradeStatusCode Pick List
         /// </summary>
        public static List<RefCourseAcademicGradeStatusCode> RefCourseAcademicGradeStatusCodePickList = new List<RefCourseAcademicGradeStatusCode>
        {
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("0397f8f5-d0ca-4eb9-a5cd-82bdb6bd8497"), Code="AuditedCourse", Description="Audited or visited the course", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("4d36abd4-b46b-4176-9911-fe8d232582b5"), Code="HonorsGrade", Description="Honors grade", SortOrder=Convert.ToDecimal("3.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("4c0bebed-e873-42d4-91a4-1b9ebed95f49"), Code="Incomplete", Description="Incomplete", SortOrder=Convert.ToDecimal("5.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("4456d1c5-e1f3-4c63-804d-6efd30aeba0e"), Code="IncompleteNotResolvedFail", Description="Incomplete Not Resolved Fail", SortOrder=Convert.ToDecimal("7.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("c5a5b467-558a-4747-a1f4-47da19a59157"), Code="InProgress", Description="In Progress", SortOrder=Convert.ToDecimal("9.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("639d340c-7ea9-4afd-bf5d-e600ed0fe3a5"), Code="NotYetReported", Description="Not Yet Reported", SortOrder=Convert.ToDecimal("11.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("a96f5f4d-6910-4281-b260-002fa46bf4fe"), Code="OtherFail", Description="Other Fail", SortOrder=Convert.ToDecimal("13.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("abb846c9-8789-4819-92bc-537552be92a9"), Code="OtherPass", Description="Other Pass", SortOrder=Convert.ToDecimal("15.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("921e17ae-4527-4ac7-a389-72f98b21fe77"), Code="PassFailFail", Description="Pass-Fail : Fail", SortOrder=Convert.ToDecimal("17.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("2aa7164a-c04f-42e2-a3a0-6cef21240307"), Code="PassFailPass", Description="Pass-Fail : Pass", SortOrder=Convert.ToDecimal("19.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("384ca13c-1e0e-4b94-8da5-3eb06a58194a"), Code="TransferNoGrade", Description="Transfer No Grade", SortOrder=Convert.ToDecimal("21.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("878f5325-06e4-4780-8e35-a92658bc5b76"), Code="Withdrew", Description="Withdrew", SortOrder=Convert.ToDecimal("23.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("f4ca5b50-f5eb-4b17-b5cf-6abb7f5aab37"), Code="WithdrewFailing", Description="Withdrew failing", SortOrder=Convert.ToDecimal("25.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("e865502e-0556-4df9-9791-bfe2f6528778"), Code="WithdrewNoPenalty", Description="Withdrew No Penalty", SortOrder=Convert.ToDecimal("27.00") },
            new RefCourseAcademicGradeStatusCode { Id=Guid.Parse("1ec03c45-7230-44ee-aff3-67a0371e7b85"), Code="WithdrewPassing", Description="Withdrew passing", SortOrder=Convert.ToDecimal("29.00") },
       };
   }
}
