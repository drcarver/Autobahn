//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentHomeLanguageSurvey.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentHomeLanguageSurvey Interface
     /// </summary>
    public partial interface IK12StudentHomeLanguageSurvey : IAutobahnBase
    {
        /// <summary>
        /// Home Language Survey Administration Date
        /// <para>
        /// The year, month, and day on which the Home Language Survey is known to have been administered to the parent or guardian of this student.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20934">Home Language Survey Administration Date</a>
        /// </para>
        /// </summary>
        System.DateTime? HomeLanguageSurveyAdministrationDate { get; set; }

        /// <summary>
        /// Home Language Survey Administration Indicator
        /// <para>
        /// An indication that the parent or guardian of this student was administered the Home Language Survey - a questionnaire given to parents or guardians that helps schools and local education agencies identify which students are potential English Learners and who will require assessment of their English language proficiency to determine whether they are eligible for language assistance services.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20935">Home Language Survey Administration Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? HomeLanguageSurveyAdministrationIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

    }
}
