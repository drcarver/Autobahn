//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefRoleStatusList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefRoleStatus Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefRoleStatus"> List
         /// </summary>
        public static List<RefRoleStatus> RefRoleStatusList = new List<RefRoleStatus>
        {
            new RefRoleStatus { Id=Guid.Parse("1d5709ca-f598-4394-8019-cd2b9b5cd685"), Code="01812", Description="Concurrently enrolled", Definition="The student is concurrently enrolled.", SortOrder=Convert.ToDecimal("1.00") },
            new RefRoleStatus { Id=Guid.Parse("b0038782-90e3-4f58-a2d0-8ed76b43da31"), Code="01811", Description="Currently enrolled", Definition="The student is currently enrolled.", SortOrder=Convert.ToDecimal("2.00") },
            new RefRoleStatus { Id=Guid.Parse("525c5cdd-9a49-46af-9427-c8833611babd"), Code="01810", Description="Previously enrolled", Definition="The student was previously enrolled.", SortOrder=Convert.ToDecimal("3.00") },
            new RefRoleStatus { Id=Guid.Parse("de903371-63a4-4851-93b7-23b6cfb31db3"), Code="01813", Description="Transferring (will enroll)", Definition="The student is transferring (will enroll).", SortOrder=Convert.ToDecimal("4.00") },
            new RefRoleStatus { Id=Guid.Parse("80be5d8e-a2e7-4eea-a6ad-d8039f685bd6"), Code="01", Description="Full-time", Definition="The student is enrolled full-time as defined by the institution for the specified term. ", SortOrder=Convert.ToDecimal("1.00") },
            new RefRoleStatus { Id=Guid.Parse("91d9ce9e-6feb-4534-a77d-a43062a5fafe"), Code="02", Description="Less than full-time but at least half-time", Definition="The student is enrolled less than full-time but at least half-time as defined by the institution for the specified term. ", SortOrder=Convert.ToDecimal("2.00") },
            new RefRoleStatus { Id=Guid.Parse("cd511386-6d8b-4895-b6b6-0448f872de2a"), Code="03", Description="Less than half-time", Definition="The student is enrolled Less than half-time as defined by the institution for the specified term. ", SortOrder=Convert.ToDecimal("3.00") },
            new RefRoleStatus { Id=Guid.Parse("b478e068-bab4-4efd-99f0-b7a9f04f9480"), Code="04", Description="Less than full-time but at least three quarter-time", Definition="The student is enrolled Less than full-time but at least three quarter-time as defined by the institution for the specified term. ", SortOrder=Convert.ToDecimal("5.00") },
            new RefRoleStatus { Id=Guid.Parse("f3eb451a-5f86-45b6-a836-7b286f9505e7"), Code="05", Description="Less than three quarter-time but at least half-time", Definition="The student is enrolled Less than three quarter-time but at least half-time as defined by the institution for the specified term. ", SortOrder=Convert.ToDecimal("7.00") },
            new RefRoleStatus { Id=Guid.Parse("7bc2714c-b5d6-42c8-a9df-dc6d4e0007e0"), Code="01384", Description="Contingent upon funding", Definition="Contingent upon funding is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("1.00") },
            new RefRoleStatus { Id=Guid.Parse("652edee1-9b0e-4064-b457-e279b8d4e1d4"), Code="01379", Description="Contractual", Definition="Contractual is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("2.00") },
            new RefRoleStatus { Id=Guid.Parse("60345d1d-aa4a-42a6-8ac2-387f527ea5de"), Code="06071", Description="Employed or affiliated with outside agency part-time", Definition="Employed or affiliated with outside agency part-time is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("3.00") },
            new RefRoleStatus { Id=Guid.Parse("603d817d-2408-4350-abf2-240f0753b7ad"), Code="01383", Description="Employed or affiliated with outside organization", Definition="Employed or affiliated with outside organization is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("4.00") },
            new RefRoleStatus { Id=Guid.Parse("011c9b54-e87e-486b-8480-ffd0f4f0c300"), Code="01385", Description="Non-contractual", Definition="Non-contractual is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("5.00") },
            new RefRoleStatus { Id=Guid.Parse("3e343e0f-6599-422c-94ab-e64ec56e9e80"), Code="09999", Description="Other", Definition="Other is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("6.00") },
            new RefRoleStatus { Id=Guid.Parse("a6a7ddee-f8af-482b-b07e-64417c9ec695"), Code="01378", Description="Probationary", Definition="Probationary is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("7.00") },
            new RefRoleStatus { Id=Guid.Parse("aa58aa9e-19e1-4c63-943a-f1a8e2495c4e"), Code="06070", Description="Self-employed part-time", Definition="Self-employed part-time is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("8.00") },
            new RefRoleStatus { Id=Guid.Parse("4d270d7d-16e3-4acf-9fca-1f0575a20d99"), Code="01380", Description="Substitute/temporary", Definition="Substitute/temporary is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("9.00") },
            new RefRoleStatus { Id=Guid.Parse("9a664e06-4e95-4b25-994a-b65e54920f78"), Code="01381", Description="Tenured or permanent", Definition="Tenured or permanent is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("10.00") },
            new RefRoleStatus { Id=Guid.Parse("07b4e4c3-195a-4993-856d-98ea8afcd1d0"), Code="01382", Description="Volunteer/no contract", Definition="Volunteer/no contract is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("11.00") },
            new RefRoleStatus { Id=Guid.Parse("cb8a4929-0c7b-4eb4-85cf-41d8db63030d"), Code="No", Description="No", Definition="The person is NOT pursuing certification as a teacher.", SortOrder=Convert.ToDecimal("1.00") },
            new RefRoleStatus { Id=Guid.Parse("478af950-20ff-42e1-9142-bb1c6285c433"), Code="SeekingCandidacy", Description="Seeking Candidacy", Definition="The person is seeking candidacy and pursuing certification as a teacher.", SortOrder=Convert.ToDecimal("2.00") },
            new RefRoleStatus { Id=Guid.Parse("86bc65ec-fe4f-421b-9cd3-c9eb318beda3"), Code="Enrolled", Description="Enrolled", Definition="The person is enrolled in a program and pursuing certification as a teacher.", SortOrder=Convert.ToDecimal("3.00") },
            new RefRoleStatus { Id=Guid.Parse("0bf38f6b-8fb7-4a67-b1a1-67c57f5d0f6c"), Code="Pre-registered", Description="Pre-registered", Definition="Pre-registered is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("1.00") },
            new RefRoleStatus { Id=Guid.Parse("4de4da66-d41b-4047-8823-d2086e69eaf2"), Code="Registered", Description="Registered", Definition="Registered is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("2.00") },
            new RefRoleStatus { Id=Guid.Parse("f9875c87-dd2b-4131-b9bf-9958ecb0fbf0"), Code="Enrolled", Description="Enrolled", Definition="Enrolled is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("3.00") },
            new RefRoleStatus { Id=Guid.Parse("24600987-8927-4702-80e2-53e70d2887e2"), Code="WaitListed", Description="Wait Listed", Definition="Wait Listed is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("4.00") },
            new RefRoleStatus { Id=Guid.Parse("ef065185-db71-4313-95ed-9754e00885c8"), Code="Dropped", Description="Dropped", Definition="Dropped is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("5.00") },
            new RefRoleStatus { Id=Guid.Parse("be92d79f-aa55-4163-aff9-de5393acaaf9"), Code="Completed", Description="Completed", Definition="Completed is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The RefRoleStatus Pick List
         /// </summary>
        public static List<RefRoleStatus> RefRoleStatusPickList = new List<RefRoleStatus>
        {
            new RefRoleStatus { Id=Guid.Parse("1d5709ca-f598-4394-8019-cd2b9b5cd685"), Code="01812", Description="Concurrently enrolled", SortOrder=Convert.ToDecimal("1.00") },
            new RefRoleStatus { Id=Guid.Parse("b0038782-90e3-4f58-a2d0-8ed76b43da31"), Code="01811", Description="Currently enrolled", SortOrder=Convert.ToDecimal("2.00") },
            new RefRoleStatus { Id=Guid.Parse("525c5cdd-9a49-46af-9427-c8833611babd"), Code="01810", Description="Previously enrolled", SortOrder=Convert.ToDecimal("3.00") },
            new RefRoleStatus { Id=Guid.Parse("de903371-63a4-4851-93b7-23b6cfb31db3"), Code="01813", Description="Transferring (will enroll)", SortOrder=Convert.ToDecimal("4.00") },
            new RefRoleStatus { Id=Guid.Parse("80be5d8e-a2e7-4eea-a6ad-d8039f685bd6"), Code="01", Description="Full-time", SortOrder=Convert.ToDecimal("1.00") },
            new RefRoleStatus { Id=Guid.Parse("91d9ce9e-6feb-4534-a77d-a43062a5fafe"), Code="02", Description="Less than full-time but at least half-time", SortOrder=Convert.ToDecimal("2.00") },
            new RefRoleStatus { Id=Guid.Parse("cd511386-6d8b-4895-b6b6-0448f872de2a"), Code="03", Description="Less than half-time", SortOrder=Convert.ToDecimal("3.00") },
            new RefRoleStatus { Id=Guid.Parse("b478e068-bab4-4efd-99f0-b7a9f04f9480"), Code="04", Description="Less than full-time but at least three quarter-time", SortOrder=Convert.ToDecimal("5.00") },
            new RefRoleStatus { Id=Guid.Parse("f3eb451a-5f86-45b6-a836-7b286f9505e7"), Code="05", Description="Less than three quarter-time but at least half-time", SortOrder=Convert.ToDecimal("7.00") },
            new RefRoleStatus { Id=Guid.Parse("7bc2714c-b5d6-42c8-a9df-dc6d4e0007e0"), Code="01384", Description="Contingent upon funding", SortOrder=Convert.ToDecimal("1.00") },
            new RefRoleStatus { Id=Guid.Parse("652edee1-9b0e-4064-b457-e279b8d4e1d4"), Code="01379", Description="Contractual", SortOrder=Convert.ToDecimal("2.00") },
            new RefRoleStatus { Id=Guid.Parse("60345d1d-aa4a-42a6-8ac2-387f527ea5de"), Code="06071", Description="Employed or affiliated with outside agency part-time", SortOrder=Convert.ToDecimal("3.00") },
            new RefRoleStatus { Id=Guid.Parse("603d817d-2408-4350-abf2-240f0753b7ad"), Code="01383", Description="Employed or affiliated with outside organization", SortOrder=Convert.ToDecimal("4.00") },
            new RefRoleStatus { Id=Guid.Parse("011c9b54-e87e-486b-8480-ffd0f4f0c300"), Code="01385", Description="Non-contractual", SortOrder=Convert.ToDecimal("5.00") },
            new RefRoleStatus { Id=Guid.Parse("3e343e0f-6599-422c-94ab-e64ec56e9e80"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("6.00") },
            new RefRoleStatus { Id=Guid.Parse("a6a7ddee-f8af-482b-b07e-64417c9ec695"), Code="01378", Description="Probationary", SortOrder=Convert.ToDecimal("7.00") },
            new RefRoleStatus { Id=Guid.Parse("aa58aa9e-19e1-4c63-943a-f1a8e2495c4e"), Code="06070", Description="Self-employed part-time", SortOrder=Convert.ToDecimal("8.00") },
            new RefRoleStatus { Id=Guid.Parse("4d270d7d-16e3-4acf-9fca-1f0575a20d99"), Code="01380", Description="Substitute/temporary", SortOrder=Convert.ToDecimal("9.00") },
            new RefRoleStatus { Id=Guid.Parse("9a664e06-4e95-4b25-994a-b65e54920f78"), Code="01381", Description="Tenured or permanent", SortOrder=Convert.ToDecimal("10.00") },
            new RefRoleStatus { Id=Guid.Parse("07b4e4c3-195a-4993-856d-98ea8afcd1d0"), Code="01382", Description="Volunteer/no contract", SortOrder=Convert.ToDecimal("11.00") },
            new RefRoleStatus { Id=Guid.Parse("cb8a4929-0c7b-4eb4-85cf-41d8db63030d"), Code="No", Description="No", SortOrder=Convert.ToDecimal("1.00") },
            new RefRoleStatus { Id=Guid.Parse("478af950-20ff-42e1-9142-bb1c6285c433"), Code="SeekingCandidacy", Description="Seeking Candidacy", SortOrder=Convert.ToDecimal("2.00") },
            new RefRoleStatus { Id=Guid.Parse("86bc65ec-fe4f-421b-9cd3-c9eb318beda3"), Code="Enrolled", Description="Enrolled", SortOrder=Convert.ToDecimal("3.00") },
            new RefRoleStatus { Id=Guid.Parse("0bf38f6b-8fb7-4a67-b1a1-67c57f5d0f6c"), Code="Pre-registered", Description="Pre-registered", SortOrder=Convert.ToDecimal("1.00") },
            new RefRoleStatus { Id=Guid.Parse("4de4da66-d41b-4047-8823-d2086e69eaf2"), Code="Registered", Description="Registered", SortOrder=Convert.ToDecimal("2.00") },
            new RefRoleStatus { Id=Guid.Parse("f9875c87-dd2b-4131-b9bf-9958ecb0fbf0"), Code="Enrolled", Description="Enrolled", SortOrder=Convert.ToDecimal("3.00") },
            new RefRoleStatus { Id=Guid.Parse("24600987-8927-4702-80e2-53e70d2887e2"), Code="WaitListed", Description="Wait Listed", SortOrder=Convert.ToDecimal("4.00") },
            new RefRoleStatus { Id=Guid.Parse("ef065185-db71-4313-95ed-9754e00885c8"), Code="Dropped", Description="Dropped", SortOrder=Convert.ToDecimal("5.00") },
            new RefRoleStatus { Id=Guid.Parse("be92d79f-aa55-4163-aff9-de5393acaaf9"), Code="Completed", Description="Completed", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
