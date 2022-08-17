//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildHealthModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The ELChildHealth Model
     /// </summary>
    public partial class ELChildHealthModel : AutobahnBase, Interfaces.IELChildHealth
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefScheduledWellChildScreening"/> model
        /// </summary>
        public Guid? RefScheduledWellChildScreeningId { get; set; }

        /// <summary>
        /// Well Child Screening Received Date
        /// <para>
        /// The year, month and day of a well child visit.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20612">Well Child Screening Received Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? WellChildScreeningReceivedDate { get; set; }

    }
}
