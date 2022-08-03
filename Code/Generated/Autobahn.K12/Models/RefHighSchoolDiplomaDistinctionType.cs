//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefHighSchoolDiplomaDistinctionType.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefHighSchoolDiplomaDistinctionType
     /// </summary>
    public partial class RefHighSchoolDiplomaDistinctionType : IRefHighSchoolDiplomaDistinctionType
    {
        /// <summary>
        /// Defines the RefHighSchoolDiplomaDistinctionType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefHighSchoolDiplomaDistinctionType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefHighSchoolDiplomaDistinctionType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefHighSchoolDiplomaDistinctionType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefHighSchoolDiplomaDistinctionType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefHighSchoolDiplomaDistinctionType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
