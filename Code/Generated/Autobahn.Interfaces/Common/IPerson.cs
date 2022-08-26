//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPerson.cs
//***************************************************************************

namespace Autobahn.Interfaces.Common
{
     /// <summary>
     /// The IPerson Interface
     /// </summary>
    public partial interface IPerson : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonMaster"/> model
        /// </summary>
        Guid? PersonMasterId { get; set; }

    }
}
