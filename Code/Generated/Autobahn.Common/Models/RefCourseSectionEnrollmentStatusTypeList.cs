//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCourseSectionEnrollmentStatusTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCourseSectionEnrollmentStatusType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseSectionEnrollmentStatusType"> List
         /// </summary>
        public static List<RefCourseSectionEnrollmentStatusType> RefCourseSectionEnrollmentStatusTypeList = new List<RefCourseSectionEnrollmentStatusType>
        {
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("3f81d227-319a-40df-8a74-9d76645643c4"), Code="Pre-registered", Description="Pre-registered", Definition="Pre-registered is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("513c9b9c-463e-4172-82e6-4f43a025040f"), Code="Registered", Description="Registered", Definition="Registered is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("3db80f1f-d900-4583-bf07-f27ce3e24d3e"), Code="Enrolled", Description="Enrolled", Definition="Enrolled is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("27b17ef9-dec6-45a9-bae6-bd81a91d98df"), Code="WaitListed", Description="Wait Listed", Definition="Wait Listed is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("28ba8a4d-9317-4296-8aa7-96ad56ecd3f9"), Code="Dropped", Description="Dropped", Definition="Dropped is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("e0a4a8eb-a4e3-4210-a4ed-ec2a080e600d"), Code="Completed", Description="Completed", Definition="Completed is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The RefCourseSectionEnrollmentStatusType Pick List
         /// </summary>
        public static List<RefCourseSectionEnrollmentStatusType> RefCourseSectionEnrollmentStatusTypePickList = new List<RefCourseSectionEnrollmentStatusType>
        {
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("3f81d227-319a-40df-8a74-9d76645643c4"), Code="Pre-registered", Description="Pre-registered", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("513c9b9c-463e-4172-82e6-4f43a025040f"), Code="Registered", Description="Registered", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("3db80f1f-d900-4583-bf07-f27ce3e24d3e"), Code="Enrolled", Description="Enrolled", SortOrder=Convert.ToDecimal("3.00") },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("27b17ef9-dec6-45a9-bae6-bd81a91d98df"), Code="WaitListed", Description="Wait Listed", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("28ba8a4d-9317-4296-8aa7-96ad56ecd3f9"), Code="Dropped", Description="Dropped", SortOrder=Convert.ToDecimal("5.00") },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("e0a4a8eb-a4e3-4210-a4ed-ec2a080e600d"), Code="Completed", Description="Completed", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
