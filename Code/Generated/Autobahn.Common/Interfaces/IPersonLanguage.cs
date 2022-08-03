//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonLanguage.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonLanguage
     /// </summary>
    public partial interface IPersonLanguage
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

        /// <summary>
        /// Defines the PersonLanguage.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonLanguage.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
