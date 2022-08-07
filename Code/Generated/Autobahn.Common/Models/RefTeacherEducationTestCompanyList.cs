//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTeacherEducationTestCompanyList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefTeacherEducationTestCompany Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTeacherEducationTestCompanyModel"> List
         /// </summary>
        public static List<RefTeacherEducationTestCompanyModel> RefTeacherEducationTestCompanyList = new List<RefTeacherEducationTestCompanyModel>
        {
            new RefTeacherEducationTestCompany { Id=Guid.Parse("3131e8c5-4012-4750-8aed-82cfea034736"), Code="1", Description="Educational Testing Service (ETS)", Definition="Educational Testing Service (ETS) is the company that provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("c919b801-45c4-4703-b681-96cdb765d067"), Code="2", Description="Evaluation Systems Group of Pearson", Definition="Evaluation Systems Group of Pearson is the company that provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("2.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("18b671ae-8775-4f16-b9c6-895361db4ed3"), Code="3", Description="College Board", Definition="College Board is the company that provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("4791c35e-e204-4a4a-91d8-755d07c1624d"), Code="4", Description="American Board for Certification of Teacher Excellence (ABCTE)", Definition="American Board for Certification of Teacher Excellence (ABCTE) is the company that provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("4.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("dba36b99-6e6f-4d13-9f63-f039e175714e"), Code="5", Description="American Council on the Teaching of Foreign Languages (ACTFL)", Definition="American Council on the Teaching of Foreign Languages (ACTFL) is the company that provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("5.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("a0290dc7-8723-415d-aabd-d1438ae5f57c"), Code="98", Description="State", Definition="The state provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("98.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("98af98cf-83a0-4293-a827-51534203d4ae"), Code="99", Description="Other", Definition="The company that provides the examination used in the teacher education program is not yet included in CEDS.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefTeacherEducationTestCompany Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefTeacherEducationTestCompanyViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefTeacherEducationTestCompany { Id=Guid.Parse("3131e8c5-4012-4750-8aed-82cfea034736"), Description="Educational Testing Service (ETS)", SortOrder=Convert.ToDecimal("1.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("c919b801-45c4-4703-b681-96cdb765d067"), Description="Evaluation Systems Group of Pearson", SortOrder=Convert.ToDecimal("2.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("18b671ae-8775-4f16-b9c6-895361db4ed3"), Description="College Board", SortOrder=Convert.ToDecimal("3.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("4791c35e-e204-4a4a-91d8-755d07c1624d"), Description="American Board for Certification of Teacher Excellence (ABCTE)", SortOrder=Convert.ToDecimal("4.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("dba36b99-6e6f-4d13-9f63-f039e175714e"), Description="American Council on the Teaching of Foreign Languages (ACTFL)", SortOrder=Convert.ToDecimal("5.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("a0290dc7-8723-415d-aabd-d1438ae5f57c"), Description="State", SortOrder=Convert.ToDecimal("98.00") },
            new RefTeacherEducationTestCompany { Id=Guid.Parse("98af98cf-83a0-4293-a827-51534203d4ae"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
