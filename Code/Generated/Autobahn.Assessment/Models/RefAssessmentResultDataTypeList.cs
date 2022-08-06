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
        public static List<RefAssessmentResultDataType> RefAssessmentResultDataTypeList = new List<RefAssessmentResultDataType> =
        {
            new RefAssessmentResultDataType { Id=Guid.Parse("c98cb483-5eca-4959-aa59-adc16981af19"), Code=" A positive or negative whole number or zero such as -2, 4, 4567.", Description="Integer", Definition="", SortOrder=0 },
            new RefAssessmentResultDataType { Id=Guid.Parse("f22a6237-1b55-4117-a936-8195c587d0d7"), Code="A representation of a real number using the base ten and decimal notation, such as 201.4, -3.89, or 0.0006", Description="Decimal", Definition="", SortOrder=0 },
            new RefAssessmentResultDataType { Id=Guid.Parse("aadcbbf6-ea43-422d-a07a-49356f5ff615"), Code="Any of 100 equal parts into which the range of the values of a set of data can be divided in order to show the distribution of those values. The part may be represented as an integer between 0 and 100, or further broken down into tenths or hundredths.  (e.g. 87, 5.2, 45.74)", Description="Percentile", Definition="", SortOrder=0 },
            new RefAssessmentResultDataType { Id=Guid.Parse("25f90296-924b-40a9-a0b2-09e4645df47e"), Code="A string representative of a non-numeric or numeric range value.", Description="String", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentResultDataType Pick List
         /// </summary>
        public static List<RefAssessmentResultDataType> RefAssessmentResultDataTypePickList = new List<RefAssessmentResultDataType> =
        {
            new RefAssessmentResultDataType { Id=Guid.Parse("c98cb483-5eca-4959-aa59-adc16981af19"), Code=" A positive or negative whole number or zero such as -2, 4, 4567.", SortOrder=0 },
            new RefAssessmentResultDataType { Id=Guid.Parse("f22a6237-1b55-4117-a936-8195c587d0d7"), Code="A representation of a real number using the base ten and decimal notation, such as 201.4, -3.89, or 0.0006", SortOrder=0 },
            new RefAssessmentResultDataType { Id=Guid.Parse("aadcbbf6-ea43-422d-a07a-49356f5ff615"), Code="Any of 100 equal parts into which the range of the values of a set of data can be divided in order to show the distribution of those values. The part may be represented as an integer between 0 and 100, or further broken down into tenths or hundredths.  (e.g. 87, 5.2, 45.74)", SortOrder=0 },
            new RefAssessmentResultDataType { Id=Guid.Parse("25f90296-924b-40a9-a0b2-09e4645df47e"), Code="A string representative of a non-numeric or numeric range value.", SortOrder=0 },
       };
   }
}
