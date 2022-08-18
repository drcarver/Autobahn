//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IRecordStatusHistory.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRecordStatusHistory Interface
     /// </summary>
    public partial interface IRecordStatusHistory : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IRecord"/> model
        /// </summary>
        Guid RecordId { get; set; }

        System.String RecordPKColumn { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRecordStatusCreatorOrganization"/> model
        /// </summary>
        Guid? RecordStatusCreatorOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRecordStatusCreatorPerson"/> model
        /// </summary>
        Guid? RecordStatusCreatorPersonId { get; set; }

        /// <summary>
        /// Record Status Date
        /// <para>
        /// The date the record was marked with the Record Status Type.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20957">Record Status Date</a>
        /// </para>
        /// </summary>
        System.DateTime? RecordStatusDate { get; set; }

        System.String RecordTable { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRecordStatusCreatorEntity"/> model
        /// </summary>
        Guid? RefRecordStatusCreatorEntityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRecordStatusType"/> model
        /// </summary>
        Guid RefRecordStatusTypeId { get; set; }

    }
}
