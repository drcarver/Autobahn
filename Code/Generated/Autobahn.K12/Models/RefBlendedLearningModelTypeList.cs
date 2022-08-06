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
        public static List<RefBlendedLearningModelType> RefBlendedLearningModelTypeList = new List<RefBlendedLearningModelType> =
        {
            new RefBlendedLearningModelType { Id=Guid.Parse("c31a147f-1379-4679-8a65-eb3b59beac6d"), Code="A model in which within a given course or subject, students rotate between learning modalities, at least one of which is online learning. Other modalities might include activities such as small-group or full-class instruction, group projects, individual tutoring, and pencil-and-paper assignments.", Description="Rotation", Definition="", SortOrder=0 },
            new RefBlendedLearningModelType { Id=Guid.Parse("bc7c1f45-e660-49d9-b98a-f2591ee3a19e"), Code="A model in which online learning is the backbone of student learning, even if it directs students to offline activities at times. Students move on an individually customized, fluid schedule among learning modalities, and the teacher of record is on-site. The teacher-of-record or other adults provide face-to-face support on a flexible and adaptive as-needed basis through activities such as small-group instruction, group projects, and individual tutoring.", Description="FlexModel", Definition="", SortOrder=0 },
            new RefBlendedLearningModelType { Id=Guid.Parse("138a1392-f5c9-4121-8f99-214790c990af"), Code="A model in which students take one or more courses entirely online with an online teacher of record and at the�same time continue to have brick-and-mortar educational experiences. Students may take the online courses either on the brick-and-mortar campus or off-site.�This differs from full-time online learning and the Enriched Virtual�model because it is not a whole-school experience.", Description="ALaCarte", Definition="", SortOrder=0 },
            new RefBlendedLearningModelType { Id=Guid.Parse("955c3e96-d41e-4453-957f-c2c165febf83"), Code="A whole-school experience in which within each course, students divide their time between attending a brick-and-mortar campus and learning remotely, off-site, using online delivery of content and instruction.", Description="EnrichedVirtual", Definition="", SortOrder=0 },
            new RefBlendedLearningModelType { Id=Guid.Parse("7344e191-f18e-49f7-8b43-2e1f6a8913ad"), Code="A model for implementing blended learning that does not fit the definition of the other blended learning model types", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefBlendedLearningModelType Pick List
         /// </summary>
        public static List<RefBlendedLearningModelType> RefBlendedLearningModelTypePickList = new List<RefBlendedLearningModelType> =
        {
            new RefBlendedLearningModelType { Id=Guid.Parse("c31a147f-1379-4679-8a65-eb3b59beac6d"), Code="A model in which within a given course or subject, students rotate between learning modalities, at least one of which is online learning. Other modalities might include activities such as small-group or full-class instruction, group projects, individual tutoring, and pencil-and-paper assignments.", SortOrder=0 },
            new RefBlendedLearningModelType { Id=Guid.Parse("bc7c1f45-e660-49d9-b98a-f2591ee3a19e"), Code="A model in which online learning is the backbone of student learning, even if it directs students to offline activities at times. Students move on an individually customized, fluid schedule among learning modalities, and the teacher of record is on-site. The teacher-of-record or other adults provide face-to-face support on a flexible and adaptive as-needed basis through activities such as small-group instruction, group projects, and individual tutoring.", SortOrder=0 },
            new RefBlendedLearningModelType { Id=Guid.Parse("138a1392-f5c9-4121-8f99-214790c990af"), Code="A model in which students take one or more courses entirely online with an online teacher of record and at the�same time continue to have brick-and-mortar educational experiences. Students may take the online courses either on the brick-and-mortar campus or off-site.�This differs from full-time online learning and the Enriched Virtual�model because it is not a whole-school experience.", SortOrder=0 },
            new RefBlendedLearningModelType { Id=Guid.Parse("955c3e96-d41e-4453-957f-c2c165febf83"), Code="A whole-school experience in which within each course, students divide their time between attending a brick-and-mortar campus and learning remotely, off-site, using online delivery of content and instruction.", SortOrder=0 },
            new RefBlendedLearningModelType { Id=Guid.Parse("7344e191-f18e-49f7-8b43-2e1f6a8913ad"), Code="A model for implementing blended learning that does not fit the definition of the other blended learning model types", SortOrder=0 },
       };
   }
}
