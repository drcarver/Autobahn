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
        /// The complete <see cref="RefFacilityAuditTypeModel"> List
         /// </summary>
        public static List<RefFacilityAuditTypeModel> RefFacilityAuditTypeList = new List<RefFacilityAuditTypeModel>
        {
            new RefFacilityAuditType { Id=Guid.Parse("710a77d0-241c-43ee-91cf-1edf3d5c014a"), Code="02979", Description="Building commissioning", Definition="A systematic review of the quality and operation of a new or substantially improved building to ensure that it functions according to its design and construction specifications.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityAuditType { Id=Guid.Parse("825745db-b6fb-4fe3-b9e7-57e37e041fe6"), Code="02977", Description="Financial audit", Definition="A systematic review of the approved budget and actual expenditures and encumbrances.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityAuditType { Id=Guid.Parse("eb3fe914-fd9e-46e4-87ee-16ea4c905b97"), Code="02980", Description="Fiscal audit", Definition="A systematic review of the capacity of a school district or municipality to generate and sustain funds to support plans, projects, or other requirements.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityAuditType { Id=Guid.Parse("3c6bb566-1669-4a1d-9f0f-f930e60140d2"), Code="02976", Description="Management audit", Definition="A systematic review of the decision-making, staffing, contracts, and governing procedures.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityAuditType { Id=Guid.Parse("8144a182-3feb-4abc-b62e-720e336eb735"), Code="02978", Description="Performance audit", Definition="A systematic review of the quality of work performed and its relationship to outcomes.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityAuditType { Id=Guid.Parse("b2d38032-0380-485d-ab7f-48904b8afb58"), Code="13688", Description="Post Occupancy Evaluation", Definition="The review of building program specifications, design and construction after the building alteration, addition or new construction has been in service for at least one year, to assess how well the facility supports the educational program and how well the design is meeting expectation for building performance.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilityAuditType { Id=Guid.Parse("199dc5ac-9a0f-42b0-8614-f79e4ab91307"), Code="02981", Description="Process audit", Definition="A systematic review of procurement procedures and decision-making.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilityAuditType { Id=Guid.Parse("6460bdde-bb6f-4edb-9ec3-a33bbd7a9676"), Code="13687", Description="Retro-commissioning", Definition="Retro-commissioning (RCx) is a one-time, systematic investigation of a building's operations and maintenance process for improving and optimizing a building's operation and maintenance done in buildings that have been in operation for at least 3 years, but usually many more years.", SortOrder=Convert.ToDecimal("8.00") },
            new RefFacilityAuditType { Id=Guid.Parse("9112624c-d179-4980-90a1-ac807f4f12d4"), Code="09999", Description="Other", Definition="Other is specified as the type of systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefFacilityAuditType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilityAuditTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilityAuditType { Id=Guid.Parse("710a77d0-241c-43ee-91cf-1edf3d5c014a"), Description="Building commissioning", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityAuditType { Id=Guid.Parse("825745db-b6fb-4fe3-b9e7-57e37e041fe6"), Description="Financial audit", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityAuditType { Id=Guid.Parse("eb3fe914-fd9e-46e4-87ee-16ea4c905b97"), Description="Fiscal audit", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityAuditType { Id=Guid.Parse("3c6bb566-1669-4a1d-9f0f-f930e60140d2"), Description="Management audit", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityAuditType { Id=Guid.Parse("8144a182-3feb-4abc-b62e-720e336eb735"), Description="Performance audit", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityAuditType { Id=Guid.Parse("b2d38032-0380-485d-ab7f-48904b8afb58"), Description="Post Occupancy Evaluation", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilityAuditType { Id=Guid.Parse("199dc5ac-9a0f-42b0-8614-f79e4ab91307"), Description="Process audit", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilityAuditType { Id=Guid.Parse("6460bdde-bb6f-4edb-9ec3-a33bbd7a9676"), Description="Retro-commissioning", SortOrder=Convert.ToDecimal("8.00") },
            new RefFacilityAuditType { Id=Guid.Parse("9112624c-d179-4980-90a1-ac807f4f12d4"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
