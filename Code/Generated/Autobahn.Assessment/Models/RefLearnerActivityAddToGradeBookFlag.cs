//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefLearnerActivityAddToGradeBookFlag.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The RefLearnerActivityAddToGradeBookFlag
     /// </summary>
    public partial class RefLearnerActivityAddToGradeBookFlag : IRefLearnerActivityAddToGradeBookFlag
    {
        /// <summary>
        /// Defines the RefLearnerActivityAddToGradeBookFlag.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefLearnerActivityAddToGradeBookFlag.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefLearnerActivityAddToGradeBookFlag.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefLearnerActivityAddToGradeBookFlag.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefLearnerActivityAddToGradeBookFlag.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefLearnerActivityAddToGradeBookFlag.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
