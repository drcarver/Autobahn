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
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        Guid RefLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguageUseType"/> model
        /// </summary>
        Guid RefLanguageUseTypeId { get; set; }

    }
}
