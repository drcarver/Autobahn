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
        /// The complete <see cref="RefDevelopmentalEducationType"> List
         /// </summary>
        public static List<RefDevelopmentalEducationType> RefDevelopmentalEducationTypeList = new List<RefDevelopmentalEducationType>
        {
            new RefDevelopmentalEducationType { Id=Guid.Parse("45bc261c-28a6-405a-a3f8-a94a91da4ddb"), Code="DevelopmentalMath", Description="Developmental Math", Definition="Developmental Math is the category of developmental education.", SortOrder=Convert.ToDecimal("1.00") },
            new RefDevelopmentalEducationType { Id=Guid.Parse("5192d498-70c1-49a4-9617-6d6017efc51e"), Code="DevelopmentalEnglish", Description="Developmental English", Definition="Developmental English is the category of developmental education.", SortOrder=Convert.ToDecimal("3.00") },
            new RefDevelopmentalEducationType { Id=Guid.Parse("feff5216-29b7-474d-b7fa-4183522ea9f8"), Code="DevelopmentalReading", Description="Developmental Reading", Definition="Developmental Reading is the category of developmental education.", SortOrder=Convert.ToDecimal("5.00") },
            new RefDevelopmentalEducationType { Id=Guid.Parse("5712bdd1-ad17-49e7-8186-faac29bd2956"), Code="DevelopmentalEnglishReading", Description="Developmental English/Reading", Definition="Developmental English/Reading is the category of developmental education.", SortOrder=Convert.ToDecimal("7.00") },
            new RefDevelopmentalEducationType { Id=Guid.Parse("3995b913-b560-4936-80d7-b43db21db308"), Code="DevelopmentalOther", Description="Developmental Other", Definition="Developmental Other is the category of developmental education.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The RefDevelopmentalEducationType Pick List
         /// </summary>
        public static List<RefDevelopmentalEducationType> RefDevelopmentalEducationTypePickList = new List<RefDevelopmentalEducationType>
        {
            new RefDevelopmentalEducationType { Id=Guid.Parse("45bc261c-28a6-405a-a3f8-a94a91da4ddb"), Code="DevelopmentalMath", Description="Developmental Math", SortOrder=Convert.ToDecimal("1.00") },
            new RefDevelopmentalEducationType { Id=Guid.Parse("5192d498-70c1-49a4-9617-6d6017efc51e"), Code="DevelopmentalEnglish", Description="Developmental English", SortOrder=Convert.ToDecimal("3.00") },
            new RefDevelopmentalEducationType { Id=Guid.Parse("feff5216-29b7-474d-b7fa-4183522ea9f8"), Code="DevelopmentalReading", Description="Developmental Reading", SortOrder=Convert.ToDecimal("5.00") },
            new RefDevelopmentalEducationType { Id=Guid.Parse("5712bdd1-ad17-49e7-8186-faac29bd2956"), Code="DevelopmentalEnglishReading", Description="Developmental English/Reading", SortOrder=Convert.ToDecimal("7.00") },
            new RefDevelopmentalEducationType { Id=Guid.Parse("3995b913-b560-4936-80d7-b43db21db308"), Code="DevelopmentalOther", Description="Developmental Other", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
