//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonTelephone.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonTelephone
     /// </summary>
    public partial class PersonTelephone : AutobahnBase, Interfaces.IPersonTelephone
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonTelephone.TelephoneNumber non nullable property
        /// </summary>
        public System.String TelephoneNumber { get; set; }

        /// <summary>
        /// Defines the PersonTelephone.PrimaryTelephoneNumberIndicator non nullable property
        /// </summary>
        public System.Boolean PrimaryTelephoneNumberIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonTelephoneNumberType"/> model
        /// </summary>
        public Guid? RefPersonTelephoneNumberTypeId { get; set; }

        /// <summary>
        /// Defines the PersonTelephone.DoNotPublishIndicator nullable property
        /// </summary>
        public System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTelephoneNumberListedStatus"/> model
        /// </summary>
        public Guid? RefTelephoneNumberListedStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
