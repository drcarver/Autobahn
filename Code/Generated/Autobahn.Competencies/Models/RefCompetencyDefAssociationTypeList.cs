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
        public static List<RefCompetencyDefAssociationType> RefCompetencyDefAssociationTypeList = new List<RefCompetencyDefAssociationType>
        {
            new RefCompetencyDefAssociationType { Id=Guid.Parse("4f1b7d1f-0ba4-4943-9f6b-41510daaf56a"), Code="Prerequisite", Description="Prerequisite", Definition="The destination of the association is required as a prior condition for the origin of the association.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("61a41f87-e6c9-4ca0-aa4a-bd3d41e4db18"), Code="ConformsTo", Description="Conforms To", Definition="The origin of the association conforms to an established standard that the destination defines.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("b98cc248-1379-4581-9486-619f771a6a69"), Code="Defines", Description="Defines", Definition="The information at origin of the association provides context or meaning for understanding the destination of the association.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("a9613e16-493d-4f76-beda-7f33801a939c"), Code="HasFormat", Description="Has Format", Definition="The destination of the association is substantially the same as the resource at the origin of the association, but in another format.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("1a91ff4f-368f-4940-9f9c-e388e8670000"), Code="HasPart", Description="Has Part", Definition="The destination of the association is included either physically or logically in the resource at the origin of the association.", SortOrder=Convert.ToDecimal("7.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("922b8f4c-3563-4c2c-a832-8af1c6b7ca0b"), Code="HasVersion", Description="Has Version", Definition="The destination of the association is a version, edition, or adaptation of the resource at the origin of the association.", SortOrder=Convert.ToDecimal("9.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("171fe05f-6316-4776-a95d-a85ef8c30334"), Code="IsAssessedBy", Description="Is Assessed By", Definition="The destination of the association may be used to assess the origin of the association.", SortOrder=Convert.ToDecimal("10.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("42b92cfe-2df7-4041-93a6-7be4045469dc"), Code="IsConformedTo", Description="Is Conformed To", Definition="The destination of the association references an established standard to which the origin of the association conforms.", SortOrder=Convert.ToDecimal("11.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("b2c86abe-6d38-446e-9f25-9f843478b0b9"), Code="IsDefinedBy", Description="Is Defined By", Definition="Context or meaning for understanding the origin of the association is provided by the destination of the association.", SortOrder=Convert.ToDecimal("12.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("5697d617-2468-440d-9bba-d2d2652e8489"), Code="FormatOf", Description="Is Format of", Definition="The destination of the association is substantially the same as the resource at the origin of the association, but in another format.", SortOrder=Convert.ToDecimal("14.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("1e4f3b67-55af-4668-a834-590a9b696099"), Code="IsPartOf", Description="Is Part Of", Definition="The origin of the association is included either physically or logically in the resource at the destination of the association.", SortOrder=Convert.ToDecimal("15.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("caed117b-5b5c-4c3b-8db4-d336205af5e9"), Code="IsPrerequisiteTo", Description="Is Prerequisite To", Definition="The origin of the association is required as a prior condition for the destination of the association.", SortOrder=Convert.ToDecimal("16.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("53aabeee-86ad-46b7-82e4-18e4655981ac"), Code="ReferencedBy", Description="Is Referenced By", Definition="The origin of the association is cited by the resource at the destination of the association.", SortOrder=Convert.ToDecimal("17.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("5a21ad14-4ce2-4c71-9b1b-20902d9858e4"), Code="ReplacedBy", Description="Is Replaced By", Definition="The origin of the association has been supplanted by, displaced by, or superseded by the destination of the association.", SortOrder=Convert.ToDecimal("18.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("12700297-559d-4ebd-bd19-b000e34b471f"), Code="RequiredBy", Description="Is Required By", Definition="The origin of the association is required by the destination of the association to support its function, delivery, or coherence.", SortOrder=Convert.ToDecimal("19.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("e673ddb5-ca5a-4de4-9a49-7c2c9ff26817"), Code="IsTaughtBy", Description="Is Taught By", Definition="The competency at the origin of the association may be taught by the resource or method at the destination of the association.", SortOrder=Convert.ToDecimal("20.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("b0f052d0-443c-443b-8604-12e60e6f989e"), Code="VersionOf", Description="Is Version Of", Definition="The origin of the association is a version, edition, or adaptation of the resource at the destination of the association.", SortOrder=Convert.ToDecimal("21.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("85b57daa-202e-408c-96fa-e6ad72952c80"), Code="Referenced", Description="Referenced", Definition="The origin of the association cites the resource at the destination of the association.", SortOrder=Convert.ToDecimal("22.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("e266aca6-8302-4fe3-8209-750035d3f17c"), Code="Assesses", Description="Assesses", Definition="The origin of the association may be used to assess the destination of the association.", SortOrder=Convert.ToDecimal("23.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("d53b00fb-5b71-4948-815b-af4c28975080"), Code="Teaches", Description="Teaches", Definition="The resource or method at the origin of the association may be used to teach the competency at the destination of the association.", SortOrder=Convert.ToDecimal("25.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("f671262b-a8e1-456d-b9fe-80ffdb49f4fb"), Code="Requires", Description="Requires", Definition="The origin of the association requires the destination of the association to support its function, delivery, or coherence.", SortOrder=Convert.ToDecimal("27.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("321d0962-70b0-4ce2-9768-e1b9c7f7ac43"), Code="ComplexityLevel", Description="Complexity Level", Definition="The point in the framework being referenced defines a level or range that measures the difficulty or challenge presented by the learning resource being described.", SortOrder=Convert.ToDecimal("29.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("ab1f68c5-ccc4-4917-9701-9783663de323"), Code="ReadingLevel", Description="Reading Level", Definition="The destination of the association defines a level or range of ability expected for a person using the resource at the origin of the association.", SortOrder=Convert.ToDecimal("31.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("91e7c43a-1bb3-4d45-b201-53c41749a767"), Code="EducationalSubject", Description="Educational Subject", Definition="The destination of the association defines a topic or subject from a controlled vocabulary.", SortOrder=Convert.ToDecimal("33.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("fbf7418e-238d-431f-b02f-e6d13c8c6abb"), Code="EducationLevel", Description="Education Level", Definition="The destination of the association defines an education level from a controlled vocabulary.", SortOrder=Convert.ToDecimal("35.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("a9248870-5e17-475b-9d8f-44ba658b2808"), Code="Precedes", Description="Precedes", Definition="The origin of the association comes before the destination of the association in time or order.", SortOrder=Convert.ToDecimal("37.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("48458839-a585-4cc9-92a6-4db0a14678d2"), Code="Follows", Description="Follows", Definition="The origin of the association comes after the destination of the association in time or order.", SortOrder=Convert.ToDecimal("39.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("932844d2-ae15-49cb-94f3-97a14b79cbe5"), Code="IsConcurrentTo", Description="Is Concurrent To", Definition="The origin of the association is achieved or delivered at the same time, or has the same ordinal position, as the destination of the association.", SortOrder=Convert.ToDecimal("41.00") },
        };

        /// <summary>
        /// The RefCompetencyDefAssociationType Pick List
         /// </summary>
        public static List<RefCompetencyDefAssociationType> RefCompetencyDefAssociationTypePickList = new List<RefCompetencyDefAssociationType>
        {
            new RefCompetencyDefAssociationType { Id=Guid.Parse("4f1b7d1f-0ba4-4943-9f6b-41510daaf56a"), Code="Prerequisite", Description="Prerequisite", SortOrder=Convert.ToDecimal("1.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("61a41f87-e6c9-4ca0-aa4a-bd3d41e4db18"), Code="ConformsTo", Description="Conforms To", SortOrder=Convert.ToDecimal("3.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("b98cc248-1379-4581-9486-619f771a6a69"), Code="Defines", Description="Defines", SortOrder=Convert.ToDecimal("4.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("a9613e16-493d-4f76-beda-7f33801a939c"), Code="HasFormat", Description="Has Format", SortOrder=Convert.ToDecimal("5.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("1a91ff4f-368f-4940-9f9c-e388e8670000"), Code="HasPart", Description="Has Part", SortOrder=Convert.ToDecimal("7.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("922b8f4c-3563-4c2c-a832-8af1c6b7ca0b"), Code="HasVersion", Description="Has Version", SortOrder=Convert.ToDecimal("9.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("171fe05f-6316-4776-a95d-a85ef8c30334"), Code="IsAssessedBy", Description="Is Assessed By", SortOrder=Convert.ToDecimal("10.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("42b92cfe-2df7-4041-93a6-7be4045469dc"), Code="IsConformedTo", Description="Is Conformed To", SortOrder=Convert.ToDecimal("11.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("b2c86abe-6d38-446e-9f25-9f843478b0b9"), Code="IsDefinedBy", Description="Is Defined By", SortOrder=Convert.ToDecimal("12.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("5697d617-2468-440d-9bba-d2d2652e8489"), Code="FormatOf", Description="Is Format of", SortOrder=Convert.ToDecimal("14.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("1e4f3b67-55af-4668-a834-590a9b696099"), Code="IsPartOf", Description="Is Part Of", SortOrder=Convert.ToDecimal("15.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("caed117b-5b5c-4c3b-8db4-d336205af5e9"), Code="IsPrerequisiteTo", Description="Is Prerequisite To", SortOrder=Convert.ToDecimal("16.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("53aabeee-86ad-46b7-82e4-18e4655981ac"), Code="ReferencedBy", Description="Is Referenced By", SortOrder=Convert.ToDecimal("17.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("5a21ad14-4ce2-4c71-9b1b-20902d9858e4"), Code="ReplacedBy", Description="Is Replaced By", SortOrder=Convert.ToDecimal("18.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("12700297-559d-4ebd-bd19-b000e34b471f"), Code="RequiredBy", Description="Is Required By", SortOrder=Convert.ToDecimal("19.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("e673ddb5-ca5a-4de4-9a49-7c2c9ff26817"), Code="IsTaughtBy", Description="Is Taught By", SortOrder=Convert.ToDecimal("20.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("b0f052d0-443c-443b-8604-12e60e6f989e"), Code="VersionOf", Description="Is Version Of", SortOrder=Convert.ToDecimal("21.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("85b57daa-202e-408c-96fa-e6ad72952c80"), Code="Referenced", Description="Referenced", SortOrder=Convert.ToDecimal("22.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("e266aca6-8302-4fe3-8209-750035d3f17c"), Code="Assesses", Description="Assesses", SortOrder=Convert.ToDecimal("23.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("d53b00fb-5b71-4948-815b-af4c28975080"), Code="Teaches", Description="Teaches", SortOrder=Convert.ToDecimal("25.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("f671262b-a8e1-456d-b9fe-80ffdb49f4fb"), Code="Requires", Description="Requires", SortOrder=Convert.ToDecimal("27.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("321d0962-70b0-4ce2-9768-e1b9c7f7ac43"), Code="ComplexityLevel", Description="Complexity Level", SortOrder=Convert.ToDecimal("29.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("ab1f68c5-ccc4-4917-9701-9783663de323"), Code="ReadingLevel", Description="Reading Level", SortOrder=Convert.ToDecimal("31.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("91e7c43a-1bb3-4d45-b201-53c41749a767"), Code="EducationalSubject", Description="Educational Subject", SortOrder=Convert.ToDecimal("33.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("fbf7418e-238d-431f-b02f-e6d13c8c6abb"), Code="EducationLevel", Description="Education Level", SortOrder=Convert.ToDecimal("35.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("a9248870-5e17-475b-9d8f-44ba658b2808"), Code="Precedes", Description="Precedes", SortOrder=Convert.ToDecimal("37.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("48458839-a585-4cc9-92a6-4db0a14678d2"), Code="Follows", Description="Follows", SortOrder=Convert.ToDecimal("39.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("932844d2-ae15-49cb-94f3-97a14b79cbe5"), Code="IsConcurrentTo", Description="Is Concurrent To", SortOrder=Convert.ToDecimal("41.00") },
       };
   }
}
