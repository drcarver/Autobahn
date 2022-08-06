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
        public static List<RefRoleStatus> RefRoleStatusList = new List<RefRoleStatus> =
        {
            new RefRoleStatus { Id=Guid.Parse("a3f657ef-24df-4400-9b7b-a1ffb97f0117"), Code="The student is concurrently enrolled.", Description="01812", Definition="", SortOrder=1 },
            new RefRoleStatus { Id=Guid.Parse("6d51aee6-7ece-45f9-9d7c-f2b4f3f1ca11"), Code="The student is currently enrolled.", Description="01811", Definition="", SortOrder=1 },
            new RefRoleStatus { Id=Guid.Parse("9ebd5907-4786-497d-b6f8-0f3df188264e"), Code="The student was previously enrolled.", Description="01810", Definition="", SortOrder=1 },
            new RefRoleStatus { Id=Guid.Parse("3b0b0c8f-1269-49fb-961f-f645df345441"), Code="The student is transferring (will enroll).", Description="01813", Definition="", SortOrder=1 },
            new RefRoleStatus { Id=Guid.Parse("b0e2ffc7-ccbf-4b82-99a1-0f38f5297fd4"), Code="The student is enrolled full-time as defined by the institution for the specified term. ", Description="01", Definition="", SortOrder=2 },
            new RefRoleStatus { Id=Guid.Parse("f73108ea-e4ad-4edb-b936-5d95c7f68fec"), Code="The student is enrolled less than full-time but at least half-time as defined by the institution for the specified term. ", Description="02", Definition="", SortOrder=2 },
            new RefRoleStatus { Id=Guid.Parse("13c7a15a-acd1-4025-8ae6-e8adbcc67ee7"), Code="The student is enrolled Less than half-time as defined by the institution for the specified term. ", Description="03", Definition="", SortOrder=2 },
            new RefRoleStatus { Id=Guid.Parse("d8f70723-67ca-44c9-9a96-2f61abf71021"), Code="The student is enrolled Less than full-time but at least three quarter-time as defined by the institution for the specified term. ", Description="04", Definition="", SortOrder=2 },
            new RefRoleStatus { Id=Guid.Parse("c95c599a-921f-4aea-8b57-a6f0ba9e9e3b"), Code="The student is enrolled Less than three quarter-time but at least half-time as defined by the institution for the specified term. ", Description="05", Definition="", SortOrder=2 },
            new RefRoleStatus { Id=Guid.Parse("065232fd-3531-4ea7-be09-4e4bcf3297f6"), Code="Contingent upon funding is the condition under which a person has agreed to serve as an employee.", Description="01384", Definition="", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("15c5f1ab-5815-4726-9fab-4a87f4d6b720"), Code="Contractual is the condition under which a person has agreed to serve as an employee.", Description="01379", Definition="", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("61b17a7f-c4f6-494a-888d-3ae9c88e2d6e"), Code="Employed or affiliated with outside agency part-time is the condition under which a person has agreed to serve as an employee.", Description="06071", Definition="", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("0ceca4ce-0886-4f97-8431-0672d819de4c"), Code="Employed or affiliated with outside organization is the condition under which a person has agreed to serve as an employee.", Description="01383", Definition="", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("84dae89d-aa95-424d-b363-cac3e698f57c"), Code="Non-contractual is the condition under which a person has agreed to serve as an employee.", Description="01385", Definition="", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("090d30fb-f58b-49ce-a4ae-90d756d337c2"), Code="Other is the condition under which a person has agreed to serve as an employee.", Description="09999", Definition="", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("2bbef3bf-4c7c-45e1-91b1-ef795fd8c33b"), Code="Probationary is the condition under which a person has agreed to serve as an employee.", Description="01378", Definition="", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("fe2146b6-0b27-41a6-88b8-9ef5b82c989e"), Code="Self-employed part-time is the condition under which a person has agreed to serve as an employee.", Description="06070", Definition="", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("ef45165f-9532-4687-abc0-97d372c84e6f"), Code="Substitute/temporary is the condition under which a person has agreed to serve as an employee.", Description="01380", Definition="", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("84abd676-9bf4-4d1c-bb75-4555b7d6d8cb"), Code="Tenured or permanent is the condition under which a person has agreed to serve as an employee.", Description="01381", Definition="", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("61e54816-b719-4321-bf24-1b1ffedc1658"), Code="Volunteer/no contract is the condition under which a person has agreed to serve as an employee.", Description="01382", Definition="", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("f1714c92-f959-4c2a-8a03-a2e3064896bd"), Code="The person is NOT pursuing certification as a teacher.", Description="No", Definition="", SortOrder=4 },
            new RefRoleStatus { Id=Guid.Parse("aab9589f-cb08-4d49-8e6b-ef4a1a827529"), Code="The person is seeking candidacy and pursuing certification as a teacher.", Description="SeekingCandidacy", Definition="", SortOrder=4 },
            new RefRoleStatus { Id=Guid.Parse("77f2ad1f-5726-4832-b7c9-a739e51a5d41"), Code="The person is enrolled in a program and pursuing certification as a teacher.", Description="Enrolled", Definition="", SortOrder=4 },
            new RefRoleStatus { Id=Guid.Parse("35558b95-8758-410f-8f5d-6750dec1ac64"), Code="Pre-registered is the status related to a student enrollment in an instance of a course.", Description="Pre-registered", Definition="", SortOrder=5 },
            new RefRoleStatus { Id=Guid.Parse("7e5d954c-0762-4e07-a6ec-ed05fbf6298f"), Code="Registered is the status related to a student enrollment in an instance of a course.", Description="Registered", Definition="", SortOrder=5 },
            new RefRoleStatus { Id=Guid.Parse("c5608e9e-fcb2-4cc6-a794-2b5819d2fffc"), Code="Enrolled is the status related to a student enrollment in an instance of a course.", Description="Enrolled", Definition="", SortOrder=5 },
            new RefRoleStatus { Id=Guid.Parse("ba212b33-92f2-4ce0-9428-aa7a34aa2e0a"), Code="Wait Listed is the status related to a student enrollment in an instance of a course.", Description="WaitListed", Definition="", SortOrder=5 },
            new RefRoleStatus { Id=Guid.Parse("b19109f8-d08d-474c-b47b-83192dfdeb65"), Code="Dropped is the status related to a student enrollment in an instance of a course.", Description="Dropped", Definition="", SortOrder=5 },
            new RefRoleStatus { Id=Guid.Parse("e298f48c-1e04-4d92-acd2-9b5a8f65c5ba"), Code="Completed is the status related to a student enrollment in an instance of a course.", Description="Completed", Definition="", SortOrder=5 },
        };

        /// <summary>
        /// The RefRoleStatus Pick List
         /// </summary>
        public static List<RefRoleStatus> RefRoleStatusPickList = new List<RefRoleStatus> =
        {
            new RefRoleStatus { Id=Guid.Parse("a3f657ef-24df-4400-9b7b-a1ffb97f0117"), Code="The student is concurrently enrolled.", SortOrder=1 },
            new RefRoleStatus { Id=Guid.Parse("6d51aee6-7ece-45f9-9d7c-f2b4f3f1ca11"), Code="The student is currently enrolled.", SortOrder=1 },
            new RefRoleStatus { Id=Guid.Parse("9ebd5907-4786-497d-b6f8-0f3df188264e"), Code="The student was previously enrolled.", SortOrder=1 },
            new RefRoleStatus { Id=Guid.Parse("3b0b0c8f-1269-49fb-961f-f645df345441"), Code="The student is transferring (will enroll).", SortOrder=1 },
            new RefRoleStatus { Id=Guid.Parse("b0e2ffc7-ccbf-4b82-99a1-0f38f5297fd4"), Code="The student is enrolled full-time as defined by the institution for the specified term. ", SortOrder=2 },
            new RefRoleStatus { Id=Guid.Parse("f73108ea-e4ad-4edb-b936-5d95c7f68fec"), Code="The student is enrolled less than full-time but at least half-time as defined by the institution for the specified term. ", SortOrder=2 },
            new RefRoleStatus { Id=Guid.Parse("13c7a15a-acd1-4025-8ae6-e8adbcc67ee7"), Code="The student is enrolled Less than half-time as defined by the institution for the specified term. ", SortOrder=2 },
            new RefRoleStatus { Id=Guid.Parse("d8f70723-67ca-44c9-9a96-2f61abf71021"), Code="The student is enrolled Less than full-time but at least three quarter-time as defined by the institution for the specified term. ", SortOrder=2 },
            new RefRoleStatus { Id=Guid.Parse("c95c599a-921f-4aea-8b57-a6f0ba9e9e3b"), Code="The student is enrolled Less than three quarter-time but at least half-time as defined by the institution for the specified term. ", SortOrder=2 },
            new RefRoleStatus { Id=Guid.Parse("065232fd-3531-4ea7-be09-4e4bcf3297f6"), Code="Contingent upon funding is the condition under which a person has agreed to serve as an employee.", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("15c5f1ab-5815-4726-9fab-4a87f4d6b720"), Code="Contractual is the condition under which a person has agreed to serve as an employee.", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("61b17a7f-c4f6-494a-888d-3ae9c88e2d6e"), Code="Employed or affiliated with outside agency part-time is the condition under which a person has agreed to serve as an employee.", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("0ceca4ce-0886-4f97-8431-0672d819de4c"), Code="Employed or affiliated with outside organization is the condition under which a person has agreed to serve as an employee.", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("84dae89d-aa95-424d-b363-cac3e698f57c"), Code="Non-contractual is the condition under which a person has agreed to serve as an employee.", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("090d30fb-f58b-49ce-a4ae-90d756d337c2"), Code="Other is the condition under which a person has agreed to serve as an employee.", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("2bbef3bf-4c7c-45e1-91b1-ef795fd8c33b"), Code="Probationary is the condition under which a person has agreed to serve as an employee.", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("fe2146b6-0b27-41a6-88b8-9ef5b82c989e"), Code="Self-employed part-time is the condition under which a person has agreed to serve as an employee.", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("ef45165f-9532-4687-abc0-97d372c84e6f"), Code="Substitute/temporary is the condition under which a person has agreed to serve as an employee.", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("84abd676-9bf4-4d1c-bb75-4555b7d6d8cb"), Code="Tenured or permanent is the condition under which a person has agreed to serve as an employee.", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("61e54816-b719-4321-bf24-1b1ffedc1658"), Code="Volunteer/no contract is the condition under which a person has agreed to serve as an employee.", SortOrder=3 },
            new RefRoleStatus { Id=Guid.Parse("f1714c92-f959-4c2a-8a03-a2e3064896bd"), Code="The person is NOT pursuing certification as a teacher.", SortOrder=4 },
            new RefRoleStatus { Id=Guid.Parse("aab9589f-cb08-4d49-8e6b-ef4a1a827529"), Code="The person is seeking candidacy and pursuing certification as a teacher.", SortOrder=4 },
            new RefRoleStatus { Id=Guid.Parse("77f2ad1f-5726-4832-b7c9-a739e51a5d41"), Code="The person is enrolled in a program and pursuing certification as a teacher.", SortOrder=4 },
            new RefRoleStatus { Id=Guid.Parse("35558b95-8758-410f-8f5d-6750dec1ac64"), Code="Pre-registered is the status related to a student enrollment in an instance of a course.", SortOrder=5 },
            new RefRoleStatus { Id=Guid.Parse("7e5d954c-0762-4e07-a6ec-ed05fbf6298f"), Code="Registered is the status related to a student enrollment in an instance of a course.", SortOrder=5 },
            new RefRoleStatus { Id=Guid.Parse("c5608e9e-fcb2-4cc6-a794-2b5819d2fffc"), Code="Enrolled is the status related to a student enrollment in an instance of a course.", SortOrder=5 },
            new RefRoleStatus { Id=Guid.Parse("ba212b33-92f2-4ce0-9428-aa7a34aa2e0a"), Code="Wait Listed is the status related to a student enrollment in an instance of a course.", SortOrder=5 },
            new RefRoleStatus { Id=Guid.Parse("b19109f8-d08d-474c-b47b-83192dfdeb65"), Code="Dropped is the status related to a student enrollment in an instance of a course.", SortOrder=5 },
            new RefRoleStatus { Id=Guid.Parse("e298f48c-1e04-4d92-acd2-9b5a8f65c5ba"), Code="Completed is the status related to a student enrollment in an instance of a course.", SortOrder=5 },
       };
   }
}
