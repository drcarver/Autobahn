//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIPEDSIntercollegiateAthleticsExpens.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefIPEDSIntercollegiateAthleticsExpens Model
     /// </summary>
    public partial class RefIPEDSIntercollegiateAthleticsExpens : ReferenceModelBase, IRefIPEDSIntercollegiateAthleticsExpens
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefIPEDSIntercollegiateAthleticsExpenses"/> model
        /// </summary>
        public Guid RefIPEDSIntercollegiateAthleticsExpensesId { get; set; }

    }
}
