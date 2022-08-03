//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonPersonalInformationVerification.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonPersonalInformationVerification
     /// </summary>
    public partial class PersonPersonalInformationVerification : IPersonPersonalInformationVerification
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonAddress"/> model
        /// </summary>
        public Guid? PersonAddressId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonDetail"/> model
        /// </summary>
        public Guid? PersonDetailId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonTelephone"/> model
        /// </summary>
        public Guid? PersonTelephoneId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationType"/> model
        /// </summary>
        public Guid? RefPersonalInformationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationVerification"/> model
        /// </summary>
        public Guid? RefPersonalInformationVerificationId { get; set; }

        /// <summary>
        /// Defines the PersonPersonalInformationVerification.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonPersonalInformationVerification.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
