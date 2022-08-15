//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IQuarterlyEmploymentRecord.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IQuarterlyEmploymentRecord Interface
     /// </summary>
    public partial interface IQuarterlyEmploymentRecord : IAutobahnBase
    {
        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        System.Decimal? Earnings { get; set; }

    }
}
