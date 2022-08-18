//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonStatus.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonStatus Interface
     /// </summary>
    public partial interface IPersonStatus : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonStatusType"/> model
        /// </summary>
        Guid RefPersonStatusTypeId { get; set; }

        /// <summary>
        /// Status End Date
        /// <para>
        /// The last year, month and day when a status applied to an individual.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20193">Status End Date</a>
        /// </para>
        /// </summary>
        System.DateTime? StatusEndDate { get; set; }

        /// <summary>
        /// Status Start Date
        /// <para>
        /// The year, month and day that a status became applicable to an individual.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20192">Status Start Date</a>
        /// </para>
        /// </summary>
        System.DateTime? StatusStartDate { get; set; }

        System.Boolean StatusValue { get; set; }

    }
}
