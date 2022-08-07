//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEntityTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEntityType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEntityTypeModel"> List
         /// </summary>
        public static List<RefEntityTypeModel> RefEntityTypeList = new List<RefEntityTypeModel>
        {
            new RefEntityType { Id=Guid.Parse("d18a2970-52f0-4fd1-9b61-05ca13029c4a"), Code="11000", Description="Early Learning", Definition="", SortOrder=Convert.ToDecimal("10.00") },
            new RefEntityType { Id=Guid.Parse("a5db84c3-88db-43e6-9103-fc37e4b56001"), Code="11001", Description="K12", Definition="", SortOrder=Convert.ToDecimal("20.00") },
            new RefEntityType { Id=Guid.Parse("aa7db5e9-395d-4bc3-b13f-fa4e9872e7f3"), Code="11002", Description="Postsecondary", Definition="", SortOrder=Convert.ToDecimal("30.00") },
            new RefEntityType { Id=Guid.Parse("5869ab63-2307-4a6c-8d12-44bfaf0bc52f"), Code="11112", Description="Career and Technical", Definition="", SortOrder=Convert.ToDecimal("40.00") },
            new RefEntityType { Id=Guid.Parse("bf83a538-3c66-41ed-8aea-2f2758b588b2"), Code="11113", Description="Adult Education", Definition="", SortOrder=Convert.ToDecimal("50.00") },
            new RefEntityType { Id=Guid.Parse("41926eeb-22b1-449b-9cf6-ab2ed9528ba6"), Code="11114", Description="Workforce", Definition="", SortOrder=Convert.ToDecimal("60.00") },
            new RefEntityType { Id=Guid.Parse("ee68234e-8c86-4929-a8aa-354ed59045e0"), Code="11089", Description="Assessments", Definition="", SortOrder=Convert.ToDecimal("70.00") },
            new RefEntityType { Id=Guid.Parse("57d821d9-ac71-448a-958f-548509c30de1"), Code="11482", Description="Credentials", Definition="", SortOrder=Convert.ToDecimal("80.00") },
            new RefEntityType { Id=Guid.Parse("534e15be-e5b8-4738-8e49-b381345e3388"), Code="11104", Description="Competencies", Definition="", SortOrder=Convert.ToDecimal("90.00") },
            new RefEntityType { Id=Guid.Parse("a42fa269-8a63-4ddc-b27f-5de7fec8dd8c"), Code="11123", Description="Learning Resources", Definition="", SortOrder=Convert.ToDecimal("100.00") },
            new RefEntityType { Id=Guid.Parse("39630338-7540-4c0a-baed-1463b73650a7"), Code="11571", Description="Facilities", Definition="", SortOrder=Convert.ToDecimal("110.00") },
            new RefEntityType { Id=Guid.Parse("7900cf99-2719-4ed3-ac92-5cb29573656c"), Code="11566", Description="Implementation Variables", Definition="", SortOrder=Convert.ToDecimal("120.00") },
            new RefEntityType { Id=Guid.Parse("38948ee8-2842-48df-bb30-772420d11928"), Code="11440", Description="Authentication and Authorization", Definition="", SortOrder=Convert.ToDecimal("130.00") },
            new RefEntityType { Id=Guid.Parse("28746c79-fbab-4738-8fd4-7b57dc0870c5"), Code="Course", Description="Course Table", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefEntityType { Id=Guid.Parse("c1f0c8ae-8b63-411d-bbb0-6aa03fcd934b"), Code="LearningResource", Description="LearningResource Table", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefEntityType { Id=Guid.Parse("312f693c-2ddc-45d0-bac1-be77c65c4d24"), Code="AssessmentItem", Description="AssessmentItem Table", Definition="", SortOrder=Convert.ToDecimal("3.00") },
            new RefEntityType { Id=Guid.Parse("ebf58e06-1eae-4866-a0f0-911ab713be61"), Code="RubricCriterion", Description="RubricCriterion Table", Definition="", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefEntityType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefEntityTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefEntityType { Id=Guid.Parse("d18a2970-52f0-4fd1-9b61-05ca13029c4a"), Description="Early Learning", SortOrder=Convert.ToDecimal("10.00") },
            new RefEntityType { Id=Guid.Parse("a5db84c3-88db-43e6-9103-fc37e4b56001"), Description="K12", SortOrder=Convert.ToDecimal("20.00") },
            new RefEntityType { Id=Guid.Parse("aa7db5e9-395d-4bc3-b13f-fa4e9872e7f3"), Description="Postsecondary", SortOrder=Convert.ToDecimal("30.00") },
            new RefEntityType { Id=Guid.Parse("5869ab63-2307-4a6c-8d12-44bfaf0bc52f"), Description="Career and Technical", SortOrder=Convert.ToDecimal("40.00") },
            new RefEntityType { Id=Guid.Parse("bf83a538-3c66-41ed-8aea-2f2758b588b2"), Description="Adult Education", SortOrder=Convert.ToDecimal("50.00") },
            new RefEntityType { Id=Guid.Parse("41926eeb-22b1-449b-9cf6-ab2ed9528ba6"), Description="Workforce", SortOrder=Convert.ToDecimal("60.00") },
            new RefEntityType { Id=Guid.Parse("ee68234e-8c86-4929-a8aa-354ed59045e0"), Description="Assessments", SortOrder=Convert.ToDecimal("70.00") },
            new RefEntityType { Id=Guid.Parse("57d821d9-ac71-448a-958f-548509c30de1"), Description="Credentials", SortOrder=Convert.ToDecimal("80.00") },
            new RefEntityType { Id=Guid.Parse("534e15be-e5b8-4738-8e49-b381345e3388"), Description="Competencies", SortOrder=Convert.ToDecimal("90.00") },
            new RefEntityType { Id=Guid.Parse("a42fa269-8a63-4ddc-b27f-5de7fec8dd8c"), Description="Learning Resources", SortOrder=Convert.ToDecimal("100.00") },
            new RefEntityType { Id=Guid.Parse("39630338-7540-4c0a-baed-1463b73650a7"), Description="Facilities", SortOrder=Convert.ToDecimal("110.00") },
            new RefEntityType { Id=Guid.Parse("7900cf99-2719-4ed3-ac92-5cb29573656c"), Description="Implementation Variables", SortOrder=Convert.ToDecimal("120.00") },
            new RefEntityType { Id=Guid.Parse("38948ee8-2842-48df-bb30-772420d11928"), Description="Authentication and Authorization", SortOrder=Convert.ToDecimal("130.00") },
            new RefEntityType { Id=Guid.Parse("28746c79-fbab-4738-8fd4-7b57dc0870c5"), Description="Course Table", SortOrder=Convert.ToDecimal("1.00") },
            new RefEntityType { Id=Guid.Parse("c1f0c8ae-8b63-411d-bbb0-6aa03fcd934b"), Description="LearningResource Table", SortOrder=Convert.ToDecimal("2.00") },
            new RefEntityType { Id=Guid.Parse("312f693c-2ddc-45d0-bac1-be77c65c4d24"), Description="AssessmentItem Table", SortOrder=Convert.ToDecimal("3.00") },
            new RefEntityType { Id=Guid.Parse("ebf58e06-1eae-4866-a0f0-911ab713be61"), Description="RubricCriterion Table", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
