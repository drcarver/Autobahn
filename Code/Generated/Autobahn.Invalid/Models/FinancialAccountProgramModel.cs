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
        /// 
        /// </summary>
        public Guid? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ProgramNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

    }
}
