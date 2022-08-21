//**********************************************************
//* DomainName: Autobahn.Financial
//* FileName:   IFinancialAccountProgram.cs
//**********************************************************

namespace Autobahn.Interfaces.Financial;

public interface IFinancialAccountProgram : IAutobahnBase
{
    string Name { get; set; }
    string ProgramNumber { get; set; }
}