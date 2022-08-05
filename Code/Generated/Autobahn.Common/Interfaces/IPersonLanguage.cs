//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonLanguage.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonLanguage
     /// </summary>
    public partial interface IPersonLanguage : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefLanguage"/> model
        /// </summary>
        Guid RefLanguageId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefLanguageUseType"/> model
        /// </summary>
        Guid RefLanguageUseTypeId { get; set; }

    }
}
