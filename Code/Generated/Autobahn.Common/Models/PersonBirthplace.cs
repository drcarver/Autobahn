//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonBirthplace.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonBirthplace
     /// </summary>
    public partial class PersonBirthplace : AutobahnBase, Interfaces.IPersonBirthplace
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonBirthplace.City non nullable property
        /// </summary>
        public System.String City { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefState"/> model
        /// </summary>
        public Guid? RefStateId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCountry"/> model
        /// </summary>
        public Guid? RefCountryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
