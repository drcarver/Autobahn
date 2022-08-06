//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefRoleList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefRole Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefRole"> List
         /// </summary>
        public static List<RefRole> RefRoleList = new List<RefRole>
        {
            new RefRole { Id=Guid.Parse("7d2ef983-ca80-4ec8-aef7-64c8d7d57f4b"), Code="AEStaff", Description="AE Staff", Definition="A person for whom instruction and/or services are provided in an Adult Education program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefRole { Id=Guid.Parse("91316b2d-4dd3-4663-a780-3f3761be6132"), Code="AEStudent", Description="AE Student", Definition="An individual who performs specified activities for any public or private education institution, agency, or household that provides instructional and/or support services to students or staff in a Career and Technical Education program.", SortOrder=Convert.ToDecimal("2.00") },
            new RefRole { Id=Guid.Parse("9782c523-0c68-419f-ab0d-2c0a2b9a5b44"), Code="CTEStaff", Description="CTE Staff", Definition="A person for whom instruction, services, and/or care are provided in a Career and Technical Education program and who has met the state-defined threshold of Career and Technical Education participation.", SortOrder=Convert.ToDecimal("3.00") },
            new RefRole { Id=Guid.Parse("0213c343-4894-4c37-8d1d-2e89d6be604a"), Code="CTEStudent", Description="CTE Student", Definition="An individual who is an applicant of a postsecondary institution.", SortOrder=Convert.ToDecimal("4.00") },
            new RefRole { Id=Guid.Parse("e0237fbf-79cf-44ad-95e2-b49b0df43b97"), Code="ELChild", Description="EL Child", Definition="A person for whom instruction, services, and/or care are provided in an early childhood program under the jurisdiction of a school, education agency, or other institution or program.", SortOrder=Convert.ToDecimal("5.00") },
            new RefRole { Id=Guid.Parse("52e14a06-47c5-435b-96a3-cdf4889a17ba"), Code="ELStaff", Description="EL Staff", Definition="A person who performs specified activities for a public or private education institution, agency, or household that provides instructional and/or support services to students or staff at the early childhood level.", SortOrder=Convert.ToDecimal("6.00") },
            new RefRole { Id=Guid.Parse("c7d19ffd-5d09-40c6-adae-e50f3c019a0a"), Code="K12Staff", Description="K12 Staff", Definition="An individual who performs specified activities for any public or private education institution, agency, or household that provides instructional and/or support services to students or staff at the early childhood level through high school completion.", SortOrder=Convert.ToDecimal("7.00") },
            new RefRole { Id=Guid.Parse("2d53a5d7-9ea6-44bb-b83b-0e82388e53dd"), Code="K12Student", Description="K12 Student", Definition="A person for whom instruction, services, and/or care are provided in an elementary or secondary educational program under the jurisdiction of a school, education agency, or other institution or program.", SortOrder=Convert.ToDecimal("8.00") },
            new RefRole { Id=Guid.Parse("569dd78c-5047-40bd-9906-34cbd5078585"), Code="ParentGuardian", Description="Parent/Guardian", Definition="A person having parental or legal guardianship responsibility for a learner.", SortOrder=Convert.ToDecimal("9.00") },
            new RefRole { Id=Guid.Parse("12f56d37-76a1-4ef2-a55b-f9fcf9d32f2f"), Code="PSApplicant", Description="PS Applicant", Definition="A person who performs specified activities for any public or private education institution, agency, or household that provides instructional and/or support services to students or staff at the postsecondary level.", SortOrder=Convert.ToDecimal("10.00") },
            new RefRole { Id=Guid.Parse("77e98ec0-a339-4d40-b8af-970424c41927"), Code="PSStaff", Description="PS Staff", Definition="An individual who is a prospect, applicant, admitted student, enrolled student, or alum of a postsecondary institution.", SortOrder=Convert.ToDecimal("11.00") },
            new RefRole { Id=Guid.Parse("38845878-4b1d-4789-95d3-aa3455a4e935"), Code="PSStudent", Description="PS Student", Definition="", SortOrder=Convert.ToDecimal("12.00") },
            new RefRole { Id=Guid.Parse("f04131d3-757f-4648-8f3a-151cd69b912d"), Code="WorkforceProgramParticipant", Description="Workforce Program Participant", Definition="A person who is employed by an Adult Education program.", SortOrder=Convert.ToDecimal("13.00") },
        };

        /// <summary>
        /// The RefRole Pick List
         /// </summary>
        public static List<RefRole> RefRolePickList = new List<RefRole>
        {
            new RefRole { Id=Guid.Parse("7d2ef983-ca80-4ec8-aef7-64c8d7d57f4b"), Code="AEStaff", Description="AE Staff", SortOrder=Convert.ToDecimal("1.00") },
            new RefRole { Id=Guid.Parse("91316b2d-4dd3-4663-a780-3f3761be6132"), Code="AEStudent", Description="AE Student", SortOrder=Convert.ToDecimal("2.00") },
            new RefRole { Id=Guid.Parse("9782c523-0c68-419f-ab0d-2c0a2b9a5b44"), Code="CTEStaff", Description="CTE Staff", SortOrder=Convert.ToDecimal("3.00") },
            new RefRole { Id=Guid.Parse("0213c343-4894-4c37-8d1d-2e89d6be604a"), Code="CTEStudent", Description="CTE Student", SortOrder=Convert.ToDecimal("4.00") },
            new RefRole { Id=Guid.Parse("e0237fbf-79cf-44ad-95e2-b49b0df43b97"), Code="ELChild", Description="EL Child", SortOrder=Convert.ToDecimal("5.00") },
            new RefRole { Id=Guid.Parse("52e14a06-47c5-435b-96a3-cdf4889a17ba"), Code="ELStaff", Description="EL Staff", SortOrder=Convert.ToDecimal("6.00") },
            new RefRole { Id=Guid.Parse("c7d19ffd-5d09-40c6-adae-e50f3c019a0a"), Code="K12Staff", Description="K12 Staff", SortOrder=Convert.ToDecimal("7.00") },
            new RefRole { Id=Guid.Parse("2d53a5d7-9ea6-44bb-b83b-0e82388e53dd"), Code="K12Student", Description="K12 Student", SortOrder=Convert.ToDecimal("8.00") },
            new RefRole { Id=Guid.Parse("569dd78c-5047-40bd-9906-34cbd5078585"), Code="ParentGuardian", Description="Parent/Guardian", SortOrder=Convert.ToDecimal("9.00") },
            new RefRole { Id=Guid.Parse("12f56d37-76a1-4ef2-a55b-f9fcf9d32f2f"), Code="PSApplicant", Description="PS Applicant", SortOrder=Convert.ToDecimal("10.00") },
            new RefRole { Id=Guid.Parse("77e98ec0-a339-4d40-b8af-970424c41927"), Code="PSStaff", Description="PS Staff", SortOrder=Convert.ToDecimal("11.00") },
            new RefRole { Id=Guid.Parse("38845878-4b1d-4789-95d3-aa3455a4e935"), Code="PSStudent", Description="PS Student", SortOrder=Convert.ToDecimal("12.00") },
            new RefRole { Id=Guid.Parse("f04131d3-757f-4648-8f3a-151cd69b912d"), Code="WorkforceProgramParticipant", Description="Workforce Program Participant", SortOrder=Convert.ToDecimal("13.00") },
       };
   }
}
