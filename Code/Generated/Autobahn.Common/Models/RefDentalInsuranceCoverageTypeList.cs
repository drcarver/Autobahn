//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefDentalInsuranceCoverageTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefDentalInsuranceCoverageType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefDentalInsuranceCoverageTypeModel"> List
         /// </summary>
        public static List<RefDentalInsuranceCoverageTypeModel> RefDentalInsuranceCoverageTypeList = new List<RefDentalInsuranceCoverageTypeModel>
        {
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("cd2a27e8-34e4-4c4b-8935-34845687eae4"), Code="NonWorkplace", Description="Non-workplace or personal", Definition="Non-workplace or personal insurance coverage.", SortOrder=Convert.ToDecimal("1.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("de148d3d-a3aa-4e47-a8f5-ab40cb9abf82"), Code="Workplace", Description="Workplace", Definition="Workplace insurance coverage.", SortOrder=Convert.ToDecimal("2.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("7c8da329-f3fa-4ddf-997f-58eaa75e850b"), Code="Medicaid", Description="Medicaid", Definition="Medicaid insurance coverage.", SortOrder=Convert.ToDecimal("3.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("87d2e577-9e0c-48cc-9795-1d291bff1695"), Code="CHIP", Description="Children's health insurance program", Definition="Children's health insurance program.", SortOrder=Convert.ToDecimal("4.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("da961708-8353-45de-a95f-0a4ea5526042"), Code="StateOnlyFunded", Description="State-only funded insurance", Definition="State-only funded insurance coverage.", SortOrder=Convert.ToDecimal("5.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("93d33c36-1cf5-4049-b2a1-70053bd9b3b0"), Code="SSI", Description="Supplemental security income", Definition="Supplemental security income insurance coverage.", SortOrder=Convert.ToDecimal("6.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("5f8b94f4-e4f5-469d-bd9a-a3b1dbf32b28"), Code="Military", Description="Military medical", Definition="Military medical insurance coverage.", SortOrder=Convert.ToDecimal("8.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("2a18a607-edaf-4d1f-a995-333a70dc6028"), Code="Veteran", Description="Veteran's medical", Definition="Veteran's medical insurance coverage.", SortOrder=Convert.ToDecimal("10.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("6bc0a785-e1d7-4e9f-b499-5fcd6b10de10"), Code="None", Description="None", Definition="None insurance coverage.", SortOrder=Convert.ToDecimal("20.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("f5e25a8a-0b3d-43e8-b501-bd7825108415"), Code="Other", Description="Other", Definition="Other insurance coverage.", SortOrder=Convert.ToDecimal("21.00") },
        };

        /// <summary>
        /// The Reference RefDentalInsuranceCoverageType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefDentalInsuranceCoverageTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("cd2a27e8-34e4-4c4b-8935-34845687eae4"), Description="Non-workplace or personal", SortOrder=Convert.ToDecimal("1.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("de148d3d-a3aa-4e47-a8f5-ab40cb9abf82"), Description="Workplace", SortOrder=Convert.ToDecimal("2.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("7c8da329-f3fa-4ddf-997f-58eaa75e850b"), Description="Medicaid", SortOrder=Convert.ToDecimal("3.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("87d2e577-9e0c-48cc-9795-1d291bff1695"), Description="Children's health insurance program", SortOrder=Convert.ToDecimal("4.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("da961708-8353-45de-a95f-0a4ea5526042"), Description="State-only funded insurance", SortOrder=Convert.ToDecimal("5.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("93d33c36-1cf5-4049-b2a1-70053bd9b3b0"), Description="Supplemental security income", SortOrder=Convert.ToDecimal("6.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("5f8b94f4-e4f5-469d-bd9a-a3b1dbf32b28"), Description="Military medical", SortOrder=Convert.ToDecimal("8.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("2a18a607-edaf-4d1f-a995-333a70dc6028"), Description="Veteran's medical", SortOrder=Convert.ToDecimal("10.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("6bc0a785-e1d7-4e9f-b499-5fcd6b10de10"), Description="None", SortOrder=Convert.ToDecimal("20.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("f5e25a8a-0b3d-43e8-b501-bd7825108415"), Description="Other", SortOrder=Convert.ToDecimal("21.00") },
       };
   }
}
