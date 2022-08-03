//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonLanguage.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonLanguage
     /// </summary>
    public partial class PersonLanguage : IPersonLanguage
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid RefLanguageId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefLanguageUseType"/> model
        /// </summary>
        public Guid RefLanguageUseTypeId { get; set; }

        /// <summary>
        /// Defines the PersonLanguage.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonLanguage.RecordEndDateTime nullable property
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
