//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentItemCharacteristicTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentItemCharacteristicType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentItemCharacteristicTypeModel"> List
         /// </summary>
        public static List<RefAssessmentItemCharacteristicTypeModel> RefAssessmentItemCharacteristicTypeList = new List<RefAssessmentItemCharacteristicTypeModel>
        {
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("4e9b6594-46fc-44e4-a162-4036a929d1bf"), Code="MeanSquareFit", Description="Mean Square Fit", Definition="Mean Square Fit is specified as a type of psychometric measure provided for assessment item.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("37a05468-cea1-4cb3-bee0-9f26113a04d0"), Code="WeightedMeanSquareFit", Description="Weighted Mean Square Fit", Definition="Weighted Mean Square Fit is specified as a type of psychometric measure provided for assessment item.", SortOrder=Convert.ToDecimal("11.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("2daf06b9-67d5-4b9d-a056-252afa35ebda"), Code="RevisedMeanSquareFit", Description="Revised Mean Square Fit", Definition="Revised Mean Square Fit is specified as a type of psychometric measure provided for assessment item.", SortOrder=Convert.ToDecimal("12.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("68227453-0cb3-45bd-bf34-8c9b65e73c4b"), Code="RevisedPointBiserial", Description="Revised Point Biserial Measure", Definition="Revised Point Biserial Measure is specified as a type of psychometric measure provided for assessment item.", SortOrder=Convert.ToDecimal("13.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("7e2a664a-5a98-4efa-94c8-3b2171c469dc"), Code="RaschItemScore", Description="Rasch Item Score", Definition="Rasch Item Score is specified as a type of psychometric measure provided for assessment item.", SortOrder=Convert.ToDecimal("14.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("6a789b74-ceaa-4cc1-aa3d-f4e6cb5fab5d"), Code="ResponseCorrelation", Description="Response Correlation", Definition="Response Correlation is specified as a type of psychometric measure provided for assessment item.", SortOrder=Convert.ToDecimal("15.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("a13f0178-803d-453b-bd61-78a1001bf6ab"), Code="ResponseCorrelationSquared", Description="Response Correlation Squared", Definition="Response Correlation Squared is specified as a type of psychometric measure provided for assessment item.", SortOrder=Convert.ToDecimal("16.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("a9560def-97d8-43fa-924d-61b70076a657"), Code="ZCHISquare", Description="Z CHI Square", Definition="Z CHI Square is specified as a type of psychometric measure provided for assessment item.", SortOrder=Convert.ToDecimal("17.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("3936e7d4-560e-4ee2-bca5-ae5f73b5544d"), Code="Pval", Description="Pval", Definition="Pval is specified as a type of psychometric measure provided for assessment item.", SortOrder=Convert.ToDecimal("18.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("f0dd44fd-400d-4e3f-bc8f-2a5dca0634f6"), Code="PointBiserial", Description="Point Biserial", Definition="Point Biserial is specified as a type of psychometric measure provided for assessment item.", SortOrder=Convert.ToDecimal("19.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("e8d0dce1-08c8-4fb6-b98e-78109a60926b"), Code="Biserial", Description="Biserial", Definition="Biserial is specified as a type of psychometric measure provided for assessment item.", SortOrder=Convert.ToDecimal("20.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("f0024570-6af0-4dd6-ac8d-aaeb9923c48b"), Code="DiscriminationIndex", Description="Discrimination Index", Definition="Discrimination Index is specified as a type of psychometric measure provided for assessment item.", SortOrder=Convert.ToDecimal("21.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("32000c89-a1e2-4fd5-8d4a-ae6fcb75daff"), Code="ReliabilityCoefficient", Description="Reliability Coefficient", Definition="Reliability Coefficient is specified as a type of psychometric measure provided for assessment item.", SortOrder=Convert.ToDecimal("22.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("4ebb24a1-d410-4879-a5c4-c2dacaa52b3a"), Code="CoefficientAlpha", Description="Coefficient Alpha", Definition="Coefficient Alpha is specified as a type of psychometric measure provided for assessment item.", SortOrder=Convert.ToDecimal("23.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("654ac8fc-2382-4709-85da-78936d192beb"), Code="ItemTestCorrelation", Description="Item Test Correlation", Definition="Item Test Correlation is specified as a type of psychometric measure provided for assessment item.", SortOrder=Convert.ToDecimal("24.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("6ecd3c3a-1732-4095-a268-bb3af0c73de5"), Code="ItemVariance", Description="Item Variance", Definition="Item Variance is specified as a type of psychometric measure provided for assessment item.", SortOrder=Convert.ToDecimal("25.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("b0b82672-0088-4d9a-b157-8a2939a40912"), Code="ScaleValue", Description="Scale Value", Definition="Scale Value is specified as a type of psychometric measure provided for assessment item.", SortOrder=Convert.ToDecimal("26.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentItemCharacteristicType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentItemCharacteristicTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("4e9b6594-46fc-44e4-a162-4036a929d1bf"), Description="Mean Square Fit", SortOrder=Convert.ToDecimal("10.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("37a05468-cea1-4cb3-bee0-9f26113a04d0"), Description="Weighted Mean Square Fit", SortOrder=Convert.ToDecimal("11.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("2daf06b9-67d5-4b9d-a056-252afa35ebda"), Description="Revised Mean Square Fit", SortOrder=Convert.ToDecimal("12.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("68227453-0cb3-45bd-bf34-8c9b65e73c4b"), Description="Revised Point Biserial Measure", SortOrder=Convert.ToDecimal("13.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("7e2a664a-5a98-4efa-94c8-3b2171c469dc"), Description="Rasch Item Score", SortOrder=Convert.ToDecimal("14.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("6a789b74-ceaa-4cc1-aa3d-f4e6cb5fab5d"), Description="Response Correlation", SortOrder=Convert.ToDecimal("15.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("a13f0178-803d-453b-bd61-78a1001bf6ab"), Description="Response Correlation Squared", SortOrder=Convert.ToDecimal("16.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("a9560def-97d8-43fa-924d-61b70076a657"), Description="Z CHI Square", SortOrder=Convert.ToDecimal("17.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("3936e7d4-560e-4ee2-bca5-ae5f73b5544d"), Description="Pval", SortOrder=Convert.ToDecimal("18.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("f0dd44fd-400d-4e3f-bc8f-2a5dca0634f6"), Description="Point Biserial", SortOrder=Convert.ToDecimal("19.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("e8d0dce1-08c8-4fb6-b98e-78109a60926b"), Description="Biserial", SortOrder=Convert.ToDecimal("20.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("f0024570-6af0-4dd6-ac8d-aaeb9923c48b"), Description="Discrimination Index", SortOrder=Convert.ToDecimal("21.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("32000c89-a1e2-4fd5-8d4a-ae6fcb75daff"), Description="Reliability Coefficient", SortOrder=Convert.ToDecimal("22.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("4ebb24a1-d410-4879-a5c4-c2dacaa52b3a"), Description="Coefficient Alpha", SortOrder=Convert.ToDecimal("23.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("654ac8fc-2382-4709-85da-78936d192beb"), Description="Item Test Correlation", SortOrder=Convert.ToDecimal("24.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("6ecd3c3a-1732-4095-a268-bb3af0c73de5"), Description="Item Variance", SortOrder=Convert.ToDecimal("25.00") },
            new RefAssessmentItemCharacteristicType { Id=Guid.Parse("b0b82672-0088-4d9a-b157-8a2939a40912"), Description="Scale Value", SortOrder=Convert.ToDecimal("26.00") },
       };
   }
}
