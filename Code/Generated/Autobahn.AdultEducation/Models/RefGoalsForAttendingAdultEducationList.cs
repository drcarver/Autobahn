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
        /// The complete <see cref="RefGoalsForAttendingAdultEducation"> List
         /// </summary>
        public static List<RefGoalsForAttendingAdultEducation> RefGoalsForAttendingAdultEducationList = new List<RefGoalsForAttendingAdultEducation>
        {
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("18f0df3b-ec79-443f-9002-3e171bec8b67"), Code="01", Description="Obtain a job", Definition="The person's reasons for attending an adult education class or program is to obtain a job.", SortOrder=Convert.ToDecimal("1.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("189606f7-4583-4854-b897-defcef63812f"), Code="02", Description="Retain current job", Definition="The person's reasons for attending an adult education class or program is to retain a current job.", SortOrder=Convert.ToDecimal("2.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("c0a2699b-4f8b-4260-9da4-5e7c9cd20d45"), Code="03", Description="Earn a secondary school diploma or achieve GED certificate", Definition="The person's reasons for attending an adult education class or program is to earn a secondary school diploma or achieve GED certificate.", SortOrder=Convert.ToDecimal("3.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("b6fcc489-218a-4dfc-82aa-db69556b18f3"), Code="04", Description="Enter postsecondary education or job training", Definition="The person's reasons for attending an adult education class or program is to enter postsecondary education or job training.", SortOrder=Convert.ToDecimal("4.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("2f8c3142-4196-4738-bea0-1187677f80bd"), Code="05", Description="Improve basic literacy skills", Definition="The person's reasons for attending an adult education class or program is to improve basic literacy skills.", SortOrder=Convert.ToDecimal("5.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("8b2a622b-258c-4743-9281-1da6303cd338"), Code="06", Description="Improve English language skills", Definition="The person's reasons for attending an adult education class or program is to improve English language skills.", SortOrder=Convert.ToDecimal("6.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("967b368c-b40e-4827-8f26-5692bdcd50ad"), Code="07", Description="Obtain citizenship skills", Definition="The person's reasons for attending an adult education class or program is to obtain citizenship skills.", SortOrder=Convert.ToDecimal("7.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("3ef8c6d2-d216-41c3-abd8-cdb18228a171"), Code="08", Description="Achieve work-based project learner goals", Definition="The person's reasons for attending an adult education class or program is to achieve work-based project learner goals.", SortOrder=Convert.ToDecimal("8.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("cfdd82a3-6c8f-4beb-965f-da4a80889bb6"), Code="09", Description="Other personal goals", Definition="The person's reasons for attending an adult education class or program is to achieve other personal goals.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The RefGoalsForAttendingAdultEducation Pick List
         /// </summary>
        public static List<RefGoalsForAttendingAdultEducation> RefGoalsForAttendingAdultEducationPickList = new List<RefGoalsForAttendingAdultEducation>
        {
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("18f0df3b-ec79-443f-9002-3e171bec8b67"), Code="01", Description="Obtain a job", SortOrder=Convert.ToDecimal("1.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("189606f7-4583-4854-b897-defcef63812f"), Code="02", Description="Retain current job", SortOrder=Convert.ToDecimal("2.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("c0a2699b-4f8b-4260-9da4-5e7c9cd20d45"), Code="03", Description="Earn a secondary school diploma or achieve GED certificate", SortOrder=Convert.ToDecimal("3.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("b6fcc489-218a-4dfc-82aa-db69556b18f3"), Code="04", Description="Enter postsecondary education or job training", SortOrder=Convert.ToDecimal("4.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("2f8c3142-4196-4738-bea0-1187677f80bd"), Code="05", Description="Improve basic literacy skills", SortOrder=Convert.ToDecimal("5.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("8b2a622b-258c-4743-9281-1da6303cd338"), Code="06", Description="Improve English language skills", SortOrder=Convert.ToDecimal("6.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("967b368c-b40e-4827-8f26-5692bdcd50ad"), Code="07", Description="Obtain citizenship skills", SortOrder=Convert.ToDecimal("7.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("3ef8c6d2-d216-41c3-abd8-cdb18228a171"), Code="08", Description="Achieve work-based project learner goals", SortOrder=Convert.ToDecimal("8.00") },
            new RefGoalsForAttendingAdultEducation { Id=Guid.Parse("cfdd82a3-6c8f-4beb-965f-da4a80889bb6"), Code="09", Description="Other personal goals", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
