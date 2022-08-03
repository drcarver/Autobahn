//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefHighSchoolDiplomaDistinctionType.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IRefHighSchoolDiplomaDistinctionType
     /// </summary>
    public partial interface IRefHighSchoolDiplomaDistinctionType
    {
        /// <summary>
        /// Defines the RefHighSchoolDiplomaDistinctionType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefHighSchoolDiplomaDistinctionType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefHighSchoolDiplomaDistinctionType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefHighSchoolDiplomaDistinctionType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefHighSchoolDiplomaDistinctionType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefHighSchoolDiplomaDistinctionType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
