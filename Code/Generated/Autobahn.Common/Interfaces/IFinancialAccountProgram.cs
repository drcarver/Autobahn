//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IFinancialAccountProgram.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IFinancialAccountProgram
     /// </summary>
    public partial interface IFinancialAccountProgram : IAutobahnBase
    {
        /// <summary>
        /// Defines the FinancialAccountProgram.Name non nullable property
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// Defines the FinancialAccountProgram.ProgramNumber non nullable property
        /// </summary>
        System.String ProgramNumber { get; set; }

    }
}
