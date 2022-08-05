//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonIdentifier.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonIdentifier
     /// </summary>
    public partial interface IPersonIdentifier : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonIdentifier.Identifier non nullable property
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPersonentificationSystem"/> model
        /// </summary>
        Guid RefPersonIdentificationSystemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationVerification"/> model
        /// </summary>
        Guid? RefPersonalInformationVerificationId { get; set; }

    }
}
