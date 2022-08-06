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
        public static List<RefCompetencyDefTestabilityType> RefCompetencyDefTestabilityTypeList = new List<RefCompetencyDefTestabilityType> =
        {
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("0b3b0ca7-5302-4061-a85b-f1337618f6dd"), Code="Testable using a single indicator type, measuring a single competency", Description="SingleIndicator", Definition="", SortOrder=0 },
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("ec88ec6d-c712-4eff-9cdd-d70370b7dbcc"), Code="Testability requires more than one indicator type used to measure a single competency", Description="MultipleIndicator", Definition="", SortOrder=0 },
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("e1aacbce-d18f-43c1-af36-76034b93870f"), Code="Testability requires a combination of indicators that assess multiple competencies or performance tasks", Description="MultipleCompetency", Definition="", SortOrder=0 },
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("e12b6729-7798-4f7b-9f1a-8f99a61b60e6"), Code="The competency (skill, knowledge, ability, disposition) cannot be assessed.", Description="CannotBeAssessed", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCompetencyDefTestabilityType Pick List
         /// </summary>
        public static List<RefCompetencyDefTestabilityType> RefCompetencyDefTestabilityTypePickList = new List<RefCompetencyDefTestabilityType> =
        {
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("0b3b0ca7-5302-4061-a85b-f1337618f6dd"), Code="Testable using a single indicator type, measuring a single competency", SortOrder=0 },
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("ec88ec6d-c712-4eff-9cdd-d70370b7dbcc"), Code="Testability requires more than one indicator type used to measure a single competency", SortOrder=0 },
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("e1aacbce-d18f-43c1-af36-76034b93870f"), Code="Testability requires a combination of indicators that assess multiple competencies or performance tasks", SortOrder=0 },
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("e12b6729-7798-4f7b-9f1a-8f99a61b60e6"), Code="The competency (skill, knowledge, ability, disposition) cannot be assessed.", SortOrder=0 },
       };
   }
}
