//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   ICompetencySet_RubricCriterion.cs
//**********************************************************

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencySet_RubricCriterion
     /// </summary>
    public partial interface ICompetencySet_RubricCriterion
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencySet"/> model
        /// </summary>
        Guid CompetencySetId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RubricCriterion"/> model
        /// </summary>
        Guid RubricCriterionId { get; set; }

        /// <summary>
        /// Defines the CompetencySet_RubricCriterion.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CompetencySet_RubricCriterion.RecordEndDateTime nullable property
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
