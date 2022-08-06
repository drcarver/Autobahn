//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefAdmittedStudentList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefAdmittedStudent Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAdmittedStudent"> List
         /// </summary>
        public static List<RefAdmittedStudent> RefAdmittedStudentList = new List<RefAdmittedStudent> =
        {
            new RefAdmittedStudent { Id=Guid.Parse("c9079c48-e9ab-4dfb-aa31-8119ff92690c"), Code="Conditional Admit is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", Description="Conditional", Definition="", SortOrder=0 },
            new RefAdmittedStudent { Id=Guid.Parse("09b8d11f-b6ec-4e6e-a62d-ac77fc1fe1a0"), Code="Early Action is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", Description="EarlyAction", Definition="", SortOrder=0 },
            new RefAdmittedStudent { Id=Guid.Parse("ac065265-d88c-47f7-9f68-3ab3a5c4f545"), Code="Early Admit is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", Description="EarlyAdmit", Definition="", SortOrder=0 },
            new RefAdmittedStudent { Id=Guid.Parse("e3e1c8bc-e0e4-4921-ab09-c90fff8532e2"), Code="Early Decision is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", Description="EarlyDecision", Definition="", SortOrder=0 },
            new RefAdmittedStudent { Id=Guid.Parse("0b50a125-6c6e-4fbe-b352-9aae460958e5"), Code="Regular Admit is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", Description="Regular", Definition="", SortOrder=0 },
            new RefAdmittedStudent { Id=Guid.Parse("56daeb55-cb59-47fe-9f00-e6822464b23a"), Code="Waitlist Admit is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", Description="Waitlist", Definition="", SortOrder=0 },
            new RefAdmittedStudent { Id=Guid.Parse("1f6e7585-d1c7-4370-acd2-74a9f2063fd0"), Code="Other Admit is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", Description="Other", Definition="", SortOrder=0 },
            new RefAdmittedStudent { Id=Guid.Parse("ad32fd20-ee11-4faa-b65c-e963e77cbffd"), Code="Then applicant has NOT been granted an official offer to enroll in the postsecondary institution.", Description="No", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAdmittedStudent Pick List
         /// </summary>
        public static List<RefAdmittedStudent> RefAdmittedStudentPickList = new List<RefAdmittedStudent> =
        {
            new RefAdmittedStudent { Id=Guid.Parse("c9079c48-e9ab-4dfb-aa31-8119ff92690c"), Code="Conditional Admit is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", SortOrder=0 },
            new RefAdmittedStudent { Id=Guid.Parse("09b8d11f-b6ec-4e6e-a62d-ac77fc1fe1a0"), Code="Early Action is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", SortOrder=0 },
            new RefAdmittedStudent { Id=Guid.Parse("ac065265-d88c-47f7-9f68-3ab3a5c4f545"), Code="Early Admit is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", SortOrder=0 },
            new RefAdmittedStudent { Id=Guid.Parse("e3e1c8bc-e0e4-4921-ab09-c90fff8532e2"), Code="Early Decision is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", SortOrder=0 },
            new RefAdmittedStudent { Id=Guid.Parse("0b50a125-6c6e-4fbe-b352-9aae460958e5"), Code="Regular Admit is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", SortOrder=0 },
            new RefAdmittedStudent { Id=Guid.Parse("56daeb55-cb59-47fe-9f00-e6822464b23a"), Code="Waitlist Admit is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", SortOrder=0 },
            new RefAdmittedStudent { Id=Guid.Parse("1f6e7585-d1c7-4370-acd2-74a9f2063fd0"), Code="Other Admit is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", SortOrder=0 },
            new RefAdmittedStudent { Id=Guid.Parse("ad32fd20-ee11-4faa-b65c-e963e77cbffd"), Code="Then applicant has NOT been granted an official offer to enroll in the postsecondary institution.", SortOrder=0 },
       };
   }
}
