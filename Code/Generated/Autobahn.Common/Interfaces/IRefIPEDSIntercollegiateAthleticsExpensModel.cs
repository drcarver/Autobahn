//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefIPEDSIntercollegiateAthleticsExpensModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefIPEDSIntercollegiateAthleticsExpens Interface Model
     /// </summary>
    public partial interface IRefIPEDSIntercollegiateAthleticsExpensModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefIPEDSIntercollegiateAthleticsExpenses"/> model
        /// </summary>
        Guid RefIPEDSIntercollegiateAthleticsExpensesId { get; set; }

    }
}
