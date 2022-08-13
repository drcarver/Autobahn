//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildHealthModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildHealth Model
     /// </summary>
    public partial class ELChildHealthModel : AutobahnBase, Interfaces.IELChildHealth
    {
        /// <summary>
        /// The individual well child visit scheduled according to the AAP recommended periodicity schedule.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// The individual well child visit scheduled according to the AAP recommended periodicity schedule.
        /// </summary>
        public Guid? RefScheduledWellChildScreeningId { get; set; }

        /// <summary>
        /// The individual well child visit scheduled according to the AAP recommended periodicity schedule.
        /// </summary>
        public System.DateTime? WellChildScreeningReceivedDate { get; set; }

    }
}
