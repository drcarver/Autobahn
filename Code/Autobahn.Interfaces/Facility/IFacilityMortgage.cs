//**********************************************************
//* DomainName: Autobahn.Interfaces.Facility
//* FileName:   IFacilityFinancial.cs
//**********************************************************

namespace Autobahn.Interfaces.Facility;

public interface IFacilityMortgage
{
    Guid FacilityId { get; set; }
    decimal? FacilityMortgageInterestAmount { get; set; }
    decimal? FacilityTotalAssessedValue { get; set; }
    Guid? RefFacilityMortgageInterestTypeId { get; set; }
    Guid? RefFacilityMortgageTypeId { get; set; }
}