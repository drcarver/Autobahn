//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonLanguageModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonLanguage Model
     /// </summary>
    public partial class PersonLanguageModel : AutobahnBase, Interfaces.IPersonLanguage
    {
        /// <summary>
        /// An indication of the function and context in which a person uses a language to communicate.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// An indication of the function and context in which a person uses a language to communicate.
        /// </summary>
        public Guid RefLanguageId { get; set; }

        /// <summary>
        /// An indication of the function and context in which a person uses a language to communicate.
        /// </summary>
        public Guid RefLanguageUseTypeId { get; set; }

    }
}
