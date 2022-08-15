//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   QuarterlyEmploymentRecordModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The QuarterlyEmploymentRecord Model
     /// </summary>
    public partial class QuarterlyEmploymentRecordModel : AutobahnBase, Interfaces.IQuarterlyEmploymentRecord
    {
        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        public System.Decimal? Earnings { get; set; }

    }
}
