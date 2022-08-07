//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCurriculumFrameworkTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCurriculumFrameworkType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCurriculumFrameworkTypeModel"> List
         /// </summary>
        public static List<RefCurriculumFrameworkTypeModel> RefCurriculumFrameworkTypeList = new List<RefCurriculumFrameworkTypeModel>
        {
            new RefCurriculumFrameworkType { Id=Guid.Parse("8f1072ef-eca4-45e9-9142-aa9d3b2c5ac0"), Code="LEA", Description="Local Education Agency (LEA) curriculum framework", Definition="A Local Education Agency (LEA) curriculum framework is the standard curriculum used for this course.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCurriculumFrameworkType { Id=Guid.Parse("12456eb5-50ad-4499-870d-e54deef3f8aa"), Code="NationalStandard", Description="National curriculum standard", Definition="A national curriculum standard is the standard curriculum used for this course.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCurriculumFrameworkType { Id=Guid.Parse("99396ab1-7506-4d7d-a8bc-4c8b9ceacd66"), Code="PrivateOrReligious", Description="Private, religious curriculum", Definition="A private, religious curriculum is the standard curriculum used for this course.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCurriculumFrameworkType { Id=Guid.Parse("6c6067c9-cf00-4f46-9726-80b06c779980"), Code="School", Description="School curriculum framework", Definition="A school curriculum framework is the standard curriculum used for this course.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCurriculumFrameworkType { Id=Guid.Parse("9e28f148-0985-42c7-99d7-1a16fbdc2f49"), Code="State", Description="State curriculum framework", Definition="A state curriculum framework is the standard curriculum used for this course.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCurriculumFrameworkType { Id=Guid.Parse("f1abefd9-f7ee-41a8-8516-51af588e9692"), Code="Other", Description="Other", Definition="The standard curriculum used for this course is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The Reference RefCurriculumFrameworkType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCurriculumFrameworkTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCurriculumFrameworkType { Id=Guid.Parse("8f1072ef-eca4-45e9-9142-aa9d3b2c5ac0"), Description="Local Education Agency (LEA) curriculum framework", SortOrder=Convert.ToDecimal("1.00") },
            new RefCurriculumFrameworkType { Id=Guid.Parse("12456eb5-50ad-4499-870d-e54deef3f8aa"), Description="National curriculum standard", SortOrder=Convert.ToDecimal("2.00") },
            new RefCurriculumFrameworkType { Id=Guid.Parse("99396ab1-7506-4d7d-a8bc-4c8b9ceacd66"), Description="Private, religious curriculum", SortOrder=Convert.ToDecimal("3.00") },
            new RefCurriculumFrameworkType { Id=Guid.Parse("6c6067c9-cf00-4f46-9726-80b06c779980"), Description="School curriculum framework", SortOrder=Convert.ToDecimal("4.00") },
            new RefCurriculumFrameworkType { Id=Guid.Parse("9e28f148-0985-42c7-99d7-1a16fbdc2f49"), Description="State curriculum framework", SortOrder=Convert.ToDecimal("5.00") },
            new RefCurriculumFrameworkType { Id=Guid.Parse("f1abefd9-f7ee-41a8-8516-51af588e9692"), Description="Other", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
