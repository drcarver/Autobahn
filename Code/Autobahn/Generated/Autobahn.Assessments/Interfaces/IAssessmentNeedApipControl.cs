//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentNeedApipControl.cs
//* Name:       Assessment Need Time Multiplier
//* Definition: Defines the multiplier to be applied to the time limit to determine the total testing time allowed when Additional Testing Time is specified as part of an Assessment Personal Needs Profile.  If the value is `unlimited' then there is no time limit for the test.
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// Defines the multiplier to be applied to the time limit to determine the total testing time allowed when Additional Testing Time is specified as part of an Assessment Personal Needs Profile.  If the value is `unlimited' then there is no time limit for the test.
     /// </summary>
    public partial interface IAssessmentNeedApipControl : IAutobahnBase
    {
    }
}
