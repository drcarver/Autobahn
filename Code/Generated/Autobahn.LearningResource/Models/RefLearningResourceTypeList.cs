//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   RefLearningResourceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The list of RefLearningResourceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearningResourceType"> List
         /// </summary>
        public static List<RefLearningResourceType> RefLearningResourceTypeList = new List<RefLearningResourceType>
        {
            new RefLearningResourceType { Id=Guid.Parse("bd0ea64b-8211-41a9-8576-e2b633b8ba80"), Code="AlternateAssessment", Description="Alternate Assessment", Definition="An assessment that is used to evaluate the performance of students who are unable to participate in general state assessments even with accommodations.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceType { Id=Guid.Parse("c03d4f8f-8deb-4bc1-9e1d-729d3fea5e0f"), Code="AssessmentItem", Description="Assessment Item", Definition="A specific prompt, that defines a question or protocol for a measurable activity that triggers a response from a person used to determine whether the person has mastered a learning objective.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceType { Id=Guid.Parse("76665b46-ad8c-48d2-9621-7317576c416e"), Code="Course", Description="Course", Definition="A series of units and lessons used to teach the skills and knowledge required by its curriculum.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceType { Id=Guid.Parse("7a5e1876-837b-40db-82c4-8b8d87c00379"), Code="DemonstrationSimulation", Description="Demonstration/Simulation", Definition="An imitation or modeling of a real-world process.", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceType { Id=Guid.Parse("60a8ff0e-2e29-48fd-a635-7dac52de6f93"), Code="EducatorCurriculumGuide", Description="Educator/Curriculum Guide", Definition="A document that defines what concepts should be taught and/or how a concept should be taught effectively.", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearningResourceType { Id=Guid.Parse("42d38fde-f33d-4c35-a91a-bea31c263c30"), Code="FormativeAssessment", Description="Formative assessment", Definition="A process used by teachers and students during instruction that provides feedback to adjust ongoing teaching and learning to improve students' achievement of intended instructional outcomes. (CCSSO FAST SCASS, 2006)", SortOrder=Convert.ToDecimal("12.00") },
            new RefLearningResourceType { Id=Guid.Parse("2db36f52-2813-4cdd-899e-36c569ac586c"), Code="ImagesVisuals", Description="Images/Visuals", Definition="Visual media, including but not limited to pictures, graphics, diagrams, figures, illustrations, charts, and maps.", SortOrder=Convert.ToDecimal("14.00") },
            new RefLearningResourceType { Id=Guid.Parse("9efb9dcf-8cda-4e69-a635-596f4a2620db"), Code="InterimSummativeAssessment", Description="Interim/Summative Assessment", Definition="An assessment instrument used to�evaluate student learning�at the end of an instructional unit by comparing it against some standard or benchmark. A learning resource of this type may be an \u0022assessment form,\u0022 i.e. one instance of the assessment instrument that can equate scores with another instance of the same assessment.", SortOrder=Convert.ToDecimal("18.00") },
            new RefLearningResourceType { Id=Guid.Parse("d2cefbb5-19ce-4cce-8c35-ed1cee8637ac"), Code="LearningActivity", Description="Learning Activity", Definition="Activities engaged in by the learner for the purpose of acquiring certain skills, concepts, or knowledge, whether guided by an instructor or not.  A Lesson may define one or more learning activities.", SortOrder=Convert.ToDecimal("22.00") },
            new RefLearningResourceType { Id=Guid.Parse("97c5b347-70de-46ae-9633-cb4eb4618d60"), Code="Lesson", Description="Lesson", Definition="A detailed description of the course of instruction for a -short period of time that is used by a teacher to guide class instruction.� A Unit contains one or more lessons.", SortOrder=Convert.ToDecimal("24.00") },
            new RefLearningResourceType { Id=Guid.Parse("1549eca1-f008-4f15-92f8-12b92f1383f1"), Code="PrimarySource", Description="Primary Source", Definition="An artifact, document, recording, or other source of information that was created at the time under study and provides first-hand testimony or direct evidence concerning a topic under investigation.", SortOrder=Convert.ToDecimal("26.00") },
            new RefLearningResourceType { Id=Guid.Parse("b19cd69d-77e1-406c-82ce-698af081d5e0"), Code="RubricScoringGuide", Description="Rubric/Scoring Guide", Definition="A document or guide that is used to delineate consistent criteria for grading.", SortOrder=Convert.ToDecimal("28.00") },
            new RefLearningResourceType { Id=Guid.Parse("175112e3-8df6-4500-b92c-295748f246d2"), Code="SelfAssessment", Description="Self Assessment", Definition="An assessment in which the user gathers information about and reflects on his or her own knowledge, skills, learning, or attitudes.", SortOrder=Convert.ToDecimal("32.00") },
            new RefLearningResourceType { Id=Guid.Parse("b4e68731-2130-417b-b331-d4b26e8c1ad0"), Code="Text", Description="Text", Definition="The body of a printed work, to include reading passages.", SortOrder=Convert.ToDecimal("34.00") },
            new RefLearningResourceType { Id=Guid.Parse("1919e838-bbdf-43ea-a93c-b5d8852fd7b0"), Code="Textbook", Description="Textbook", Definition="A book used as a standard source of information on a particular subject.", SortOrder=Convert.ToDecimal("36.00") },
            new RefLearningResourceType { Id=Guid.Parse("de5ccf96-373b-48fb-9dff-00ac5955f2af"), Code="Unit", Description="Unit", Definition="A long-range plan of instruction on a particular concept; it contains multiple lessons that are related.", SortOrder=Convert.ToDecimal("38.00") },
            new RefLearningResourceType { Id=Guid.Parse("cad1f063-6b0a-47c4-b466-57eb325d256f"), Code="Other", Description="Other", Definition="A type of learning resource in a category not yet defined by CEDS. ", SortOrder=Convert.ToDecimal("40.00") },
        };

        /// <summary>
        /// The RefLearningResourceType Pick List
         /// </summary>
        public static List<RefLearningResourceType> RefLearningResourceTypePickList = new List<RefLearningResourceType>
        {
            new RefLearningResourceType { Id=Guid.Parse("bd0ea64b-8211-41a9-8576-e2b633b8ba80"), Code="AlternateAssessment", Description="Alternate Assessment", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceType { Id=Guid.Parse("c03d4f8f-8deb-4bc1-9e1d-729d3fea5e0f"), Code="AssessmentItem", Description="Assessment Item", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceType { Id=Guid.Parse("76665b46-ad8c-48d2-9621-7317576c416e"), Code="Course", Description="Course", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceType { Id=Guid.Parse("7a5e1876-837b-40db-82c4-8b8d87c00379"), Code="DemonstrationSimulation", Description="Demonstration/Simulation", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceType { Id=Guid.Parse("60a8ff0e-2e29-48fd-a635-7dac52de6f93"), Code="EducatorCurriculumGuide", Description="Educator/Curriculum Guide", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearningResourceType { Id=Guid.Parse("42d38fde-f33d-4c35-a91a-bea31c263c30"), Code="FormativeAssessment", Description="Formative assessment", SortOrder=Convert.ToDecimal("12.00") },
            new RefLearningResourceType { Id=Guid.Parse("2db36f52-2813-4cdd-899e-36c569ac586c"), Code="ImagesVisuals", Description="Images/Visuals", SortOrder=Convert.ToDecimal("14.00") },
            new RefLearningResourceType { Id=Guid.Parse("9efb9dcf-8cda-4e69-a635-596f4a2620db"), Code="InterimSummativeAssessment", Description="Interim/Summative Assessment", SortOrder=Convert.ToDecimal("18.00") },
            new RefLearningResourceType { Id=Guid.Parse("d2cefbb5-19ce-4cce-8c35-ed1cee8637ac"), Code="LearningActivity", Description="Learning Activity", SortOrder=Convert.ToDecimal("22.00") },
            new RefLearningResourceType { Id=Guid.Parse("97c5b347-70de-46ae-9633-cb4eb4618d60"), Code="Lesson", Description="Lesson", SortOrder=Convert.ToDecimal("24.00") },
            new RefLearningResourceType { Id=Guid.Parse("1549eca1-f008-4f15-92f8-12b92f1383f1"), Code="PrimarySource", Description="Primary Source", SortOrder=Convert.ToDecimal("26.00") },
            new RefLearningResourceType { Id=Guid.Parse("b19cd69d-77e1-406c-82ce-698af081d5e0"), Code="RubricScoringGuide", Description="Rubric/Scoring Guide", SortOrder=Convert.ToDecimal("28.00") },
            new RefLearningResourceType { Id=Guid.Parse("175112e3-8df6-4500-b92c-295748f246d2"), Code="SelfAssessment", Description="Self Assessment", SortOrder=Convert.ToDecimal("32.00") },
            new RefLearningResourceType { Id=Guid.Parse("b4e68731-2130-417b-b331-d4b26e8c1ad0"), Code="Text", Description="Text", SortOrder=Convert.ToDecimal("34.00") },
            new RefLearningResourceType { Id=Guid.Parse("1919e838-bbdf-43ea-a93c-b5d8852fd7b0"), Code="Textbook", Description="Textbook", SortOrder=Convert.ToDecimal("36.00") },
            new RefLearningResourceType { Id=Guid.Parse("de5ccf96-373b-48fb-9dff-00ac5955f2af"), Code="Unit", Description="Unit", SortOrder=Convert.ToDecimal("38.00") },
            new RefLearningResourceType { Id=Guid.Parse("cad1f063-6b0a-47c4-b466-57eb325d256f"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("40.00") },
       };
   }
}
