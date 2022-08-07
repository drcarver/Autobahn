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
        /// The complete <see cref="RefCourseInstructionMethodModel"> List
         /// </summary>
        public static List<RefCourseInstructionMethodModel> RefCourseInstructionMethodList = new List<RefCourseInstructionMethodModel>
        {
            new RefCourseInstructionMethod { Id=Guid.Parse("012558af-f775-4389-9246-feda2549fd8d"), Code="Lecture", Description="Lecture", Definition="Lecture is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("1c6433e6-154c-49b4-8ec6-9e9af8fe8f1f"), Code="Laboratory", Description="Laboratory", Definition="Laboratory is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("3b568ed7-02bc-4f4e-8c1c-d8d41b040b68"), Code="Seminar", Description="Seminar", Definition="Seminar is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("e2cc058f-1cba-4c85-a29e-408e0fb9c548"), Code="IndependentStudy", Description="Independent Study", Definition="Independent Study is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("10d0ed0d-74e0-4efe-969a-ed961a4fc3b6"), Code="PrivateStudy", Description="Private Study", Definition="Private Study is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("10.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("5c234bec-c59a-4800-98fb-8acf5888696c"), Code="PracticeTeaching", Description="Practice Teaching", Definition="Practice Teaching is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("12.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("c417740c-c9ac-48ec-940f-a959f03a0153"), Code="Internship", Description="Internship", Definition="Internship is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("14.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("ee502dac-7a3f-4dd6-bf20-92d71bd4c2ca"), Code="Practicum", Description="Practicum", Definition="Practicum is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("16.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("3e89fb85-dac8-4005-b60a-084d43ebb90a"), Code="ApprenticeshipExternship", Description="Apprenticeship Externship", Definition="Apprenticeship Externship is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("18.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("dfd29866-8943-44e3-8328-018054456a74"), Code="AppliedInstruction", Description="Applied Instruction", Definition="Applied Instruction is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("20.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("8a533bb5-5eff-49fb-9db9-ce9ee97f5987"), Code="Residency", Description="Residency", Definition="Residency is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("22.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("98c43664-00d7-4213-b59a-6e97bc9ca7e4"), Code="ClinicalRotationInstruction", Description="Clinical Rotation Instruction", Definition="Clinical Rotation Instruction is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("24.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("a10d25b5-1a18-4535-95c0-5d80859cb3cc"), Code="SelfPaced", Description="Self Paced", Definition="Self Paced is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("26.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("2bb728d6-d3b1-4524-8f51-4b8c2a72516d"), Code="FieldStudy", Description="Field Study", Definition="Field Study is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("28.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("43ca6b14-3351-41fa-b65c-8bafcc476b04"), Code="InternetInstruction", Description="Internet Instruction", Definition="Internet Instruction is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("30.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("580bb89e-2965-49b5-a42c-6898fb95e57a"), Code="InteractiveVideo", Description="Interactive Video", Definition="Interactive Video is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("32.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("79dcd0c2-9725-4f09-9179-579c318fd052"), Code="Videotape", Description="Videotape", Definition="Videotape is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("34.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("9c58a392-ba7b-4de9-9550-c49e6aa0a316"), Code="Television", Description="Television", Definition="Television is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("36.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("2541dbe5-4f9c-4576-bd99-9126c4a3efe7"), Code="OtherDistanceLearning", Description="Other Distance Learning", Definition="Other Distance Learning is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("38.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("c502ed25-db0d-438a-b735-9363cb27c352"), Code="Audiotape", Description="Audiotape", Definition="Audiotape is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("40.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("1e330ef1-55c0-423c-a1c0-62c6a69dc68e"), Code="ComputerBasedInstruction", Description="Computer Based Instruction", Definition="Computer Based Instruction is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("42.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("74224be2-3316-4a58-8d21-5dce0a0a25f9"), Code="CompressedVideo", Description="Compressed Video", Definition="Compressed Video is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("44.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("74da0486-b056-45b7-be4c-16356d8f76de"), Code="Correspondence", Description="Correspondence", Definition="Correspondence is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("46.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("0fa2cbdc-3f98-41a4-bfc3-3df2e3ead524"), Code="CooperativeEducation", Description="Cooperative Education", Definition="Cooperative Education is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("48.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("4a77bad2-1d84-4948-a685-1c9cbe9d731c"), Code="WorkStudy", Description="Work Study", Definition="Work Study is the primary method of instruction used for the course.", SortOrder=Convert.ToDecimal("50.00") },
        };

        /// <summary>
        /// The Reference RefCourseInstructionMethod Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCourseInstructionMethodViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCourseInstructionMethod { Id=Guid.Parse("012558af-f775-4389-9246-feda2549fd8d"), Description="Lecture", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("1c6433e6-154c-49b4-8ec6-9e9af8fe8f1f"), Description="Laboratory", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("3b568ed7-02bc-4f4e-8c1c-d8d41b040b68"), Description="Seminar", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("e2cc058f-1cba-4c85-a29e-408e0fb9c548"), Description="Independent Study", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("10d0ed0d-74e0-4efe-969a-ed961a4fc3b6"), Description="Private Study", SortOrder=Convert.ToDecimal("10.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("5c234bec-c59a-4800-98fb-8acf5888696c"), Description="Practice Teaching", SortOrder=Convert.ToDecimal("12.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("c417740c-c9ac-48ec-940f-a959f03a0153"), Description="Internship", SortOrder=Convert.ToDecimal("14.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("ee502dac-7a3f-4dd6-bf20-92d71bd4c2ca"), Description="Practicum", SortOrder=Convert.ToDecimal("16.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("3e89fb85-dac8-4005-b60a-084d43ebb90a"), Description="Apprenticeship Externship", SortOrder=Convert.ToDecimal("18.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("dfd29866-8943-44e3-8328-018054456a74"), Description="Applied Instruction", SortOrder=Convert.ToDecimal("20.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("8a533bb5-5eff-49fb-9db9-ce9ee97f5987"), Description="Residency", SortOrder=Convert.ToDecimal("22.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("98c43664-00d7-4213-b59a-6e97bc9ca7e4"), Description="Clinical Rotation Instruction", SortOrder=Convert.ToDecimal("24.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("a10d25b5-1a18-4535-95c0-5d80859cb3cc"), Description="Self Paced", SortOrder=Convert.ToDecimal("26.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("2bb728d6-d3b1-4524-8f51-4b8c2a72516d"), Description="Field Study", SortOrder=Convert.ToDecimal("28.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("43ca6b14-3351-41fa-b65c-8bafcc476b04"), Description="Internet Instruction", SortOrder=Convert.ToDecimal("30.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("580bb89e-2965-49b5-a42c-6898fb95e57a"), Description="Interactive Video", SortOrder=Convert.ToDecimal("32.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("79dcd0c2-9725-4f09-9179-579c318fd052"), Description="Videotape", SortOrder=Convert.ToDecimal("34.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("9c58a392-ba7b-4de9-9550-c49e6aa0a316"), Description="Television", SortOrder=Convert.ToDecimal("36.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("2541dbe5-4f9c-4576-bd99-9126c4a3efe7"), Description="Other Distance Learning", SortOrder=Convert.ToDecimal("38.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("c502ed25-db0d-438a-b735-9363cb27c352"), Description="Audiotape", SortOrder=Convert.ToDecimal("40.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("1e330ef1-55c0-423c-a1c0-62c6a69dc68e"), Description="Computer Based Instruction", SortOrder=Convert.ToDecimal("42.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("74224be2-3316-4a58-8d21-5dce0a0a25f9"), Description="Compressed Video", SortOrder=Convert.ToDecimal("44.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("74da0486-b056-45b7-be4c-16356d8f76de"), Description="Correspondence", SortOrder=Convert.ToDecimal("46.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("0fa2cbdc-3f98-41a4-bfc3-3df2e3ead524"), Description="Cooperative Education", SortOrder=Convert.ToDecimal("48.00") },
            new RefCourseInstructionMethod { Id=Guid.Parse("4a77bad2-1d84-4948-a685-1c9cbe9d731c"), Description="Work Study", SortOrder=Convert.ToDecimal("50.00") },
       };
   }
}
