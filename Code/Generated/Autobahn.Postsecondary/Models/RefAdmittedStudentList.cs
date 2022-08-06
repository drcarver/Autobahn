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
        public static List<RefAdmittedStudent> RefAdmittedStudentList = new List<RefAdmittedStudent>
        {
            new RefAdmittedStudent { Id=Guid.Parse("fcb769c1-7e31-42ab-bda0-8eb53493137f"), Code="Conditional", Description="Conditional Admit", Definition="Conditional Admit is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", SortOrder=Convert.ToDecimal("0.00") },
            new RefAdmittedStudent { Id=Guid.Parse("eeae402d-893d-4ba5-8d4e-5315890d92aa"), Code="EarlyAction", Description="Early Action", Definition="Early Action is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAdmittedStudent { Id=Guid.Parse("a300c5f0-2875-42b7-871d-a2109f9e7a1d"), Code="EarlyAdmit", Description="Early Admit", Definition="Early Admit is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAdmittedStudent { Id=Guid.Parse("2f455d64-f3d4-4e68-9b28-54b7057ef386"), Code="EarlyDecision", Description="Early Decision", Definition="Early Decision is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAdmittedStudent { Id=Guid.Parse("5ab3ad2e-b0e1-4afd-9c54-1f62db5a0e4a"), Code="Regular", Description="Regular Admit", Definition="Regular Admit is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAdmittedStudent { Id=Guid.Parse("5be4a271-589b-4d29-8f89-f69da0702c7e"), Code="Waitlist", Description="Waitlist Admit", Definition="Waitlist Admit is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAdmittedStudent { Id=Guid.Parse("33830c48-73b1-4f59-897b-95059f8a43bc"), Code="Other", Description="Other Admit", Definition="Other Admit is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", SortOrder=Convert.ToDecimal("12.00") },
            new RefAdmittedStudent { Id=Guid.Parse("3f3346d4-c2b8-4270-896b-5b81c171881b"), Code="No", Description="No", Definition="Then applicant has NOT been granted an official offer to enroll in the postsecondary institution.", SortOrder=Convert.ToDecimal("14.00") },
        };

        /// <summary>
        /// The RefAdmittedStudent Pick List
         /// </summary>
        public static List<RefAdmittedStudent> RefAdmittedStudentPickList = new List<RefAdmittedStudent>
        {
            new RefAdmittedStudent { Id=Guid.Parse("fcb769c1-7e31-42ab-bda0-8eb53493137f"), Code="Conditional", Description="Conditional Admit", SortOrder=Convert.ToDecimal("0.00") },
            new RefAdmittedStudent { Id=Guid.Parse("eeae402d-893d-4ba5-8d4e-5315890d92aa"), Code="EarlyAction", Description="Early Action", SortOrder=Convert.ToDecimal("2.00") },
            new RefAdmittedStudent { Id=Guid.Parse("a300c5f0-2875-42b7-871d-a2109f9e7a1d"), Code="EarlyAdmit", Description="Early Admit", SortOrder=Convert.ToDecimal("4.00") },
            new RefAdmittedStudent { Id=Guid.Parse("2f455d64-f3d4-4e68-9b28-54b7057ef386"), Code="EarlyDecision", Description="Early Decision", SortOrder=Convert.ToDecimal("6.00") },
            new RefAdmittedStudent { Id=Guid.Parse("5ab3ad2e-b0e1-4afd-9c54-1f62db5a0e4a"), Code="Regular", Description="Regular Admit", SortOrder=Convert.ToDecimal("8.00") },
            new RefAdmittedStudent { Id=Guid.Parse("5be4a271-589b-4d29-8f89-f69da0702c7e"), Code="Waitlist", Description="Waitlist Admit", SortOrder=Convert.ToDecimal("10.00") },
            new RefAdmittedStudent { Id=Guid.Parse("33830c48-73b1-4f59-897b-95059f8a43bc"), Code="Other", Description="Other Admit", SortOrder=Convert.ToDecimal("12.00") },
            new RefAdmittedStudent { Id=Guid.Parse("3f3346d4-c2b8-4270-896b-5b81c171881b"), Code="No", Description="No", SortOrder=Convert.ToDecimal("14.00") },
       };
   }
}
