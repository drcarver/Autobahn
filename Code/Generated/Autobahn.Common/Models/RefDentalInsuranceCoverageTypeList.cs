//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefDentalInsuranceCoverageTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefDentalInsuranceCoverageType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefDentalInsuranceCoverageType"> List
         /// </summary>
        public static List<RefDentalInsuranceCoverageType> RefDentalInsuranceCoverageTypeList = new List<RefDentalInsuranceCoverageType>
        {
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("0a876755-194f-4be6-ab1c-1adeea0e895b"), Code="NonWorkplace", Description="Non-workplace or personal", Definition="Non-workplace or personal insurance coverage.", SortOrder=Convert.ToDecimal("1.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("f6c5c616-d3fe-4fea-a354-e32b16d92814"), Code="Workplace", Description="Workplace", Definition="Workplace insurance coverage.", SortOrder=Convert.ToDecimal("2.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("f83b8445-a9e1-45b4-a854-3aeb8da080b1"), Code="Medicaid", Description="Medicaid", Definition="Medicaid insurance coverage.", SortOrder=Convert.ToDecimal("3.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("71dad507-5775-4f24-bc68-542e0b34388d"), Code="CHIP", Description="Children's health insurance program", Definition="Children's health insurance program.", SortOrder=Convert.ToDecimal("4.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("5ae3e346-840f-4f16-88f3-e5e692b3f7d4"), Code="StateOnlyFunded", Description="State-only funded insurance", Definition="State-only funded insurance coverage.", SortOrder=Convert.ToDecimal("5.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("b96a7956-9d7f-4d94-81b3-cc3df1afc25f"), Code="SSI", Description="Supplemental security income", Definition="Supplemental security income insurance coverage.", SortOrder=Convert.ToDecimal("6.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("83f8a57f-4cf8-4bec-a264-6568c7fa72cb"), Code="Military", Description="Military medical", Definition="Military medical insurance coverage.", SortOrder=Convert.ToDecimal("8.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("af5df6ec-7ff4-4971-b83e-e099e769c81a"), Code="Veteran", Description="Veteran's medical", Definition="Veteran's medical insurance coverage.", SortOrder=Convert.ToDecimal("10.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("243bcabd-6ff7-4497-9f66-fabc158db35c"), Code="None", Description="None", Definition="None insurance coverage.", SortOrder=Convert.ToDecimal("20.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("4f0680e5-084b-4d96-ba0c-7e93da17854b"), Code="Other", Description="Other", Definition="Other insurance coverage.", SortOrder=Convert.ToDecimal("21.00") },
        };

        /// <summary>
        /// The RefDentalInsuranceCoverageType Pick List
         /// </summary>
        public static List<RefDentalInsuranceCoverageType> RefDentalInsuranceCoverageTypePickList = new List<RefDentalInsuranceCoverageType>
        {
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("0a876755-194f-4be6-ab1c-1adeea0e895b"), Code="NonWorkplace", Description="Non-workplace or personal", SortOrder=Convert.ToDecimal("1.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("f6c5c616-d3fe-4fea-a354-e32b16d92814"), Code="Workplace", Description="Workplace", SortOrder=Convert.ToDecimal("2.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("f83b8445-a9e1-45b4-a854-3aeb8da080b1"), Code="Medicaid", Description="Medicaid", SortOrder=Convert.ToDecimal("3.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("71dad507-5775-4f24-bc68-542e0b34388d"), Code="CHIP", Description="Children's health insurance program", SortOrder=Convert.ToDecimal("4.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("5ae3e346-840f-4f16-88f3-e5e692b3f7d4"), Code="StateOnlyFunded", Description="State-only funded insurance", SortOrder=Convert.ToDecimal("5.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("b96a7956-9d7f-4d94-81b3-cc3df1afc25f"), Code="SSI", Description="Supplemental security income", SortOrder=Convert.ToDecimal("6.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("83f8a57f-4cf8-4bec-a264-6568c7fa72cb"), Code="Military", Description="Military medical", SortOrder=Convert.ToDecimal("8.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("af5df6ec-7ff4-4971-b83e-e099e769c81a"), Code="Veteran", Description="Veteran's medical", SortOrder=Convert.ToDecimal("10.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("243bcabd-6ff7-4497-9f66-fabc158db35c"), Code="None", Description="None", SortOrder=Convert.ToDecimal("20.00") },
            new RefDentalInsuranceCoverageType { Id=Guid.Parse("4f0680e5-084b-4d96-ba0c-7e93da17854b"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("21.00") },
       };
   }
}
