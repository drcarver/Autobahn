//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefRoleStatusList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefRoleStatus Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefRoleStatusModel"> List
         /// </summary>
        public static List<RefRoleStatusModel> RefRoleStatusList = new List<RefRoleStatusModel>
        {
            new RefRoleStatus { Id=Guid.Parse("c5841392-98ca-4d3f-a9f9-ac7c58313118"), Code="01812", Description="Concurrently enrolled", Definition="The student is concurrently enrolled.", SortOrder=Convert.ToDecimal("1.00") },
            new RefRoleStatus { Id=Guid.Parse("4a5ebd95-54c6-4ff7-aff0-de6eb251d3fc"), Code="01811", Description="Currently enrolled", Definition="The student is currently enrolled.", SortOrder=Convert.ToDecimal("2.00") },
            new RefRoleStatus { Id=Guid.Parse("bd8f0211-4db5-4706-a8b7-7cdd95dd9a97"), Code="01810", Description="Previously enrolled", Definition="The student was previously enrolled.", SortOrder=Convert.ToDecimal("3.00") },
            new RefRoleStatus { Id=Guid.Parse("5a3b2f24-af74-499f-92f9-a6aad8a58f8e"), Code="01813", Description="Transferring (will enroll)", Definition="The student is transferring (will enroll).", SortOrder=Convert.ToDecimal("4.00") },
            new RefRoleStatus { Id=Guid.Parse("8d0bf3c1-a713-428e-b9c9-098d450c22af"), Code="01", Description="Full-time", Definition="The student is enrolled full-time as defined by the institution for the specified term. ", SortOrder=Convert.ToDecimal("1.00") },
            new RefRoleStatus { Id=Guid.Parse("5d866f5a-cbc6-487a-b1e2-b08ddaa92672"), Code="02", Description="Less than full-time but at least half-time", Definition="The student is enrolled less than full-time but at least half-time as defined by the institution for the specified term. ", SortOrder=Convert.ToDecimal("2.00") },
            new RefRoleStatus { Id=Guid.Parse("57872ecd-26cd-4561-8acb-88fc2d3210f5"), Code="03", Description="Less than half-time", Definition="The student is enrolled Less than half-time as defined by the institution for the specified term. ", SortOrder=Convert.ToDecimal("3.00") },
            new RefRoleStatus { Id=Guid.Parse("d57fa920-3d79-476d-b68b-ef0f24156a9c"), Code="04", Description="Less than full-time but at least three quarter-time", Definition="The student is enrolled Less than full-time but at least three quarter-time as defined by the institution for the specified term. ", SortOrder=Convert.ToDecimal("5.00") },
            new RefRoleStatus { Id=Guid.Parse("dd4b3115-2b45-4f87-9823-483fe058d73a"), Code="05", Description="Less than three quarter-time but at least half-time", Definition="The student is enrolled Less than three quarter-time but at least half-time as defined by the institution for the specified term. ", SortOrder=Convert.ToDecimal("7.00") },
            new RefRoleStatus { Id=Guid.Parse("60f82b20-300a-4ee9-b0c6-a491132ce0f4"), Code="01384", Description="Contingent upon funding", Definition="Contingent upon funding is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("1.00") },
            new RefRoleStatus { Id=Guid.Parse("734f2c42-c000-4341-81f4-e261c17a846f"), Code="01379", Description="Contractual", Definition="Contractual is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("2.00") },
            new RefRoleStatus { Id=Guid.Parse("72a206ab-412d-4f8b-a13b-4b81c88bd6fe"), Code="06071", Description="Employed or affiliated with outside agency part-time", Definition="Employed or affiliated with outside agency part-time is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("3.00") },
            new RefRoleStatus { Id=Guid.Parse("e4106edc-8f5a-4b4a-9791-639dcdb510cc"), Code="01383", Description="Employed or affiliated with outside organization", Definition="Employed or affiliated with outside organization is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("4.00") },
            new RefRoleStatus { Id=Guid.Parse("37bf9a6b-887e-48b1-b73c-58f956d45284"), Code="01385", Description="Non-contractual", Definition="Non-contractual is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("5.00") },
            new RefRoleStatus { Id=Guid.Parse("3989a00d-b717-4c8f-af33-c7718b64c60f"), Code="09999", Description="Other", Definition="Other is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("6.00") },
            new RefRoleStatus { Id=Guid.Parse("03121381-8648-45ab-a71e-ec344a24099e"), Code="01378", Description="Probationary", Definition="Probationary is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("7.00") },
            new RefRoleStatus { Id=Guid.Parse("2e514a92-9171-48e9-ba5e-735246cfd2fc"), Code="06070", Description="Self-employed part-time", Definition="Self-employed part-time is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("8.00") },
            new RefRoleStatus { Id=Guid.Parse("285f550e-7d1a-4bec-b3ce-05beb0ab2bb5"), Code="01380", Description="Substitute/temporary", Definition="Substitute/temporary is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("9.00") },
            new RefRoleStatus { Id=Guid.Parse("eb74392e-be74-4e01-9a14-f235ee1395ff"), Code="01381", Description="Tenured or permanent", Definition="Tenured or permanent is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("10.00") },
            new RefRoleStatus { Id=Guid.Parse("87c4b91d-e84b-4847-a4f3-fa6088fe17bd"), Code="01382", Description="Volunteer/no contract", Definition="Volunteer/no contract is the condition under which a person has agreed to serve as an employee.", SortOrder=Convert.ToDecimal("11.00") },
            new RefRoleStatus { Id=Guid.Parse("32522a41-3d9a-4c86-a542-aa4d8ce5e99a"), Code="No", Description="No", Definition="The person is NOT pursuing certification as a teacher.", SortOrder=Convert.ToDecimal("1.00") },
            new RefRoleStatus { Id=Guid.Parse("c59dcaba-99fa-4ad9-8a4d-d89fc2f9000b"), Code="SeekingCandidacy", Description="Seeking Candidacy", Definition="The person is seeking candidacy and pursuing certification as a teacher.", SortOrder=Convert.ToDecimal("2.00") },
            new RefRoleStatus { Id=Guid.Parse("48d58678-1ab2-4d98-9759-741a1d4bca96"), Code="Enrolled", Description="Enrolled", Definition="The person is enrolled in a program and pursuing certification as a teacher.", SortOrder=Convert.ToDecimal("3.00") },
            new RefRoleStatus { Id=Guid.Parse("45613ea1-88af-4a38-9e89-194e518a89e9"), Code="Pre-registered", Description="Pre-registered", Definition="Pre-registered is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("1.00") },
            new RefRoleStatus { Id=Guid.Parse("525322d1-5d2c-4a71-a4eb-4bbacbf01ec2"), Code="Registered", Description="Registered", Definition="Registered is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("2.00") },
            new RefRoleStatus { Id=Guid.Parse("f028eba0-555c-4ad9-ac1c-8d369c2b16bb"), Code="Enrolled", Description="Enrolled", Definition="Enrolled is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("3.00") },
            new RefRoleStatus { Id=Guid.Parse("17811357-795b-441c-baf6-26bfc8184ffb"), Code="WaitListed", Description="Wait Listed", Definition="Wait Listed is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("4.00") },
            new RefRoleStatus { Id=Guid.Parse("eb4d073b-0c84-4ee1-8464-80e2416b0bcb"), Code="Dropped", Description="Dropped", Definition="Dropped is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("5.00") },
            new RefRoleStatus { Id=Guid.Parse("eccf8634-0e1f-40ee-9450-4d7b1a6b076c"), Code="Completed", Description="Completed", Definition="Completed is the status related to a student enrollment in an instance of a course.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The Reference RefRoleStatus Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefRoleStatusViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefRoleStatus { Id=Guid.Parse("c5841392-98ca-4d3f-a9f9-ac7c58313118"), Description="Concurrently enrolled", SortOrder=Convert.ToDecimal("1.00") },
            new RefRoleStatus { Id=Guid.Parse("4a5ebd95-54c6-4ff7-aff0-de6eb251d3fc"), Description="Currently enrolled", SortOrder=Convert.ToDecimal("2.00") },
            new RefRoleStatus { Id=Guid.Parse("bd8f0211-4db5-4706-a8b7-7cdd95dd9a97"), Description="Previously enrolled", SortOrder=Convert.ToDecimal("3.00") },
            new RefRoleStatus { Id=Guid.Parse("5a3b2f24-af74-499f-92f9-a6aad8a58f8e"), Description="Transferring (will enroll)", SortOrder=Convert.ToDecimal("4.00") },
            new RefRoleStatus { Id=Guid.Parse("8d0bf3c1-a713-428e-b9c9-098d450c22af"), Description="Full-time", SortOrder=Convert.ToDecimal("1.00") },
            new RefRoleStatus { Id=Guid.Parse("5d866f5a-cbc6-487a-b1e2-b08ddaa92672"), Description="Less than full-time but at least half-time", SortOrder=Convert.ToDecimal("2.00") },
            new RefRoleStatus { Id=Guid.Parse("57872ecd-26cd-4561-8acb-88fc2d3210f5"), Description="Less than half-time", SortOrder=Convert.ToDecimal("3.00") },
            new RefRoleStatus { Id=Guid.Parse("d57fa920-3d79-476d-b68b-ef0f24156a9c"), Description="Less than full-time but at least three quarter-time", SortOrder=Convert.ToDecimal("5.00") },
            new RefRoleStatus { Id=Guid.Parse("dd4b3115-2b45-4f87-9823-483fe058d73a"), Description="Less than three quarter-time but at least half-time", SortOrder=Convert.ToDecimal("7.00") },
            new RefRoleStatus { Id=Guid.Parse("60f82b20-300a-4ee9-b0c6-a491132ce0f4"), Description="Contingent upon funding", SortOrder=Convert.ToDecimal("1.00") },
            new RefRoleStatus { Id=Guid.Parse("734f2c42-c000-4341-81f4-e261c17a846f"), Description="Contractual", SortOrder=Convert.ToDecimal("2.00") },
            new RefRoleStatus { Id=Guid.Parse("72a206ab-412d-4f8b-a13b-4b81c88bd6fe"), Description="Employed or affiliated with outside agency part-time", SortOrder=Convert.ToDecimal("3.00") },
            new RefRoleStatus { Id=Guid.Parse("e4106edc-8f5a-4b4a-9791-639dcdb510cc"), Description="Employed or affiliated with outside organization", SortOrder=Convert.ToDecimal("4.00") },
            new RefRoleStatus { Id=Guid.Parse("37bf9a6b-887e-48b1-b73c-58f956d45284"), Description="Non-contractual", SortOrder=Convert.ToDecimal("5.00") },
            new RefRoleStatus { Id=Guid.Parse("3989a00d-b717-4c8f-af33-c7718b64c60f"), Description="Other", SortOrder=Convert.ToDecimal("6.00") },
            new RefRoleStatus { Id=Guid.Parse("03121381-8648-45ab-a71e-ec344a24099e"), Description="Probationary", SortOrder=Convert.ToDecimal("7.00") },
            new RefRoleStatus { Id=Guid.Parse("2e514a92-9171-48e9-ba5e-735246cfd2fc"), Description="Self-employed part-time", SortOrder=Convert.ToDecimal("8.00") },
            new RefRoleStatus { Id=Guid.Parse("285f550e-7d1a-4bec-b3ce-05beb0ab2bb5"), Description="Substitute/temporary", SortOrder=Convert.ToDecimal("9.00") },
            new RefRoleStatus { Id=Guid.Parse("eb74392e-be74-4e01-9a14-f235ee1395ff"), Description="Tenured or permanent", SortOrder=Convert.ToDecimal("10.00") },
            new RefRoleStatus { Id=Guid.Parse("87c4b91d-e84b-4847-a4f3-fa6088fe17bd"), Description="Volunteer/no contract", SortOrder=Convert.ToDecimal("11.00") },
            new RefRoleStatus { Id=Guid.Parse("32522a41-3d9a-4c86-a542-aa4d8ce5e99a"), Description="No", SortOrder=Convert.ToDecimal("1.00") },
            new RefRoleStatus { Id=Guid.Parse("c59dcaba-99fa-4ad9-8a4d-d89fc2f9000b"), Description="Seeking Candidacy", SortOrder=Convert.ToDecimal("2.00") },
            new RefRoleStatus { Id=Guid.Parse("48d58678-1ab2-4d98-9759-741a1d4bca96"), Description="Enrolled", SortOrder=Convert.ToDecimal("3.00") },
            new RefRoleStatus { Id=Guid.Parse("45613ea1-88af-4a38-9e89-194e518a89e9"), Description="Pre-registered", SortOrder=Convert.ToDecimal("1.00") },
            new RefRoleStatus { Id=Guid.Parse("525322d1-5d2c-4a71-a4eb-4bbacbf01ec2"), Description="Registered", SortOrder=Convert.ToDecimal("2.00") },
            new RefRoleStatus { Id=Guid.Parse("f028eba0-555c-4ad9-ac1c-8d369c2b16bb"), Description="Enrolled", SortOrder=Convert.ToDecimal("3.00") },
            new RefRoleStatus { Id=Guid.Parse("17811357-795b-441c-baf6-26bfc8184ffb"), Description="Wait Listed", SortOrder=Convert.ToDecimal("4.00") },
            new RefRoleStatus { Id=Guid.Parse("eb4d073b-0c84-4ee1-8464-80e2416b0bcb"), Description="Dropped", SortOrder=Convert.ToDecimal("5.00") },
            new RefRoleStatus { Id=Guid.Parse("eccf8634-0e1f-40ee-9450-4d7b1a6b076c"), Description="Completed", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
