//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentItemResponseTheory.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentItemResponseTheory
     /// </summary>
    public partial interface IAssessmentItemResponseTheory : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.ParameterA nullable property
        /// </summary>
        System.Int32? ParameterA { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.ParameterB nullable property
        /// </summary>
        System.Int32? ParameterB { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.ParameterC nullable property
        /// </summary>
        System.Int32? ParameterC { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.ParameterD1 nullable property
        /// </summary>
        System.Int32? ParameterD1 { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.ParameterD2 nullable property
        /// </summary>
        System.Int32? ParameterD2 { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.ParameterD3 nullable property
        /// </summary>
        System.Int32? ParameterD3 { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.ParameterD4 nullable property
        /// </summary>
        System.Int32? ParameterD4 { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.ParameterD5 nullable property
        /// </summary>
        System.Int32? ParameterD5 { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.ParameterD6 nullable property
        /// </summary>
        System.Int32? ParameterD6 { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.PointBiserialCorrelationValue nullable property
        /// </summary>
        System.Int32? PointBiserialCorrelationValue { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.DIFValue nullable property
        /// </summary>
        System.Int32? DIFValue { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponseTheory.KappaValue nullable property
        /// </summary>
        System.Int32? KappaValue { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefItemResponseTheoryDifficultyCategory"/> model
        /// </summary>
        Guid? RefItemResponseTheoryDifficultyCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefItemResponseTheoryKappaAlgorithm"/> model
        /// </summary>
        Guid? RefItemResponseTheoryKappaAlgorithmId { get; set; }

    }
}
