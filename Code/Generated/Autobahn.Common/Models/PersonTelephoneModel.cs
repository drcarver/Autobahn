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
        public System.Boolean PrimaryTelephoneNumberIndicator { get; set; }

    }
}
