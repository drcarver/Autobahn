//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentAssetTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentAssetType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentAssetTypeModel"> List
         /// </summary>
        public static List<RefAssessmentAssetTypeModel> RefAssessmentAssetTypeList = new List<RefAssessmentAssetTypeModel>
        {
            new RefAssessmentAssetType { Id=Guid.Parse("8f07af8d-2e67-4c56-9a95-b36a440481ac"), Code="ReadingPassage", Description="Reading passage", Definition="Reading passage is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("e40faf3e-b7ea-4d58-bf30-11cc2378dbcf"), Code="GraphicArt", Description="Graphic art", Definition="Graphic art is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("09c45c23-343a-478f-af7f-b6e023a8bfca"), Code="Map", Description="Map", Definition="Map is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("7f201db2-a4a6-4783-b15b-3cb4185d35f7"), Code="FormulaSheet", Description="Formula sheet", Definition="Formula sheet is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("e1d67ed5-6f65-44dd-9901-75f9664a2d23"), Code="Table", Description="Table", Definition="Table is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("10.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("e19e4d37-6add-406a-beb9-34f62ee0a397"), Code="Chart", Description="Chart", Definition="Chart is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("12.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("b6421908-a662-4204-a399-2fc84441f944"), Code="Audio", Description="Audio", Definition="Audio is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("14.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("81be4643-bf89-43b7-b6eb-5320d583ad4d"), Code="Video", Description="Video", Definition="Video is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("16.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("97f67148-db52-4c65-ae73-c2f68e71a870"), Code="Scenario", Description="Scenario", Definition="Scenario is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("18.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("b5c3e44d-1f40-48df-bc6e-8482760a359b"), Code="Simulation", Description="Simulation", Definition="Simulation is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("20.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("1f72e290-c4d7-4c21-942e-3de9405e13a8"), Code="StoryBoard", Description="Story board", Definition="Story board is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("22.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("30b3a9c2-9360-4842-95ba-4c092978809a"), Code="LabSet", Description="Lab set", Definition="Lab set is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("24.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("8043f1f9-6dfc-46fa-9e16-7a26bcf63da6"), Code="PeriodicTable", Description="Periodic table", Definition="Periodic table is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("26.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("fff1f50e-d381-42c2-8ad6-d36c11b52239"), Code="TranslationDictionary", Description="Translation dictionary", Definition="Translation dictionary is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("28.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("c55fe42b-751c-4ee6-9180-671ca6219073"), Code="BasicCalculator", Description="Basic calculator", Definition="Basic calculator is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("30.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("70a88829-eff1-40b4-9f28-d7cb651f8ac0"), Code="StandardCalculator", Description="Standard calculator", Definition="Standard calculator is specified as the predominant type of assessment asset represented by the Learning Resource.", SortOrder=Convert.ToDecimal("32.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("50c314f9-12de-4af1-8fd4-9d87b2dfcb37"), Code="ScientificCalculator", Description="Scientific calculator", Definition="Scientific calculator is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("34.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("c5872a0d-f7c7-49a6-9537-fb705178b3a8"), Code="GraphingCalculator", Description="Graphing calculator", Definition="Graphing calculator is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("36.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("714d69ca-3375-41a6-bee0-f7adc131b795"), Code="Protractor", Description="Protractor", Definition="Protractor is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("38.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("427976be-0bde-486d-b0f4-d6e54f6994b4"), Code="MetricRuler", Description="Metric ruler", Definition="Metric ruler is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("40.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("e666e790-6f9e-4c0e-a3ed-b03b43158717"), Code="EnglishRuler", Description="English ruler", Definition="English ruler is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("42.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("0c785180-39ba-405f-9cd4-e0e3b3f7331a"), Code="UnitsRuler", Description="Units ruler", Definition="Units ruler is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("44.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("9abaabf7-855b-4698-81ed-afd255068117"), Code="ReadingLine", Description="Reading line", Definition="Reading line is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("46.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("9326cba1-d0a6-44e4-b7f5-8d35538f97e4"), Code="LineDraw", Description="Line draw", Definition="Line draw is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("48.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("4202f8f4-a178-407b-9d4f-cc3030100cb8"), Code="Highlighter", Description="Highlighter", Definition="Highlighter is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("50.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("0c19482e-a4b9-4299-bfe5-8dedd4e33914"), Code="OtherInteractive", Description="Other interactive", Definition="Other interactive is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("52.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("e7e5345e-3b46-45e7-9f4a-146d39da4ec6"), Code="OtherNonInteractive", Description="Other non-interactive", Definition="Other non-interactive is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("54.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("06bdec59-322a-4adb-a682-8b3153d31c6c"), Code="Other", Description="Other", Definition="Other is specified as the predominant type of assessment asset represented by the Learning Resource. ", SortOrder=Convert.ToDecimal("56.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentAssetType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentAssetTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentAssetType { Id=Guid.Parse("8f07af8d-2e67-4c56-9a95-b36a440481ac"), Description="Reading passage", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("e40faf3e-b7ea-4d58-bf30-11cc2378dbcf"), Description="Graphic art", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("09c45c23-343a-478f-af7f-b6e023a8bfca"), Description="Map", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("7f201db2-a4a6-4783-b15b-3cb4185d35f7"), Description="Formula sheet", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("e1d67ed5-6f65-44dd-9901-75f9664a2d23"), Description="Table", SortOrder=Convert.ToDecimal("10.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("e19e4d37-6add-406a-beb9-34f62ee0a397"), Description="Chart", SortOrder=Convert.ToDecimal("12.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("b6421908-a662-4204-a399-2fc84441f944"), Description="Audio", SortOrder=Convert.ToDecimal("14.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("81be4643-bf89-43b7-b6eb-5320d583ad4d"), Description="Video", SortOrder=Convert.ToDecimal("16.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("97f67148-db52-4c65-ae73-c2f68e71a870"), Description="Scenario", SortOrder=Convert.ToDecimal("18.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("b5c3e44d-1f40-48df-bc6e-8482760a359b"), Description="Simulation", SortOrder=Convert.ToDecimal("20.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("1f72e290-c4d7-4c21-942e-3de9405e13a8"), Description="Story board", SortOrder=Convert.ToDecimal("22.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("30b3a9c2-9360-4842-95ba-4c092978809a"), Description="Lab set", SortOrder=Convert.ToDecimal("24.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("8043f1f9-6dfc-46fa-9e16-7a26bcf63da6"), Description="Periodic table", SortOrder=Convert.ToDecimal("26.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("fff1f50e-d381-42c2-8ad6-d36c11b52239"), Description="Translation dictionary", SortOrder=Convert.ToDecimal("28.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("c55fe42b-751c-4ee6-9180-671ca6219073"), Description="Basic calculator", SortOrder=Convert.ToDecimal("30.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("70a88829-eff1-40b4-9f28-d7cb651f8ac0"), Description="Standard calculator", SortOrder=Convert.ToDecimal("32.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("50c314f9-12de-4af1-8fd4-9d87b2dfcb37"), Description="Scientific calculator", SortOrder=Convert.ToDecimal("34.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("c5872a0d-f7c7-49a6-9537-fb705178b3a8"), Description="Graphing calculator", SortOrder=Convert.ToDecimal("36.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("714d69ca-3375-41a6-bee0-f7adc131b795"), Description="Protractor", SortOrder=Convert.ToDecimal("38.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("427976be-0bde-486d-b0f4-d6e54f6994b4"), Description="Metric ruler", SortOrder=Convert.ToDecimal("40.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("e666e790-6f9e-4c0e-a3ed-b03b43158717"), Description="English ruler", SortOrder=Convert.ToDecimal("42.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("0c785180-39ba-405f-9cd4-e0e3b3f7331a"), Description="Units ruler", SortOrder=Convert.ToDecimal("44.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("9abaabf7-855b-4698-81ed-afd255068117"), Description="Reading line", SortOrder=Convert.ToDecimal("46.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("9326cba1-d0a6-44e4-b7f5-8d35538f97e4"), Description="Line draw", SortOrder=Convert.ToDecimal("48.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("4202f8f4-a178-407b-9d4f-cc3030100cb8"), Description="Highlighter", SortOrder=Convert.ToDecimal("50.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("0c19482e-a4b9-4299-bfe5-8dedd4e33914"), Description="Other interactive", SortOrder=Convert.ToDecimal("52.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("e7e5345e-3b46-45e7-9f4a-146d39da4ec6"), Description="Other non-interactive", SortOrder=Convert.ToDecimal("54.00") },
            new RefAssessmentAssetType { Id=Guid.Parse("06bdec59-322a-4adb-a682-8b3153d31c6c"), Description="Other", SortOrder=Convert.ToDecimal("56.00") },
       };
   }
}
