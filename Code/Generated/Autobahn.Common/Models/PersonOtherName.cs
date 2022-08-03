//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonOtherName.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonOtherName
     /// </summary>
    public partial class PersonOtherName : IPersonOtherName
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOtherNameType"/> model
        /// </summary>
        public Guid? RefOtherNameTypeId { get; set; }

        /// <summary>
        /// Defines the PersonOtherName.OtherName non nullable property
        /// </summary>
        public System.String OtherName { get; set; }

        /// <summary>
        /// Defines the PersonOtherName.FirstName non nullable property
        /// </summary>
        public System.String FirstName { get; set; }

        /// <summary>
        /// Defines the PersonOtherName.MiddleName non nullable property
        /// </summary>
        public System.String MiddleName { get; set; }

        /// <summary>
        /// Defines the PersonOtherName.LastName non nullable property
        /// </summary>
        public System.String LastName { get; set; }

        /// <summary>
        /// Defines the PersonOtherName.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonOtherName.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}