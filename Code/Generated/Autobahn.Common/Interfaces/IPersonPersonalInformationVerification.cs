//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonPersonalInformationVerification.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonPersonalInformationVerification
     /// </summary>
    public partial interface IPersonPersonalInformationVerification : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonAddress"/> model
        /// </summary>
        Guid? PersonAddressId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonDetail"/> model
        /// </summary>
        Guid? PersonDetailId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonTelephone"/> model
        /// </summary>
        Guid? PersonTelephoneId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationType"/> model
        /// </summary>
        Guid? RefPersonalInformationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationVerification"/> model
        /// </summary>
        Guid? RefPersonalInformationVerificationId { get; set; }

    }
}
