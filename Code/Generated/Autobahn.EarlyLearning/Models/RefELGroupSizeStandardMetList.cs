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
        public static List<RefELGroupSizeStandardMet> RefELGroupSizeStandardMetList = new List<RefELGroupSizeStandardMet> =
        {
            new RefELGroupSizeStandardMet { Id=Guid.Parse("2e2ed8d5-c775-4a60-88a0-faba54633ec4"), Code="Meets or exceeds NAEYC or NAFCC standards for infant group sizes.", Description="Infants", Definition="", SortOrder=0 },
            new RefELGroupSizeStandardMet { Id=Guid.Parse("b75248f8-acb5-464a-8e0b-274054c83881"), Code="Meets or exceeds NAEYC or NAFCC standards for toddler group sizes. ", Description="Toddlers", Definition="", SortOrder=0 },
            new RefELGroupSizeStandardMet { Id=Guid.Parse("e4749005-a6e2-4aea-b158-862e2321c75b"), Code="Meets or exceeds NAEYC or NAFCC standards for preschooler group sizes.", Description="Preschoolers", Definition="", SortOrder=0 },
            new RefELGroupSizeStandardMet { Id=Guid.Parse("93b0408a-b66b-457b-83f5-be74bc3ed5ec"), Code="Meets or exceeds NAEYC or NAFCC standards for school-age group sizes.", Description="School-Age", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefELGroupSizeStandardMet Pick List
         /// </summary>
        public static List<RefELGroupSizeStandardMet> RefELGroupSizeStandardMetPickList = new List<RefELGroupSizeStandardMet> =
        {
            new RefELGroupSizeStandardMet { Id=Guid.Parse("2e2ed8d5-c775-4a60-88a0-faba54633ec4"), Code="Meets or exceeds NAEYC or NAFCC standards for infant group sizes.", SortOrder=0 },
            new RefELGroupSizeStandardMet { Id=Guid.Parse("b75248f8-acb5-464a-8e0b-274054c83881"), Code="Meets or exceeds NAEYC or NAFCC standards for toddler group sizes. ", SortOrder=0 },
            new RefELGroupSizeStandardMet { Id=Guid.Parse("e4749005-a6e2-4aea-b158-862e2321c75b"), Code="Meets or exceeds NAEYC or NAFCC standards for preschooler group sizes.", SortOrder=0 },
            new RefELGroupSizeStandardMet { Id=Guid.Parse("93b0408a-b66b-457b-83f5-be74bc3ed5ec"), Code="Meets or exceeds NAEYC or NAFCC standards for school-age group sizes.", SortOrder=0 },
       };
   }
}
