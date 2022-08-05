//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefIPEDSIntercollegiateAthleticsExpens.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefIPEDSIntercollegiateAthleticsExpens Interface
     /// </summary>
    public partial interface IRefIPEDSIntercollegiateAthleticsExpens : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefIPEDSIntercollegiateAthleticsExpenses"/> model
        /// </summary>
        Guid RefIPEDSIntercollegiateAthleticsExpensesId { get; set; }

    }
}
