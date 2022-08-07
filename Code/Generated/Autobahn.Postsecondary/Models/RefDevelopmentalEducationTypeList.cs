//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefDevelopmentalEducationTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefDevelopmentalEducationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefDevelopmentalEducationTypeModel"> List
         /// </summary>
        public static List<RefDevelopmentalEducationTypeModel> RefDevelopmentalEducationTypeList = new List<RefDevelopmentalEducationTypeModel>
        {
            new RefDevelopmentalEducationType { Id=Guid.Parse("90da948c-b7ec-478f-8b10-b29edb252ee6"), Code="DevelopmentalMath", Description="Developmental Math", Definition="Developmental Math is the category of developmental education.", SortOrder=Convert.ToDecimal("1.00") },
            new RefDevelopmentalEducationType { Id=Guid.Parse("d4af4661-4eae-488b-81a2-fe276a71d423"), Code="DevelopmentalEnglish", Description="Developmental English", Definition="Developmental English is the category of developmental education.", SortOrder=Convert.ToDecimal("3.00") },
            new RefDevelopmentalEducationType { Id=Guid.Parse("8b95326b-de68-46c5-b727-b3ec74b842c8"), Code="DevelopmentalReading", Description="Developmental Reading", Definition="Developmental Reading is the category of developmental education.", SortOrder=Convert.ToDecimal("5.00") },
            new RefDevelopmentalEducationType { Id=Guid.Parse("5254e245-b94d-45e9-982f-65b046132791"), Code="DevelopmentalEnglishReading", Description="Developmental English/Reading", Definition="Developmental English/Reading is the category of developmental education.", SortOrder=Convert.ToDecimal("7.00") },
            new RefDevelopmentalEducationType { Id=Guid.Parse("fbdf5cc5-e8e7-4093-a442-0201a461f2dd"), Code="DevelopmentalOther", Description="Developmental Other", Definition="Developmental Other is the category of developmental education.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefDevelopmentalEducationType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefDevelopmentalEducationTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefDevelopmentalEducationType { Id=Guid.Parse("90da948c-b7ec-478f-8b10-b29edb252ee6"), Description="Developmental Math", SortOrder=Convert.ToDecimal("1.00") },
            new RefDevelopmentalEducationType { Id=Guid.Parse("d4af4661-4eae-488b-81a2-fe276a71d423"), Description="Developmental English", SortOrder=Convert.ToDecimal("3.00") },
            new RefDevelopmentalEducationType { Id=Guid.Parse("8b95326b-de68-46c5-b727-b3ec74b842c8"), Description="Developmental Reading", SortOrder=Convert.ToDecimal("5.00") },
            new RefDevelopmentalEducationType { Id=Guid.Parse("5254e245-b94d-45e9-982f-65b046132791"), Description="Developmental English/Reading", SortOrder=Convert.ToDecimal("7.00") },
            new RefDevelopmentalEducationType { Id=Guid.Parse("fbdf5cc5-e8e7-4093-a442-0201a461f2dd"), Description="Developmental Other", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
