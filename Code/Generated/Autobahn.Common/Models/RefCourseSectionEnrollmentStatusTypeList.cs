//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCourseSectionEnrollmentStatusTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCourseSectionEnrollmentStatusType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseSectionEnrollmentStatusTypeModel"> List
         /// </summary>
        public static List<RefCourseSectionEnrollmentStatusTypeModel> RefCourseSectionEnrollmentStatusTypeList = new List<RefCourseSectionEnrollmentStatusTypeModel>
        {
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("0162f5d9-5241-4cab-a552-964bc1981c5b"), Code="Pre-registered", Description="Pre-registered", Definition="Pre-registered is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("0a4d88bc-d74b-4485-a284-b34f80d509f5"), Code="Registered", Description="Registered", Definition="Registered is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("499e75e8-091a-4600-81b8-6c915c8e6350"), Code="Enrolled", Description="Enrolled", Definition="Enrolled is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("35615ada-064e-4e36-a2f0-0c982f563ce0"), Code="WaitListed", Description="Wait Listed", Definition="Wait Listed is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("4e36d273-2fcd-490a-8cf8-240676b7780b"), Code="Dropped", Description="Dropped", Definition="Dropped is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("778bee71-5a60-44a2-bf61-9a8cd4df3f5f"), Code="Completed", Description="Completed", Definition="Completed is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The Reference RefCourseSectionEnrollmentStatusType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCourseSectionEnrollmentStatusTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("0162f5d9-5241-4cab-a552-964bc1981c5b"), Description="Pre-registered", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("0a4d88bc-d74b-4485-a284-b34f80d509f5"), Description="Registered", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("499e75e8-091a-4600-81b8-6c915c8e6350"), Description="Enrolled", SortOrder=Convert.ToDecimal("3.00") },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("35615ada-064e-4e36-a2f0-0c982f563ce0"), Description="Wait Listed", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("4e36d273-2fcd-490a-8cf8-240676b7780b"), Description="Dropped", SortOrder=Convert.ToDecimal("5.00") },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("778bee71-5a60-44a2-bf61-9a8cd4df3f5f"), Description="Completed", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
