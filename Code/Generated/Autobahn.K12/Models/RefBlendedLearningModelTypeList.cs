//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefBlendedLearningModelTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefBlendedLearningModelType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBlendedLearningModelTypeModel"> List
         /// </summary>
        public static List<RefBlendedLearningModelTypeModel> RefBlendedLearningModelTypeList = new List<RefBlendedLearningModelTypeModel>
        {
            new RefBlendedLearningModelType { Id=Guid.Parse("b170c5a5-fef1-4477-b7c6-15a8b99ea344"), Code="Rotation", Description="Rotation model", Definition="A model in which within a given course or subject, students rotate between learning modalities, at least one of which is online learning. Other modalities might include activities such as small-group or full-class instruction, group projects, individual tutoring, and pencil-and-paper assignments.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBlendedLearningModelType { Id=Guid.Parse("500b1036-ab7c-4ac8-bae4-0510b4d9ec86"), Code="FlexModel", Description="Flex model", Definition="A model in which online learning is the backbone of student learning, even if it directs students to offline activities at times. Students move on an individually customized, fluid schedule among learning modalities, and the teacher of record is on-site. The teacher-of-record or other adults provide face-to-face support on a flexible and adaptive as-needed basis through activities such as small-group instruction, group projects, and individual tutoring.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBlendedLearningModelType { Id=Guid.Parse("5825aaa4-6bfb-4f0e-b5ff-b6cd47956445"), Code="ALaCarte", Description="A La Carte model", Definition="A model in which students take one or more courses entirely online with an online teacher of record and at the�same time continue to have brick-and-mortar educational experiences. Students may take the online courses either on the brick-and-mortar campus or off-site.�This differs from full-time online learning and the Enriched Virtual�model because it is not a whole-school experience.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBlendedLearningModelType { Id=Guid.Parse("5a9e1f30-38b3-4524-88a4-5e91ffe6ed5c"), Code="EnrichedVirtual", Description="Enriched Virtual model", Definition="A whole-school experience in which within each course, students divide their time between attending a brick-and-mortar campus and learning remotely, off-site, using online delivery of content and instruction.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBlendedLearningModelType { Id=Guid.Parse("78ab6a49-88e1-4dee-b813-c6ebc6a09551"), Code="Other", Description="Other", Definition="A model for implementing blended learning that does not fit the definition of the other blended learning model types", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBlendedLearningModelType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBlendedLearningModelTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBlendedLearningModelType { Id=Guid.Parse("b170c5a5-fef1-4477-b7c6-15a8b99ea344"), Description="Rotation model", SortOrder=Convert.ToDecimal("1.00") },
            new RefBlendedLearningModelType { Id=Guid.Parse("500b1036-ab7c-4ac8-bae4-0510b4d9ec86"), Description="Flex model", SortOrder=Convert.ToDecimal("3.00") },
            new RefBlendedLearningModelType { Id=Guid.Parse("5825aaa4-6bfb-4f0e-b5ff-b6cd47956445"), Description="A La Carte model", SortOrder=Convert.ToDecimal("5.00") },
            new RefBlendedLearningModelType { Id=Guid.Parse("5a9e1f30-38b3-4524-88a4-5e91ffe6ed5c"), Description="Enriched Virtual model", SortOrder=Convert.ToDecimal("7.00") },
            new RefBlendedLearningModelType { Id=Guid.Parse("78ab6a49-88e1-4dee-b813-c6ebc6a09551"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
