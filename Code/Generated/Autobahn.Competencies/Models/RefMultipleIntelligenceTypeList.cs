//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   RefMultipleIntelligenceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The list of RefMultipleIntelligenceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMultipleIntelligenceTypeModel"> List
         /// </summary>
        public static List<RefMultipleIntelligenceTypeModel> RefMultipleIntelligenceTypeList = new List<RefMultipleIntelligenceTypeModel>
        {
            new RefMultipleIntelligenceType { Id=Guid.Parse("44dc4547-d139-439d-a25b-899efd79fd37"), Code="Linguistic", Description="Linguistic", Definition="The learning standard item or competency fits into the Linguistic intelligence modality. ", SortOrder=Convert.ToDecimal("1.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("d000824d-3a8b-4b39-96cd-d660fd76427a"), Code="Logic-mathematical", Description="Logic-mathematical", Definition="The learning standard item or competency fits into the Logic-mathematical intelligence modality.", SortOrder=Convert.ToDecimal("2.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("34471f14-118d-4195-a006-675a09073c24"), Code="Musical", Description="Musical", Definition="The learning standard item or competency fits into the Musical intelligence modality.", SortOrder=Convert.ToDecimal("3.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("0a78571a-6d97-47b8-be4c-83c164d112a6"), Code="Spatial", Description="Spatial", Definition="The learning standard item or competency fits into the Spatial intelligence modality.", SortOrder=Convert.ToDecimal("4.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("aaae1adf-a62a-42c1-b5f8-64ce22280b0b"), Code="BodilyKinesthetic", Description="Bodily/kinesthetic", Definition="The learning standard item or competency fits into the Bodily/kinesthetic intelligence modality.", SortOrder=Convert.ToDecimal("5.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("62143dc9-9e89-48e2-baf5-33ca38553b51"), Code="Interpersonal", Description="Interpersonal", Definition="The learning standard item or competency fits into the Interpersonal intelligence modality.", SortOrder=Convert.ToDecimal("6.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("3160d02e-691b-4517-85da-7e0925544927"), Code="Intrapersonal", Description="Intrapersonal", Definition="The learning standard item or competency fits into the Intrapersonal intelligence modality.", SortOrder=Convert.ToDecimal("7.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("5a7ab359-335c-449c-9d6c-eb6215539ce8"), Code="Naturalistic", Description="Naturalistic", Definition="The learning standard item or competency fits into the Naturalistic intelligence modality.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefMultipleIntelligenceType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefMultipleIntelligenceTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefMultipleIntelligenceType { Id=Guid.Parse("44dc4547-d139-439d-a25b-899efd79fd37"), Description="Linguistic", SortOrder=Convert.ToDecimal("1.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("d000824d-3a8b-4b39-96cd-d660fd76427a"), Description="Logic-mathematical", SortOrder=Convert.ToDecimal("2.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("34471f14-118d-4195-a006-675a09073c24"), Description="Musical", SortOrder=Convert.ToDecimal("3.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("0a78571a-6d97-47b8-be4c-83c164d112a6"), Description="Spatial", SortOrder=Convert.ToDecimal("4.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("aaae1adf-a62a-42c1-b5f8-64ce22280b0b"), Description="Bodily/kinesthetic", SortOrder=Convert.ToDecimal("5.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("62143dc9-9e89-48e2-baf5-33ca38553b51"), Description="Interpersonal", SortOrder=Convert.ToDecimal("6.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("3160d02e-691b-4517-85da-7e0925544927"), Description="Intrapersonal", SortOrder=Convert.ToDecimal("7.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("5a7ab359-335c-449c-9d6c-eb6215539ce8"), Description="Naturalistic", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
