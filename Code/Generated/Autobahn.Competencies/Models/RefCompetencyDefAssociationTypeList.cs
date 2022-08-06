//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   RefCompetencyDefAssociationTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The list of RefCompetencyDefAssociationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCompetencyDefAssociationType"> List
         /// </summary>
        public static List<RefCompetencyDefAssociationType> RefCompetencyDefAssociationTypeList = new List<RefCompetencyDefAssociationType> =
        {
            new RefCompetencyDefAssociationType { Id=Guid.Parse("654eadc9-dcd6-43c9-8939-c3ce44af5f35"), Code="The destination of the association is required as a prior condition for the origin of the association.", Description="Prerequisite", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("f9c4b4fc-db2d-43a4-9734-81ecbe2d595b"), Code="The origin of the association conforms to an established standard that the destination defines.", Description="ConformsTo", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("58920ada-fd28-4988-84aa-973c99adc271"), Code="The information at origin of the association provides context or meaning for understanding the destination of the association.", Description="Defines", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("838d88c0-1de2-45a4-89da-486e91d91d6f"), Code="The destination of the association is substantially the same as the resource at the origin of the association, but in another format.", Description="HasFormat", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("baf189e0-1bb9-4558-8532-dbaa36edd26b"), Code="The destination of the association is included either physically or logically in the resource at the origin of the association.", Description="HasPart", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("a920e0d0-2e38-4e80-90b6-df615f9600f5"), Code="The destination of the association is a version, edition, or adaptation of the resource at the origin of the association.", Description="HasVersion", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("ae0f656b-7c74-4d4b-9efd-7fe944484e6c"), Code="The destination of the association may be used to assess the origin of the association.", Description="IsAssessedBy", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("319b8bd7-272c-4fbe-a1b9-9da92ae4ed41"), Code="The destination of the association references an established standard to which the origin of the association conforms.", Description="IsConformedTo", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("ec8fbefc-f43d-466a-a58a-c64da9596692"), Code="Context or meaning for understanding the origin of the association is provided by the destination of the association.", Description="IsDefinedBy", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("68ff6399-ab81-41ef-a24e-b8392d0f0836"), Code="The destination of the association is substantially the same as the resource at the origin of the association, but in another format.", Description="FormatOf", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("c8f21663-f7fd-4507-a8b7-c8e17939ddc3"), Code="The origin of the association is included either physically or logically in the resource at the destination of the association.", Description="IsPartOf", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("a77bf791-aa00-4661-a5f5-3c4e48f508e0"), Code="The origin of the association is required as a prior condition for the destination of the association.", Description="IsPrerequisiteTo", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("2d8edfdc-bfa7-4ad4-8704-68b11f2db9ef"), Code="The origin of the association is cited by the resource at the destination of the association.", Description="ReferencedBy", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("6f539bab-ad74-4327-affd-191ddde0a92e"), Code="The origin of the association has been supplanted by, displaced by, or superseded by the destination of the association.", Description="ReplacedBy", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("400ab6ef-0bb9-4caf-b47f-e63a8ed4a806"), Code="The origin of the association is required by the destination of the association to support its function, delivery, or coherence.", Description="RequiredBy", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("72c0b6f3-2026-41fe-9a60-3d5dfb6052d9"), Code="The competency at the origin of the association may be taught by the resource or method at the destination of the association.", Description="IsTaughtBy", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("b3d1d91e-fe63-4d57-9cce-f87ac9961490"), Code="The origin of the association is a version, edition, or adaptation of the resource at the destination of the association.", Description="VersionOf", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("6583b9d0-244b-4c63-9435-a27d0bf5839c"), Code="The origin of the association cites the resource at the destination of the association.", Description="Referenced", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("3c9c0496-f6ef-441a-a2f9-7228595bca3f"), Code="The origin of the association may be used to assess the destination of the association.", Description="Assesses", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("4b6045c1-2212-4415-8e86-325dc73f9aee"), Code="The resource or method at the origin of the association may be used to teach the competency at the destination of the association.", Description="Teaches", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("7591930f-f9f5-471a-910e-9c4972aa1463"), Code="The origin of the association requires the destination of the association to support its function, delivery, or coherence.", Description="Requires", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("721948e5-ee1e-40c5-bb01-4e6f414501cd"), Code="The point in the framework being referenced defines a level or range that measures the difficulty or challenge presented by the learning resource being described.", Description="ComplexityLevel", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("1f9733fe-4f86-4b62-82ee-cd8ed4f2441b"), Code="The destination of the association defines a level or range of ability expected for a person using the resource at the origin of the association.", Description="ReadingLevel", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("57cc5ad2-d57a-4810-97a2-b6f4750c893c"), Code="The destination of the association defines a topic or subject from a controlled vocabulary.", Description="EducationalSubject", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("5d4d9c0b-4a0d-410d-86ac-665098e2e6ea"), Code="The destination of the association defines an education level from a controlled vocabulary.", Description="EducationLevel", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("a8e18f2f-541c-4f85-89ae-c2b2dc660018"), Code="The origin of the association comes before the destination of the association in time or order.", Description="Precedes", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("19fd9805-3048-4e17-b321-b2829ab10bfc"), Code="The origin of the association comes after the destination of the association in time or order.", Description="Follows", Definition="", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("3fff1bb2-1860-4328-a518-27b52fff3f82"), Code="The origin of the association is achieved or delivered at the same time, or has the same ordinal position, as the destination of the association.", Description="IsConcurrentTo", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCompetencyDefAssociationType Pick List
         /// </summary>
        public static List<RefCompetencyDefAssociationType> RefCompetencyDefAssociationTypePickList = new List<RefCompetencyDefAssociationType> =
        {
            new RefCompetencyDefAssociationType { Id=Guid.Parse("654eadc9-dcd6-43c9-8939-c3ce44af5f35"), Code="The destination of the association is required as a prior condition for the origin of the association.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("f9c4b4fc-db2d-43a4-9734-81ecbe2d595b"), Code="The origin of the association conforms to an established standard that the destination defines.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("58920ada-fd28-4988-84aa-973c99adc271"), Code="The information at origin of the association provides context or meaning for understanding the destination of the association.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("838d88c0-1de2-45a4-89da-486e91d91d6f"), Code="The destination of the association is substantially the same as the resource at the origin of the association, but in another format.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("baf189e0-1bb9-4558-8532-dbaa36edd26b"), Code="The destination of the association is included either physically or logically in the resource at the origin of the association.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("a920e0d0-2e38-4e80-90b6-df615f9600f5"), Code="The destination of the association is a version, edition, or adaptation of the resource at the origin of the association.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("ae0f656b-7c74-4d4b-9efd-7fe944484e6c"), Code="The destination of the association may be used to assess the origin of the association.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("319b8bd7-272c-4fbe-a1b9-9da92ae4ed41"), Code="The destination of the association references an established standard to which the origin of the association conforms.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("ec8fbefc-f43d-466a-a58a-c64da9596692"), Code="Context or meaning for understanding the origin of the association is provided by the destination of the association.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("68ff6399-ab81-41ef-a24e-b8392d0f0836"), Code="The destination of the association is substantially the same as the resource at the origin of the association, but in another format.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("c8f21663-f7fd-4507-a8b7-c8e17939ddc3"), Code="The origin of the association is included either physically or logically in the resource at the destination of the association.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("a77bf791-aa00-4661-a5f5-3c4e48f508e0"), Code="The origin of the association is required as a prior condition for the destination of the association.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("2d8edfdc-bfa7-4ad4-8704-68b11f2db9ef"), Code="The origin of the association is cited by the resource at the destination of the association.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("6f539bab-ad74-4327-affd-191ddde0a92e"), Code="The origin of the association has been supplanted by, displaced by, or superseded by the destination of the association.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("400ab6ef-0bb9-4caf-b47f-e63a8ed4a806"), Code="The origin of the association is required by the destination of the association to support its function, delivery, or coherence.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("72c0b6f3-2026-41fe-9a60-3d5dfb6052d9"), Code="The competency at the origin of the association may be taught by the resource or method at the destination of the association.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("b3d1d91e-fe63-4d57-9cce-f87ac9961490"), Code="The origin of the association is a version, edition, or adaptation of the resource at the destination of the association.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("6583b9d0-244b-4c63-9435-a27d0bf5839c"), Code="The origin of the association cites the resource at the destination of the association.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("3c9c0496-f6ef-441a-a2f9-7228595bca3f"), Code="The origin of the association may be used to assess the destination of the association.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("4b6045c1-2212-4415-8e86-325dc73f9aee"), Code="The resource or method at the origin of the association may be used to teach the competency at the destination of the association.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("7591930f-f9f5-471a-910e-9c4972aa1463"), Code="The origin of the association requires the destination of the association to support its function, delivery, or coherence.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("721948e5-ee1e-40c5-bb01-4e6f414501cd"), Code="The point in the framework being referenced defines a level or range that measures the difficulty or challenge presented by the learning resource being described.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("1f9733fe-4f86-4b62-82ee-cd8ed4f2441b"), Code="The destination of the association defines a level or range of ability expected for a person using the resource at the origin of the association.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("57cc5ad2-d57a-4810-97a2-b6f4750c893c"), Code="The destination of the association defines a topic or subject from a controlled vocabulary.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("5d4d9c0b-4a0d-410d-86ac-665098e2e6ea"), Code="The destination of the association defines an education level from a controlled vocabulary.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("a8e18f2f-541c-4f85-89ae-c2b2dc660018"), Code="The origin of the association comes before the destination of the association in time or order.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("19fd9805-3048-4e17-b321-b2829ab10bfc"), Code="The origin of the association comes after the destination of the association in time or order.", SortOrder=0 },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("3fff1bb2-1860-4328-a518-27b52fff3f82"), Code="The origin of the association is achieved or delivered at the same time, or has the same ordinal position, as the destination of the association.", SortOrder=0 },
       };
   }
}
