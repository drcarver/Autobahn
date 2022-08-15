//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELStaff.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELStaff Interface
     /// </summary>
    public partial interface IELStaff : IAutobahnBase
    {
        /// <summary>
        /// Type of Child Development Associate credential as defined by options.
        /// </summary>
        Guid? RefChildDevelopmentAssociateTypeId { get; set; }

    }
}
