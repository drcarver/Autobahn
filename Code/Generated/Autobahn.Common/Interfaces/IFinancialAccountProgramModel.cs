//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IFinancialAccountProgramModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IFinancialAccountProgramModel Interface
     /// </summary>
    public partial interface IFinancialAccountProgramModel : IAutobahnBase
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
