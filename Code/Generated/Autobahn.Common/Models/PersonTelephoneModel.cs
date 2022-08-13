//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonTelephoneModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonTelephone Model
     /// </summary>
    public partial class PersonTelephoneModel : AutobahnBase, Interfaces.IPersonTelephone
    {
        /// <summary>
        /// An indication that the telephone number should be used as the principal number for a person or organization.
        /// </summary>
        public System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// An indication that the telephone number should be used as the principal number for a person or organization.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// An indication that the telephone number should be used as the principal number for a person or organization.
        /// </summary>
        public System.Boolean PrimaryTelephoneNumberIndicator { get; set; }

        /// <summary>
        /// An indication that the telephone number should be used as the principal number for a person or organization.
        /// </summary>
        public Guid? RefPersonTelephoneNumberTypeId { get; set; }

        /// <summary>
        /// An indication that the telephone number should be used as the principal number for a person or organization.
        /// </summary>
        public Guid? RefTelephoneNumberListedStatusId { get; set; }

        /// <summary>
        /// An indication that the telephone number should be used as the principal number for a person or organization.
        /// </summary>
        public System.String TelephoneNumber { get; set; }

    }
}
