//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IFinancialAccountProgram.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IFinancialAccountProgram Interface
     /// </summary>
    public partial interface IFinancialAccountProgram : IAutobahnBase
    {
        /// <summary>
        /// The name given to the program area in an educational institution's accounting system.
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// The name given to the program area in an educational institution's accounting system.
        /// </summary>
        System.String ProgramNumber { get; set; }

    }
}
