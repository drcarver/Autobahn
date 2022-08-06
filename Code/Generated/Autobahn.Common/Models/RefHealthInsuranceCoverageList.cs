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
        public static List<RefHealthInsuranceCoverage> RefHealthInsuranceCoverageList = new List<RefHealthInsuranceCoverage> =
        {
            new RefHealthInsuranceCoverage { Id=Guid.Parse("feee8d0c-2d18-4647-835d-4f66b89907cd"), Code="Non-workplace or personal insurance coverage.", Description="NonWorkplace", Definition="", SortOrder=0 },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("98a4977f-5ad2-4255-8f5a-c86b8b4369bf"), Code="Workplace insurance coverage.", Description="Workplace", Definition="", SortOrder=0 },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("7c890378-69a6-4315-9223-fc248d08f743"), Code="Medicaid insurance coverage.", Description="Medicaid", Definition="", SortOrder=0 },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("15d1e4cf-801f-42aa-9002-a115eba3d53a"), Code="Children's health insurance program.", Description="CHIP", Definition="", SortOrder=0 },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("f8c8b837-dc53-4695-b62f-df5e613eb318"), Code="State-only funded insurance coverage.", Description="StateOnlyFunded", Definition="", SortOrder=0 },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("2dfc50a5-76ac-484a-a2e5-ddb83bbe82ec"), Code="Supplemental security income insurance coverage.", Description="SSI", Definition="", SortOrder=0 },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("fb07b5b5-5413-4139-888f-b41c543e26bc"), Code="Military medical insurance coverage.", Description="Military", Definition="", SortOrder=0 },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("f2339607-1b0b-4613-8024-72c2ee026a54"), Code="Veteran's medical insurance coverage.", Description="Veteran", Definition="", SortOrder=0 },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("697cfb71-32b2-4919-aadc-8ef2cdc73b0c"), Code="None insurance coverage.", Description="None", Definition="", SortOrder=0 },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("1686d8dd-43d8-442a-89b8-a0bf4f875799"), Code="Other insurance coverage.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefHealthInsuranceCoverage Pick List
         /// </summary>
        public static List<RefHealthInsuranceCoverage> RefHealthInsuranceCoveragePickList = new List<RefHealthInsuranceCoverage> =
        {
            new RefHealthInsuranceCoverage { Id=Guid.Parse("feee8d0c-2d18-4647-835d-4f66b89907cd"), Code="Non-workplace or personal insurance coverage.", SortOrder=0 },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("98a4977f-5ad2-4255-8f5a-c86b8b4369bf"), Code="Workplace insurance coverage.", SortOrder=0 },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("7c890378-69a6-4315-9223-fc248d08f743"), Code="Medicaid insurance coverage.", SortOrder=0 },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("15d1e4cf-801f-42aa-9002-a115eba3d53a"), Code="Children's health insurance program.", SortOrder=0 },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("f8c8b837-dc53-4695-b62f-df5e613eb318"), Code="State-only funded insurance coverage.", SortOrder=0 },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("2dfc50a5-76ac-484a-a2e5-ddb83bbe82ec"), Code="Supplemental security income insurance coverage.", SortOrder=0 },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("fb07b5b5-5413-4139-888f-b41c543e26bc"), Code="Military medical insurance coverage.", SortOrder=0 },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("f2339607-1b0b-4613-8024-72c2ee026a54"), Code="Veteran's medical insurance coverage.", SortOrder=0 },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("697cfb71-32b2-4919-aadc-8ef2cdc73b0c"), Code="None insurance coverage.", SortOrder=0 },
            new RefHealthInsuranceCoverage { Id=Guid.Parse("1686d8dd-43d8-442a-89b8-a0bf4f875799"), Code="Other insurance coverage.", SortOrder=0 },
       };
   }
}
