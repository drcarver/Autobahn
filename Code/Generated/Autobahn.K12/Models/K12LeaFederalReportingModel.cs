//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaFederalReportingModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaFederalReporting Model
     /// </summary>
    public partial class K12LeaFederalReportingModel : AutobahnBase, Interfaces.IK12LeaFederalReporting
    {
        /// <summary>
        /// Desegregation Order or Plan
        /// <para>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19080">Desegregation Order or Plan</a>
        /// </para>
        /// </summary>
        public System.Boolean? DesegregationOrderOrPlan { get; set; }

        /// <summary>
        /// Harassment or Bullying Policy Status
        /// <para>
        /// An indication of whether the education unit has adopted written policy prohibiting harassment and bullying on the basis of a civil rights law.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19135">Harassment or Bullying Policy Status</a>
        /// </para>
        /// </summary>
        public System.Boolean? HarassmentOrBullyingPolicy { get; set; }

        /// <summary>
        /// Interscholastic Sport Participants - Female Only
        /// <para>
        /// The number of female students who participated on an interscholastic team.  A student should be counted once for each team she was on.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19665">Interscholastic Sport Participants - Female Only</a>
        /// </para>
        /// </summary>
        public System.Int32? InterscholasticSportParticipantsFemale { get; set; }

        /// <summary>
        /// Interscholastic Sport Participants - Male Only
        /// <para>
        /// The number of male students who participated on an interscholastic team.  A student should be counted once for each team he was on.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19664">Interscholastic Sport Participants - Male Only</a>
        /// </para>
        /// </summary>
        public System.Int32? InterscholasticSportParticipantsMale { get; set; }

        /// <summary>
        /// Interscholastic Sports - Female Only
        /// <para>
        /// The number of interscholastic sports in which only female students participate.  Sports include distinct sports such as football, basketball, soccer but not intramural sports or cheerleading.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19661">Interscholastic Sports - Female Only</a>
        /// </para>
        /// </summary>
        public System.Int32? InterscholasticSportsFemaleOnly { get; set; }

        /// <summary>
        /// Interscholastic Sports - Male Only
        /// <para>
        /// The number of interscholastic sports in which only male students participate.  Sports include distinct sports such as football, basketball, soccer but not intramural sports or cheerleading.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19660">Interscholastic Sports - Male Only</a>
        /// </para>
        /// </summary>
        public System.Int32? InterscholasticSportsMaleOnly { get; set; }

        /// <summary>
        /// Interscholastic Teams - Female Only
        /// <para>
        /// The number of interscholastic teams in which only female students participate.  Teams include each competitive level team in each sport, such as freshman team, junior varsity team, and varsity team but not intramural sports or cheerleading.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19663">Interscholastic Teams - Female Only</a>
        /// </para>
        /// </summary>
        public System.Int32? InterscholasticTeamsFemaleOnly { get; set; }

        /// <summary>
        /// Interscholastic Teams - Male Only
        /// <para>
        /// The number of interscholastic teams in which only male students participate.  Teams include each competitive level team in each sport, such as freshman team, junior varsity team, and varsity team but not intramural sports or cheerleading.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19662">Interscholastic Teams - Male Only</a>
        /// </para>
        /// </summary>
        public System.Int32? InterscholasticTeamsMaleOnly { get; set; }

        /// <summary>
        /// Charter School Indicator
        /// <para>
        /// An indication that a public school provides free public elementary and/or secondary education to eligible students under a specific charter executed, pursuant to a state charter school law, by an authorized chartering agency/authority and that is designated by such authority to be a public charter school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19039">Charter School Indicator</a>
        /// </para>
        /// </summary>
        public Guid K12LeaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBarrierToEducatingHomeless"/> model
        /// </summary>
        public Guid? RefBarrierToEducatingHomelessId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIntegratedTechnologyStatus"/> model
        /// </summary>
        public Guid? RefIntegratedTechnologyStatusId { get; set; }

        /// <summary>
        /// State Assessment Administration Funding
        /// <para>
        /// The percentage of funds used to administer assessments required by section 1111(b) or to carry out other activities described in section 6111 and other activities related to ensuring that the State's schools and local educational agencies are held accountable for results.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19444">State Assessment Administration Funding</a>
        /// </para>
        /// </summary>
        public System.Decimal? StateAssessmentAdminFunding { get; set; }

        /// <summary>
        /// State Assessment Standards Funding
        /// <para>
        /// The percentage of funds used to pay the costs of the development of the State assessments and standards required by section 1111(b).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19443">State Assessment Standards Funding</a>
        /// </para>
        /// </summary>
        public System.Decimal? StateAssessStandardsFunding { get; set; }

        /// <summary>
        /// Terminated Title III Programs Due to Failure
        /// <para>
        /// An indication of whether a Title III program or activity was terminated due to failure to meet goals.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19473">Terminated Title III Programs Due to Failure</a>
        /// </para>
        /// </summary>
        public System.Boolean? TerminatedTitleIIIProgramFailure { get; set; }

    }
}
