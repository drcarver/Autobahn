//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedApipControlModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentNeedApipControl Model
     /// </summary>
    public partial class AssessmentNeedApipControlModel : AutobahnBase, Interfaces.IAssessmentNeedApipControl
    {
        /// <summary>
        /// Defines the multiplier to be applied to the time limit to determine the total testing time allowed when Additional Testing Time is specified as part of an Assessment Personal Needs Profile.  If the value is `unlimited' then there is no time limit for the test.
        /// </summary>
        public System.String AssessmentNeedTimeMultiplier { get; set; }

    }
}
