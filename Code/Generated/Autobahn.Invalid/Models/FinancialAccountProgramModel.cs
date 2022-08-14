//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   FinancialAccountProgramModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The FinancialAccountProgram Model
     /// </summary>
    public partial class FinancialAccountProgramModel : AutobahnBase, Interfaces.IFinancialAccountProgram
    {
        /// <summary>
        /// The name given to the program area in an educational institution's accounting system.
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// The name given to the program area in an educational institution's accounting system.
        /// </summary>
        public System.String ProgramNumber { get; set; }

    }
}
