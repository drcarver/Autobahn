//**********************************************************
//* DomainName: Autobahn.Interfaces.Facility
//* FileName:   IFacilityFinancial.cs
//**********************************************************

namespace Autobahn.Interfaces.Facility;

public interface IFacilityFinancial
{
    Guid OrganizationFinancialId { get; set; }
    Guid? FacilityLeaseId { get; set; }
    Guid? FacilityMortgageId { get; set; }
    Guid? FacilityMortgageFeeId { get; set; }
}