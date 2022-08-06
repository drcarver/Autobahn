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
        /// The complete <see cref="RefAssessmentItemType"> List
         /// </summary>
        public static List<RefAssessmentItemType> RefAssessmentItemTypeList = new List<RefAssessmentItemType>
        {
            new RefAssessmentItemType { Id=Guid.Parse("ea8ecf36-14ef-4e34-af79-900935e04c03"), Code="MultipleChoice", Description="Multiple-choice", Definition="A forced-choice assessment item featuring a stem (which is a prompt) and two or more choices, one of which is the correct answer, and the remainder are distractors.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentItemType { Id=Guid.Parse("f5b4b107-32b1-42d9-871d-e8df20277f32"), Code="FillInTheBlank", Description="Fill-in-the-blank", Definition="A short-answer item in which examinees are presented with a sentence in which a word or words is missing, and are asked to provide the missing word(s).", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentItemType { Id=Guid.Parse("331e8f68-48ca-418a-9a77-a63d0e596610"), Code="TrueFalse", Description="True/False", Definition="A declarative statement that examinees judge true or false.  Variants of the true/false item have examinees identify: fact/opinion, supported by the narrative or not, etc.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentItemType { Id=Guid.Parse("adcd1738-bd89-42ec-964f-ffef76c31b33"), Code="MultipleResponse", Description="Multiple Response", Definition="A multiple choice assessment item that directs examinees to select all of the options that apply.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentItemType { Id=Guid.Parse("aff369c0-1402-43bd-9a64-560eeb1c4a74"), Code="Matching", Description="Matching", Definition="An assessment item in which examinees are presented with a set of premises and are asked to link them to a set of responses, via directions for identifying the correspondences.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentItemType { Id=Guid.Parse("ea374f50-0fb4-4b7a-8cbf-fb343eabde48"), Code="ShortAnswer", Description="Short answer", Definition="An assessment item that asks examinees to provide a very short response, such as an item asking for a correct computational or text-based answer, or a closed item.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentItemType { Id=Guid.Parse("952841cb-098a-4474-9fbc-386e537e9007"), Code="Labeling", Description="Labeling", Definition="An assessment item that presents an image or object, such as a graph, diagram, or geometric shape, and asks examinees to apply one or more descriptive, symbolic, or quantitative labels.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAssessmentItemType { Id=Guid.Parse("1b5a3ab7-8797-4e89-a128-38f002d9a871"), Code="VisualRepresentation", Description="Visual representation", Definition="An assessment item that asks examinees to create simple graphics (e.g., sketches, schematics, diagrams) to generate evidence of understanding a key concept or its application.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentItemType { Id=Guid.Parse("6fdeb44d-934d-49e0-bab9-744ba3ed32b0"), Code="ShowYourWork", Description="Show your work", Definition="An assessment item that asks examinees to show preparatory work for the creation of a product, performance, or extended text.   The item may be treated as one component of a task leading to a final product or may be stand-alone, as evidence of preliminary thinking and problem-solving.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAssessmentItemType { Id=Guid.Parse("c8fbc35b-a21a-43f4-82bc-9c9aafbd4710"), Code="OtherConstructedResponse", Description="Other constructed response", Definition="Any assessment item that asks the examinee to develop answers without suggested answer choices and that does not fit the definition of the other assessment item types.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAssessmentItemType { Id=Guid.Parse("0b2254b6-eca8-437e-91e5-4e322d09aa98"), Code="PerformanceTask", Description="Performance task", Definition="An item or set of items that directs examinees to demonstrate what they know and can do via a performance, given a set of conditions and expectations for the task(s).  The range of possible performances is long, and may include oral, written, procedural, artistic, and/or psychomotor performances such as conducting science experiments, developing informational materials, or participating in a recital, to name a few.  An extended constructed response or essay item is a specific instance of a performance task.", SortOrder=Convert.ToDecimal("11.00") },
            new RefAssessmentItemType { Id=Guid.Parse("c092ce1a-e916-4edc-9509-8f9712c656cf"), Code="ExtendedResponse", Description="Extended Response (Essay)", Definition="An assessment item type that asks examinees to prepare and deliver an organized, cohesive response to an item prompt.  The essay item is one type of extended constructed response.  Others include the development and sequencing of mathematical proofs, extended analytical papers, and research papers.", SortOrder=Convert.ToDecimal("12.00") },
            new RefAssessmentItemType { Id=Guid.Parse("aea77b01-5826-42ad-b91c-d7b6d49a847d"), Code="TechnologyEnhancedInteractive", Description="Technology Enhanced / Interactive", Definition="An  interactive assessment item delivered in an online or computerized testing environment such that the manipulation of the stem, options, or other facet of the item by the examinees becomes part of the item prompt or part of the item response.  Scalise and Gifford (2006**) present a taxonomy of 28 innovative item types that include: Drag and Drop, Reordering, and other experiential items.", SortOrder=Convert.ToDecimal("13.00") },
            new RefAssessmentItemType { Id=Guid.Parse("ddaf15f3-9de4-4e36-b11c-5cb881df7603"), Code="Reordering", Description="Reordering", Definition="An assessment item that asks examinees to reorder items, such as pictures of events within a chronological sequence, items forming a pattern, or text within a passage.", SortOrder=Convert.ToDecimal("14.00") },
            new RefAssessmentItemType { Id=Guid.Parse("d1413abd-0873-47ce-b159-074131014e00"), Code="Substitution", Description="Substitution", Definition="An assessment item that presents visual or written stimulus with incomplete or incorrect information and asks examinees to correct or complete the information.", SortOrder=Convert.ToDecimal("15.00") },
            new RefAssessmentItemType { Id=Guid.Parse("369d5b06-03f6-4b2d-a167-2740ce540cc4"), Code="Other", Description="Other", Definition="Other assessment item type.", SortOrder=Convert.ToDecimal("16.00") },
        };

        /// <summary>
        /// The RefAssessmentItemType Pick List
         /// </summary>
        public static List<RefAssessmentItemType> RefAssessmentItemTypePickList = new List<RefAssessmentItemType>
        {
            new RefAssessmentItemType { Id=Guid.Parse("ea8ecf36-14ef-4e34-af79-900935e04c03"), Code="MultipleChoice", Description="Multiple-choice", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentItemType { Id=Guid.Parse("f5b4b107-32b1-42d9-871d-e8df20277f32"), Code="FillInTheBlank", Description="Fill-in-the-blank", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentItemType { Id=Guid.Parse("331e8f68-48ca-418a-9a77-a63d0e596610"), Code="TrueFalse", Description="True/False", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentItemType { Id=Guid.Parse("adcd1738-bd89-42ec-964f-ffef76c31b33"), Code="MultipleResponse", Description="Multiple Response", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentItemType { Id=Guid.Parse("aff369c0-1402-43bd-9a64-560eeb1c4a74"), Code="Matching", Description="Matching", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentItemType { Id=Guid.Parse("ea374f50-0fb4-4b7a-8cbf-fb343eabde48"), Code="ShortAnswer", Description="Short answer", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentItemType { Id=Guid.Parse("952841cb-098a-4474-9fbc-386e537e9007"), Code="Labeling", Description="Labeling", SortOrder=Convert.ToDecimal("7.00") },
            new RefAssessmentItemType { Id=Guid.Parse("1b5a3ab7-8797-4e89-a128-38f002d9a871"), Code="VisualRepresentation", Description="Visual representation", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentItemType { Id=Guid.Parse("6fdeb44d-934d-49e0-bab9-744ba3ed32b0"), Code="ShowYourWork", Description="Show your work", SortOrder=Convert.ToDecimal("9.00") },
            new RefAssessmentItemType { Id=Guid.Parse("c8fbc35b-a21a-43f4-82bc-9c9aafbd4710"), Code="OtherConstructedResponse", Description="Other constructed response", SortOrder=Convert.ToDecimal("10.00") },
            new RefAssessmentItemType { Id=Guid.Parse("0b2254b6-eca8-437e-91e5-4e322d09aa98"), Code="PerformanceTask", Description="Performance task", SortOrder=Convert.ToDecimal("11.00") },
            new RefAssessmentItemType { Id=Guid.Parse("c092ce1a-e916-4edc-9509-8f9712c656cf"), Code="ExtendedResponse", Description="Extended Response (Essay)", SortOrder=Convert.ToDecimal("12.00") },
            new RefAssessmentItemType { Id=Guid.Parse("aea77b01-5826-42ad-b91c-d7b6d49a847d"), Code="TechnologyEnhancedInteractive", Description="Technology Enhanced / Interactive", SortOrder=Convert.ToDecimal("13.00") },
            new RefAssessmentItemType { Id=Guid.Parse("ddaf15f3-9de4-4e36-b11c-5cb881df7603"), Code="Reordering", Description="Reordering", SortOrder=Convert.ToDecimal("14.00") },
            new RefAssessmentItemType { Id=Guid.Parse("d1413abd-0873-47ce-b159-074131014e00"), Code="Substitution", Description="Substitution", SortOrder=Convert.ToDecimal("15.00") },
            new RefAssessmentItemType { Id=Guid.Parse("369d5b06-03f6-4b2d-a167-2740ce540cc4"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("16.00") },
       };
   }
}
