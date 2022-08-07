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
        /// The complete <see cref="RefCompetencyDefTestabilityTypeModel"> List
         /// </summary>
        public static List<RefCompetencyDefTestabilityTypeModel> RefCompetencyDefTestabilityTypeList = new List<RefCompetencyDefTestabilityTypeModel>
        {
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("a889865a-b867-458b-86fa-96085d52dd2e"), Code="SingleIndicator", Description="Single Indicator", Definition="Testable using a single indicator type, measuring a single competency", SortOrder=Convert.ToDecimal("2.00") },
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("e983925a-72cc-482c-87f0-1afcb122c2b4"), Code="MultipleIndicator", Description="Multiple Indicator", Definition="Testability requires more than one indicator type used to measure a single competency", SortOrder=Convert.ToDecimal("4.00") },
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("8c81bb61-5eb8-417b-92c7-9dd18f925838"), Code="MultipleCompetency", Description="Multiple Competency", Definition="Testability requires a combination of indicators that assess multiple competencies or performance tasks", SortOrder=Convert.ToDecimal("6.00") },
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("965c3ca0-5f9c-4eef-a0bc-7db40e59f564"), Code="CannotBeAssessed", Description="Cannot be assessed", Definition="The competency (skill, knowledge, ability, disposition) cannot be assessed.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefCompetencyDefTestabilityType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCompetencyDefTestabilityTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("a889865a-b867-458b-86fa-96085d52dd2e"), Description="Single Indicator", SortOrder=Convert.ToDecimal("2.00") },
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("e983925a-72cc-482c-87f0-1afcb122c2b4"), Description="Multiple Indicator", SortOrder=Convert.ToDecimal("4.00") },
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("8c81bb61-5eb8-417b-92c7-9dd18f925838"), Description="Multiple Competency", SortOrder=Convert.ToDecimal("6.00") },
            new RefCompetencyDefTestabilityType { Id=Guid.Parse("965c3ca0-5f9c-4eef-a0bc-7db40e59f564"), Description="Cannot be assessed", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
