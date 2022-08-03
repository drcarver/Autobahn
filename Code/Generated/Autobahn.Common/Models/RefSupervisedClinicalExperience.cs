//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefSupervisedClinicalExperience.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefSupervisedClinicalExperience
     /// </summary>
    public partial class RefSupervisedClinicalExperience : IRefSupervisedClinicalExperience
    {
        /// <summary>
        /// Defines the RefSupervisedClinicalExperience.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefSupervisedClinicalExperience.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefSupervisedClinicalExperience.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefSupervisedClinicalExperience.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefSupervisedClinicalExperience.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefSupervisedClinicalExperience.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
