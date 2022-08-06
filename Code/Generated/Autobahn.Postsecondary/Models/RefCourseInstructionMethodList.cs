//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefCourseInstructionMethodList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefCourseInstructionMethod Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseInstructionMethod"> List
         /// </summary>
        public static List<RefCourseInstructionMethod> RefCourseInstructionMethodList = new List<RefCourseInstructionMethod>
        {
            new RefCourseInstructionMethod { Id=Guid.Parse("ac47cfea-b489-4ea3-a2fc-26740a7c320a"), Code="Lecture", Description="Lecture", Definition="Lecture is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("5fe0817c-efb9-4ba9-992d-82840c48f530"), Code="Laboratory", Description="Laboratory", Definition="Laboratory is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("87a2c2c9-6ba6-4a58-8a85-6bcbb070cc28"), Code="Seminar", Description="Seminar", Definition="Seminar is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("2802417b-9368-49a8-809c-5db4ebdd12e7"), Code="IndependentStudy", Description="Independent Study", Definition="Independent Study is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("6696abf1-dcc5-48a1-a1ac-089edbcf6683"), Code="PrivateStudy", Description="Private Study", Definition="Private Study is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("10.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("aa60f348-4e87-44b7-a5fc-8f5756fe7f70"), Code="PracticeTeaching", Description="Practice Teaching", Definition="Practice Teaching is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("12.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("ee736ef6-c6a7-4843-956b-75fe5f6c6bad"), Code="Internship", Description="Internship", Definition="Internship is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("14.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("a44a3f7a-a773-45fa-bb80-caf43a53b766"), Code="Practicum", Description="Practicum", Definition="Practicum is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("16.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("5dcd2bdc-3ff5-4aca-980d-b75c2ddd62b3"), Code="ApprenticeshipExternship", Description="Apprenticeship Externship", Definition="Apprenticeship Externship is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("18.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("898be5f9-feb9-4b44-811c-28955968280d"), Code="AppliedInstruction", Description="Applied Instruction", Definition="Applied Instruction is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("20.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("47e970bf-5802-4fb5-8964-fa9c45f61a4b"), Code="Residency", Description="Residency", Definition="Residency is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("22.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("b32de753-cd57-40f4-b183-ad185d94c5af"), Code="ClinicalRotationInstruction", Description="Clinical Rotation Instruction", Definition="Clinical Rotation Instruction is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("24.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("3631215e-3e26-44c7-89f3-a801d6cb4086"), Code="SelfPaced", Description="Self Paced", Definition="Self Paced is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("26.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("81775fe5-ceba-426d-8347-9d85083b77ae"), Code="FieldStudy", Description="Field Study", Definition="Field Study is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("28.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("3616e9ad-e3fb-4b21-8691-125c4a8bfa13"), Code="InternetInstruction", Description="Internet Instruction", Definition="Internet Instruction is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("30.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("4564ee40-4590-47af-9f7d-d42512b34e8e"), Code="InteractiveVideo", Description="Interactive Video", Definition="Interactive Video is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("32.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("e65c3a67-f5c9-46e4-9b9e-cbd325c6603f"), Code="Videotape", Description="Videotape", Definition="Videotape is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("34.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("8488b4ee-395e-434c-ae4d-cb420d6dc1ba"), Code="Television", Description="Television", Definition="Television is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("36.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("eb53734f-264a-482a-bb1d-9afb190f5f9b"), Code="OtherDistanceLearning", Description="Other Distance Learning", Definition="Other Distance Learning is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("38.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("8602cb6d-19da-4a0f-97e1-38db140c4748"), Code="Audiotape", Description="Audiotape", Definition="Audiotape is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("40.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("51706d26-4868-477b-9400-c0bd2cd3f0bf"), Code="ComputerBasedInstruction", Description="Computer Based Instruction", Definition="Computer Based Instruction is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("42.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("09f5cd4b-06cc-4a70-ac3e-66d9997ba11d"), Code="CompressedVideo", Description="Compressed Video", Definition="Compressed Video is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("44.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("cffad056-7d2d-40cf-81fb-d7af2d491dec"), Code="Correspondence", Description="Correspondence", Definition="Correspondence is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("46.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("221f447a-232a-447e-9ed4-968e99debf5c"), Code="CooperativeEducation", Description="Cooperative Education", Definition="Cooperative Education is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("48.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("5ed0aa9e-9e21-457e-b011-78a405b68140"), Code="WorkStudy", Description="Work Study", Definition="Work Study is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("50.00") },
        };

        /// <summary>
        /// The RefCourseInstructionMethod Pick List
         /// </summary>
        public static List<RefCourseInstructionMethod> RefCourseInstructionMethodPickList = new List<RefCourseInstructionMethod>
        {
            new RefCourseInstructionMethod { Id=Guid.Parse("ac47cfea-b489-4ea3-a2fc-26740a7c320a"), Code="Lecture", Description="Lecture", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("5fe0817c-efb9-4ba9-992d-82840c48f530"), Code="Laboratory", Description="Laboratory", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("87a2c2c9-6ba6-4a58-8a85-6bcbb070cc28"), Code="Seminar", Description="Seminar", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("2802417b-9368-49a8-809c-5db4ebdd12e7"), Code="IndependentStudy", Description="Independent Study", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("6696abf1-dcc5-48a1-a1ac-089edbcf6683"), Code="PrivateStudy", Description="Private Study", SortOrder=Convert.ToDecimal("10.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("aa60f348-4e87-44b7-a5fc-8f5756fe7f70"), Code="PracticeTeaching", Description="Practice Teaching", SortOrder=Convert.ToDecimal("12.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("ee736ef6-c6a7-4843-956b-75fe5f6c6bad"), Code="Internship", Description="Internship", SortOrder=Convert.ToDecimal("14.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("a44a3f7a-a773-45fa-bb80-caf43a53b766"), Code="Practicum", Description="Practicum", SortOrder=Convert.ToDecimal("16.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("5dcd2bdc-3ff5-4aca-980d-b75c2ddd62b3"), Code="ApprenticeshipExternship", Description="Apprenticeship Externship", SortOrder=Convert.ToDecimal("18.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("898be5f9-feb9-4b44-811c-28955968280d"), Code="AppliedInstruction", Description="Applied Instruction", SortOrder=Convert.ToDecimal("20.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("47e970bf-5802-4fb5-8964-fa9c45f61a4b"), Code="Residency", Description="Residency", SortOrder=Convert.ToDecimal("22.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("b32de753-cd57-40f4-b183-ad185d94c5af"), Code="ClinicalRotationInstruction", Description="Clinical Rotation Instruction", SortOrder=Convert.ToDecimal("24.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("3631215e-3e26-44c7-89f3-a801d6cb4086"), Code="SelfPaced", Description="Self Paced", SortOrder=Convert.ToDecimal("26.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("81775fe5-ceba-426d-8347-9d85083b77ae"), Code="FieldStudy", Description="Field Study", SortOrder=Convert.ToDecimal("28.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("3616e9ad-e3fb-4b21-8691-125c4a8bfa13"), Code="InternetInstruction", Description="Internet Instruction", SortOrder=Convert.ToDecimal("30.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("4564ee40-4590-47af-9f7d-d42512b34e8e"), Code="InteractiveVideo", Description="Interactive Video", SortOrder=Convert.ToDecimal("32.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("e65c3a67-f5c9-46e4-9b9e-cbd325c6603f"), Code="Videotape", Description="Videotape", SortOrder=Convert.ToDecimal("34.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("8488b4ee-395e-434c-ae4d-cb420d6dc1ba"), Code="Television", Description="Television", SortOrder=Convert.ToDecimal("36.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("eb53734f-264a-482a-bb1d-9afb190f5f9b"), Code="OtherDistanceLearning", Description="Other Distance Learning", SortOrder=Convert.ToDecimal("38.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("8602cb6d-19da-4a0f-97e1-38db140c4748"), Code="Audiotape", Description="Audiotape", SortOrder=Convert.ToDecimal("40.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("51706d26-4868-477b-9400-c0bd2cd3f0bf"), Code="ComputerBasedInstruction", Description="Computer Based Instruction", SortOrder=Convert.ToDecimal("42.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("09f5cd4b-06cc-4a70-ac3e-66d9997ba11d"), Code="CompressedVideo", Description="Compressed Video", SortOrder=Convert.ToDecimal("44.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("cffad056-7d2d-40cf-81fb-d7af2d491dec"), Code="Correspondence", Description="Correspondence", SortOrder=Convert.ToDecimal("46.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("221f447a-232a-447e-9ed4-968e99debf5c"), Code="CooperativeEducation", Description="Cooperative Education", SortOrder=Convert.ToDecimal("48.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("5ed0aa9e-9e21-457e-b011-78a405b68140"), Code="WorkStudy", Description="Work Study", SortOrder=Convert.ToDecimal("50.00") },
       };
   }
}
