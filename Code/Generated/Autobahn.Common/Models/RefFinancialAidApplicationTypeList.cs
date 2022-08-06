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
        public static List<RefFinancialAidApplicationType> RefFinancialAidApplicationTypeList = new List<RefFinancialAidApplicationType>
        {
            new RefFinancialAidApplicationType { Id=Guid.Parse("c93f6a97-cf28-44d5-90e1-d20472a6ffa8"), Code="FAFSA", Description="Free Application for Federal Student Aid (FAFSA)", Definition="Free Application for Federal Student Aid (FAFSA)", SortOrder=Convert.ToDecimal("0.00") },
            new RefFinancialAidApplicationType { Id=Guid.Parse("065bb011-de92-408a-a999-b68fd01afcdf"), Code="StateApplication", Description="State Application", Definition="State Application", SortOrder=Convert.ToDecimal("2.00") },
            new RefFinancialAidApplicationType { Id=Guid.Parse("1f900f29-1d1f-4c8e-8369-4fffb0f577ac"), Code="InstitutionApplication", Description="Institution Application", Definition="Institution Application", SortOrder=Convert.ToDecimal("4.00") },
            new RefFinancialAidApplicationType { Id=Guid.Parse("9041cc01-79ab-4795-8085-aad7ee9bfd8f"), Code="Other", Description="Other", Definition="Other", SortOrder=Convert.ToDecimal("6.00") },
            new RefFinancialAidApplicationType { Id=Guid.Parse("21823337-ebab-4d55-975a-c1d2f0bd883c"), Code="None", Description="None", Definition="None", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The RefFinancialAidApplicationType Pick List
         /// </summary>
        public static List<RefFinancialAidApplicationType> RefFinancialAidApplicationTypePickList = new List<RefFinancialAidApplicationType>
        {
            new RefFinancialAidApplicationType { Id=Guid.Parse("c93f6a97-cf28-44d5-90e1-d20472a6ffa8"), Code="FAFSA", Description="Free Application for Federal Student Aid (FAFSA)", SortOrder=Convert.ToDecimal("0.00") },
            new RefFinancialAidApplicationType { Id=Guid.Parse("065bb011-de92-408a-a999-b68fd01afcdf"), Code="StateApplication", Description="State Application", SortOrder=Convert.ToDecimal("2.00") },
            new RefFinancialAidApplicationType { Id=Guid.Parse("1f900f29-1d1f-4c8e-8369-4fffb0f577ac"), Code="InstitutionApplication", Description="Institution Application", SortOrder=Convert.ToDecimal("4.00") },
            new RefFinancialAidApplicationType { Id=Guid.Parse("9041cc01-79ab-4795-8085-aad7ee9bfd8f"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("6.00") },
            new RefFinancialAidApplicationType { Id=Guid.Parse("21823337-ebab-4d55-975a-c1d2f0bd883c"), Code="None", Description="None", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
