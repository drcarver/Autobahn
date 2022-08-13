//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonEmailAddressModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonEmailAddress Model
     /// </summary>
    public partial class PersonEmailAddressModel : AutobahnBase, Interfaces.IPersonEmailAddress
    {
        /// <summary>
        /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
        /// </summary>
        public System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
        /// </summary>
        public System.String EmailAddress { get; set; }

        /// <summary>
        /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
        /// </summary>
        public Guid? RefEmailTypeId { get; set; }

    }
}
