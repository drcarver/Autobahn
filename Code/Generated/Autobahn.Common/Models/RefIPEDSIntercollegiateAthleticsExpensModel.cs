//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIPEDSIntercollegiateAthleticsExpensModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefIPEDSIntercollegiateAthleticsExpens Model
     /// </summary>
    public partial class RefIPEDSIntercollegiateAthleticsExpensModel : ReferenceModelBase, IRefIPEDSIntercollegiateAthleticsExpensModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefIPEDSIntercollegiateAthleticsExpenses"/> model
        /// </summary>
        public Guid RefIPEDSIntercollegiateAthleticsExpensesId { get; set; }

    }
}
