//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefAcademicAwardPrerequisiteType.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The RefAcademicAwardPrerequisiteType
     /// </summary>
    public partial class RefAcademicAwardPrerequisiteType : IRefAcademicAwardPrerequisiteType
    {
        /// <summary>
        /// Defines the RefAcademicAwardPrerequisiteType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAcademicAwardPrerequisiteType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAcademicAwardPrerequisiteType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAcademicAwardPrerequisiteType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAcademicAwardPrerequisiteType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAcademicAwardPrerequisiteType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
