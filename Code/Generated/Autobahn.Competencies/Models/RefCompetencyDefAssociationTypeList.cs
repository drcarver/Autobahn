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
        /// The complete <see cref="RefCompetencyDefAssociationTypeModel"> List
         /// </summary>
        public static List<RefCompetencyDefAssociationTypeModel> RefCompetencyDefAssociationTypeList = new List<RefCompetencyDefAssociationTypeModel>
        {
            new RefCompetencyDefAssociationType { Id=Guid.Parse("87e24a57-2e92-4e60-820a-017ebccf2910"), Code="Prerequisite", Description="Prerequisite", Definition="The destination of the association is required as a prior condition for the origin of the association.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("c645f042-e4e7-482b-b720-cb72d0764443"), Code="ConformsTo", Description="Conforms To", Definition="The origin of the association conforms to an established standard that the destination defines.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("fb36cff1-ee09-4676-a665-b5d1945565e6"), Code="Defines", Description="Defines", Definition="The information at origin of the association provides context or meaning for understanding the destination of the association.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("4031331c-a07c-4c22-9d3e-69cd9edff673"), Code="HasFormat", Description="Has Format", Definition="The destination of the association is substantially the same as the resource at the origin of the association, but in another format.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("0cc58894-31b7-45e8-8a64-6b539dd80f43"), Code="HasPart", Description="Has Part", Definition="The destination of the association is included either physically or logically in the resource at the origin of the association.", SortOrder=Convert.ToDecimal("7.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("9bd9eb55-8336-4ba6-9fab-d44076ce9cf4"), Code="HasVersion", Description="Has Version", Definition="The destination of the association is a version, edition, or adaptation of the resource at the origin of the association.", SortOrder=Convert.ToDecimal("9.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("d2c936e3-67d2-4142-820c-4b3e72ea86ef"), Code="IsAssessedBy", Description="Is Assessed By", Definition="The destination of the association may be used to assess the origin of the association.", SortOrder=Convert.ToDecimal("10.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("d7425caa-9d28-446a-90c6-211370e5bece"), Code="IsConformedTo", Description="Is Conformed To", Definition="The destination of the association references an established standard to which the origin of the association conforms.", SortOrder=Convert.ToDecimal("11.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("7c6c6cbe-0675-4062-97fe-53aba6a25f3b"), Code="IsDefinedBy", Description="Is Defined By", Definition="Context or meaning for understanding the origin of the association is provided by the destination of the association.", SortOrder=Convert.ToDecimal("12.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("746c04fb-a9d7-4111-a954-dc77b4172258"), Code="FormatOf", Description="Is Format of", Definition="The destination of the association is substantially the same as the resource at the origin of the association, but in another format.", SortOrder=Convert.ToDecimal("14.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("03518930-8edd-41af-8696-1407e1d6e3d4"), Code="IsPartOf", Description="Is Part Of", Definition="The origin of the association is included either physically or logically in the resource at the destination of the association.", SortOrder=Convert.ToDecimal("15.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("10586be2-9438-4a68-bc96-99a00f24fae2"), Code="IsPrerequisiteTo", Description="Is Prerequisite To", Definition="The origin of the association is required as a prior condition for the destination of the association.", SortOrder=Convert.ToDecimal("16.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("ecef9bb6-c3b4-4c1a-8426-4ea17c2b9f8f"), Code="ReferencedBy", Description="Is Referenced By", Definition="The origin of the association is cited by the resource at the destination of the association.", SortOrder=Convert.ToDecimal("17.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("66bc9bb9-d0b4-43db-8282-a77f5bef315a"), Code="ReplacedBy", Description="Is Replaced By", Definition="The origin of the association has been supplanted by, displaced by, or superseded by the destination of the association.", SortOrder=Convert.ToDecimal("18.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("150681a2-adbd-4c53-bd76-486bb313afed"), Code="RequiredBy", Description="Is Required By", Definition="The origin of the association is required by the destination of the association to support its function, delivery, or coherence.", SortOrder=Convert.ToDecimal("19.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("553fa808-f153-498f-9364-d69d51a5fbf6"), Code="IsTaughtBy", Description="Is Taught By", Definition="The competency at the origin of the association may be taught by the resource or method at the destination of the association.", SortOrder=Convert.ToDecimal("20.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("505cba98-a9e8-40ca-bd34-72811da410ad"), Code="VersionOf", Description="Is Version Of", Definition="The origin of the association is a version, edition, or adaptation of the resource at the destination of the association.", SortOrder=Convert.ToDecimal("21.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("75d3ddc6-6e44-4d79-85e7-9ba565a7d5d0"), Code="Referenced", Description="Referenced", Definition="The origin of the association cites the resource at the destination of the association.", SortOrder=Convert.ToDecimal("22.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("67d1a1fb-b2ba-4da7-9afe-af353c2b5334"), Code="Assesses", Description="Assesses", Definition="The origin of the association may be used to assess the destination of the association.", SortOrder=Convert.ToDecimal("23.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("4a795d73-c5e8-4945-aa83-4c33f1c6d983"), Code="Teaches", Description="Teaches", Definition="The resource or method at the origin of the association may be used to teach the competency at the destination of the association.", SortOrder=Convert.ToDecimal("25.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("da5b0e28-349e-4f03-b29b-20ce63984a5e"), Code="Requires", Description="Requires", Definition="The origin of the association requires the destination of the association to support its function, delivery, or coherence.", SortOrder=Convert.ToDecimal("27.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("5332a80d-03e4-4e90-b91f-ef4f4ce2b845"), Code="ComplexityLevel", Description="Complexity Level", Definition="The point in the framework being referenced defines a level or range that measures the difficulty or challenge presented by the learning resource being described.", SortOrder=Convert.ToDecimal("29.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("ee3f4561-ebf7-4f3e-96a0-111e5a800f12"), Code="ReadingLevel", Description="Reading Level", Definition="The destination of the association defines a level or range of ability expected for a person using the resource at the origin of the association.", SortOrder=Convert.ToDecimal("31.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("c966a2f0-a3af-4d87-8e91-46c4d62f3032"), Code="EducationalSubject", Description="Educational Subject", Definition="The destination of the association defines a topic or subject from a controlled vocabulary.", SortOrder=Convert.ToDecimal("33.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("c5bd190c-00d2-476d-ba86-6ffc724bda2f"), Code="EducationLevel", Description="Education Level", Definition="The destination of the association defines an education level from a controlled vocabulary.", SortOrder=Convert.ToDecimal("35.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("f6b5d11e-b281-474e-a8e4-91e8520910d8"), Code="Precedes", Description="Precedes", Definition="The origin of the association comes before the destination of the association in time or order.", SortOrder=Convert.ToDecimal("37.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("30547c6d-74bd-4bc1-8f0a-e08801b1992e"), Code="Follows", Description="Follows", Definition="The origin of the association comes after the destination of the association in time or order.", SortOrder=Convert.ToDecimal("39.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("c25c9323-56d9-493e-ba40-5d1bdc9a04a5"), Code="IsConcurrentTo", Description="Is Concurrent To", Definition="The origin of the association is achieved or delivered at the same time, or has the same ordinal position, as the destination of the association.", SortOrder=Convert.ToDecimal("41.00") },
        };

        /// <summary>
        /// The Reference RefCompetencyDefAssociationType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCompetencyDefAssociationTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCompetencyDefAssociationType { Id=Guid.Parse("87e24a57-2e92-4e60-820a-017ebccf2910"), Description="Prerequisite", SortOrder=Convert.ToDecimal("1.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("c645f042-e4e7-482b-b720-cb72d0764443"), Description="Conforms To", SortOrder=Convert.ToDecimal("3.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("fb36cff1-ee09-4676-a665-b5d1945565e6"), Description="Defines", SortOrder=Convert.ToDecimal("4.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("4031331c-a07c-4c22-9d3e-69cd9edff673"), Description="Has Format", SortOrder=Convert.ToDecimal("5.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("0cc58894-31b7-45e8-8a64-6b539dd80f43"), Description="Has Part", SortOrder=Convert.ToDecimal("7.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("9bd9eb55-8336-4ba6-9fab-d44076ce9cf4"), Description="Has Version", SortOrder=Convert.ToDecimal("9.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("d2c936e3-67d2-4142-820c-4b3e72ea86ef"), Description="Is Assessed By", SortOrder=Convert.ToDecimal("10.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("d7425caa-9d28-446a-90c6-211370e5bece"), Description="Is Conformed To", SortOrder=Convert.ToDecimal("11.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("7c6c6cbe-0675-4062-97fe-53aba6a25f3b"), Description="Is Defined By", SortOrder=Convert.ToDecimal("12.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("746c04fb-a9d7-4111-a954-dc77b4172258"), Description="Is Format of", SortOrder=Convert.ToDecimal("14.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("03518930-8edd-41af-8696-1407e1d6e3d4"), Description="Is Part Of", SortOrder=Convert.ToDecimal("15.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("10586be2-9438-4a68-bc96-99a00f24fae2"), Description="Is Prerequisite To", SortOrder=Convert.ToDecimal("16.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("ecef9bb6-c3b4-4c1a-8426-4ea17c2b9f8f"), Description="Is Referenced By", SortOrder=Convert.ToDecimal("17.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("66bc9bb9-d0b4-43db-8282-a77f5bef315a"), Description="Is Replaced By", SortOrder=Convert.ToDecimal("18.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("150681a2-adbd-4c53-bd76-486bb313afed"), Description="Is Required By", SortOrder=Convert.ToDecimal("19.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("553fa808-f153-498f-9364-d69d51a5fbf6"), Description="Is Taught By", SortOrder=Convert.ToDecimal("20.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("505cba98-a9e8-40ca-bd34-72811da410ad"), Description="Is Version Of", SortOrder=Convert.ToDecimal("21.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("75d3ddc6-6e44-4d79-85e7-9ba565a7d5d0"), Description="Referenced", SortOrder=Convert.ToDecimal("22.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("67d1a1fb-b2ba-4da7-9afe-af353c2b5334"), Description="Assesses", SortOrder=Convert.ToDecimal("23.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("4a795d73-c5e8-4945-aa83-4c33f1c6d983"), Description="Teaches", SortOrder=Convert.ToDecimal("25.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("da5b0e28-349e-4f03-b29b-20ce63984a5e"), Description="Requires", SortOrder=Convert.ToDecimal("27.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("5332a80d-03e4-4e90-b91f-ef4f4ce2b845"), Description="Complexity Level", SortOrder=Convert.ToDecimal("29.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("ee3f4561-ebf7-4f3e-96a0-111e5a800f12"), Description="Reading Level", SortOrder=Convert.ToDecimal("31.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("c966a2f0-a3af-4d87-8e91-46c4d62f3032"), Description="Educational Subject", SortOrder=Convert.ToDecimal("33.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("c5bd190c-00d2-476d-ba86-6ffc724bda2f"), Description="Education Level", SortOrder=Convert.ToDecimal("35.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("f6b5d11e-b281-474e-a8e4-91e8520910d8"), Description="Precedes", SortOrder=Convert.ToDecimal("37.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("30547c6d-74bd-4bc1-8f0a-e08801b1992e"), Description="Follows", SortOrder=Convert.ToDecimal("39.00") },
            new RefCompetencyDefAssociationType { Id=Guid.Parse("c25c9323-56d9-493e-ba40-5d1bdc9a04a5"), Description="Is Concurrent To", SortOrder=Convert.ToDecimal("41.00") },
       };
   }
}
