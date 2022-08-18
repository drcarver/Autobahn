//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentDisciplineModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentDiscipline Model
     /// </summary>
    public partial class K12StudentDisciplineModel : AutobahnBase, Interfaces.IK12StudentDiscipline
    {
        /// <summary>
        /// Disciplinary Action End Date
        /// <para>
        /// The year, month and day on which a discipline action ends.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19082">Disciplinary Action End Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? DisciplinaryActionEndDate { get; set; }

        /// <summary>
        /// Disciplinary Action Start Date
        /// <para>
        /// The year, month and day on which a discipline action begins.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19083">Disciplinary Action Start Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? DisciplinaryActionStartDate { get; set; }

        /// <summary>
        /// Duration of Disciplinary Action
        /// <para>
        /// The length, in school days, of the disciplinary action.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19502">Duration of Disciplinary Action</a>
        /// </para>
        /// </summary>
        public System.Decimal? DurationOfDisciplinaryAction { get; set; }

        /// <summary>
        /// Educational Services After Removal
        /// <para>
        /// An indication of whether children (students) were provided educational services when removed from the regular school program for disciplinary reasons.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19570">Educational Services After Removal</a>
        /// </para>
        /// </summary>
        public System.Boolean? EducationalServicesAfterRemoval { get; set; }

        /// <summary>
        /// Full Year Expulsion
        /// <para>
        /// An expulsion with or without services for a period of one full year (i.e., 365 days).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19504">Full Year Expulsion</a>
        /// </para>
        /// </summary>
        public System.Boolean? FullYearExpulsion { get; set; }

        /// <summary>
        /// Disciplinary Action IEP Placement Meeting Indicator
        /// <para>
        /// An indication as to whether an offense and/or disciplinary action resulted in a meeting of a student's Individualized Education Program (IEP) team to determine appropriate placement.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20288">Disciplinary Action IEP Placement Meeting Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? IEPPlacementMeetingIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIncident"/> model
        /// </summary>
        public Guid? IncidentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplinaryActionTaken"/> model
        /// </summary>
        public Guid? RefDisciplinaryActionTakenId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineLengthDifferenceReason"/> model
        /// </summary>
        public Guid? RefDisciplineLengthDifferenceReasonId { get; set; }

        /// <summary>
        /// Discipline Method for Firearms Incidents
        /// <para>
        /// The method used to discipline students who are not children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19546">Discipline Method for Firearms Incidents</a>
        /// </para>
        /// </summary>
        public Guid? RefDisciplineMethodFirearmsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineMethodOfCwd"/> model
        /// </summary>
        public Guid? RefDisciplineMethodOfCwdId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineReason"/> model
        /// </summary>
        public Guid? RefDisciplineReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEADisciplineMethodFirearm"/> model
        /// </summary>
        public Guid? RefIDEADisciplineMethodFirearmId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefeaInterimRemoval"/> model
        /// </summary>
        public Guid? RefIdeaInterimRemovalId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefeaInterimRemovalReason"/> model
        /// </summary>
        public Guid? RefIdeaInterimRemovalReasonId { get; set; }

        /// <summary>
        /// Related to Zero Tolerance Policy
        /// <para>
        /// An indication of whether or not any of the disciplinary actions taken against a student were imposed as a consequence of state or local zero tolerance policies.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19503">Related to Zero Tolerance Policy</a>
        /// </para>
        /// </summary>
        public System.Boolean? RelatedToZeroTolerancePolicy { get; set; }

        /// <summary>
        /// Shortened Expulsion
        /// <para>
        /// An expulsion with or without services that is shortened to a term of less than one year by the superintendent or chief administrator of a school district.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19505">Shortened Expulsion</a>
        /// </para>
        /// </summary>
        public System.Boolean? ShortenedExpulsion { get; set; }

    }
}
