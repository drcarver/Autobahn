//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonLanguage.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonLanguage
     /// </summary>
    public partial class PersonLanguage : AutobahnBase, Interfaces.IPersonLanguage
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
