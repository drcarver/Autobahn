//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonEmailAddress.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonEmailAddress
     /// </summary>
    public partial class PersonEmailAddress : AutobahnBase, Interfaces.IPersonEmailAddress
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonEmailAddress.EmailAddress non nullable property
        /// </summary>
        public System.String EmailAddress { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmailType"/> model
        /// </summary>
        public Guid? RefEmailTypeId { get; set; }

        /// <summary>
        /// Defines the PersonEmailAddress.DoNotPublishIndicator nullable property
        /// </summary>
        public System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
