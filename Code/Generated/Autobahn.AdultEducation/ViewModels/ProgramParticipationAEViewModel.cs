//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   ProgramParticipationAEViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.AdultEducation.ViewModels
{
     /// <summary>
     /// The ProgramParticipationAE View Model
     /// </summary>
    public partial class ProgramParticipationAEViewModel : ViewModelBase, Interfaces.IProgramParticipationAE
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationAE";

        // DisplacedHomemakerIndicator -- (backing property for Career-Technical-Adult Education Displaced Homemaker Indicator)
        private System.Boolean? _DisplacedHomemakerIndicator;

        // InstructionalActivityHoursCompleted -- (backing property for Instructional Activity Hours Completed)
        private System.Decimal? _InstructionalActivityHoursCompleted;

        // OutOfWorkforceIndicator -- (backing property for Out of Workforce Indicator)
        private System.Boolean? _OutOfWorkforceIndicator;

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // PostsecondaryTransitionDate -- (backing property for Adult Education Postsecondary Transition Date)
        private System.DateTime? _PostsecondaryTransitionDate;

        // ProxyContactHours -- (backing property for Proxy Contact Hours)
        private System.Decimal? _ProxyContactHours;

        // RefAdultEducationProgramExitReasonId -- (backing property for Adult Education Program Exit Reason)
        private Guid? _RefAdultEducationProgramExitReasonId;

        // RefAeFunctioningLevelAtIntakeId -- (backing property for Adult Educational Functioning Level at Intake)
        private Guid? _RefAeFunctioningLevelAtIntakeId;

        // RefAeFunctioningLevelAtPosttestId -- (backing property for Adult Educational Functioning Level at Posttest)
        private Guid? _RefAeFunctioningLevelAtPosttestId;

        // RefAeInstructionalProgramTypeId -- (backing property for Adult Education Instructional Program Type)
        private Guid? _RefAeInstructionalProgramTypeId;

        // RefAePostsecondaryTransitionActionId -- (backing property for Adult Education Postsecondary Transition Action)
        private Guid? _RefAePostsecondaryTransitionActionId;

        // RefAeSpecialProgramTypeId -- (backing property for Adult Education Special Program Type)
        private Guid? _RefAeSpecialProgramTypeId;

        // RefCorrectionalEducationFacilityTypeId -- (backing property for Correctional Education Facility Type)
        private Guid? _RefCorrectionalEducationFacilityTypeId;

        // RefGoalsForAttendingAdultEducationId -- (backing property for Goals for Attending Adult Education)
        private Guid? _RefGoalsForAttendingAdultEducationId;

        // RefWorkbasedLearningOpportunityTypeId -- (backing property for Work-based Learning Opportunity Type)
        private Guid? _RefWorkbasedLearningOpportunityTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Career-Technical-Adult Education Displaced Homemaker Indicator
        /// <para>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19084">Career-Technical-Adult Education Displaced Homemaker Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? DisplacedHomemakerIndicator { get => _DisplacedHomemakerIndicator; set => SetProperty(ref _DisplacedHomemakerIndicator, value); }

        /// <summary>
        /// Instructional Activity Hours Completed
        /// <para>
        /// The number of credit hours and/or contact hours successfully completed by a person during a term.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19361">Instructional Activity Hours Completed</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? InstructionalActivityHoursCompleted { get => _InstructionalActivityHoursCompleted; set => SetProperty(ref _InstructionalActivityHoursCompleted, value); }

        /// <summary>
        /// Out of Workforce Indicator
        /// <para>
        /// An individual: (A) who is a displaced homemaker, as defined in section 3 of the Workforce Innovation and Opportunity Act (29 U.S.C. 3102); or (B) who (i)(I) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills; or (II) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (ii) is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20908">Out of Workforce Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? OutOfWorkforceIndicator { get => _OutOfWorkforceIndicator; set => SetProperty(ref _OutOfWorkforceIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// Adult Education Postsecondary Transition Date
        /// <para>
        /// The year, month and day on which a person previously enrolled in adult education entered and began to receive instructional services or training at a postsecondary institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19769">Adult Education Postsecondary Transition Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? PostsecondaryTransitionDate { get => _PostsecondaryTransitionDate; set => SetProperty(ref _PostsecondaryTransitionDate, value); }

        /// <summary>
        /// Proxy Contact Hours
        /// <para>
        /// The number of instructional hours completed by an adult enrolled in a distance learning program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19776">Proxy Contact Hours</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? ProxyContactHours { get => _ProxyContactHours; set => SetProperty(ref _ProxyContactHours, value); }

        /// <summary>
        /// Adult Education Program Exit Reason
        /// <para>
        /// The documented or assumed reason the person is no longer being served by the adult education program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20915">Adult Education Program Exit Reason</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAdultEducationProgramExitReasonId { get => _RefAdultEducationProgramExitReasonId; set => SetProperty(ref _RefAdultEducationProgramExitReasonId, value); }

        /// <summary>
        /// Adult Educational Functioning Level at Intake
        /// <para>
        /// An individual's entering skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment at program intake.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19763">Adult Educational Functioning Level at Intake</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAeFunctioningLevelAtIntakeId { get => _RefAeFunctioningLevelAtIntakeId; set => SetProperty(ref _RefAeFunctioningLevelAtIntakeId, value); }

        /// <summary>
        /// Adult Educational Functioning Level at Posttest
        /// <para>
        /// An individual's skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment after a set time period or number of instructional hours.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19764">Adult Educational Functioning Level at Posttest</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAeFunctioningLevelAtPosttestId { get => _RefAeFunctioningLevelAtPosttestId; set => SetProperty(ref _RefAeFunctioningLevelAtPosttestId, value); }

        /// <summary>
        /// Adult Education Instructional Program Type
        /// <para>
        /// The type of instructional program in which an adult is enrolled.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19765">Adult Education Instructional Program Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAeInstructionalProgramTypeId { get => _RefAeInstructionalProgramTypeId; set => SetProperty(ref _RefAeInstructionalProgramTypeId, value); }

        /// <summary>
        /// Adult Education Postsecondary Transition Action
        /// <para>
        /// The action taken with respect to postsecondary enrollment by the learner after program exit or when co-enrolled in ABE and postsecondary with respect to enrollment in a postsecondary educational or occupational skills program building on prior services or training received.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19768">Adult Education Postsecondary Transition Action</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAePostsecondaryTransitionActionId { get => _RefAePostsecondaryTransitionActionId; set => SetProperty(ref _RefAePostsecondaryTransitionActionId, value); }

        /// <summary>
        /// Adult Education Special Program Type
        /// <para>
        /// The type, by location or delivery mode, of adult education instruction program in which an adult participates.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19766">Adult Education Special Program Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAeSpecialProgramTypeId { get => _RefAeSpecialProgramTypeId; set => SetProperty(ref _RefAeSpecialProgramTypeId, value); }

        /// <summary>
        /// Correctional Education Facility Type
        /// <para>
        /// The type of facility in which an inmate receives correctional education services.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20262">Correctional Education Facility Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCorrectionalEducationFacilityTypeId { get => _RefCorrectionalEducationFacilityTypeId; set => SetProperty(ref _RefCorrectionalEducationFacilityTypeId, value); }

        /// <summary>
        /// Goals for Attending Adult Education
        /// <para>
        /// A person's reasons for attending an adult education class or program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19767">Goals for Attending Adult Education</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefGoalsForAttendingAdultEducationId { get => _RefGoalsForAttendingAdultEducationId; set => SetProperty(ref _RefGoalsForAttendingAdultEducationId, value); }

        /// <summary>
        /// Work-based Learning Opportunity Type
        /// <para>
        /// The type of work-based learning opportunity a student participated in.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20471">Work-based Learning Opportunity Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get => _RefWorkbasedLearningOpportunityTypeId; set => SetProperty(ref _RefWorkbasedLearningOpportunityTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationAE model)
        {
            IsBusy = true;
            Id = model.Id;
            DisplacedHomemakerIndicator = model.DisplacedHomemakerIndicator; // Career-Technical-Adult Education Displaced Homemaker Indicator
            InstructionalActivityHoursCompleted = model.InstructionalActivityHoursCompleted; // Instructional Activity Hours Completed
            OutOfWorkforceIndicator = model.OutOfWorkforceIndicator; // Out of Workforce Indicator
            PersonProgramParticipationId = model.PersonProgramParticipationId; // 
            PostsecondaryTransitionDate = model.PostsecondaryTransitionDate; // Adult Education Postsecondary Transition Date
            ProxyContactHours = model.ProxyContactHours; // Proxy Contact Hours
            RefAdultEducationProgramExitReasonId = model.RefAdultEducationProgramExitReasonId; // Adult Education Program Exit Reason
            RefAeFunctioningLevelAtIntakeId = model.RefAeFunctioningLevelAtIntakeId; // Adult Educational Functioning Level at Intake
            RefAeFunctioningLevelAtPosttestId = model.RefAeFunctioningLevelAtPosttestId; // Adult Educational Functioning Level at Posttest
            RefAeInstructionalProgramTypeId = model.RefAeInstructionalProgramTypeId; // Adult Education Instructional Program Type
            RefAePostsecondaryTransitionActionId = model.RefAePostsecondaryTransitionActionId; // Adult Education Postsecondary Transition Action
            RefAeSpecialProgramTypeId = model.RefAeSpecialProgramTypeId; // Adult Education Special Program Type
            RefCorrectionalEducationFacilityTypeId = model.RefCorrectionalEducationFacilityTypeId; // Correctional Education Facility Type
            RefGoalsForAttendingAdultEducationId = model.RefGoalsForAttendingAdultEducationId; // Goals for Attending Adult Education
            RefWorkbasedLearningOpportunityTypeId = model.RefWorkbasedLearningOpportunityTypeId; // Work-based Learning Opportunity Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
