//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefFinancialAidApplicationTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefFinancialAidApplicationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFinancialAidApplicationType"> List
         /// </summary>
        public static List<RefFinancialAidApplicationType> RefFinancialAidApplicationTypeList = new List<RefFinancialAidApplicationType> =
        {
            new RefFinancialAidApplicationType { Id=Guid.Parse("5ee041d2-912e-4d69-965b-6583187bfe52"), Code="Free Application for Federal Student Aid (FAFSA)", Description="FAFSA", Definition="", SortOrder=0 },
            new RefFinancialAidApplicationType { Id=Guid.Parse("b20969bd-860e-4fbe-b3a0-9978084d120a"), Code="State Application", Description="StateApplication", Definition="", SortOrder=0 },
            new RefFinancialAidApplicationType { Id=Guid.Parse("42f60004-59bd-4dda-b807-796403ad27e8"), Code="Institution Application", Description="InstitutionApplication", Definition="", SortOrder=0 },
            new RefFinancialAidApplicationType { Id=Guid.Parse("094b0c80-a53a-4738-baf6-18a8c59600fc"), Code="Other", Description="Other", Definition="", SortOrder=0 },
            new RefFinancialAidApplicationType { Id=Guid.Parse("a737ca92-31a9-490a-b757-8ad006e1ccb4"), Code="None", Description="None", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFinancialAidApplicationType Pick List
         /// </summary>
        public static List<RefFinancialAidApplicationType> RefFinancialAidApplicationTypePickList = new List<RefFinancialAidApplicationType> =
        {
            new RefFinancialAidApplicationType { Id=Guid.Parse("5ee041d2-912e-4d69-965b-6583187bfe52"), Code="Free Application for Federal Student Aid (FAFSA)", SortOrder=0 },
            new RefFinancialAidApplicationType { Id=Guid.Parse("b20969bd-860e-4fbe-b3a0-9978084d120a"), Code="State Application", SortOrder=0 },
            new RefFinancialAidApplicationType { Id=Guid.Parse("42f60004-59bd-4dda-b807-796403ad27e8"), Code="Institution Application", SortOrder=0 },
            new RefFinancialAidApplicationType { Id=Guid.Parse("094b0c80-a53a-4738-baf6-18a8c59600fc"), Code="Other", SortOrder=0 },
            new RefFinancialAidApplicationType { Id=Guid.Parse("a737ca92-31a9-490a-b757-8ad006e1ccb4"), Code="None", SortOrder=0 },
       };
   }
}
