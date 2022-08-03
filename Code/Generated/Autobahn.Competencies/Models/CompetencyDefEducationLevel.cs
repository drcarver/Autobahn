//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencyDefEducationLevel.cs
//**********************************************************

using Autobahn.Competencies.Interfaces;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencyDefEducationLevel
     /// </summary>
    public partial class CompetencyDefEducationLevel : ICompetencyDefEducationLevel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencyDefinition"/> model
        /// </summary>
        public Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefEducationLevel"/> model
        /// </summary>
        public Guid RefEducationLevelId { get; set; }

        /// <summary>
        /// Defines the CompetencyDefEducationLevel.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CompetencyDefEducationLevel.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
