//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefELServiceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefELServiceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefELServiceType"> List
         /// </summary>
        public static List<RefELServiceType> RefELServiceTypeList = new List<RefELServiceType>
        {
            new RefELServiceType { Id=Guid.Parse("9694c230-06a9-4757-936b-77b10fb53cf4"), Code="MentalHealth", Description="Mental health", Definition="Mental health is the type of service provided to a child.", SortOrder=Convert.ToDecimal("1.00") },
            new RefELServiceType { Id=Guid.Parse("79136f55-284e-44b4-8dbf-9f5df93f5e23"), Code="Nutritional", Description="Nutritional", Definition="Nutritional is the type of service provided to a child.", SortOrder=Convert.ToDecimal("3.00") },
            new RefELServiceType { Id=Guid.Parse("8bceab8b-c03e-40c0-9d1e-327c60bfa08b"), Code="Educational", Description="Educational", Definition="Educational is the type of service provided to a child.", SortOrder=Convert.ToDecimal("5.00") },
            new RefELServiceType { Id=Guid.Parse("8cb4f3f6-2c8a-4ee1-8179-7fa0a362ecbf"), Code="PhysicalRehabilitation", Description="Physical rehabilitation", Definition="Physical rehabilitation", SortOrder=Convert.ToDecimal("7.00") },
            new RefELServiceType { Id=Guid.Parse("50138fd5-91d3-4470-8dea-93248028b9f7"), Code="DentalHealth", Description="Dental Health", Definition="Dental Health is the type of service provided to a child.", SortOrder=Convert.ToDecimal("9.00") },
            new RefELServiceType { Id=Guid.Parse("92ac87e6-3a4f-454a-ae45-73d702af38e8"), Code="Other", Description="Other", Definition="The type of service provided to a child is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefELServiceType Pick List
         /// </summary>
        public static List<RefELServiceType> RefELServiceTypePickList = new List<RefELServiceType>
        {
            new RefELServiceType { Id=Guid.Parse("9694c230-06a9-4757-936b-77b10fb53cf4"), Code="MentalHealth", Description="Mental health", SortOrder=Convert.ToDecimal("1.00") },
            new RefELServiceType { Id=Guid.Parse("79136f55-284e-44b4-8dbf-9f5df93f5e23"), Code="Nutritional", Description="Nutritional", SortOrder=Convert.ToDecimal("3.00") },
            new RefELServiceType { Id=Guid.Parse("8bceab8b-c03e-40c0-9d1e-327c60bfa08b"), Code="Educational", Description="Educational", SortOrder=Convert.ToDecimal("5.00") },
            new RefELServiceType { Id=Guid.Parse("8cb4f3f6-2c8a-4ee1-8179-7fa0a362ecbf"), Code="PhysicalRehabilitation", Description="Physical rehabilitation", SortOrder=Convert.ToDecimal("7.00") },
            new RefELServiceType { Id=Guid.Parse("50138fd5-91d3-4470-8dea-93248028b9f7"), Code="DentalHealth", Description="Dental Health", SortOrder=Convert.ToDecimal("9.00") },
            new RefELServiceType { Id=Guid.Parse("92ac87e6-3a4f-454a-ae45-73d702af38e8"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
