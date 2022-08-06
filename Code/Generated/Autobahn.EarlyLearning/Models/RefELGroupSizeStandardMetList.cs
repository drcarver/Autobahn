//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefELGroupSizeStandardMetList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefELGroupSizeStandardMet Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefELGroupSizeStandardMet"> List
         /// </summary>
        public static List<RefELGroupSizeStandardMet> RefELGroupSizeStandardMetList = new List<RefELGroupSizeStandardMet>
        {
            new RefELGroupSizeStandardMet { Id=Guid.Parse("e0e9081a-372d-44ba-abca-7660389b348f"), Code="Infants", Description="Meets or exceeds standards for infants", Definition="Meets or exceeds NAEYC or NAFCC standards for infant group sizes.", SortOrder=Convert.ToDecimal("1.00") },
            new RefELGroupSizeStandardMet { Id=Guid.Parse("6aefec36-39e1-4579-885f-9c7d7c91f7f0"), Code="Toddlers", Description="Meets or exceeds standards for toddlers", Definition="Meets or exceeds NAEYC or NAFCC standards for toddler group sizes. ", SortOrder=Convert.ToDecimal("2.00") },
            new RefELGroupSizeStandardMet { Id=Guid.Parse("6ba13e22-1166-4cfd-9b5f-3265f0dac81b"), Code="Preschoolers", Description="Meets or exceeds standards for preschoolers", Definition="Meets or exceeds NAEYC or NAFCC standards for preschooler group sizes.", SortOrder=Convert.ToDecimal("3.00") },
            new RefELGroupSizeStandardMet { Id=Guid.Parse("1ea95573-1ba4-4d36-9aee-9add1d4359d9"), Code="School-Age", Description="Meets or exceeds standards for school-age", Definition="Meets or exceeds NAEYC or NAFCC standards for school-age group sizes.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefELGroupSizeStandardMet Pick List
         /// </summary>
        public static List<RefELGroupSizeStandardMet> RefELGroupSizeStandardMetPickList = new List<RefELGroupSizeStandardMet>
        {
            new RefELGroupSizeStandardMet { Id=Guid.Parse("e0e9081a-372d-44ba-abca-7660389b348f"), Code="Infants", Description="Meets or exceeds standards for infants", SortOrder=Convert.ToDecimal("1.00") },
            new RefELGroupSizeStandardMet { Id=Guid.Parse("6aefec36-39e1-4579-885f-9c7d7c91f7f0"), Code="Toddlers", Description="Meets or exceeds standards for toddlers", SortOrder=Convert.ToDecimal("2.00") },
            new RefELGroupSizeStandardMet { Id=Guid.Parse("6ba13e22-1166-4cfd-9b5f-3265f0dac81b"), Code="Preschoolers", Description="Meets or exceeds standards for preschoolers", SortOrder=Convert.ToDecimal("3.00") },
            new RefELGroupSizeStandardMet { Id=Guid.Parse("1ea95573-1ba4-4d36-9aee-9add1d4359d9"), Code="School-Age", Description="Meets or exceeds standards for school-age", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
