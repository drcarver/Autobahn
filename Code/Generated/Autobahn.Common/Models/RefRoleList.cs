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
        public static List<RefRole> RefRoleList = new List<RefRole> =
        {
            new RefRole { Id=Guid.Parse("cd537f7d-4be2-48d6-abd4-7dfc53e48321"), Code="A person for whom instruction and/or services are provided in an Adult Education program.", Description="AEStaff", Definition="", SortOrder=0 },
            new RefRole { Id=Guid.Parse("70263b2c-06b7-421c-9624-f0bb544eab01"), Code="An individual who performs specified activities for any public or private education institution, agency, or household that provides instructional and/or support services to students or staff in a Career and Technical Education program.", Description="AEStudent", Definition="", SortOrder=0 },
            new RefRole { Id=Guid.Parse("32dda19d-d39a-48cb-988a-add7fafd5662"), Code="A person for whom instruction, services, and/or care are provided in a Career and Technical Education program and who has met the state-defined threshold of Career and Technical Education participation.", Description="CTEStaff", Definition="", SortOrder=0 },
            new RefRole { Id=Guid.Parse("10928b55-b4a9-4cee-9ad0-a97b8c5e59ee"), Code="An individual who is an applicant of a postsecondary institution.", Description="CTEStudent", Definition="", SortOrder=0 },
            new RefRole { Id=Guid.Parse("5e0ed377-07cc-4c34-a83c-3f00172b7257"), Code="A person for whom instruction, services, and/or care are provided in an early childhood program under the jurisdiction of a school, education agency, or other institution or program.", Description="ELChild", Definition="", SortOrder=0 },
            new RefRole { Id=Guid.Parse("6d4fde79-b23a-40ee-a5ad-3f3813c0882a"), Code="A person who performs specified activities for a public or private education institution, agency, or household that provides instructional and/or support services to students or staff at the early childhood level.", Description="ELStaff", Definition="", SortOrder=0 },
            new RefRole { Id=Guid.Parse("1d2fd956-d243-4a5a-8b68-a730d380df47"), Code="An individual who performs specified activities for any public or private education institution, agency, or household that provides instructional and/or support services to students or staff at the early childhood level through high school completion.", Description="K12Staff", Definition="", SortOrder=0 },
            new RefRole { Id=Guid.Parse("7722d353-b3cf-479d-b6ba-ee922ba774db"), Code="A person for whom instruction, services, and/or care are provided in an elementary or secondary educational program under the jurisdiction of a school, education agency, or other institution or program.", Description="K12Student", Definition="", SortOrder=0 },
            new RefRole { Id=Guid.Parse("0e695348-14c9-42da-ac0e-abe9b7003618"), Code="A person having parental or legal guardianship responsibility for a learner.", Description="ParentGuardian", Definition="", SortOrder=0 },
            new RefRole { Id=Guid.Parse("7a15e9ef-2c54-4540-ba5c-5a931de4176d"), Code="A person who performs specified activities for any public or private education institution, agency, or household that provides instructional and/or support services to students or staff at the postsecondary level.", Description="PSApplicant", Definition="", SortOrder=0 },
            new RefRole { Id=Guid.Parse("0ff859ec-b5d7-4c3f-ae15-8a88c04e010c"), Code="An individual who is a prospect, applicant, admitted student, enrolled student, or alum of a postsecondary institution.", Description="PSStaff", Definition="", SortOrder=0 },
            new RefRole { Id=Guid.Parse("c1242de2-b68f-488f-87a1-af0dc7c1aa09"), Code="", Description="PSStudent", Definition="", SortOrder=0 },
            new RefRole { Id=Guid.Parse("17e0aefb-cf6c-4cd4-b047-c5db95ffe090"), Code="A person who is employed by an Adult Education program.", Description="WorkforceProgramParticipant", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefRole Pick List
         /// </summary>
        public static List<RefRole> RefRolePickList = new List<RefRole> =
        {
            new RefRole { Id=Guid.Parse("cd537f7d-4be2-48d6-abd4-7dfc53e48321"), Code="A person for whom instruction and/or services are provided in an Adult Education program.", SortOrder=0 },
            new RefRole { Id=Guid.Parse("70263b2c-06b7-421c-9624-f0bb544eab01"), Code="An individual who performs specified activities for any public or private education institution, agency, or household that provides instructional and/or support services to students or staff in a Career and Technical Education program.", SortOrder=0 },
            new RefRole { Id=Guid.Parse("32dda19d-d39a-48cb-988a-add7fafd5662"), Code="A person for whom instruction, services, and/or care are provided in a Career and Technical Education program and who has met the state-defined threshold of Career and Technical Education participation.", SortOrder=0 },
            new RefRole { Id=Guid.Parse("10928b55-b4a9-4cee-9ad0-a97b8c5e59ee"), Code="An individual who is an applicant of a postsecondary institution.", SortOrder=0 },
            new RefRole { Id=Guid.Parse("5e0ed377-07cc-4c34-a83c-3f00172b7257"), Code="A person for whom instruction, services, and/or care are provided in an early childhood program under the jurisdiction of a school, education agency, or other institution or program.", SortOrder=0 },
            new RefRole { Id=Guid.Parse("6d4fde79-b23a-40ee-a5ad-3f3813c0882a"), Code="A person who performs specified activities for a public or private education institution, agency, or household that provides instructional and/or support services to students or staff at the early childhood level.", SortOrder=0 },
            new RefRole { Id=Guid.Parse("1d2fd956-d243-4a5a-8b68-a730d380df47"), Code="An individual who performs specified activities for any public or private education institution, agency, or household that provides instructional and/or support services to students or staff at the early childhood level through high school completion.", SortOrder=0 },
            new RefRole { Id=Guid.Parse("7722d353-b3cf-479d-b6ba-ee922ba774db"), Code="A person for whom instruction, services, and/or care are provided in an elementary or secondary educational program under the jurisdiction of a school, education agency, or other institution or program.", SortOrder=0 },
            new RefRole { Id=Guid.Parse("0e695348-14c9-42da-ac0e-abe9b7003618"), Code="A person having parental or legal guardianship responsibility for a learner.", SortOrder=0 },
            new RefRole { Id=Guid.Parse("7a15e9ef-2c54-4540-ba5c-5a931de4176d"), Code="A person who performs specified activities for any public or private education institution, agency, or household that provides instructional and/or support services to students or staff at the postsecondary level.", SortOrder=0 },
            new RefRole { Id=Guid.Parse("0ff859ec-b5d7-4c3f-ae15-8a88c04e010c"), Code="An individual who is a prospect, applicant, admitted student, enrolled student, or alum of a postsecondary institution.", SortOrder=0 },
            new RefRole { Id=Guid.Parse("c1242de2-b68f-488f-87a1-af0dc7c1aa09"), Code="", SortOrder=0 },
            new RefRole { Id=Guid.Parse("17e0aefb-cf6c-4cd4-b047-c5db95ffe090"), Code="A person who is employed by an Adult Education program.", SortOrder=0 },
       };
   }
}
