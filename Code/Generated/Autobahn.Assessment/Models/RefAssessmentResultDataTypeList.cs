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
        /// The complete <see cref="RefAssessmentResultDataTypeModel"> List
         /// </summary>
        public static List<RefAssessmentResultDataTypeModel> RefAssessmentResultDataTypeList = new List<RefAssessmentResultDataTypeModel>
        {
            new RefAssessmentResultDataType { Id=Guid.Parse("c7e23d6d-11b6-45b0-bc26-c812ece7c70a"), Code="Integer", Description="Integer", Definition=" A positive or negative whole number or zero such as -2, 4, 4567.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentResultDataType { Id=Guid.Parse("1110725e-b01a-4235-b213-cd1a5ca24870"), Code="Decimal", Description="Decimal", Definition="A representation of a real number using the base ten and decimal notation, such as 201.4, -3.89, or 0.0006", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentResultDataType { Id=Guid.Parse("8c25e15e-84a5-40f3-bf9a-2b9846781767"), Code="Percentile", Description="Percentile", Definition="Any of 100 equal parts into which the range of the values of a set of data can be divided in order to show the distribution of those values. The part may be represented as an integer between 0 and 100, or further broken down into tenths or hundredths.  (e.g. 87, 5.2, 45.74)", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentResultDataType { Id=Guid.Parse("343be9b0-c468-45d9-9af1-7517cd7ee44e"), Code="String", Description="String", Definition="A string representative of a non-numeric or numeric range value.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentResultDataType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentResultDataTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentResultDataType { Id=Guid.Parse("c7e23d6d-11b6-45b0-bc26-c812ece7c70a"), Description="Integer", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentResultDataType { Id=Guid.Parse("1110725e-b01a-4235-b213-cd1a5ca24870"), Description="Decimal", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentResultDataType { Id=Guid.Parse("8c25e15e-84a5-40f3-bf9a-2b9846781767"), Description="Percentile", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentResultDataType { Id=Guid.Parse("343be9b0-c468-45d9-9af1-7517cd7ee44e"), Description="String", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
