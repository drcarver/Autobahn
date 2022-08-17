//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELChildHealth.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildHealth Interface
     /// </summary>
    public partial interface IELChildHealth : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefScheduledWellChildScreening"/> model
        /// </summary>
        Guid? RefScheduledWellChildScreeningId { get; set; }

        /// <summary>
        /// Well Child Screening Received Date
        /// <para>
        /// The year, month and day of a well child visit.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20612">Well Child Screening Received Date</a>
        /// </para>
        /// </summary>
        System.DateTime? WellChildScreeningReceivedDate { get; set; }

    }
}
