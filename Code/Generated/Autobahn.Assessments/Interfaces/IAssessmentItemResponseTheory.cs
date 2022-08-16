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
        /// 
        /// </summary>
         DIFValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
         KappaValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? ParameterA { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ParameterB { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ParameterC { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ParameterD1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ParameterD2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ParameterD3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ParameterD4 { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ParameterD5 { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ParameterD6 { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PointBiserialCorrelationValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefItemResponseTheoryDifficultyCategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefItemResponseTheoryKappaAlgorithmId { get; set; }

    }
}
