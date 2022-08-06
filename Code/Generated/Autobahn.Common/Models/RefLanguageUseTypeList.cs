//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefLanguageUseTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefLanguageUseType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLanguageUseType"> List
         /// </summary>
        public static List<RefLanguageUseType> RefLanguageUseTypeList = new List<RefLanguageUseType> =
        {
            new RefLanguageUseType { Id=Guid.Parse("5bf4e1e4-f853-40f2-a1b9-bf62ea1b9463"), Code="", Description="", Definition="", SortOrder=0 },
            new RefLanguageUseType { Id=Guid.Parse("6b947bd0-b78e-49f4-aab3-e22da20607b1"), Code="", Description="The language specified by the related Language Code is the language the person uses for both written and spoken correspondence.", Definition="1.00", SortOrder=0 },
            new RefLanguageUseType { Id=Guid.Parse("7602555e-a093-45b4-87a0-0ec86f157304"), Code="The language specified by the related Language Code is the person's dominant language.", Description="Dominant", Definition="", SortOrder=0 },
            new RefLanguageUseType { Id=Guid.Parse("a73b7357-a00c-40af-b47d-17521f570367"), Code="The language specified by the related Language Code is the language the person uses at home.", Description="Home", Definition="", SortOrder=0 },
            new RefLanguageUseType { Id=Guid.Parse("74149c34-844a-4f5c-8aff-396bc75b0aeb"), Code="The language specified by the related Language Code is the person's native language.", Description="Native", Definition="", SortOrder=0 },
            new RefLanguageUseType { Id=Guid.Parse("04fc10f7-91f7-41e8-ada5-093415c46d6a"), Code="The language specified by the related Language Code is the language the person's other language proficiency.", Description="OtherLanguageProficiency", Definition="", SortOrder=0 },
            new RefLanguageUseType { Id=Guid.Parse("0b1439b4-13ed-46f9-b8a9-b835639fd227"), Code="The function and context in which a person uses the  language specified by the related Language Code is in a category not yet defined in CEDS.", Description="Other", Definition="", SortOrder=0 },
            new RefLanguageUseType { Id=Guid.Parse("bee8ef83-6af7-402f-a56c-3a76d811df07"), Code="The language specified by the related Language Code is the language the person uses for spoken correspondence.", Description="Spoken", Definition="", SortOrder=0 },
            new RefLanguageUseType { Id=Guid.Parse("eeeef7ba-32f6-4894-81b5-dad2c1e074d4"), Code="The language specified by the related Language Code is the language the person uses for written correspondence.", Description="Written", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefLanguageUseType Pick List
         /// </summary>
        public static List<RefLanguageUseType> RefLanguageUseTypePickList = new List<RefLanguageUseType> =
        {
            new RefLanguageUseType { Id=Guid.Parse("5bf4e1e4-f853-40f2-a1b9-bf62ea1b9463"), Code="", SortOrder=0 },
            new RefLanguageUseType { Id=Guid.Parse("6b947bd0-b78e-49f4-aab3-e22da20607b1"), Code="", SortOrder=0 },
            new RefLanguageUseType { Id=Guid.Parse("7602555e-a093-45b4-87a0-0ec86f157304"), Code="The language specified by the related Language Code is the person's dominant language.", SortOrder=0 },
            new RefLanguageUseType { Id=Guid.Parse("a73b7357-a00c-40af-b47d-17521f570367"), Code="The language specified by the related Language Code is the language the person uses at home.", SortOrder=0 },
            new RefLanguageUseType { Id=Guid.Parse("74149c34-844a-4f5c-8aff-396bc75b0aeb"), Code="The language specified by the related Language Code is the person's native language.", SortOrder=0 },
            new RefLanguageUseType { Id=Guid.Parse("04fc10f7-91f7-41e8-ada5-093415c46d6a"), Code="The language specified by the related Language Code is the language the person's other language proficiency.", SortOrder=0 },
            new RefLanguageUseType { Id=Guid.Parse("0b1439b4-13ed-46f9-b8a9-b835639fd227"), Code="The function and context in which a person uses the  language specified by the related Language Code is in a category not yet defined in CEDS.", SortOrder=0 },
            new RefLanguageUseType { Id=Guid.Parse("bee8ef83-6af7-402f-a56c-3a76d811df07"), Code="The language specified by the related Language Code is the language the person uses for spoken correspondence.", SortOrder=0 },
            new RefLanguageUseType { Id=Guid.Parse("eeeef7ba-32f6-4894-81b5-dad2c1e074d4"), Code="The language specified by the related Language Code is the language the person uses for written correspondence.", SortOrder=0 },
       };
   }
}
