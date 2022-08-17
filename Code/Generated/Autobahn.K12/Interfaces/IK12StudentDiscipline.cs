//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentDiscipline.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentDiscipline Interface
     /// </summary>
    public partial interface IK12StudentDiscipline : IAutobahnBase
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
        System.DateTime? DisciplinaryActionEndDate { get; set; }

        /// <summary>
        /// Disciplinary Action Start Date
        /// <para>
        /// The year, month and day on which a discipline action begins.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19083">Disciplinary Action Start Date</a>
        /// </para>
        /// </summary>
        System.DateTime? DisciplinaryActionStartDate { get; set; }

        /// <summary>
        /// Duration of Disciplinary Action
        /// <para>
        /// The length, in school days, of the disciplinary action.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19502">Duration of Disciplinary Action</a>
        /// </para>
        /// </summary>
        System.Decimal? DurationOfDisciplinaryAction { get; set; }

        /// <summary>
        /// Educational Services After Removal
        /// <para>
        /// An indication of whether children (students) were provided educational services when removed from the regular school program for disciplinary reasons.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19570">Educational Services After Removal</a>
        /// </para>
        /// </summary>
        System.Boolean? EducationalServicesAfterRemoval { get; set; }

        /// <summary>
        /// Full Year Expulsion
        /// <para>
        /// An expulsion with or without services for a period of one full year (i.e., 365 days).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19504">Full Year Expulsion</a>
        /// </para>
        /// </summary>
        System.Boolean? FullYearExpulsion { get; set; }

        /// <summary>
        /// Disciplinary Action IEP Placement Meeting Indicator
        /// <para>
        /// An indication as to whether an offense and/or disciplinary action resulted in a meeting of a student's Individualized Education Program (IEP) team to determine appropriate placement.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20288">Disciplinary Action IEP Placement Meeting Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? IEPPlacementMeetingIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIncident"/> model
        /// </summary>
        Guid? IncidentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefDisciplinaryActionTaken"/> model
        /// </summary>
        Guid? RefDisciplinaryActionTakenId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefDisciplineLengthDifferenceReason"/> model
        /// </summary>
        Guid? RefDisciplineLengthDifferenceReasonId { get; set; }

        /// <summary>
        /// Discipline Method for Firearms Incidents
        /// <para>
        /// The method used to discipline students who are not children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19546">Discipline Method for Firearms Incidents</a>
        /// </para>
        /// </summary>
        Guid? RefDisciplineMethodFirearmsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefDisciplineMethodOfCwd"/> model
        /// </summary>
        Guid? RefDisciplineMethodOfCwdId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefDisciplineReason"/> model
        /// </summary>
        Guid? RefDisciplineReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIDEADisciplineMethodFirearm"/> model
        /// </summary>
        Guid? RefIDEADisciplineMethodFirearmId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefeaInterimRemoval"/> model
        /// </summary>
        Guid? RefIdeaInterimRemovalId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefeaInterimRemovalReason"/> model
        /// </summary>
        Guid? RefIdeaInterimRemovalReasonId { get; set; }

        /// <summary>
        /// Related to Zero Tolerance Policy
        /// <para>
        /// An indication of whether or not any of the disciplinary actions taken against a student were imposed as a consequence of state or local zero tolerance policies.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19503">Related to Zero Tolerance Policy</a>
        /// </para>
        /// </summary>
        System.Boolean? RelatedToZeroTolerancePolicy { get; set; }

        /// <summary>
        /// Shortened Expulsion
        /// <para>
        /// An expulsion with or without services that is shortened to a term of less than one year by the superintendent or chief administrator of a school district.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19505">Shortened Expulsion</a>
        /// </para>
        /// </summary>
        System.Boolean? ShortenedExpulsion { get; set; }

    }
}
