//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityAuditTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityAuditType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityAuditType"> List
         /// </summary>
        public static List<RefFacilityAuditType> RefFacilityAuditTypeList = new List<RefFacilityAuditType> =
        {
            new RefFacilityAuditType { Id=Guid.Parse("58a78bc9-65cc-4d51-85d1-d645e1d1edae"), Code="A systematic review of the quality and operation of a new or substantially improved building to ensure that it functions according to its design and construction specifications.", Description="02979", Definition="", SortOrder=0 },
            new RefFacilityAuditType { Id=Guid.Parse("0622dd06-caca-4862-8dce-311f60330533"), Code="A systematic review of the approved budget and actual expenditures and encumbrances.", Description="02977", Definition="", SortOrder=0 },
            new RefFacilityAuditType { Id=Guid.Parse("6d28e534-15be-4fa2-8536-5a168b9b48b4"), Code="A systematic review of the capacity of a school district or municipality to generate and sustain funds to support plans, projects, or other requirements.", Description="02980", Definition="", SortOrder=0 },
            new RefFacilityAuditType { Id=Guid.Parse("10dcd930-e001-4226-86c1-20de127c7d99"), Code="A systematic review of the decision-making, staffing, contracts, and governing procedures.", Description="02976", Definition="", SortOrder=0 },
            new RefFacilityAuditType { Id=Guid.Parse("1ddcc584-a85e-4702-8dfb-28a85d505cab"), Code="A systematic review of the quality of work performed and its relationship to outcomes.", Description="02978", Definition="", SortOrder=0 },
            new RefFacilityAuditType { Id=Guid.Parse("e17b881e-6f09-4cce-bb98-f7039f95fda6"), Code="The review of building program specifications, design and construction after the building alteration, addition or new construction has been in service for at least one year, to assess how well the facility supports the educational program and how well the design is meeting expectation for building performance.", Description="13688", Definition="", SortOrder=0 },
            new RefFacilityAuditType { Id=Guid.Parse("666e92cb-8479-479b-890f-7bd449af4098"), Code="A systematic review of procurement procedures and decision-making.", Description="02981", Definition="", SortOrder=0 },
            new RefFacilityAuditType { Id=Guid.Parse("8e178865-db7d-4e22-b92e-a146a4adaa74"), Code="Retro-commissioning (RCx) is a one-time, systematic investigation of a building's operations and maintenance process for improving and optimizing a building's operation and maintenance done in buildings that have been in operation for at least 3 years, but usually many more years.", Description="13687", Definition="", SortOrder=0 },
            new RefFacilityAuditType { Id=Guid.Parse("b8d3d1b9-2b0c-46ce-a583-8bb0f3a4c8a1"), Code="Other is specified as the type of systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.", Description="09999", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFacilityAuditType Pick List
         /// </summary>
        public static List<RefFacilityAuditType> RefFacilityAuditTypePickList = new List<RefFacilityAuditType> =
        {
            new RefFacilityAuditType { Id=Guid.Parse("58a78bc9-65cc-4d51-85d1-d645e1d1edae"), Code="A systematic review of the quality and operation of a new or substantially improved building to ensure that it functions according to its design and construction specifications.", SortOrder=0 },
            new RefFacilityAuditType { Id=Guid.Parse("0622dd06-caca-4862-8dce-311f60330533"), Code="A systematic review of the approved budget and actual expenditures and encumbrances.", SortOrder=0 },
            new RefFacilityAuditType { Id=Guid.Parse("6d28e534-15be-4fa2-8536-5a168b9b48b4"), Code="A systematic review of the capacity of a school district or municipality to generate and sustain funds to support plans, projects, or other requirements.", SortOrder=0 },
            new RefFacilityAuditType { Id=Guid.Parse("10dcd930-e001-4226-86c1-20de127c7d99"), Code="A systematic review of the decision-making, staffing, contracts, and governing procedures.", SortOrder=0 },
            new RefFacilityAuditType { Id=Guid.Parse("1ddcc584-a85e-4702-8dfb-28a85d505cab"), Code="A systematic review of the quality of work performed and its relationship to outcomes.", SortOrder=0 },
            new RefFacilityAuditType { Id=Guid.Parse("e17b881e-6f09-4cce-bb98-f7039f95fda6"), Code="The review of building program specifications, design and construction after the building alteration, addition or new construction has been in service for at least one year, to assess how well the facility supports the educational program and how well the design is meeting expectation for building performance.", SortOrder=0 },
            new RefFacilityAuditType { Id=Guid.Parse("666e92cb-8479-479b-890f-7bd449af4098"), Code="A systematic review of procurement procedures and decision-making.", SortOrder=0 },
            new RefFacilityAuditType { Id=Guid.Parse("8e178865-db7d-4e22-b92e-a146a4adaa74"), Code="Retro-commissioning (RCx) is a one-time, systematic investigation of a building's operations and maintenance process for improving and optimizing a building's operation and maintenance done in buildings that have been in operation for at least 3 years, but usually many more years.", SortOrder=0 },
            new RefFacilityAuditType { Id=Guid.Parse("b8d3d1b9-2b0c-46ce-a583-8bb0f3a4c8a1"), Code="Other is specified as the type of systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.", SortOrder=0 },
       };
   }
}
