//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonTelephone.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonTelephone Interface
     /// </summary>
    public partial interface IPersonTelephone : IAutobahnBase
    {
        /// <summary>
        /// Do Not Publish Indicator
        /// <para>
        /// An indication that the record should not be published.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20905">Do Not Publish Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Primary Telephone Number Indicator
        /// <para>
        /// An indication that the telephone number should be used as the principal number for a person or organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19219">Primary Telephone Number Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean PrimaryTelephoneNumberIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonTelephoneNumberType"/> model
        /// </summary>
        Guid? RefPersonTelephoneNumberTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTelephoneNumberListedStatus"/> model
        /// </summary>
        Guid? RefTelephoneNumberListedStatusId { get; set; }

        /// <summary>
        /// Telephone Number
        /// <para>
        /// The telephone number including the area code, and extension, if applicable.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19279">Telephone Number</a>
        /// </para>
        /// </summary>
        System.String TelephoneNumber { get; set; }

    }
}
