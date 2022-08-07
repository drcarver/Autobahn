//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentItemTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentItemType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentItemTypeModel"> List
         /// </summary>
        public static List<RefAssessmentItemTypeModel> RefAssessmentItemTypeList = new List<RefAssessmentItemTypeModel>
        {
            new RefAssessmentItemType { Id=Guid.Parse("27acb3f6-c4ca-4cf4-9a92-043caedf39bd"), Code="MultipleChoice", Description="Multiple-choice", Definition="A forced-choice assessment item featuring a stem (which is a prompt) and two or more choices, one of which is the correct answer, and the remainder are distractors.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentItemType { Id=Guid.Parse("dcfe23a9-8637-4222-bfcb-fbfe4fb13459"), Code="FillInTheBlank", Description="Fill-in-the-blank", Definition="A short-answer item in which examinees are presented with a sentence in which a word or words is missing, and are asked to provide the missing word(s).", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentItemType { Id=Guid.Parse("c413446a-2946-4525-a892-5077bb60a836"), Code="TrueFalse", Description="True/False", Definition="A declarative statement that examinees judge true or false.  Variants of the true/false item have examinees identify: fact/opinion, supported by the narrative or not, etc.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentItemType { Id=Guid.Parse("a5952534-1fe7-48ec-b174-5ec4d02f43d6"), Code="MultipleResponse", Description="Multiple Response", Definition="A multiple choice assessment item that directs examinees to select all of the options that apply.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentItemType { Id=Guid.Parse("47aec915-2d27-469a-a59b-4d2777852dd7"), Code="Matching", Description="Matching", Definition="An assessment item in which examinees are presented with a set of premises and are asked to link them to a set of responses, via directions for identifying the correspondences.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentItemType { Id=Guid.Parse("2994f365-a0f8-41e5-a140-896ea30548ff"), Code="ShortAnswer", Description="Short answer", Definition="An assessment item that asks examinees to provide a very short response, such as an item asking for a correct computational or text-based answer, or a closed item.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentItemType { Id=Guid.Parse("deead00e-6c7e-4ffd-96cf-a3a4d826acd9"), Code="Labeling", Description="Labeling", Definition="An assessment item that presents an image or object, such as a graph, diagram, or geometric shape, and asks examinees to apply one or more descriptive, symbolic, or quantitative labels.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAssessmentItemType { Id=Guid.Parse("55b17caa-6f14-477f-b660-57f72589b091"), Code="VisualRepresentation", Description="Visual representation", Definition="An assessment item that asks examinees to create simple graphics (e.g., sketches, schematics, diagrams) to generate evidence of understanding a key concept or its application.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentItemType { Id=Guid.Parse("d6de6143-475c-4018-94b8-aaefae4dec12"), Code="ShowYourWork", Description="Show your work", Definition="An assessment item that asks examinees to show preparatory work for the creation of a product, performance, or extended text.   The item may be treated as one component of a task leading to a final product or may be stand-alone, as evidence of preliminary thinking and problem-solving.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAssessmentItemType { Id=Guid.Parse("0b9c0cd6-cd2e-4797-9bfa-7e26063b29b6"), Code="OtherConstructedResponse", Description="Other constructed response", Definition="Any assessment item that asks the examinee to develop answers without suggested answer choices and that does not fit the definition of the other assessment item types.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAssessmentItemType { Id=Guid.Parse("4e64ef7d-f935-4a82-9380-e6a80e08940c"), Code="PerformanceTask", Description="Performance task", Definition="An item or set of items that directs examinees to demonstrate what they know and can do via a performance, given a set of conditions and expectations for the task(s).  The range of possible performances is long, and may include oral, written, procedural, artistic, and/or psychomotor performances such as conducting science experiments, developing informational materials, or participating in a recital, to name a few.  An extended constructed response or essay item is a specific instance of a performance task.", SortOrder=Convert.ToDecimal("11.00") },
            new RefAssessmentItemType { Id=Guid.Parse("0651de67-15e1-47f7-b5bf-0452e701927e"), Code="ExtendedResponse", Description="Extended Response (Essay)", Definition="An assessment item type that asks examinees to prepare and deliver an organized, cohesive response to an item prompt.  The essay item is one type of extended constructed response.  Others include the development and sequencing of mathematical proofs, extended analytical papers, and research papers.", SortOrder=Convert.ToDecimal("12.00") },
            new RefAssessmentItemType { Id=Guid.Parse("4ea19126-4b0b-4d2b-9795-cf044c53e0a5"), Code="TechnologyEnhancedInteractive", Description="Technology Enhanced / Interactive", Definition="An  interactive assessment item delivered in an online or computerized testing environment such that the manipulation of the stem, options, or other facet of the item by the examinees becomes part of the item prompt or part of the item response.  Scalise and Gifford (2006**) present a taxonomy of 28 innovative item types that include: Drag and Drop, Reordering, and other experiential items.", SortOrder=Convert.ToDecimal("13.00") },
            new RefAssessmentItemType { Id=Guid.Parse("c7b46c24-7ff9-40ab-a5a4-9d3a9d5e0bae"), Code="Reordering", Description="Reordering", Definition="An assessment item that asks examinees to reorder items, such as pictures of events within a chronological sequence, items forming a pattern, or text within a passage.", SortOrder=Convert.ToDecimal("14.00") },
            new RefAssessmentItemType { Id=Guid.Parse("b00af7df-2823-4157-913e-cdb80d65e923"), Code="Substitution", Description="Substitution", Definition="An assessment item that presents visual or written stimulus with incomplete or incorrect information and asks examinees to correct or complete the information.", SortOrder=Convert.ToDecimal("15.00") },
            new RefAssessmentItemType { Id=Guid.Parse("bb3dca97-6bba-4881-a8fa-d70d707095ad"), Code="Other", Description="Other", Definition="Other assessment item type.", SortOrder=Convert.ToDecimal("16.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentItemType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentItemTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentItemType { Id=Guid.Parse("27acb3f6-c4ca-4cf4-9a92-043caedf39bd"), Description="Multiple-choice", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentItemType { Id=Guid.Parse("dcfe23a9-8637-4222-bfcb-fbfe4fb13459"), Description="Fill-in-the-blank", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentItemType { Id=Guid.Parse("c413446a-2946-4525-a892-5077bb60a836"), Description="True/False", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentItemType { Id=Guid.Parse("a5952534-1fe7-48ec-b174-5ec4d02f43d6"), Description="Multiple Response", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentItemType { Id=Guid.Parse("47aec915-2d27-469a-a59b-4d2777852dd7"), Description="Matching", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentItemType { Id=Guid.Parse("2994f365-a0f8-41e5-a140-896ea30548ff"), Description="Short answer", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentItemType { Id=Guid.Parse("deead00e-6c7e-4ffd-96cf-a3a4d826acd9"), Description="Labeling", SortOrder=Convert.ToDecimal("7.00") },
            new RefAssessmentItemType { Id=Guid.Parse("55b17caa-6f14-477f-b660-57f72589b091"), Description="Visual representation", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentItemType { Id=Guid.Parse("d6de6143-475c-4018-94b8-aaefae4dec12"), Description="Show your work", SortOrder=Convert.ToDecimal("9.00") },
            new RefAssessmentItemType { Id=Guid.Parse("0b9c0cd6-cd2e-4797-9bfa-7e26063b29b6"), Description="Other constructed response", SortOrder=Convert.ToDecimal("10.00") },
            new RefAssessmentItemType { Id=Guid.Parse("4e64ef7d-f935-4a82-9380-e6a80e08940c"), Description="Performance task", SortOrder=Convert.ToDecimal("11.00") },
            new RefAssessmentItemType { Id=Guid.Parse("0651de67-15e1-47f7-b5bf-0452e701927e"), Description="Extended Response (Essay)", SortOrder=Convert.ToDecimal("12.00") },
            new RefAssessmentItemType { Id=Guid.Parse("4ea19126-4b0b-4d2b-9795-cf044c53e0a5"), Description="Technology Enhanced / Interactive", SortOrder=Convert.ToDecimal("13.00") },
            new RefAssessmentItemType { Id=Guid.Parse("c7b46c24-7ff9-40ab-a5a4-9d3a9d5e0bae"), Description="Reordering", SortOrder=Convert.ToDecimal("14.00") },
            new RefAssessmentItemType { Id=Guid.Parse("b00af7df-2823-4157-913e-cdb80d65e923"), Description="Substitution", SortOrder=Convert.ToDecimal("15.00") },
            new RefAssessmentItemType { Id=Guid.Parse("bb3dca97-6bba-4881-a8fa-d70d707095ad"), Description="Other", SortOrder=Convert.ToDecimal("16.00") },
       };
   }
}
