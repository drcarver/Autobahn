//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildHealthModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildHealth Model
     /// </summary>
    public partial class ELChildHealthModel : AutobahnBase, Interfaces.IELChildHealthModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Defines the ELChildHealth.WellChildScreeningReceivedDate nullable property
        /// </summary>
        public System.DateTime? WellChildScreeningReceivedDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefScheduledWellChildScreening"/> model
        /// </summary>
        public Guid? RefScheduledWellChildScreeningId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
