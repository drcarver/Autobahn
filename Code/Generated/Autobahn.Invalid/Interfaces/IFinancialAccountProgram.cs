//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IFinancialAccountProgram.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IFinancialAccountProgram Interface
     /// </summary>
    public partial interface IFinancialAccountProgram : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ProgramNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

    }
}
