//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonLanguageModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
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
        /// Reference to an optional instance of the <see cref="IRefLanguage"/> model
        /// </summary>
        public Guid RefLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefLanguageUseType"/> model
        /// </summary>
        public Guid RefLanguageUseTypeId { get; set; }

    }
}
