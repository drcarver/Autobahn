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
        /// The complete <see cref="RefAdmittedStudentModel"> List
         /// </summary>
        public static List<RefAdmittedStudentModel> RefAdmittedStudentList = new List<RefAdmittedStudentModel>
        {
            new RefAdmittedStudent { Id=Guid.Parse("4aa1651c-35b7-485b-89a1-767b40836595"), Code="Conditional", Description="Conditional Admit", Definition="Conditional Admit is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", SortOrder=Convert.ToDecimal("0.00") },
            new RefAdmittedStudent { Id=Guid.Parse("9ed8fd40-6f45-44f8-ab11-b0ef49e77f57"), Code="EarlyAction", Description="Early Action", Definition="Early Action is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAdmittedStudent { Id=Guid.Parse("9fbaf687-9e47-430c-b699-9698598a25f2"), Code="EarlyAdmit", Description="Early Admit", Definition="Early Admit is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAdmittedStudent { Id=Guid.Parse("94e3bbea-8894-42e8-b2aa-ea1938b06702"), Code="EarlyDecision", Description="Early Decision", Definition="Early Decision is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAdmittedStudent { Id=Guid.Parse("abc4cfa5-90ef-4534-ade1-806d37667a37"), Code="Regular", Description="Regular Admit", Definition="Regular Admit is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAdmittedStudent { Id=Guid.Parse("87a0821f-94eb-4a26-9bfa-0df990937eb4"), Code="Waitlist", Description="Waitlist Admit", Definition="Waitlist Admit is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAdmittedStudent { Id=Guid.Parse("bda7637d-f2a8-4762-9ffc-02e0b5b31b16"), Code="Other", Description="Other Admit", Definition="Other Admit is specified as the category under which an applicant has been granted an official offer to enroll in a postsecondary institution.", SortOrder=Convert.ToDecimal("12.00") },
            new RefAdmittedStudent { Id=Guid.Parse("a9037a2c-fdd2-40a9-97f0-bd18dfaa8795"), Code="No", Description="No", Definition="Then applicant has NOT been granted an official offer to enroll in the postsecondary institution.", SortOrder=Convert.ToDecimal("14.00") },
        };

        /// <summary>
        /// The Reference RefAdmittedStudent Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAdmittedStudentViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAdmittedStudent { Id=Guid.Parse("4aa1651c-35b7-485b-89a1-767b40836595"), Description="Conditional Admit", SortOrder=Convert.ToDecimal("0.00") },
            new RefAdmittedStudent { Id=Guid.Parse("9ed8fd40-6f45-44f8-ab11-b0ef49e77f57"), Description="Early Action", SortOrder=Convert.ToDecimal("2.00") },
            new RefAdmittedStudent { Id=Guid.Parse("9fbaf687-9e47-430c-b699-9698598a25f2"), Description="Early Admit", SortOrder=Convert.ToDecimal("4.00") },
            new RefAdmittedStudent { Id=Guid.Parse("94e3bbea-8894-42e8-b2aa-ea1938b06702"), Description="Early Decision", SortOrder=Convert.ToDecimal("6.00") },
            new RefAdmittedStudent { Id=Guid.Parse("abc4cfa5-90ef-4534-ade1-806d37667a37"), Description="Regular Admit", SortOrder=Convert.ToDecimal("8.00") },
            new RefAdmittedStudent { Id=Guid.Parse("87a0821f-94eb-4a26-9bfa-0df990937eb4"), Description="Waitlist Admit", SortOrder=Convert.ToDecimal("10.00") },
            new RefAdmittedStudent { Id=Guid.Parse("bda7637d-f2a8-4762-9ffc-02e0b5b31b16"), Description="Other Admit", SortOrder=Convert.ToDecimal("12.00") },
            new RefAdmittedStudent { Id=Guid.Parse("a9037a2c-fdd2-40a9-97f0-bd18dfaa8795"), Description="No", SortOrder=Convert.ToDecimal("14.00") },
       };
   }
}
