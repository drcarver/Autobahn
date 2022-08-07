//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   RefGoalsForAttendingAdultEducationList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The list of RefGoalsForAttendingAdultEducation Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefGoalsForAttendingAdultEducationModel"> List
         /// </summary>
        public static List<RefGoalsForAttendingAdultEducationModel> RefGoalsForAttendingAdultEducationList = new List<RefGoalsForAttendingAdultEducationModel>
        {
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("29414ec6-3f06-475a-a1f8-3071b6a9c9a9"), Code="01", Description="Obtain a job", Definition="The person's reasons for attending an adult education class or program is to obtain a job.", SortOrder=Convert.ToDecimal("1.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("61db6b20-4fbc-4e06-b8ab-199bf711e6ea"), Code="02", Description="Retain current job", Definition="The person's reasons for attending an adult education class or program is to retain a current job.", SortOrder=Convert.ToDecimal("2.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("38d7fc54-523e-45b4-9c39-d68a18ee9b1c"), Code="03", Description="Earn a secondary school diploma or achieve GED certificate", Definition="The person's reasons for attending an adult education class or program is to earn a secondary school diploma or achieve GED certificate.", SortOrder=Convert.ToDecimal("3.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("bfe5adae-bf69-4aeb-a6c6-83b4e5b5d56a"), Code="04", Description="Enter postsecondary education or job training", Definition="The person's reasons for attending an adult education class or program is to enter postsecondary education or job training.", SortOrder=Convert.ToDecimal("4.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("5cfb7893-a241-42e2-b7d8-5eecdd926d69"), Code="05", Description="Improve basic literacy skills", Definition="The person's reasons for attending an adult education class or program is to improve basic literacy skills.", SortOrder=Convert.ToDecimal("5.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("d612541e-4a9b-4133-b328-d365681d7a80"), Code="06", Description="Improve English language skills", Definition="The person's reasons for attending an adult education class or program is to improve English language skills.", SortOrder=Convert.ToDecimal("6.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("bad96b1f-e87a-41b5-9775-cfbfbf4617d6"), Code="07", Description="Obtain citizenship skills", Definition="The person's reasons for attending an adult education class or program is to obtain citizenship skills.", SortOrder=Convert.ToDecimal("7.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("c09e09e5-090e-4b4a-84fc-4f8891b40d22"), Code="08", Description="Achieve work-based project learner goals", Definition="The person's reasons for attending an adult education class or program is to achieve work-based project learner goals.", SortOrder=Convert.ToDecimal("8.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("8c756771-c97b-45d0-81e0-b6c66efbdb33"), Code="09", Description="Other personal goals", Definition="The person's reasons for attending an adult education class or program is to achieve other personal goals.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefGoalsForAttendingAdultEducation Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefGoalsForAttendingAdultEducationViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("29414ec6-3f06-475a-a1f8-3071b6a9c9a9"), Description="Obtain a job", SortOrder=Convert.ToDecimal("1.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("61db6b20-4fbc-4e06-b8ab-199bf711e6ea"), Description="Retain current job", SortOrder=Convert.ToDecimal("2.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("38d7fc54-523e-45b4-9c39-d68a18ee9b1c"), Description="Earn a secondary school diploma or achieve GED certificate", SortOrder=Convert.ToDecimal("3.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("bfe5adae-bf69-4aeb-a6c6-83b4e5b5d56a"), Description="Enter postsecondary education or job training", SortOrder=Convert.ToDecimal("4.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("5cfb7893-a241-42e2-b7d8-5eecdd926d69"), Description="Improve basic literacy skills", SortOrder=Convert.ToDecimal("5.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("d612541e-4a9b-4133-b328-d365681d7a80"), Description="Improve English language skills", SortOrder=Convert.ToDecimal("6.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("bad96b1f-e87a-41b5-9775-cfbfbf4617d6"), Description="Obtain citizenship skills", SortOrder=Convert.ToDecimal("7.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("c09e09e5-090e-4b4a-84fc-4f8891b40d22"), Description="Achieve work-based project learner goals", SortOrder=Convert.ToDecimal("8.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("8c756771-c97b-45d0-81e0-b6c66efbdb33"), Description="Other personal goals", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
