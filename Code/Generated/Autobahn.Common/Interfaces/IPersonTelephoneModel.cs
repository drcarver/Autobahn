//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonTelephoneModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonTelephoneModel Interface
     /// </summary>
    public partial interface IPersonTelephoneModel : IAutobahnBase
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
        /// Defines the PersonTelephone.DoNotPublishIndicator nullable property
        /// </summary>
        System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTelephoneNumberListedStatus"/> model
        /// </summary>
        Guid? RefTelephoneNumberListedStatusId { get; set; }

    }
}
