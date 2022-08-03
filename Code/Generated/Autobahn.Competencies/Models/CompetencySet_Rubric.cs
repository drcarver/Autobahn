//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencySet_Rubric.cs
//**********************************************************

using Autobahn.Competencies.Interfaces;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencySet_Rubric
     /// </summary>
    public partial class CompetencySet_Rubric : ICompetencySet_Rubric
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencySet"/> model
        /// </summary>
        public Guid CompetencySetId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Rubric"/> model
        /// </summary>
        public Guid RubricId { get; set; }

        /// <summary>
        /// Defines the CompetencySet_Rubric.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CompetencySet_Rubric.RecordEndDateTime nullable property
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
