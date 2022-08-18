//**********************************************************
//* DomainName: Common Models
//* FileName:   RecordStatusModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RecordStatus Model
     /// </summary>
    public partial class RecordStatusModel : AutobahnBase, Interfaces.IRecordStatus
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IRecordStatusCreatorOrganization"/> model
        /// </summary>
        public Guid? RecordStatusCreatorOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRecordStatusCreatorPerson"/> model
        /// </summary>
        public Guid? RecordStatusCreatorPersonId { get; set; }

        /// <summary>
        /// Record Status Date
        /// <para>
        /// The date the record was marked with the Record Status Type.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20957">Record Status Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? RecordStatusDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRecordStatusCreatorEntity"/> model
        /// </summary>
        public Guid? RefRecordStatusCreatorEntityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRecordStatusType"/> model
        /// </summary>
        public Guid RefRecordStatusTypeId { get; set; }

    }
}
