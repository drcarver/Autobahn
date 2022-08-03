//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonTelephone.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonTelephone
     /// </summary>
    public partial interface IPersonTelephone
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonTelephone.TelephoneNumber non nullable property
        /// </summary>
        System.String TelephoneNumber { get; set; }

        /// <summary>
        /// Defines the PersonTelephone.PrimaryTelephoneNumberIndicator non nullable property
        /// </summary>
        System.Boolean PrimaryTelephoneNumberIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonTelephoneNumberType"/> model
        /// </summary>
        Guid? RefPersonTelephoneNumberTypeId { get; set; }

        /// <summary>
        /// Defines the PersonTelephone.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonTelephone.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Defines the PersonTelephone.DoNotPublishIndicator nullable property
        /// </summary>
        System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTelephoneNumberListedStatus"/> model
        /// </summary>
        Guid? RefTelephoneNumberListedStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
