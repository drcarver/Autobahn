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
        public static List<RefFacilityAuditType> RefFacilityAuditTypeList = new List<RefFacilityAuditType>
        {
            new RefFacilityAuditType { Id=Guid.Parse("54791af7-c541-40a7-aa3d-23e33ba3d1c8"), Code="02979", Description="Building commissioning", Definition="A systematic review of the quality and operation of a new or substantially improved building to ensure that it functions according to its design and construction specifications.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityAuditType { Id=Guid.Parse("62025e97-2755-4c08-8215-f976185e2526"), Code="02977", Description="Financial audit", Definition="A systematic review of the approved budget and actual expenditures and encumbrances.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityAuditType { Id=Guid.Parse("ad9f2acf-2c6d-44b5-9ad7-28fd7e9a197c"), Code="02980", Description="Fiscal audit", Definition="A systematic review of the capacity of a school district or municipality to generate and sustain funds to support plans, projects, or other requirements.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityAuditType { Id=Guid.Parse("82888c03-f6ae-4985-9d6f-afa9a51a1020"), Code="02976", Description="Management audit", Definition="A systematic review of the decision-making, staffing, contracts, and governing procedures.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityAuditType { Id=Guid.Parse("b52f29fb-a40d-4f4c-9277-34d5c7cd3c86"), Code="02978", Description="Performance audit", Definition="A systematic review of the quality of work performed and its relationship to outcomes.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityAuditType { Id=Guid.Parse("8bf54e17-d814-4297-9d58-031bb2245edc"), Code="13688", Description="Post Occupancy Evaluation", Definition="The review of building program specifications, design and construction after the building alteration, addition or new construction has been in service for at least one year, to assess how well the facility supports the educational program and how well the design is meeting expectation for building performance.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilityAuditType { Id=Guid.Parse("d22b17d9-49a5-4a90-9804-580ba80acd5f"), Code="02981", Description="Process audit", Definition="A systematic review of procurement procedures and decision-making.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilityAuditType { Id=Guid.Parse("51bfec28-1b7b-408e-b1fe-af25089b91ae"), Code="13687", Description="Retro-commissioning", Definition="Retro-commissioning (RCx) is a one-time, systematic investigation of a building's operations and maintenance process for improving and optimizing a building's operation and maintenance done in buildings that have been in operation for at least 3 years, but usually many more years.", SortOrder=Convert.ToDecimal("8.00") },
            new RefFacilityAuditType { Id=Guid.Parse("9e996c0c-93a5-45e6-8721-74ed33526a00"), Code="09999", Description="Other", Definition="Other is specified as the type of systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefFacilityAuditType Pick List
         /// </summary>
        public static List<RefFacilityAuditType> RefFacilityAuditTypePickList = new List<RefFacilityAuditType>
        {
            new RefFacilityAuditType { Id=Guid.Parse("54791af7-c541-40a7-aa3d-23e33ba3d1c8"), Code="02979", Description="Building commissioning", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityAuditType { Id=Guid.Parse("62025e97-2755-4c08-8215-f976185e2526"), Code="02977", Description="Financial audit", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityAuditType { Id=Guid.Parse("ad9f2acf-2c6d-44b5-9ad7-28fd7e9a197c"), Code="02980", Description="Fiscal audit", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityAuditType { Id=Guid.Parse("82888c03-f6ae-4985-9d6f-afa9a51a1020"), Code="02976", Description="Management audit", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityAuditType { Id=Guid.Parse("b52f29fb-a40d-4f4c-9277-34d5c7cd3c86"), Code="02978", Description="Performance audit", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityAuditType { Id=Guid.Parse("8bf54e17-d814-4297-9d58-031bb2245edc"), Code="13688", Description="Post Occupancy Evaluation", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilityAuditType { Id=Guid.Parse("d22b17d9-49a5-4a90-9804-580ba80acd5f"), Code="02981", Description="Process audit", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilityAuditType { Id=Guid.Parse("51bfec28-1b7b-408e-b1fe-af25089b91ae"), Code="13687", Description="Retro-commissioning", SortOrder=Convert.ToDecimal("8.00") },
            new RefFacilityAuditType { Id=Guid.Parse("9e996c0c-93a5-45e6-8721-74ed33526a00"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
