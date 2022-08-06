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
        /// The complete <see cref="RefBlendedLearningModelType"> List
         /// </summary>
        public static List<RefBlendedLearningModelType> RefBlendedLearningModelTypeList = new List<RefBlendedLearningModelType>
        {
            new RefBlendedLearningModelType { Id=Guid.Parse("5a33e6a0-3016-4b45-a2c8-8fdaa7d7ffe9"), Code="Rotation", Description="Rotation model", Definition="A model in which within a given course or subject, students rotate between learning modalities, at least one of which is online learning. Other modalities might include activities such as small-group or full-class instruction, group projects, individual tutoring, and pencil-and-paper assignments.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBlendedLearningModelType { Id=Guid.Parse("fc876884-3a41-403e-8d13-1c7a8e6b38dd"), Code="FlexModel", Description="Flex model", Definition="A model in which online learning is the backbone of student learning, even if it directs students to offline activities at times. Students move on an individually customized, fluid schedule among learning modalities, and the teacher of record is on-site. The teacher-of-record or other adults provide face-to-face support on a flexible and adaptive as-needed basis through activities such as small-group instruction, group projects, and individual tutoring.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBlendedLearningModelType { Id=Guid.Parse("aad6f9d9-70f3-4e4b-a6f4-b7b00d6b44f2"), Code="ALaCarte", Description="A La Carte model", Definition="A model in which students take one or more courses entirely online with an online teacher of record and at the�same time continue to have brick-and-mortar educational experiences. Students may take the online courses either on the brick-and-mortar campus or off-site.�This differs from full-time online learning and the Enriched Virtual�model because it is not a whole-school experience.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBlendedLearningModelType { Id=Guid.Parse("20f02029-9382-4746-85fb-ba4c6180cf78"), Code="EnrichedVirtual", Description="Enriched Virtual model", Definition="A whole-school experience in which within each course, students divide their time between attending a brick-and-mortar campus and learning remotely, off-site, using online delivery of content and instruction.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBlendedLearningModelType { Id=Guid.Parse("e0ba70c2-e70b-4bd1-981d-17bf7582c5b1"), Code="Other", Description="Other", Definition="A model for implementing blended learning that does not fit the definition of the other blended learning model types", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefBlendedLearningModelType Pick List
         /// </summary>
        public static List<RefBlendedLearningModelType> RefBlendedLearningModelTypePickList = new List<RefBlendedLearningModelType>
        {
            new RefBlendedLearningModelType { Id=Guid.Parse("5a33e6a0-3016-4b45-a2c8-8fdaa7d7ffe9"), Code="Rotation", Description="Rotation model", SortOrder=Convert.ToDecimal("1.00") },
            new RefBlendedLearningModelType { Id=Guid.Parse("fc876884-3a41-403e-8d13-1c7a8e6b38dd"), Code="FlexModel", Description="Flex model", SortOrder=Convert.ToDecimal("3.00") },
            new RefBlendedLearningModelType { Id=Guid.Parse("aad6f9d9-70f3-4e4b-a6f4-b7b00d6b44f2"), Code="ALaCarte", Description="A La Carte model", SortOrder=Convert.ToDecimal("5.00") },
            new RefBlendedLearningModelType { Id=Guid.Parse("20f02029-9382-4746-85fb-ba4c6180cf78"), Code="EnrichedVirtual", Description="Enriched Virtual model", SortOrder=Convert.ToDecimal("7.00") },
            new RefBlendedLearningModelType { Id=Guid.Parse("e0ba70c2-e70b-4bd1-981d-17bf7582c5b1"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
