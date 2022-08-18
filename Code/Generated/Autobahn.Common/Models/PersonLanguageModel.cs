//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonLanguageModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonLanguage Model
     /// </summary>
    public partial class PersonLanguageModel : AutobahnBase, Interfaces.IPersonLanguage
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid RefLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguageUseType"/> model
        /// </summary>
        public Guid RefLanguageUseTypeId { get; set; }

    }
}
