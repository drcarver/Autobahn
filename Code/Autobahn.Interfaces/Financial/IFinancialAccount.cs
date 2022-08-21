//**********************************************************
//* DomainName: Autobahn.Interfaces.Financial
//* FileName:   IFinancialAccount.cs
//**********************************************************

namespace Autobahn.Interfaces.Financial;

public interface IFinancialAccount
{
    string Name { get; set; }
    string Description { get; set; }
    string AccountNumber { get; set; }
    Guid? RefFinancialAccountCategoryId { get; set; }
    Guid? RefFinancialAccountFundClassificationId { get; set; }
    Guid? RefFinancialAccountProgramCodeId { get; set; }
    Guid? RefFinancialAccountBalanceSheetCodeId { get; set; }
    Guid? RefFinancialExpenditureFunctionCodeId { get; set; }
    Guid? RefFinancialExpenditureObjectCodeId { get; set; }
    string FinancialAccountNumber { get; set; }
    decimal? FinancialExpenditureProjectReportingCode { get; set; }
    Guid? RefFinancialExpenditureLevelOfInstructionCodeId { get; set; }
    Guid? RefFinancialAccountRevenueCodeId { get; set; }
    string FederalProgramCode { get; set; }
}