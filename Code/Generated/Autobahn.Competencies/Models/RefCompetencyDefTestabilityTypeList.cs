//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   RefCompetencyDefTestabilityTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The list of RefCompetencyDefTestabilityType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCompetencyDefTestabilityType"> List
         /// </summary>
        public static List<RefCompetencyDefTestabilityType> RefCompetencyDefTestabilityTypeList = new List<RefCompetencyDefTestabilityType>
        {
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("0680604a-2d95-48b1-b347-02ec380ad8b9"), Code="SingleIndicator", Description="Single Indicator", Definition="Testable using a single indicator type, measuring a single competency", SortOrder=Convert.ToDecimal("2.00") },
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("dbe8d0ae-2043-4176-93b3-de89116cce36"), Code="MultipleIndicator", Description="Multiple Indicator", Definition="Testability requires more than one indicator type used to measure a single competency", SortOrder=Convert.ToDecimal("4.00") },
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("b6f5df6d-8286-41ed-ac40-b510a09d3ad2"), Code="MultipleCompetency", Description="Multiple Competency", Definition="Testability requires a combination of indicators that assess multiple competencies or performance tasks", SortOrder=Convert.ToDecimal("6.00") },
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("124ade08-7d14-43f5-a9c5-452315b14540"), Code="CannotBeAssessed", Description="Cannot be assessed", Definition="The competency (skill, knowledge, ability, disposition) cannot be assessed.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The RefCompetencyDefTestabilityType Pick List
         /// </summary>
        public static List<RefCompetencyDefTestabilityType> RefCompetencyDefTestabilityTypePickList = new List<RefCompetencyDefTestabilityType>
        {
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("0680604a-2d95-48b1-b347-02ec380ad8b9"), Code="SingleIndicator", Description="Single Indicator", SortOrder=Convert.ToDecimal("2.00") },
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("dbe8d0ae-2043-4176-93b3-de89116cce36"), Code="MultipleIndicator", Description="Multiple Indicator", SortOrder=Convert.ToDecimal("4.00") },
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("b6f5df6d-8286-41ed-ac40-b510a09d3ad2"), Code="MultipleCompetency", Description="Multiple Competency", SortOrder=Convert.ToDecimal("6.00") },
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("124ade08-7d14-43f5-a9c5-452315b14540"), Code="CannotBeAssessed", Description="Cannot be assessed", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
