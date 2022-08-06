//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefHealthInsuranceCoverageList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefHealthInsuranceCoverage Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefHealthInsuranceCoverage"> List
         /// </summary>
        public static List<RefHealthInsuranceCoverage> RefHealthInsuranceCoverageList = new List<RefHealthInsuranceCoverage>
        {
            new RefHealthInsuranceCoverage { Id=Guid.Parse("97ce9a72-3cdb-4492-b0d1-64bf58238c81"), Code="NonWorkplace", Description="Non-workplace or personal", Definition="Non-workplace or personal insurance coverage.", SortOrder=Convert.ToDecimal("1.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("0bef7eaa-ced0-4f3a-b476-779b21db2279"), Code="Workplace", Description="Workplace", Definition="Workplace insurance coverage.", SortOrder=Convert.ToDecimal("2.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("e9568c27-25c0-4cb0-93f0-2c606c1bd2a1"), Code="Medicaid", Description="Medicaid", Definition="Medicaid insurance coverage.", SortOrder=Convert.ToDecimal("3.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("59372ab6-dad8-40e0-a7d4-743a45aa3569"), Code="CHIP", Description="Children's health insurance program", Definition="Children's health insurance program.", SortOrder=Convert.ToDecimal("4.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("0ba8425e-e1d8-423f-8ac4-7125cfa7ae66"), Code="StateOnlyFunded", Description="State-only funded insurance", Definition="State-only funded insurance coverage.", SortOrder=Convert.ToDecimal("5.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("3d100bcf-16cd-4b95-801f-9054a0df2999"), Code="SSI", Description="Supplemental security income", Definition="Supplemental security income insurance coverage.", SortOrder=Convert.ToDecimal("6.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("75d4ded5-85f3-47ed-b406-450a40feeca5"), Code="Military", Description="Military medical", Definition="Military medical insurance coverage.", SortOrder=Convert.ToDecimal("8.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("4901a06e-c807-4174-9fd5-a15294cc11d1"), Code="Veteran", Description="Veteran's medical", Definition="Veteran's medical insurance coverage.", SortOrder=Convert.ToDecimal("10.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("90415cc8-aa1f-48e3-97ed-d6f010756d1e"), Code="None", Description="None", Definition="None insurance coverage.", SortOrder=Convert.ToDecimal("20.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("29cc7bc6-9bdb-4c8c-a0ae-f0e0723e9de5"), Code="Other", Description="Other", Definition="Other insurance coverage.", SortOrder=Convert.ToDecimal("21.00") },
        };

        /// <summary>
        /// The RefHealthInsuranceCoverage Pick List
         /// </summary>
        public static List<RefHealthInsuranceCoverage> RefHealthInsuranceCoveragePickList = new List<RefHealthInsuranceCoverage>
        {
            new RefHealthInsuranceCoverage { Id=Guid.Parse("97ce9a72-3cdb-4492-b0d1-64bf58238c81"), Code="NonWorkplace", Description="Non-workplace or personal", SortOrder=Convert.ToDecimal("1.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("0bef7eaa-ced0-4f3a-b476-779b21db2279"), Code="Workplace", Description="Workplace", SortOrder=Convert.ToDecimal("2.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("e9568c27-25c0-4cb0-93f0-2c606c1bd2a1"), Code="Medicaid", Description="Medicaid", SortOrder=Convert.ToDecimal("3.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("59372ab6-dad8-40e0-a7d4-743a45aa3569"), Code="CHIP", Description="Children's health insurance program", SortOrder=Convert.ToDecimal("4.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("0ba8425e-e1d8-423f-8ac4-7125cfa7ae66"), Code="StateOnlyFunded", Description="State-only funded insurance", SortOrder=Convert.ToDecimal("5.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("3d100bcf-16cd-4b95-801f-9054a0df2999"), Code="SSI", Description="Supplemental security income", SortOrder=Convert.ToDecimal("6.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("75d4ded5-85f3-47ed-b406-450a40feeca5"), Code="Military", Description="Military medical", SortOrder=Convert.ToDecimal("8.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("4901a06e-c807-4174-9fd5-a15294cc11d1"), Code="Veteran", Description="Veteran's medical", SortOrder=Convert.ToDecimal("10.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("90415cc8-aa1f-48e3-97ed-d6f010756d1e"), Code="None", Description="None", SortOrder=Convert.ToDecimal("20.00") },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("29cc7bc6-9bdb-4c8c-a0ae-f0e0723e9de5"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("21.00") },
       };
   }
}
