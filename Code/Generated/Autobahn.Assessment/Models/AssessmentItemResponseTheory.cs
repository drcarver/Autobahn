//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemResponseTheory.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentItemResponseTheory
     /// </summary>
    public partial class AssessmentItemResponseTheory : IAssessmentItemResponseTheory
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.ParameterA nullable property
        /// </summary>
        public System.Int32? ParameterA { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.ParameterB nullable property
        /// </summary>
        public System.Int32? ParameterB { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.ParameterC nullable property
        /// </summary>
        public System.Int32? ParameterC { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.ParameterD1 nullable property
        /// </summary>
        public System.Int32? ParameterD1 { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.ParameterD2 nullable property
        /// </summary>
        public System.Int32? ParameterD2 { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.ParameterD3 nullable property
        /// </summary>
        public System.Int32? ParameterD3 { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.ParameterD4 nullable property
        /// </summary>
        public System.Int32? ParameterD4 { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.ParameterD5 nullable property
        /// </summary>
        public System.Int32? ParameterD5 { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.ParameterD6 nullable property
        /// </summary>
        public System.Int32? ParameterD6 { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.PointBiserialCorrelationValue nullable property
        /// </summary>
        public System.Int32? PointBiserialCorrelationValue { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.DIFValue nullable property
        /// </summary>
        public System.Int32? DIFValue { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.KappaValue nullable property
        /// </summary>
        public System.Int32? KappaValue { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefItemResponseTheoryDifficultyCategory"/> model
        /// </summary>
        public Guid? RefItemResponseTheoryDifficultyCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefItemResponseTheoryKappaAlgorithm"/> model
        /// </summary>
        public Guid? RefItemResponseTheoryKappaAlgorithmId { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.RecordEndDateTime nullable property
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
