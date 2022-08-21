//**********************************************************
//* DomainName: Autobahn.Interfaces.Financial
//* FileName:   IIPEDSFinance.cs
//**********************************************************

namespace Autobahn.Interfaces.Financial;

public interface IIPEDSFinance
{
    Guid OrganizationFinancialId { get; set; }
    Guid? RefIPEDSFASBFinancialPositionId { get; set; }
    Guid? RefIPEDSFASBFunctionalExpenseId { get; set; }
    Guid? RefIPEDSFASBPellGrantTransactionsId { get; set; }
    Guid? RefIPEDSFASBRevenueId { get; set; }
    Guid? RefIPEDSFASBRevenueRestrictionId { get; set; }
    Guid? RefIPEDSFASBScholarshipsandFellowshipsRevenueId { get; set; }
    Guid? RefIPEDSGASBFinancialPositionId { get; set; }
    Guid? RefIPEDSGASBFunctionalExpenseId { get; set; }
    Guid? RefIPEDSGASBRevenueId { get; set; }
    Guid? RefIPEDSGASBScholarshipsandFellowshipsRevenueId { get; set; }
    Guid? RefIPEDSIntercollegiateAthleticsExpensesId { get; set; }
    Guid? RefIPEDSNaturalExpenseId { get; set; }
}