//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefAcademicHonorTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefAcademicHonorType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAcademicHonorType"> List
         /// </summary>
        public static List<RefAcademicHonorType> RefAcademicHonorTypeList = new List<RefAcademicHonorType>
        {
            new RefAcademicHonorType { Id=Guid.Parse("6f8884d6-2bd1-4f19-8991-cd23ff6ed965"), Code="01985", Description="Honor roll", Definition="Honor roll is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAcademicHonorType { Id=Guid.Parse("4f400fb9-7161-41d8-b500-b9e47e9d9192"), Code="01986", Description="Honor society", Definition="Honor society is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAcademicHonorType { Id=Guid.Parse("9b25aed9-5fe5-4b59-92b6-8002fa963429"), Code="01987", Description="Honorable mention", Definition="Honorable mention is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAcademicHonorType { Id=Guid.Parse("4ff1a256-2b68-412a-b8f4-43d9529affb1"), Code="01988", Description="Honors program", Definition="Honors program is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicHonorType { Id=Guid.Parse("38a8e5de-fffa-4f41-af0e-41983815f102"), Code="73064", Description="National Technical Education Honor Society", Definition="National Technical Education Honor Society is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicHonorType { Id=Guid.Parse("2d9fd7a0-6550-46b6-a826-9a921b528c11"), Code="01989", Description="Prize awards", Definition="Prize awards is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAcademicHonorType { Id=Guid.Parse("a6699d4b-35f1-4cda-8832-2b65c087e0ca"), Code="01991", Description="Scholarships", Definition="Scholarships is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAcademicHonorType { Id=Guid.Parse("257fa38f-5436-4f9b-abba-76c81c2edc7f"), Code="00738", Description="Awarding of units of value", Definition="Awarding of units of value is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAcademicHonorType { Id=Guid.Parse("84f00cf1-8cb6-48d0-820f-c0547a764441"), Code="00740", Description="Citizenship award/recognition", Definition="Citizenship award/recognition is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAcademicHonorType { Id=Guid.Parse("f400a14b-1fba-4467-9f57-2af9ef076389"), Code="00741", Description="Completion of requirement, but no units of value awarded", Definition="Completion of requirement, but no units of value awarded is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAcademicHonorType { Id=Guid.Parse("0979ef2f-cfbd-4462-b140-1235239fc61a"), Code="08692", Description="Attendance award", Definition="Attendance award is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAcademicHonorType { Id=Guid.Parse("560a95dd-b1a5-4818-b418-bce0bbe21fc1"), Code="00742", Description="Certificate", Definition="Certificate is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("11.00") },
            new RefAcademicHonorType { Id=Guid.Parse("57fa01f0-b37f-42f2-b858-b3033b0f1351"), Code="02047", Description="Honor award", Definition="Honor award is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("12.00") },
            new RefAcademicHonorType { Id=Guid.Parse("76a43128-7254-4134-a4e3-6bac4ea1414a"), Code="00744", Description="Letter of student commendation", Definition="Letter of student commendation is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("13.00") },
            new RefAcademicHonorType { Id=Guid.Parse("609c87be-9d15-49e9-95af-89f85d9648f6"), Code="00745", Description="Medals", Definition="Medals is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("14.00") },
            new RefAcademicHonorType { Id=Guid.Parse("02879d43-e8c9-4cd9-9c65-a7d236dc49cd"), Code="08693", Description="National Merit scholar", Definition="National Merit scholar is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("15.00") },
            new RefAcademicHonorType { Id=Guid.Parse("498b6b9e-be7f-48f7-b963-b5eb2b84a64f"), Code="00747", Description="Points", Definition="Points is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("16.00") },
            new RefAcademicHonorType { Id=Guid.Parse("00d73bad-57e0-437a-8ca9-ed363fc1b715"), Code="00748", Description="Promotion or advancement", Definition="Promotion or advancement is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("17.00") },
            new RefAcademicHonorType { Id=Guid.Parse("f6e6a210-00b2-4ac3-a280-fb6496d807c5"), Code="09999", Description="Other", Definition="Other is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("18.00") },
        };

        /// <summary>
        /// The RefAcademicHonorType Pick List
         /// </summary>
        public static List<RefAcademicHonorType> RefAcademicHonorTypePickList = new List<RefAcademicHonorType>
        {
            new RefAcademicHonorType { Id=Guid.Parse("6f8884d6-2bd1-4f19-8991-cd23ff6ed965"), Code="01985", Description="Honor roll", SortOrder=Convert.ToDecimal("1.00") },
            new RefAcademicHonorType { Id=Guid.Parse("4f400fb9-7161-41d8-b500-b9e47e9d9192"), Code="01986", Description="Honor society", SortOrder=Convert.ToDecimal("2.00") },
            new RefAcademicHonorType { Id=Guid.Parse("9b25aed9-5fe5-4b59-92b6-8002fa963429"), Code="01987", Description="Honorable mention", SortOrder=Convert.ToDecimal("3.00") },
            new RefAcademicHonorType { Id=Guid.Parse("4ff1a256-2b68-412a-b8f4-43d9529affb1"), Code="01988", Description="Honors program", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicHonorType { Id=Guid.Parse("38a8e5de-fffa-4f41-af0e-41983815f102"), Code="73064", Description="National Technical Education Honor Society", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicHonorType { Id=Guid.Parse("2d9fd7a0-6550-46b6-a826-9a921b528c11"), Code="01989", Description="Prize awards", SortOrder=Convert.ToDecimal("5.00") },
            new RefAcademicHonorType { Id=Guid.Parse("a6699d4b-35f1-4cda-8832-2b65c087e0ca"), Code="01991", Description="Scholarships", SortOrder=Convert.ToDecimal("6.00") },
            new RefAcademicHonorType { Id=Guid.Parse("257fa38f-5436-4f9b-abba-76c81c2edc7f"), Code="00738", Description="Awarding of units of value", SortOrder=Convert.ToDecimal("7.00") },
            new RefAcademicHonorType { Id=Guid.Parse("84f00cf1-8cb6-48d0-820f-c0547a764441"), Code="00740", Description="Citizenship award/recognition", SortOrder=Convert.ToDecimal("8.00") },
            new RefAcademicHonorType { Id=Guid.Parse("f400a14b-1fba-4467-9f57-2af9ef076389"), Code="00741", Description="Completion of requirement, but no units of value awarded", SortOrder=Convert.ToDecimal("9.00") },
            new RefAcademicHonorType { Id=Guid.Parse("0979ef2f-cfbd-4462-b140-1235239fc61a"), Code="08692", Description="Attendance award", SortOrder=Convert.ToDecimal("10.00") },
            new RefAcademicHonorType { Id=Guid.Parse("560a95dd-b1a5-4818-b418-bce0bbe21fc1"), Code="00742", Description="Certificate", SortOrder=Convert.ToDecimal("11.00") },
            new RefAcademicHonorType { Id=Guid.Parse("57fa01f0-b37f-42f2-b858-b3033b0f1351"), Code="02047", Description="Honor award", SortOrder=Convert.ToDecimal("12.00") },
            new RefAcademicHonorType { Id=Guid.Parse("76a43128-7254-4134-a4e3-6bac4ea1414a"), Code="00744", Description="Letter of student commendation", SortOrder=Convert.ToDecimal("13.00") },
            new RefAcademicHonorType { Id=Guid.Parse("609c87be-9d15-49e9-95af-89f85d9648f6"), Code="00745", Description="Medals", SortOrder=Convert.ToDecimal("14.00") },
            new RefAcademicHonorType { Id=Guid.Parse("02879d43-e8c9-4cd9-9c65-a7d236dc49cd"), Code="08693", Description="National Merit scholar", SortOrder=Convert.ToDecimal("15.00") },
            new RefAcademicHonorType { Id=Guid.Parse("498b6b9e-be7f-48f7-b963-b5eb2b84a64f"), Code="00747", Description="Points", SortOrder=Convert.ToDecimal("16.00") },
            new RefAcademicHonorType { Id=Guid.Parse("00d73bad-57e0-437a-8ca9-ed363fc1b715"), Code="00748", Description="Promotion or advancement", SortOrder=Convert.ToDecimal("17.00") },
            new RefAcademicHonorType { Id=Guid.Parse("f6e6a210-00b2-4ac3-a280-fb6496d807c5"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("18.00") },
       };
   }
}
