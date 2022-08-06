//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentResultDataTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentResultDataType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentResultDataType"> List
         /// </summary>
        public static List<RefAssessmentResultDataType> RefAssessmentResultDataTypeList = new List<RefAssessmentResultDataType>
        {
            new RefAssessmentResultDataType { Id=Guid.Parse("c192589b-9a39-4414-952a-2ecc9c73f6ad"), Code="Integer", Description="Integer", Definition=" A positive or negative whole number or zero such as -2, 4, 4567.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentResultDataType { Id=Guid.Parse("7428893a-c45d-40e2-ade1-9af7c78dfae5"), Code="Decimal", Description="Decimal", Definition="A representation of a real number using the base ten and decimal notation, such as 201.4, -3.89, or 0.0006", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentResultDataType { Id=Guid.Parse("05e6a321-7991-49d9-9b0a-2256f24cc6dd"), Code="Percentile", Description="Percentile", Definition="Any of 100 equal parts into which the range of the values of a set of data can be divided in order to show the distribution of those values. The part may be represented as an integer between 0 and 100, or further broken down into tenths or hundredths.  (e.g. 87, 5.2, 45.74)", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentResultDataType { Id=Guid.Parse("6f00aa92-06bc-4755-9616-c6a4dc505100"), Code="String", Description="String", Definition="A string representative of a non-numeric or numeric range value.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefAssessmentResultDataType Pick List
         /// </summary>
        public static List<RefAssessmentResultDataType> RefAssessmentResultDataTypePickList = new List<RefAssessmentResultDataType>
        {
            new RefAssessmentResultDataType { Id=Guid.Parse("c192589b-9a39-4414-952a-2ecc9c73f6ad"), Code="Integer", Description="Integer", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentResultDataType { Id=Guid.Parse("7428893a-c45d-40e2-ade1-9af7c78dfae5"), Code="Decimal", Description="Decimal", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentResultDataType { Id=Guid.Parse("05e6a321-7991-49d9-9b0a-2256f24cc6dd"), Code="Percentile", Description="Percentile", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentResultDataType { Id=Guid.Parse("6f00aa92-06bc-4755-9616-c6a4dc505100"), Code="String", Description="String", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
