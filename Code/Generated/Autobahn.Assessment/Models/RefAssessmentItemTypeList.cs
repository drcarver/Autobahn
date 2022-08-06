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
        public static List<RefAssessmentItemType> RefAssessmentItemTypeList = new List<RefAssessmentItemType> =
        {
            new RefAssessmentItemType { Id=Guid.Parse("ea797729-6d4e-4754-aab7-c740bd8f443c"), Code="A forced-choice assessment item featuring a stem (which is a prompt) and two or more choices, one of which is the correct answer, and the remainder are distractors.", Description="MultipleChoice", Definition="", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("516676e0-320f-41c2-9dd8-fcb3d894f4ef"), Code="A short-answer item in which examinees are presented with a sentence in which a word or words is missing, and are asked to provide the missing word(s).", Description="FillInTheBlank", Definition="", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("08d6a745-5dd1-478b-80ec-5de9efbd1961"), Code="A declarative statement that examinees judge true or false.  Variants of the true/false item have examinees identify: fact/opinion, supported by the narrative or not, etc.", Description="TrueFalse", Definition="", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("a29db198-8cde-42d8-af51-83fa28bf21b1"), Code="A multiple choice assessment item that directs examinees to select all of the options that apply.", Description="MultipleResponse", Definition="", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("fa239e0f-e33f-42e2-b144-e66791d7ab20"), Code="An assessment item in which examinees are presented with a set of premises and are asked to link them to a set of responses, via directions for identifying the correspondences.", Description="Matching", Definition="", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("999b9794-44c3-4562-889c-55f400521e2f"), Code="An assessment item that asks examinees to provide a very short response, such as an item asking for a correct computational or text-based answer, or a closed item.", Description="ShortAnswer", Definition="", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("0e1eeb9f-53c9-4959-8737-e3791d71084e"), Code="An assessment item that presents an image or object, such as a graph, diagram, or geometric shape, and asks examinees to apply one or more descriptive, symbolic, or quantitative labels.", Description="Labeling", Definition="", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("87547e53-ae24-4c26-8d02-87e4ff730aed"), Code="An assessment item that asks examinees to create simple graphics (e.g., sketches, schematics, diagrams) to generate evidence of understanding a key concept or its application.", Description="VisualRepresentation", Definition="", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("7942e3f0-f8e8-45bf-844f-e9a896a32ade"), Code="An assessment item that asks examinees to show preparatory work for the creation of a product, performance, or extended text.   The item may be treated as one component of a task leading to a final product or may be stand-alone, as evidence of preliminary thinking and problem-solving.", Description="ShowYourWork", Definition="", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("0dfb39aa-0a43-40cd-93a9-934b93835268"), Code="Any assessment item that asks the examinee to develop answers without suggested answer choices and that does not fit the definition of the other assessment item types.", Description="OtherConstructedResponse", Definition="", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("1779f88c-fb9a-463f-aecb-ddcf7fb9a91d"), Code="An item or set of items that directs examinees to demonstrate what they know and can do via a performance, given a set of conditions and expectations for the task(s).  The range of possible performances is long, and may include oral, written, procedural, artistic, and/or psychomotor performances such as conducting science experiments, developing informational materials, or participating in a recital, to name a few.  An extended constructed response or essay item is a specific instance of a performance task.", Description="PerformanceTask", Definition="", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("7ccaf5c4-fd17-428c-b4cb-05f311610768"), Code="An assessment item type that asks examinees to prepare and deliver an organized, cohesive response to an item prompt.  The essay item is one type of extended constructed response.  Others include the development and sequencing of mathematical proofs, extended analytical papers, and research papers.", Description="ExtendedResponse", Definition="", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("ba7dc94d-afd0-477c-bb8e-3ba3441053f6"), Code="An  interactive assessment item delivered in an online or computerized testing environment such that the manipulation of the stem, options, or other facet of the item by the examinees becomes part of the item prompt or part of the item response.  Scalise and Gifford (2006**) present a taxonomy of 28 innovative item types that include: Drag and Drop, Reordering, and other experiential items.", Description="TechnologyEnhancedInteractive", Definition="", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("5a08cc45-36e5-418a-b75b-5f1c51c581e5"), Code="An assessment item that asks examinees to reorder items, such as pictures of events within a chronological sequence, items forming a pattern, or text within a passage.", Description="Reordering", Definition="", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("7c91b7a5-1f83-459f-94f0-1b23dc6b0f86"), Code="An assessment item that presents visual or written stimulus with incomplete or incorrect information and asks examinees to correct or complete the information.", Description="Substitution", Definition="", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("75a0f83a-33ab-4a26-8e76-cc6aa5584609"), Code="Other assessment item type.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentItemType Pick List
         /// </summary>
        public static List<RefAssessmentItemType> RefAssessmentItemTypePickList = new List<RefAssessmentItemType> =
        {
            new RefAssessmentItemType { Id=Guid.Parse("ea797729-6d4e-4754-aab7-c740bd8f443c"), Code="A forced-choice assessment item featuring a stem (which is a prompt) and two or more choices, one of which is the correct answer, and the remainder are distractors.", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("516676e0-320f-41c2-9dd8-fcb3d894f4ef"), Code="A short-answer item in which examinees are presented with a sentence in which a word or words is missing, and are asked to provide the missing word(s).", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("08d6a745-5dd1-478b-80ec-5de9efbd1961"), Code="A declarative statement that examinees judge true or false.  Variants of the true/false item have examinees identify: fact/opinion, supported by the narrative or not, etc.", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("a29db198-8cde-42d8-af51-83fa28bf21b1"), Code="A multiple choice assessment item that directs examinees to select all of the options that apply.", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("fa239e0f-e33f-42e2-b144-e66791d7ab20"), Code="An assessment item in which examinees are presented with a set of premises and are asked to link them to a set of responses, via directions for identifying the correspondences.", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("999b9794-44c3-4562-889c-55f400521e2f"), Code="An assessment item that asks examinees to provide a very short response, such as an item asking for a correct computational or text-based answer, or a closed item.", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("0e1eeb9f-53c9-4959-8737-e3791d71084e"), Code="An assessment item that presents an image or object, such as a graph, diagram, or geometric shape, and asks examinees to apply one or more descriptive, symbolic, or quantitative labels.", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("87547e53-ae24-4c26-8d02-87e4ff730aed"), Code="An assessment item that asks examinees to create simple graphics (e.g., sketches, schematics, diagrams) to generate evidence of understanding a key concept or its application.", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("7942e3f0-f8e8-45bf-844f-e9a896a32ade"), Code="An assessment item that asks examinees to show preparatory work for the creation of a product, performance, or extended text.   The item may be treated as one component of a task leading to a final product or may be stand-alone, as evidence of preliminary thinking and problem-solving.", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("0dfb39aa-0a43-40cd-93a9-934b93835268"), Code="Any assessment item that asks the examinee to develop answers without suggested answer choices and that does not fit the definition of the other assessment item types.", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("1779f88c-fb9a-463f-aecb-ddcf7fb9a91d"), Code="An item or set of items that directs examinees to demonstrate what they know and can do via a performance, given a set of conditions and expectations for the task(s).  The range of possible performances is long, and may include oral, written, procedural, artistic, and/or psychomotor performances such as conducting science experiments, developing informational materials, or participating in a recital, to name a few.  An extended constructed response or essay item is a specific instance of a performance task.", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("7ccaf5c4-fd17-428c-b4cb-05f311610768"), Code="An assessment item type that asks examinees to prepare and deliver an organized, cohesive response to an item prompt.  The essay item is one type of extended constructed response.  Others include the development and sequencing of mathematical proofs, extended analytical papers, and research papers.", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("ba7dc94d-afd0-477c-bb8e-3ba3441053f6"), Code="An  interactive assessment item delivered in an online or computerized testing environment such that the manipulation of the stem, options, or other facet of the item by the examinees becomes part of the item prompt or part of the item response.  Scalise and Gifford (2006**) present a taxonomy of 28 innovative item types that include: Drag and Drop, Reordering, and other experiential items.", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("5a08cc45-36e5-418a-b75b-5f1c51c581e5"), Code="An assessment item that asks examinees to reorder items, such as pictures of events within a chronological sequence, items forming a pattern, or text within a passage.", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("7c91b7a5-1f83-459f-94f0-1b23dc6b0f86"), Code="An assessment item that presents visual or written stimulus with incomplete or incorrect information and asks examinees to correct or complete the information.", SortOrder=0 },
            new RefAssessmentItemType { Id=Guid.Parse("75a0f83a-33ab-4a26-8e76-cc6aa5584609"), Code="Other assessment item type.", SortOrder=0 },
       };
   }
}
