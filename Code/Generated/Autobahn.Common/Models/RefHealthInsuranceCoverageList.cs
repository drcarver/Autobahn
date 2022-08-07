//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefHealthInsuranceCoverageList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefHealthInsuranceCoverage Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefHealthInsuranceCoverageModel"> List
         /// </summary>
        public static List<RefHealthInsuranceCoverageModel> RefHealthInsuranceCoverageList = new List<RefHealthInsuranceCoverageModel>
        {
            new RefHealthInsuranceCoverage { Id=Guid.Parse("8c532ba8-ce00-4e67-9ce9-6e68fd89c561"), Code="NonWorkplace", Description="Non-workplace or personal", Definition="Non-workplace or personal insurance coverage.", SortOrder=Convert.ToDecimal("1.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("0722c22a-27b6-49f8-b390-7b0617e1ff14"), Code="Workplace", Description="Workplace", Definition="Workplace insurance coverage.", SortOrder=Convert.ToDecimal("2.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("5e04f2bb-8561-4277-b8bf-96dfa9885684"), Code="Medicaid", Description="Medicaid", Definition="Medicaid insurance coverage.", SortOrder=Convert.ToDecimal("3.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("123f2061-3c48-4843-b785-783775e5e70a"), Code="CHIP", Description="Children's health insurance program", Definition="Children's health insurance program.", SortOrder=Convert.ToDecimal("4.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("094a545f-905b-4cb2-ac2e-f012f0f57088"), Code="StateOnlyFunded", Description="State-only funded insurance", Definition="State-only funded insurance coverage.", SortOrder=Convert.ToDecimal("5.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("5ae9a3e5-dd51-4e62-a21c-647c1eaa0af4"), Code="SSI", Description="Supplemental security income", Definition="Supplemental security income insurance coverage.", SortOrder=Convert.ToDecimal("6.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("08595815-c38b-4a9e-bc53-f289bedb5db9"), Code="Military", Description="Military medical", Definition="Military medical insurance coverage.", SortOrder=Convert.ToDecimal("8.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("7716171b-51dc-4dd1-9370-1f13ad2e49b6"), Code="Veteran", Description="Veteran's medical", Definition="Veteran's medical insurance coverage.", SortOrder=Convert.ToDecimal("10.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("ac946c48-b26e-4329-9c5e-0d85697801d5"), Code="None", Description="None", Definition="None insurance coverage.", SortOrder=Convert.ToDecimal("20.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("f69d8a68-0c81-4c20-b808-38476d1128a5"), Code="Other", Description="Other", Definition="Other insurance coverage.", SortOrder=Convert.ToDecimal("21.00") },
        };

        /// <summary>
        /// The Reference RefHealthInsuranceCoverage Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefHealthInsuranceCoverageViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefHealthInsuranceCoverage { Id=Guid.Parse("8c532ba8-ce00-4e67-9ce9-6e68fd89c561"), Description="Non-workplace or personal", SortOrder=Convert.ToDecimal("1.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("0722c22a-27b6-49f8-b390-7b0617e1ff14"), Description="Workplace", SortOrder=Convert.ToDecimal("2.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("5e04f2bb-8561-4277-b8bf-96dfa9885684"), Description="Medicaid", SortOrder=Convert.ToDecimal("3.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("123f2061-3c48-4843-b785-783775e5e70a"), Description="Children's health insurance program", SortOrder=Convert.ToDecimal("4.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("094a545f-905b-4cb2-ac2e-f012f0f57088"), Description="State-only funded insurance", SortOrder=Convert.ToDecimal("5.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("5ae9a3e5-dd51-4e62-a21c-647c1eaa0af4"), Description="Supplemental security income", SortOrder=Convert.ToDecimal("6.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("08595815-c38b-4a9e-bc53-f289bedb5db9"), Description="Military medical", SortOrder=Convert.ToDecimal("8.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("7716171b-51dc-4dd1-9370-1f13ad2e49b6"), Description="Veteran's medical", SortOrder=Convert.ToDecimal("10.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("ac946c48-b26e-4329-9c5e-0d85697801d5"), Description="None", SortOrder=Convert.ToDecimal("20.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("f69d8a68-0c81-4c20-b808-38476d1128a5"), Description="Other", SortOrder=Convert.ToDecimal("21.00") },
       };
   }
}
