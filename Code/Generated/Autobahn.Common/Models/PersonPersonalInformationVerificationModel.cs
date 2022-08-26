//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonPersonalInformationVerificationModel.cs
//***************************************************************************

using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonPersonalInformationVerification Model
     /// </summary>
    public partial class PersonPersonalInformationVerificationModel : AutobahnBase, IPersonPersonalInformationVerification
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonAddress"/> model
        /// </summary>
        public Guid? PersonAddressId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonDetail"/> model
        /// </summary>
        public Guid? PersonDetailId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonTelephone"/> model
        /// </summary>
        public Guid? PersonTelephoneId { get; set; }

        /// <summary>
        /// Personal Information Type
        /// <para>
        /// The type of personal information verified through the Personal Information Verification evidence.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20951">Personal Information Type</a>
        /// </para>
        /// </summary>
        public Guid? RefPersonalInformationTypeId { get; set; }

        /// <summary>
        /// Personal Information Verification
        /// <para>
        /// The evidence by which a persons name, address, date of birth, etc. is confirmed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19611">Personal Information Verification</a>
        /// </para>
        /// </summary>
        public Guid? RefPersonalInformationVerificationId { get; set; }

    }
}
