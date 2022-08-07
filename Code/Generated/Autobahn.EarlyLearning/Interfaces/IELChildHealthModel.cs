//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELChildHealthModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildHealthModel Interface
     /// </summary>
    public partial interface IELChildHealthModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the ELChildHealth.WellChildScreeningReceivedDate nullable property
        /// </summary>
        System.DateTime? WellChildScreeningReceivedDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefScheduledWellChildScreening"/> model
        /// </summary>
        Guid? RefScheduledWellChildScreeningId { get; set; }

    }
}
