//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemResponseTheoryModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentItemResponseTheory Model
     /// </summary>
    public partial class AssessmentItemResponseTheoryModel : AutobahnBase, Interfaces.IAssessmentItemResponseTheory
    {
        /// <summary>
        /// The Item Response Theory value representing the discrimination of the item. The a parameter is found by taking the slope of the line tangent to the item characteristic curve at the inflection point, B. The parameter is the steepness of the curve at its steepest point.
        /// </summary>
        public System.Int32? ParameterA { get; set; }

    }
}
