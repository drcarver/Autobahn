//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefLanguageUseTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefLanguageUseType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLanguageUseTypeModel"> List
         /// </summary>
        public static List<RefLanguageUseTypeModel> RefLanguageUseTypeList = new List<RefLanguageUseTypeModel>
        {
            new RefLanguageUseType { Id=Guid.Parse("7d31983f-d38c-4561-bc4c-061064bf66af"), Code="", Description="Correspondence", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefLanguageUseType { Id=Guid.Parse("35344bc5-9e37-4f83-91ff-5cd05ec41d88"), Code="The language specified by the related Language Code is the language the person uses for both written and spoken correspondence.", Description="Correspondence", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefLanguageUseType { Id=Guid.Parse("f955024f-782b-4441-b856-811cdad28d11"), Code="Dominant", Description="Dominant language", Definition="The language specified by the related Language Code is the person's dominant language.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLanguageUseType { Id=Guid.Parse("2fcdcf9d-8048-4bda-9a03-5b3de37ce9e2"), Code="Home", Description="Home language", Definition="The language specified by the related Language Code is the language the person uses at home.", SortOrder=Convert.ToDecimal("3.00") },
            new RefLanguageUseType { Id=Guid.Parse("e2ecbe64-29fd-41a1-865a-55b77bddebc7"), Code="Native", Description="Native language", Definition="The language specified by the related Language Code is the person's native language.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLanguageUseType { Id=Guid.Parse("fbadc948-1dd8-490a-892f-a70ab8ed7679"), Code="OtherLanguageProficiency", Description="Other language proficiency", Definition="The language specified by the related Language Code is the language the person's other language proficiency.", SortOrder=Convert.ToDecimal("5.00") },
            new RefLanguageUseType { Id=Guid.Parse("97dd045f-53d7-42e9-bc9c-6453b31d4b77"), Code="Other", Description="Other", Definition="The function and context in which a person uses the  language specified by the related Language Code is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLanguageUseType { Id=Guid.Parse("2d42bdd2-701e-43d9-9b08-e957dec11181"), Code="Spoken", Description="Spoken Correspondence", Definition="The language specified by the related Language Code is the language the person uses for spoken correspondence.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLanguageUseType { Id=Guid.Parse("657a559d-94c5-4d9a-9d66-fa46a7bfdc58"), Code="Written", Description="Written Correspondence", Definition="The language specified by the related Language Code is the language the person uses for written correspondence.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefLanguageUseType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLanguageUseTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLanguageUseType { Id=Guid.Parse("7d31983f-d38c-4561-bc4c-061064bf66af"), Description="Correspondence", SortOrder=Convert.ToDecimal("") },
            new RefLanguageUseType { Id=Guid.Parse("35344bc5-9e37-4f83-91ff-5cd05ec41d88"), Description="Correspondence", SortOrder=Convert.ToDecimal("") },
            new RefLanguageUseType { Id=Guid.Parse("f955024f-782b-4441-b856-811cdad28d11"), Description="Dominant language", SortOrder=Convert.ToDecimal("2.00") },
            new RefLanguageUseType { Id=Guid.Parse("2fcdcf9d-8048-4bda-9a03-5b3de37ce9e2"), Description="Home language", SortOrder=Convert.ToDecimal("3.00") },
            new RefLanguageUseType { Id=Guid.Parse("e2ecbe64-29fd-41a1-865a-55b77bddebc7"), Description="Native language", SortOrder=Convert.ToDecimal("4.00") },
            new RefLanguageUseType { Id=Guid.Parse("fbadc948-1dd8-490a-892f-a70ab8ed7679"), Description="Other language proficiency", SortOrder=Convert.ToDecimal("5.00") },
            new RefLanguageUseType { Id=Guid.Parse("97dd045f-53d7-42e9-bc9c-6453b31d4b77"), Description="Other", SortOrder=Convert.ToDecimal("6.00") },
            new RefLanguageUseType { Id=Guid.Parse("2d42bdd2-701e-43d9-9b08-e957dec11181"), Description="Spoken Correspondence", SortOrder=Convert.ToDecimal("6.00") },
            new RefLanguageUseType { Id=Guid.Parse("657a559d-94c5-4d9a-9d66-fa46a7bfdc58"), Description="Written Correspondence", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
