//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonStatusModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonStatus Model
     /// </summary>
    public partial class PersonStatusModel : AutobahnBase, Interfaces.IPersonStatus
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonStatusType"/> model
        /// </summary>
        public Guid RefPersonStatusTypeId { get; set; }

        /// <summary>
        /// Status End Date
        /// <para>
        /// The last year, month and day when a status applied to an individual.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20193">Status End Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? StatusEndDate { get; set; }

        /// <summary>
        /// Status Start Date
        /// <para>
        /// The year, month and day that a status became applicable to an individual.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20192">Status Start Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? StatusStartDate { get; set; }

        public System.Boolean StatusValue { get; set; }

    }
}
