//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonIdentifier.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonIdentifier
     /// </summary>
    public partial class PersonIdentifier : AutobahnBase, Interfaces.IPersonIdentifier
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonIdentifier.Identifier non nullable property
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPersonentificationSystem"/> model
        /// </summary>
        public Guid RefPersonIdentificationSystemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationVerification"/> model
        /// </summary>
        public Guid? RefPersonalInformationVerificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
