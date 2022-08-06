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
        public static List<RefLanguageUseType> RefLanguageUseTypeList = new List<RefLanguageUseType>
        {
            new RefLanguageUseType { Id=Guid.Parse("d2d4e4af-9110-4234-a2a0-a98cdd86ea55"), Code="", Description="Correspondence", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefLanguageUseType { Id=Guid.Parse("1986180c-b3c4-49e1-94a5-47d43797b7ff"), Code="The language specified by the related Language Code is the language the person uses for both written and spoken correspondence.", Description="Correspondence", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefLanguageUseType { Id=Guid.Parse("542612c6-9793-424d-8ec9-d64186831cdd"), Code="Dominant", Description="Dominant language", Definition="The language specified by the related Language Code is the person's dominant language.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLanguageUseType { Id=Guid.Parse("d4699b8c-137a-4204-a2c6-43cf7a96d1f6"), Code="Home", Description="Home language", Definition="The language specified by the related Language Code is the language the person uses at home.", SortOrder=Convert.ToDecimal("3.00") },
            new RefLanguageUseType { Id=Guid.Parse("cfe5fb4f-f00d-4f82-a24e-f68dd2230ed9"), Code="Native", Description="Native language", Definition="The language specified by the related Language Code is the person's native language.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLanguageUseType { Id=Guid.Parse("3919ceae-9707-481b-8480-0b18f48bf7f5"), Code="OtherLanguageProficiency", Description="Other language proficiency", Definition="The language specified by the related Language Code is the language the person's other language proficiency.", SortOrder=Convert.ToDecimal("5.00") },
            new RefLanguageUseType { Id=Guid.Parse("9dfaa80b-46ee-40b1-8482-2664ad3a74cb"), Code="Other", Description="Other", Definition="The function and context in which a person uses the  language specified by the related Language Code is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLanguageUseType { Id=Guid.Parse("3db0b61a-7341-4ca1-8dde-e9bf6991a2f1"), Code="Spoken", Description="Spoken Correspondence", Definition="The language specified by the related Language Code is the language the person uses for spoken correspondence.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLanguageUseType { Id=Guid.Parse("5ddc9c70-d8f8-4cfd-82bd-94772ae9dbff"), Code="Written", Description="Written Correspondence", Definition="The language specified by the related Language Code is the language the person uses for written correspondence.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefLanguageUseType Pick List
         /// </summary>
        public static List<RefLanguageUseType> RefLanguageUseTypePickList = new List<RefLanguageUseType>
        {
            new RefLanguageUseType { Id=Guid.Parse("d2d4e4af-9110-4234-a2a0-a98cdd86ea55"), Code="", Description="Correspondence", SortOrder=Convert.ToDecimal("") },
            new RefLanguageUseType { Id=Guid.Parse("1986180c-b3c4-49e1-94a5-47d43797b7ff"), Code="The language specified by the related Language Code is the language the person uses for both written and spoken correspondence.", Description="Correspondence", SortOrder=Convert.ToDecimal("") },
            new RefLanguageUseType { Id=Guid.Parse("542612c6-9793-424d-8ec9-d64186831cdd"), Code="Dominant", Description="Dominant language", SortOrder=Convert.ToDecimal("2.00") },
            new RefLanguageUseType { Id=Guid.Parse("d4699b8c-137a-4204-a2c6-43cf7a96d1f6"), Code="Home", Description="Home language", SortOrder=Convert.ToDecimal("3.00") },
            new RefLanguageUseType { Id=Guid.Parse("cfe5fb4f-f00d-4f82-a24e-f68dd2230ed9"), Code="Native", Description="Native language", SortOrder=Convert.ToDecimal("4.00") },
            new RefLanguageUseType { Id=Guid.Parse("3919ceae-9707-481b-8480-0b18f48bf7f5"), Code="OtherLanguageProficiency", Description="Other language proficiency", SortOrder=Convert.ToDecimal("5.00") },
            new RefLanguageUseType { Id=Guid.Parse("9dfaa80b-46ee-40b1-8482-2664ad3a74cb"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("6.00") },
            new RefLanguageUseType { Id=Guid.Parse("3db0b61a-7341-4ca1-8dde-e9bf6991a2f1"), Code="Spoken", Description="Spoken Correspondence", SortOrder=Convert.ToDecimal("6.00") },
            new RefLanguageUseType { Id=Guid.Parse("5ddc9c70-d8f8-4cfd-82bd-94772ae9dbff"), Code="Written", Description="Written Correspondence", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
