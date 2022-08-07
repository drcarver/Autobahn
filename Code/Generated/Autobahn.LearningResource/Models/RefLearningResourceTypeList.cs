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
        /// The complete <see cref="RefLearningResourceTypeModel"> List
         /// </summary>
        public static List<RefLearningResourceTypeModel> RefLearningResourceTypeList = new List<RefLearningResourceTypeModel>
        {
            new RefLearningResourceType { Id=Guid.Parse("cf2cdc2e-16e1-4f27-8bf5-638a9885e736"), Code="AlternateAssessment", Description="Alternate Assessment", Definition="An assessment that is used to evaluate the performance of students who are unable to participate in general state assessments even with accommodations.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceType { Id=Guid.Parse("eaae2b3f-282c-4899-bc30-f0ca7ec06da5"), Code="AssessmentItem", Description="Assessment Item", Definition="A specific prompt, that defines a question or protocol for a measurable activity that triggers a response from a person used to determine whether the person has mastered a learning objective.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceType { Id=Guid.Parse("80299b99-4bf5-4121-93a0-9ad4a3075f6b"), Code="Course", Description="Course", Definition="A series of units and lessons used to teach the skills and knowledge required by its curriculum.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceType { Id=Guid.Parse("f2815d0b-526d-4719-8866-69e56b654b26"), Code="DemonstrationSimulation", Description="Demonstration/Simulation", Definition="An imitation or modeling of a real-world process.", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceType { Id=Guid.Parse("7e647fd3-7f6e-411d-8186-310e28d158b5"), Code="EducatorCurriculumGuide", Description="Educator/Curriculum Guide", Definition="A document that defines what concepts should be taught and/or how a concept should be taught effectively.", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearningResourceType { Id=Guid.Parse("eedb8892-0d24-461d-85d9-d3d680ff119c"), Code="FormativeAssessment", Description="Formative assessment", Definition="A process used by teachers and students during instruction that provides feedback to adjust ongoing teaching and learning to improve students' achievement of intended instructional outcomes. (CCSSO FAST SCASS, 2006)", SortOrder=Convert.ToDecimal("12.00") },
            new RefLearningResourceType { Id=Guid.Parse("d2742ac2-abe4-4060-bf13-b217807c9e5f"), Code="ImagesVisuals", Description="Images/Visuals", Definition="Visual media, including but not limited to pictures, graphics, diagrams, figures, illustrations, charts, and maps.", SortOrder=Convert.ToDecimal("14.00") },
            new RefLearningResourceType { Id=Guid.Parse("ccf248d2-c0ad-4d5e-9d5b-8313ac758831"), Code="InterimSummativeAssessment", Description="Interim/Summative Assessment", Definition="An assessment instrument used to�evaluate student learning�at the end of an instructional unit by comparing it against some standard or benchmark. A learning resource of this type may be an \u0022assessment form,\u0022 i.e. one instance of the assessment instrument that can equate scores with another instance of the same assessment.", SortOrder=Convert.ToDecimal("18.00") },
            new RefLearningResourceType { Id=Guid.Parse("a20908aa-9c9e-4800-acbc-a5be34616d5f"), Code="LearningActivity", Description="Learning Activity", Definition="Activities engaged in by the learner for the purpose of acquiring certain skills, concepts, or knowledge, whether guided by an instructor or not.  A Lesson may define one or more learning activities.", SortOrder=Convert.ToDecimal("22.00") },
            new RefLearningResourceType { Id=Guid.Parse("cc86e434-f24e-41a0-87d5-7eff5cff401d"), Code="Lesson", Description="Lesson", Definition="A detailed description of the course of instruction for a -short period of time that is used by a teacher to guide class instruction.� A Unit contains one or more lessons.", SortOrder=Convert.ToDecimal("24.00") },
            new RefLearningResourceType { Id=Guid.Parse("314127cf-934b-48fe-a4e2-c84d6c5d3a20"), Code="PrimarySource", Description="Primary Source", Definition="An artifact, document, recording, or other source of information that was created at the time under study and provides first-hand testimony or direct evidence concerning a topic under investigation.", SortOrder=Convert.ToDecimal("26.00") },
            new RefLearningResourceType { Id=Guid.Parse("1d1133b6-c6bc-4976-94c4-6cb533a3d3f8"), Code="RubricScoringGuide", Description="Rubric/Scoring Guide", Definition="A document or guide that is used to delineate consistent criteria for grading.", SortOrder=Convert.ToDecimal("28.00") },
            new RefLearningResourceType { Id=Guid.Parse("3da91303-1e14-4c4c-8768-d6be45c98d27"), Code="SelfAssessment", Description="Self Assessment", Definition="An assessment in which the user gathers information about and reflects on his or her own knowledge, skills, learning, or attitudes.", SortOrder=Convert.ToDecimal("32.00") },
            new RefLearningResourceType { Id=Guid.Parse("4df5f1fe-ba13-499e-b88a-7c3c7f4f55d5"), Code="Text", Description="Text", Definition="The body of a printed work, to include reading passages.", SortOrder=Convert.ToDecimal("34.00") },
            new RefLearningResourceType { Id=Guid.Parse("ce42966f-34dd-47dd-9591-828fecc46ae9"), Code="Textbook", Description="Textbook", Definition="A book used as a standard source of information on a particular subject.", SortOrder=Convert.ToDecimal("36.00") },
            new RefLearningResourceType { Id=Guid.Parse("4b3b6245-bfd2-41be-a080-4c48f557310d"), Code="Unit", Description="Unit", Definition="A long-range plan of instruction on a particular concept; it contains multiple lessons that are related.", SortOrder=Convert.ToDecimal("38.00") },
            new RefLearningResourceType { Id=Guid.Parse("20a81d79-e2f6-4424-b0aa-14e77f0f77b7"), Code="Other", Description="Other", Definition="A type of learning resource in a category not yet defined by CEDS. ", SortOrder=Convert.ToDecimal("40.00") },
        };

        /// <summary>
        /// The Reference RefLearningResourceType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLearningResourceTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLearningResourceType { Id=Guid.Parse("cf2cdc2e-16e1-4f27-8bf5-638a9885e736"), Description="Alternate Assessment", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceType { Id=Guid.Parse("eaae2b3f-282c-4899-bc30-f0ca7ec06da5"), Description="Assessment Item", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceType { Id=Guid.Parse("80299b99-4bf5-4121-93a0-9ad4a3075f6b"), Description="Course", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceType { Id=Guid.Parse("f2815d0b-526d-4719-8866-69e56b654b26"), Description="Demonstration/Simulation", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceType { Id=Guid.Parse("7e647fd3-7f6e-411d-8186-310e28d158b5"), Description="Educator/Curriculum Guide", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearningResourceType { Id=Guid.Parse("eedb8892-0d24-461d-85d9-d3d680ff119c"), Description="Formative assessment", SortOrder=Convert.ToDecimal("12.00") },
            new RefLearningResourceType { Id=Guid.Parse("d2742ac2-abe4-4060-bf13-b217807c9e5f"), Description="Images/Visuals", SortOrder=Convert.ToDecimal("14.00") },
            new RefLearningResourceType { Id=Guid.Parse("ccf248d2-c0ad-4d5e-9d5b-8313ac758831"), Description="Interim/Summative Assessment", SortOrder=Convert.ToDecimal("18.00") },
            new RefLearningResourceType { Id=Guid.Parse("a20908aa-9c9e-4800-acbc-a5be34616d5f"), Description="Learning Activity", SortOrder=Convert.ToDecimal("22.00") },
            new RefLearningResourceType { Id=Guid.Parse("cc86e434-f24e-41a0-87d5-7eff5cff401d"), Description="Lesson", SortOrder=Convert.ToDecimal("24.00") },
            new RefLearningResourceType { Id=Guid.Parse("314127cf-934b-48fe-a4e2-c84d6c5d3a20"), Description="Primary Source", SortOrder=Convert.ToDecimal("26.00") },
            new RefLearningResourceType { Id=Guid.Parse("1d1133b6-c6bc-4976-94c4-6cb533a3d3f8"), Description="Rubric/Scoring Guide", SortOrder=Convert.ToDecimal("28.00") },
            new RefLearningResourceType { Id=Guid.Parse("3da91303-1e14-4c4c-8768-d6be45c98d27"), Description="Self Assessment", SortOrder=Convert.ToDecimal("32.00") },
            new RefLearningResourceType { Id=Guid.Parse("4df5f1fe-ba13-499e-b88a-7c3c7f4f55d5"), Description="Text", SortOrder=Convert.ToDecimal("34.00") },
            new RefLearningResourceType { Id=Guid.Parse("ce42966f-34dd-47dd-9591-828fecc46ae9"), Description="Textbook", SortOrder=Convert.ToDecimal("36.00") },
            new RefLearningResourceType { Id=Guid.Parse("4b3b6245-bfd2-41be-a080-4c48f557310d"), Description="Unit", SortOrder=Convert.ToDecimal("38.00") },
            new RefLearningResourceType { Id=Guid.Parse("20a81d79-e2f6-4424-b0aa-14e77f0f77b7"), Description="Other", SortOrder=Convert.ToDecimal("40.00") },
       };
   }
}
