//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonLanguage.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonLanguage Interface
     /// </summary>
    public partial interface IPersonLanguage : IAutobahnBase
    {
        /// <summary>
        /// An indication of the function and context in which a person uses a language to communicate.
        /// </summary>
        Guid RefLanguageUseTypeId { get; set; }

    }
}
