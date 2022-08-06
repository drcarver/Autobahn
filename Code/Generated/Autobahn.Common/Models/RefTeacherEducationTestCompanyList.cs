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
        public static List<RefTeacherEducationTestCompany> RefTeacherEducationTestCompanyList = new List<RefTeacherEducationTestCompany>
        {
            new RefTeacherEducationTestCompany { Id=Guid.Parse("1ad4313c-7a4b-4a24-b45b-15d5e985ec47"), Code="1", Description="Educational Testing Service (ETS)", Definition="Educational Testing Service (ETS) is the company that provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("c182ed2d-77fa-41e7-a342-efe9754a36db"), Code="2", Description="Evaluation Systems Group of Pearson", Definition="Evaluation Systems Group of Pearson is the company that provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("2.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("016d67c5-93cc-4bc4-a044-724fe7785f91"), Code="3", Description="College Board", Definition="College Board is the company that provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("b2e19698-cbae-4fbf-a520-a8b5f7dec80c"), Code="4", Description="American Board for Certification of Teacher Excellence (ABCTE)", Definition="American Board for Certification of Teacher Excellence (ABCTE) is the company that provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("4.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("c6f97ac7-526d-4743-8753-6a0060b1feef"), Code="5", Description="American Council on the Teaching of Foreign Languages (ACTFL)", Definition="American Council on the Teaching of Foreign Languages (ACTFL) is the company that provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("5.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("7aacbade-16de-40c8-a27a-e9ae1e90a55a"), Code="98", Description="State", Definition="The state provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("98.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("477f16de-8ae8-4ce8-81e8-1d064c976ebe"), Code="99", Description="Other", Definition="The company that provides the examination used in the teacher education program is not yet included in CEDS.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefTeacherEducationTestCompany Pick List
         /// </summary>
        public static List<RefTeacherEducationTestCompany> RefTeacherEducationTestCompanyPickList = new List<RefTeacherEducationTestCompany>
        {
            new RefTeacherEducationTestCompany { Id=Guid.Parse("1ad4313c-7a4b-4a24-b45b-15d5e985ec47"), Code="1", Description="Educational Testing Service (ETS)", SortOrder=Convert.ToDecimal("1.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("c182ed2d-77fa-41e7-a342-efe9754a36db"), Code="2", Description="Evaluation Systems Group of Pearson", SortOrder=Convert.ToDecimal("2.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("016d67c5-93cc-4bc4-a044-724fe7785f91"), Code="3", Description="College Board", SortOrder=Convert.ToDecimal("3.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("b2e19698-cbae-4fbf-a520-a8b5f7dec80c"), Code="4", Description="American Board for Certification of Teacher Excellence (ABCTE)", SortOrder=Convert.ToDecimal("4.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("c6f97ac7-526d-4743-8753-6a0060b1feef"), Code="5", Description="American Council on the Teaching of Foreign Languages (ACTFL)", SortOrder=Convert.ToDecimal("5.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("7aacbade-16de-40c8-a27a-e9ae1e90a55a"), Code="98", Description="State", SortOrder=Convert.ToDecimal("98.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("477f16de-8ae8-4ce8-81e8-1d064c976ebe"), Code="99", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
