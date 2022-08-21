//**********************************************************
//* DomainName: Autobahn.Interfaces.Financial
//* FileName:   IOrganizationFinancial.cs
//**********************************************************

namespace Autobahn.Interfaces.Financial;

public interface IOrganizationFinancial
{
    Guid FinancialAccountId { get; set; }
    Guid OrganizationCalendarSessionId { get; set; }
    decimal? ActualValue { get; set; }
    decimal? BudgetedValue { get; set; }
    DateTime? Date { get; set; }
    decimal? EncumberedValue { get; set; }
    decimal? Value { get; set; }
    DateTime? FiscalPeriodBeginDate { get; set; }
    DateTime? FiscalPeriodEndDate { get; set; }
    string FiscalYear { get; set; }
    Guid? FinancialAccountProgramId { get; set; }
}