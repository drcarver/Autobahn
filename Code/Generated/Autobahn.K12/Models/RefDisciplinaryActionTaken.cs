//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefDisciplinaryActionTaken.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefDisciplinaryActionTaken
     /// </summary>
    public partial class RefDisciplinaryActionTaken : IRefDisciplinaryActionTaken
    {
        /// <summary>
        /// Defines the RefDisciplinaryActionTaken.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefDisciplinaryActionTaken.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefDisciplinaryActionTaken.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefDisciplinaryActionTaken.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefDisciplinaryActionTaken.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefDisciplinaryActionTaken.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
