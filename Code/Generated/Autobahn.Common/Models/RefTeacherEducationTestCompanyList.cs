//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTeacherEducationTestCompanyList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefTeacherEducationTestCompany Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTeacherEducationTestCompany"> List
         /// </summary>
        public static List<RefTeacherEducationTestCompany> RefTeacherEducationTestCompanyList = new List<RefTeacherEducationTestCompany> =
        {
            new RefTeacherEducationTestCompany { Id=Guid.Parse("45e8fb6e-adf4-4fe1-8a8d-9ecc592caa62"), Code="Educational Testing Service (ETS) is the company that provides the examination used in the teacher education program.", Description="1", Definition="", SortOrder=0 },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("502fdea8-3dd9-49ea-b179-8a95d03b743d"), Code="Evaluation Systems Group of Pearson is the company that provides the examination used in the teacher education program.", Description="2", Definition="", SortOrder=0 },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("7303e905-82a0-463b-9a63-c7e0361e412a"), Code="College Board is the company that provides the examination used in the teacher education program.", Description="3", Definition="", SortOrder=0 },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("ea1d3491-74a2-4984-ae34-a0e963ec0879"), Code="American Board for Certification of Teacher Excellence (ABCTE) is the company that provides the examination used in the teacher education program.", Description="4", Definition="", SortOrder=0 },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("70c377e0-a1a9-42a3-9c32-3ab968dc1a94"), Code="American Council on the Teaching of Foreign Languages (ACTFL) is the company that provides the examination used in the teacher education program.", Description="5", Definition="", SortOrder=0 },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("f8bf2334-9200-4bc3-8f9a-eab485b143af"), Code="The state provides the examination used in the teacher education program.", Description="98", Definition="", SortOrder=0 },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("109ee7f7-ff10-4de5-b698-c8d845a393ce"), Code="The company that provides the examination used in the teacher education program is not yet included in CEDS.", Description="99", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefTeacherEducationTestCompany Pick List
         /// </summary>
        public static List<RefTeacherEducationTestCompany> RefTeacherEducationTestCompanyPickList = new List<RefTeacherEducationTestCompany> =
        {
            new RefTeacherEducationTestCompany { Id=Guid.Parse("45e8fb6e-adf4-4fe1-8a8d-9ecc592caa62"), Code="Educational Testing Service (ETS) is the company that provides the examination used in the teacher education program.", SortOrder=0 },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("502fdea8-3dd9-49ea-b179-8a95d03b743d"), Code="Evaluation Systems Group of Pearson is the company that provides the examination used in the teacher education program.", SortOrder=0 },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("7303e905-82a0-463b-9a63-c7e0361e412a"), Code="College Board is the company that provides the examination used in the teacher education program.", SortOrder=0 },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("ea1d3491-74a2-4984-ae34-a0e963ec0879"), Code="American Board for Certification of Teacher Excellence (ABCTE) is the company that provides the examination used in the teacher education program.", SortOrder=0 },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("70c377e0-a1a9-42a3-9c32-3ab968dc1a94"), Code="American Council on the Teaching of Foreign Languages (ACTFL) is the company that provides the examination used in the teacher education program.", SortOrder=0 },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("f8bf2334-9200-4bc3-8f9a-eab485b143af"), Code="The state provides the examination used in the teacher education program.", SortOrder=0 },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("109ee7f7-ff10-4de5-b698-c8d845a393ce"), Code="The company that provides the examination used in the teacher education program is not yet included in CEDS.", SortOrder=0 },
       };
   }
}
