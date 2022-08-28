//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonStatusModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Common.Models
{
     /// <summary>
     /// The PersonStatus Model
     /// </summary>
    public partial class PersonStatusModel : IPersonStatus
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region IPersonStatus
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Economic Disadvantage Status
        /// <para>
        /// An indication that the student met the State criteria for classification as having an economic disadvantage.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19086">Economic Disadvantage Status</a>
        /// </para>
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
        public DateTime? StatusEndDate { get; set; }

        /// <summary>
        /// Status Start Date
        /// <para>
        /// The year, month and day that a status became applicable to an individual.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20192">Status Start Date</a>
        /// </para>
        /// </summary>
        public DateTime? StatusStartDate { get; set; }

        public System.Boolean StatusValue { get; set; }

        #endregion
    }
}
