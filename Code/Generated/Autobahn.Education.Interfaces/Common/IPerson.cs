//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPerson.cs
//***************************************************************************

namespace Autobahn.Education.Interfaces.Common
{
     /// <summary>
     /// The IPerson Interface
     /// </summary>
    public partial interface IPerson : IAutobahnBase
    {
        #region IPerson
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonMaster"/> model
        /// </summary>
        Guid? PersonMasterId { get; set; }

        #endregion
    }
}
