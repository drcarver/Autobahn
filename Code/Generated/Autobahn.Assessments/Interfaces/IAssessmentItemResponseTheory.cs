//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentItemResponseTheory.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentItemResponseTheory Interface
     /// </summary>
    public partial interface IAssessmentItemResponseTheory : IAutobahnBase
    {
        /// <summary>
        /// The Item Response Theory value representing the discrimination of the item. The a parameter is found by taking the slope of the line tangent to the item characteristic curve at the inflection point, B. The parameter is the steepness of the curve at its steepest point.
        /// </summary>
        Guid AssessmentItemId { get; set; }

        /// <summary>
        /// The Item Response Theory value representing the discrimination of the item. The a parameter is found by taking the slope of the line tangent to the item characteristic curve at the inflection point, B. The parameter is the steepness of the curve at its steepest point.
        /// </summary>
        System.Int32? DIFValue { get; set; }

        /// <summary>
        /// The Item Response Theory value representing the discrimination of the item. The a parameter is found by taking the slope of the line tangent to the item characteristic curve at the inflection point, B. The parameter is the steepness of the curve at its steepest point.
        /// </summary>
        System.Int32? KappaValue { get; set; }

        /// <summary>
        /// The Item Response Theory value representing the discrimination of the item. The a parameter is found by taking the slope of the line tangent to the item characteristic curve at the inflection point, B. The parameter is the steepness of the curve at its steepest point.
        /// </summary>
        System.Int32? ParameterA { get; set; }

        /// <summary>
        /// The Item Response Theory value representing the discrimination of the item. The a parameter is found by taking the slope of the line tangent to the item characteristic curve at the inflection point, B. The parameter is the steepness of the curve at its steepest point.
        /// </summary>
        System.Int32? ParameterB { get; set; }

        /// <summary>
        /// The Item Response Theory value representing the discrimination of the item. The a parameter is found by taking the slope of the line tangent to the item characteristic curve at the inflection point, B. The parameter is the steepness of the curve at its steepest point.
        /// </summary>
        System.Int32? ParameterC { get; set; }

        /// <summary>
        /// The Item Response Theory value representing the discrimination of the item. The a parameter is found by taking the slope of the line tangent to the item characteristic curve at the inflection point, B. The parameter is the steepness of the curve at its steepest point.
        /// </summary>
        System.Int32? ParameterD1 { get; set; }

        /// <summary>
        /// The Item Response Theory value representing the discrimination of the item. The a parameter is found by taking the slope of the line tangent to the item characteristic curve at the inflection point, B. The parameter is the steepness of the curve at its steepest point.
        /// </summary>
        System.Int32? ParameterD2 { get; set; }

        /// <summary>
        /// The Item Response Theory value representing the discrimination of the item. The a parameter is found by taking the slope of the line tangent to the item characteristic curve at the inflection point, B. The parameter is the steepness of the curve at its steepest point.
        /// </summary>
        System.Int32? ParameterD3 { get; set; }

        /// <summary>
        /// The Item Response Theory value representing the discrimination of the item. The a parameter is found by taking the slope of the line tangent to the item characteristic curve at the inflection point, B. The parameter is the steepness of the curve at its steepest point.
        /// </summary>
        System.Int32? ParameterD4 { get; set; }

        /// <summary>
        /// The Item Response Theory value representing the discrimination of the item. The a parameter is found by taking the slope of the line tangent to the item characteristic curve at the inflection point, B. The parameter is the steepness of the curve at its steepest point.
        /// </summary>
        System.Int32? ParameterD5 { get; set; }

        /// <summary>
        /// The Item Response Theory value representing the discrimination of the item. The a parameter is found by taking the slope of the line tangent to the item characteristic curve at the inflection point, B. The parameter is the steepness of the curve at its steepest point.
        /// </summary>
        System.Int32? ParameterD6 { get; set; }

        /// <summary>
        /// The Item Response Theory value representing the discrimination of the item. The a parameter is found by taking the slope of the line tangent to the item characteristic curve at the inflection point, B. The parameter is the steepness of the curve at its steepest point.
        /// </summary>
        System.Int32? PointBiserialCorrelationValue { get; set; }

        /// <summary>
        /// The Item Response Theory value representing the discrimination of the item. The a parameter is found by taking the slope of the line tangent to the item characteristic curve at the inflection point, B. The parameter is the steepness of the curve at its steepest point.
        /// </summary>
        Guid? RefItemResponseTheoryDifficultyCategoryId { get; set; }

        /// <summary>
        /// The Item Response Theory value representing the discrimination of the item. The a parameter is found by taking the slope of the line tangent to the item characteristic curve at the inflection point, B. The parameter is the steepness of the curve at its steepest point.
        /// </summary>
        Guid? RefItemResponseTheoryKappaAlgorithmId { get; set; }

    }
}
