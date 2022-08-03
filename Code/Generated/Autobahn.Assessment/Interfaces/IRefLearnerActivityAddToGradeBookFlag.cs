//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRefLearnerActivityAddToGradeBookFlag.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IRefLearnerActivityAddToGradeBookFlag
     /// </summary>
    public partial interface IRefLearnerActivityAddToGradeBookFlag
    {
        /// <summary>
        /// Defines the RefLearnerActivityAddToGradeBookFlag.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefLearnerActivityAddToGradeBookFlag.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefLearnerActivityAddToGradeBookFlag.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefLearnerActivityAddToGradeBookFlag.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefLearnerActivityAddToGradeBookFlag.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefLearnerActivityAddToGradeBookFlag.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
