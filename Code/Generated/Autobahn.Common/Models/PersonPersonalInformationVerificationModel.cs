//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonPersonalInformationVerificationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonPersonalInformationVerification Model
     /// </summary>
    public partial class PersonPersonalInformationVerificationModel : AutobahnBase, Interfaces.IPersonPersonalInformationVerification
    {
        /// <summary>
        /// The evidence by which a persons name, address, date of birth, etc. is confirmed.
        /// </summary>
        public Guid? PersonAddressId { get; set; }

        /// <summary>
        /// The evidence by which a persons name, address, date of birth, etc. is confirmed.
        /// </summary>
        public Guid? PersonDetailId { get; set; }

        /// <summary>
        /// The evidence by which a persons name, address, date of birth, etc. is confirmed.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// The evidence by which a persons name, address, date of birth, etc. is confirmed.
        /// </summary>
        public Guid? PersonTelephoneId { get; set; }

        /// <summary>
        /// The evidence by which a persons name, address, date of birth, etc. is confirmed.
        /// </summary>
        public Guid? RefPersonalInformationTypeId { get; set; }

        /// <summary>
        /// The evidence by which a persons name, address, date of birth, etc. is confirmed.
        /// </summary>
        public Guid? RefPersonalInformationVerificationId { get; set; }

    }
}
