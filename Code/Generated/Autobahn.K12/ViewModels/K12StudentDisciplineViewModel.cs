//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentDisciplineViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentDiscipline View Model
     /// </summary>
    public partial class K12StudentDisciplineViewModel : ViewModelBase, Interfaces.IK12StudentDiscipline
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentDiscipline";

        // DisciplinaryActionEndDate -- (backing property for Disciplinary Action End Date)
        private System.DateTime? _DisciplinaryActionEndDate;

        // DisciplinaryActionStartDate -- (backing property for Disciplinary Action Start Date)
        private System.DateTime? _DisciplinaryActionStartDate;

        // DurationOfDisciplinaryAction -- (backing property for Duration of Disciplinary Action)
        private System.Decimal? _DurationOfDisciplinaryAction;

        // EducationalServicesAfterRemoval -- (backing property for Educational Services After Removal)
        private System.Boolean? _EducationalServicesAfterRemoval;

        // FullYearExpulsion -- (backing property for Full Year Expulsion)
        private System.Boolean? _FullYearExpulsion;

        // IEPPlacementMeetingIndicator -- (backing property for Disciplinary Action IEP Placement Meeting Indicator)
        private System.Boolean? _IEPPlacementMeetingIndicator;

        // member variable for the IncidentId property
        private Guid? _IncidentId;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefDisciplinaryActionTakenId -- (backing property for Disciplinary Action Taken)
        private Guid? _RefDisciplinaryActionTakenId;

        // RefDisciplineLengthDifferenceReasonId -- (backing property for Discipline Action Length Difference Reason)
        private Guid? _RefDisciplineLengthDifferenceReasonId;

        // RefDisciplineMethodFirearmsId -- (backing property for Discipline Method for Firearms Incidents)
        private Guid? _RefDisciplineMethodFirearmsId;

        // RefDisciplineMethodOfCwdId -- (backing property for Discipline Method of Children with Disabilities)
        private Guid? _RefDisciplineMethodOfCwdId;

        // RefDisciplineReasonId -- (backing property for Discipline Reason)
        private Guid? _RefDisciplineReasonId;

        // RefIDEADisciplineMethodFirearmId -- (backing property for IDEA Discipline Method for Firearms Incidents)
        private Guid? _RefIDEADisciplineMethodFirearmId;

        // RefIdeaInterimRemovalId -- (backing property for IDEA Interim Removal)
        private Guid? _RefIdeaInterimRemovalId;

        // RefIdeaInterimRemovalReasonId -- (backing property for IDEA Interim Removal Reason)
        private Guid? _RefIdeaInterimRemovalReasonId;

        // RelatedToZeroTolerancePolicy -- (backing property for Related to Zero Tolerance Policy)
        private System.Boolean? _RelatedToZeroTolerancePolicy;

        // ShortenedExpulsion -- (backing property for Shortened Expulsion)
        private System.Boolean? _ShortenedExpulsion;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Disciplinary Action End Date
        /// <para>
        /// The year, month and day on which a discipline action ends.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19082">Disciplinary Action End Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? DisciplinaryActionEndDate { get => _DisciplinaryActionEndDate; set => SetProperty(ref _DisciplinaryActionEndDate, value); }

        /// <summary>
        /// Disciplinary Action Start Date
        /// <para>
        /// The year, month and day on which a discipline action begins.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19083">Disciplinary Action Start Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? DisciplinaryActionStartDate { get => _DisciplinaryActionStartDate; set => SetProperty(ref _DisciplinaryActionStartDate, value); }

        /// <summary>
        /// Duration of Disciplinary Action
        /// <para>
        /// The length, in school days, of the disciplinary action.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19502">Duration of Disciplinary Action</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? DurationOfDisciplinaryAction { get => _DurationOfDisciplinaryAction; set => SetProperty(ref _DurationOfDisciplinaryAction, value); }

        /// <summary>
        /// Educational Services After Removal
        /// <para>
        /// An indication of whether children (students) were provided educational services when removed from the regular school program for disciplinary reasons.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19570">Educational Services After Removal</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? EducationalServicesAfterRemoval { get => _EducationalServicesAfterRemoval; set => SetProperty(ref _EducationalServicesAfterRemoval, value); }

        /// <summary>
        /// Full Year Expulsion
        /// <para>
        /// An expulsion with or without services for a period of one full year (i.e., 365 days).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19504">Full Year Expulsion</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? FullYearExpulsion { get => _FullYearExpulsion; set => SetProperty(ref _FullYearExpulsion, value); }

        /// <summary>
        /// Disciplinary Action IEP Placement Meeting Indicator
        /// <para>
        /// An indication as to whether an offense and/or disciplinary action resulted in a meeting of a student's Individualized Education Program (IEP) team to determine appropriate placement.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20288">Disciplinary Action IEP Placement Meeting Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? IEPPlacementMeetingIndicator { get => _IEPPlacementMeetingIndicator; set => SetProperty(ref _IEPPlacementMeetingIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIncident"/> model
        /// </summary>
        public Guid? IncidentId { get => _IncidentId; set => SetProperty(ref _IncidentId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Disciplinary Action Taken
        /// <para>
        /// Identifies the consequences of an incident for the student(s) involved in an incident as perpetrator(s).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19479">Disciplinary Action Taken</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefDisciplinaryActionTakenId { get => _RefDisciplinaryActionTakenId; set => SetProperty(ref _RefDisciplinaryActionTakenId, value); }

        /// <summary>
        /// Discipline Action Length Difference Reason
        /// <para>
        /// The reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19602">Discipline Action Length Difference Reason</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefDisciplineLengthDifferenceReasonId { get => _RefDisciplineLengthDifferenceReasonId; set => SetProperty(ref _RefDisciplineLengthDifferenceReasonId, value); }

        /// <summary>
        /// Discipline Method for Firearms Incidents
        /// <para>
        /// The method used to discipline students who are not children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19546">Discipline Method for Firearms Incidents</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefDisciplineMethodFirearmsId { get => _RefDisciplineMethodFirearmsId; set => SetProperty(ref _RefDisciplineMethodFirearmsId, value); }

        /// <summary>
        /// Discipline Method of Children with Disabilities
        /// <para>
        /// The type of suspension or expulsion used for the discipline of children with disabilities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19529">Discipline Method of Children with Disabilities</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefDisciplineMethodOfCwdId { get => _RefDisciplineMethodOfCwdId; set => SetProperty(ref _RefDisciplineMethodOfCwdId, value); }

        /// <summary>
        /// Discipline Reason
        /// <para>
        /// The reason why the student was disciplined.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19536">Discipline Reason</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefDisciplineReasonId { get => _RefDisciplineReasonId; set => SetProperty(ref _RefDisciplineReasonId, value); }

        /// <summary>
        /// IDEA Discipline Method for Firearms Incidents
        /// <para>
        /// The methods used to discipline students who are children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19547">IDEA Discipline Method for Firearms Incidents</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIDEADisciplineMethodFirearmId { get => _RefIDEADisciplineMethodFirearmId; set => SetProperty(ref _RefIDEADisciplineMethodFirearmId, value); }

        /// <summary>
        /// IDEA Interim Removal
        /// <para>
        /// The type of interim removal from current educational setting experienced by children with disabilities (IDEA).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19532">IDEA Interim Removal</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIdeaInterimRemovalId { get => _RefIdeaInterimRemovalId; set => SetProperty(ref _RefIdeaInterimRemovalId, value); }

        /// <summary>
        /// IDEA Interim Removal Reason
        /// <para>
        /// The reasons why children with disabilities were unilaterally removed from their current educational placement to an interim alternative educational setting.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19530">IDEA Interim Removal Reason</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIdeaInterimRemovalReasonId { get => _RefIdeaInterimRemovalReasonId; set => SetProperty(ref _RefIdeaInterimRemovalReasonId, value); }

        /// <summary>
        /// Related to Zero Tolerance Policy
        /// <para>
        /// An indication of whether or not any of the disciplinary actions taken against a student were imposed as a consequence of state or local zero tolerance policies.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19503">Related to Zero Tolerance Policy</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? RelatedToZeroTolerancePolicy { get => _RelatedToZeroTolerancePolicy; set => SetProperty(ref _RelatedToZeroTolerancePolicy, value); }

        /// <summary>
        /// Shortened Expulsion
        /// <para>
        /// An expulsion with or without services that is shortened to a term of less than one year by the superintendent or chief administrator of a school district.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19505">Shortened Expulsion</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? ShortenedExpulsion { get => _ShortenedExpulsion; set => SetProperty(ref _ShortenedExpulsion, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentDiscipline model)
        {
            IsBusy = true;
            Id = model.Id;
            DisciplinaryActionEndDate = model.DisciplinaryActionEndDate; // Disciplinary Action End Date
            DisciplinaryActionStartDate = model.DisciplinaryActionStartDate; // Disciplinary Action Start Date
            DurationOfDisciplinaryAction = model.DurationOfDisciplinaryAction; // Duration of Disciplinary Action
            EducationalServicesAfterRemoval = model.EducationalServicesAfterRemoval; // Educational Services After Removal
            FullYearExpulsion = model.FullYearExpulsion; // Full Year Expulsion
            IEPPlacementMeetingIndicator = model.IEPPlacementMeetingIndicator; // Disciplinary Action IEP Placement Meeting Indicator
            IncidentId = model.IncidentId; // 
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefDisciplinaryActionTakenId = model.RefDisciplinaryActionTakenId; // Disciplinary Action Taken
            RefDisciplineLengthDifferenceReasonId = model.RefDisciplineLengthDifferenceReasonId; // Discipline Action Length Difference Reason
            RefDisciplineMethodFirearmsId = model.RefDisciplineMethodFirearmsId; // Discipline Method for Firearms Incidents
            RefDisciplineMethodOfCwdId = model.RefDisciplineMethodOfCwdId; // Discipline Method of Children with Disabilities
            RefDisciplineReasonId = model.RefDisciplineReasonId; // Discipline Reason
            RefIDEADisciplineMethodFirearmId = model.RefIDEADisciplineMethodFirearmId; // IDEA Discipline Method for Firearms Incidents
            RefIdeaInterimRemovalId = model.RefIdeaInterimRemovalId; // IDEA Interim Removal
            RefIdeaInterimRemovalReasonId = model.RefIdeaInterimRemovalReasonId; // IDEA Interim Removal Reason
            RelatedToZeroTolerancePolicy = model.RelatedToZeroTolerancePolicy; // Related to Zero Tolerance Policy
            ShortenedExpulsion = model.ShortenedExpulsion; // Shortened Expulsion
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefeaInterimRemoval List
        /// <summary>
        /// The complete <see cref="RefeaInterimRemoval"> List
        /// </summary>
        private static List<ReferenceModelBase> RefeaInterimRemovalList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefeaInterimRemovalReason List
        /// <summary>
        /// The complete <see cref="RefeaInterimRemovalReason"> List
        /// </summary>
        private static List<ReferenceModelBase> RefeaInterimRemovalReasonList = new List<ReferenceModelBase>
        {
        };
        #endregion
    }
}
