//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityCapitalProgramMgmtTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityCapitalProgramMgmtType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityCapitalProgramMgmtType"> List
         /// </summary>
        public static List<RefFacilityCapitalProgramMgmtType> RefFacilityCapitalProgramMgmtTypeList = new List<RefFacilityCapitalProgramMgmtType>
        {
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("3a88d8af-8093-4cb3-8b51-72fa4fc580a4"), Code="02913", Description="District management", Definition="The school district procures and oversees the design and construction services for its capital projects.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("54c000c7-0b24-47bf-9e75-d8ef738909e7"), Code="02824", Description="Nonschool public agency management", Definition="A nonschool governmental agency procures and oversees the design and construction of the school district's capital projects. May be a municipal clerk of the works, separate building authority, or even the Army Corps of Engineers.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("bf357fee-f631-495d-8ba2-e0d5ec648ae5"), Code="02823", Description="Private management", Definition="The school district contracts with private program managers who procure and oversee the design and construction of its capital projects.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("1beba35f-a8b3-4e86-b19f-1206d2c2b5ab"), Code="09999", Description="Other", Definition="Other is specified as the type of management organization for planning, design, and construction of major capital projects.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefFacilityCapitalProgramMgmtType Pick List
         /// </summary>
        public static List<RefFacilityCapitalProgramMgmtType> RefFacilityCapitalProgramMgmtTypePickList = new List<RefFacilityCapitalProgramMgmtType>
        {
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("3a88d8af-8093-4cb3-8b51-72fa4fc580a4"), Code="02913", Description="District management", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("54c000c7-0b24-47bf-9e75-d8ef738909e7"), Code="02824", Description="Nonschool public agency management", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("bf357fee-f631-495d-8ba2-e0d5ec648ae5"), Code="02823", Description="Private management", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("1beba35f-a8b3-4e86-b19f-1206d2c2b5ab"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
