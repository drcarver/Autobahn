//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEntityTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEntityType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEntityType"> List
         /// </summary>
        public static List<RefEntityType> RefEntityTypeList = new List<RefEntityType>
        {
            new RefEntityType { Id=Guid.Parse("d2b06db6-26b1-48dd-aaef-f7e5a7e7fdc9"), Code="11000", Description="Early Learning", Definition="", SortOrder=Convert.ToDecimal("10.00") },
            new RefEntityType { Id=Guid.Parse("a993cb6e-3e69-4e82-a872-bb9a7efd4d11"), Code="11001", Description="K12", Definition="", SortOrder=Convert.ToDecimal("20.00") },
            new RefEntityType { Id=Guid.Parse("4dd79b27-460d-4e5a-bba4-9928346cb29c"), Code="11002", Description="Postsecondary", Definition="", SortOrder=Convert.ToDecimal("30.00") },
            new RefEntityType { Id=Guid.Parse("1345c932-8cd7-4014-97a5-74196324f3d3"), Code="11112", Description="Career and Technical", Definition="", SortOrder=Convert.ToDecimal("40.00") },
            new RefEntityType { Id=Guid.Parse("adb45f90-a4ec-4781-a144-e4bf9a9e85f5"), Code="11113", Description="Adult Education", Definition="", SortOrder=Convert.ToDecimal("50.00") },
            new RefEntityType { Id=Guid.Parse("acbd0f7e-93b1-4d2e-a5a1-a0034a5ca72a"), Code="11114", Description="Workforce", Definition="", SortOrder=Convert.ToDecimal("60.00") },
            new RefEntityType { Id=Guid.Parse("ea95548b-2d97-4a01-9cf5-138bb40470f8"), Code="11089", Description="Assessments", Definition="", SortOrder=Convert.ToDecimal("70.00") },
            new RefEntityType { Id=Guid.Parse("8fed842d-f6a2-4e60-9e2c-b132a22c566b"), Code="11482", Description="Credentials", Definition="", SortOrder=Convert.ToDecimal("80.00") },
            new RefEntityType { Id=Guid.Parse("2ed3117d-3f05-44f8-8d40-5da7589473d5"), Code="11104", Description="Competencies", Definition="", SortOrder=Convert.ToDecimal("90.00") },
            new RefEntityType { Id=Guid.Parse("3a74389c-ad68-4463-8047-375d8a82f65a"), Code="11123", Description="Learning Resources", Definition="", SortOrder=Convert.ToDecimal("100.00") },
            new RefEntityType { Id=Guid.Parse("7988d81e-45f8-4684-ab58-1b812dd9e4ec"), Code="11571", Description="Facilities", Definition="", SortOrder=Convert.ToDecimal("110.00") },
            new RefEntityType { Id=Guid.Parse("938c22de-0e74-4bdd-9b3a-335c80ee6274"), Code="11566", Description="Implementation Variables", Definition="", SortOrder=Convert.ToDecimal("120.00") },
            new RefEntityType { Id=Guid.Parse("5f816a45-27bc-482e-b32b-b1ab76b0c19a"), Code="11440", Description="Authentication and Authorization", Definition="", SortOrder=Convert.ToDecimal("130.00") },
            new RefEntityType { Id=Guid.Parse("5ed33034-dc92-4c40-b303-7dfcc098726c"), Code="Course", Description="Course Table", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefEntityType { Id=Guid.Parse("a47f9653-f7d3-4096-8b96-e0f98231248e"), Code="LearningResource", Description="LearningResource Table", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefEntityType { Id=Guid.Parse("09317ad6-612c-44b2-ba82-88e2451874c2"), Code="AssessmentItem", Description="AssessmentItem Table", Definition="", SortOrder=Convert.ToDecimal("3.00") },
            new RefEntityType { Id=Guid.Parse("f808370b-b5f9-4ac7-a704-e46cdd74c551"), Code="RubricCriterion", Description="RubricCriterion Table", Definition="", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefEntityType Pick List
         /// </summary>
        public static List<RefEntityType> RefEntityTypePickList = new List<RefEntityType>
        {
            new RefEntityType { Id=Guid.Parse("d2b06db6-26b1-48dd-aaef-f7e5a7e7fdc9"), Code="11000", Description="Early Learning", SortOrder=Convert.ToDecimal("10.00") },
            new RefEntityType { Id=Guid.Parse("a993cb6e-3e69-4e82-a872-bb9a7efd4d11"), Code="11001", Description="K12", SortOrder=Convert.ToDecimal("20.00") },
            new RefEntityType { Id=Guid.Parse("4dd79b27-460d-4e5a-bba4-9928346cb29c"), Code="11002", Description="Postsecondary", SortOrder=Convert.ToDecimal("30.00") },
            new RefEntityType { Id=Guid.Parse("1345c932-8cd7-4014-97a5-74196324f3d3"), Code="11112", Description="Career and Technical", SortOrder=Convert.ToDecimal("40.00") },
            new RefEntityType { Id=Guid.Parse("adb45f90-a4ec-4781-a144-e4bf9a9e85f5"), Code="11113", Description="Adult Education", SortOrder=Convert.ToDecimal("50.00") },
            new RefEntityType { Id=Guid.Parse("acbd0f7e-93b1-4d2e-a5a1-a0034a5ca72a"), Code="11114", Description="Workforce", SortOrder=Convert.ToDecimal("60.00") },
            new RefEntityType { Id=Guid.Parse("ea95548b-2d97-4a01-9cf5-138bb40470f8"), Code="11089", Description="Assessments", SortOrder=Convert.ToDecimal("70.00") },
            new RefEntityType { Id=Guid.Parse("8fed842d-f6a2-4e60-9e2c-b132a22c566b"), Code="11482", Description="Credentials", SortOrder=Convert.ToDecimal("80.00") },
            new RefEntityType { Id=Guid.Parse("2ed3117d-3f05-44f8-8d40-5da7589473d5"), Code="11104", Description="Competencies", SortOrder=Convert.ToDecimal("90.00") },
            new RefEntityType { Id=Guid.Parse("3a74389c-ad68-4463-8047-375d8a82f65a"), Code="11123", Description="Learning Resources", SortOrder=Convert.ToDecimal("100.00") },
            new RefEntityType { Id=Guid.Parse("7988d81e-45f8-4684-ab58-1b812dd9e4ec"), Code="11571", Description="Facilities", SortOrder=Convert.ToDecimal("110.00") },
            new RefEntityType { Id=Guid.Parse("938c22de-0e74-4bdd-9b3a-335c80ee6274"), Code="11566", Description="Implementation Variables", SortOrder=Convert.ToDecimal("120.00") },
            new RefEntityType { Id=Guid.Parse("5f816a45-27bc-482e-b32b-b1ab76b0c19a"), Code="11440", Description="Authentication and Authorization", SortOrder=Convert.ToDecimal("130.00") },
            new RefEntityType { Id=Guid.Parse("5ed33034-dc92-4c40-b303-7dfcc098726c"), Code="Course", Description="Course Table", SortOrder=Convert.ToDecimal("1.00") },
            new RefEntityType { Id=Guid.Parse("a47f9653-f7d3-4096-8b96-e0f98231248e"), Code="LearningResource", Description="LearningResource Table", SortOrder=Convert.ToDecimal("2.00") },
            new RefEntityType { Id=Guid.Parse("09317ad6-612c-44b2-ba82-88e2451874c2"), Code="AssessmentItem", Description="AssessmentItem Table", SortOrder=Convert.ToDecimal("3.00") },
            new RefEntityType { Id=Guid.Parse("f808370b-b5f9-4ac7-a704-e46cdd74c551"), Code="RubricCriterion", Description="RubricCriterion Table", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
