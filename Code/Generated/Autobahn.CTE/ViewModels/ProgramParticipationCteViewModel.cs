//**********************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   ProgramParticipationCteViewModel.cs
//* Name:       Career Pathways Program Participation Exit Date
//* Definition: The year, month and day on which the person ceased to participate in a program.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.CTE.ViewModels
{
     /// <summary>
     /// The year, month and day on which the person ceased to participate in a program.
     /// </summary>
    public partial class ProgramParticipationCteViewModel : ViewModelBase, Interfaces.IProgramParticipationCte
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationCte";

        // CareerPathwaysProgramParticipationExitDate -- (backing property for Career Pathways Program Participation Exit Date)
        private System.DateTime? _CareerPathwaysProgramParticipationExitDate;

        // CareerPathwaysProgramParticipationStartDate -- (backing property for Career Pathways Program Participation Start Date)
        private System.DateTime? _CareerPathwaysProgramParticipationStartDate;

        // CteCompleter -- (backing property for Career and Technical Education Completer)
        private System.Boolean? _CteCompleter;

        // CteConcentrator -- (backing property for Career and Technical Education Concentrator)
        private System.Boolean? _CteConcentrator;

        // CteNonTraditionalCompletion -- (backing property for Career and Technical Education Nontraditional Completion)
        private System.Boolean? _CteNonTraditionalCompletion;

        // CteParticipant -- (backing property for Career and Technical Education Participant)
        private System.Boolean? _CteParticipant;

        // DisplacedHomemakerIndicator -- (backing property for Career-Technical-Adult Education Displaced Homemaker Indicator)
        private System.Boolean? _DisplacedHomemakerIndicator;

        // OutOfWorkforceIndicator -- (backing property for Out of Workforce Indicator)
        private System.Boolean? _OutOfWorkforceIndicator;

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // RefNonTraditionalGenderStatusId -- (backing property for Career Technical Education Nontraditional Gender Status)
        private Guid? _RefNonTraditionalGenderStatusId;

        // RefWorkbasedLearningOpportunityTypeId -- (backing property for Work-based Learning Opportunity Type)
        private Guid? _RefWorkbasedLearningOpportunityTypeId;

        // SingleParentOrSinglePregnantWoman -- (backing property for Single Parent or Single Pregnant Woman Status)
        private System.Boolean? _SingleParentOrSinglePregnantWoman;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Career Pathways Program Participation Exit Date
        /// <para>
        /// The year, month and day on which the person ceased to participate in a program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20562">Career Pathways Program Participation Exit Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? CareerPathwaysProgramParticipationExitDate { get => _CareerPathwaysProgramParticipationExitDate; set => SetProperty(ref _CareerPathwaysProgramParticipationExitDate, value); }

        /// <summary>
        /// Career Pathways Program Participation Start Date
        /// <para>
        /// The year, month and day on which the person began to participate in a career pathway program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20563">Career Pathways Program Participation Start Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? CareerPathwaysProgramParticipationStartDate { get => _CareerPathwaysProgramParticipationStartDate; set => SetProperty(ref _CareerPathwaysProgramParticipationStartDate, value); }

        /// <summary>
        /// Career and Technical Education Completer
        /// <para>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19036">Career and Technical Education Completer</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? CteCompleter { get => _CteCompleter; set => SetProperty(ref _CteCompleter, value); }

        /// <summary>
        /// Career and Technical Education Concentrator
        /// <para>
        /// An indication of a student who has met the state-defined threshold of career and technical education concentrators, as defined in the State's approved Perkins IV State Plan.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19037">Career and Technical Education Concentrator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? CteConcentrator { get => _CteConcentrator; set => SetProperty(ref _CteConcentrator, value); }

        /// <summary>
        /// Career and Technical Education Nontraditional Completion
        /// <para>
        /// An indication that the CTE student has completed a CTE program in a nontraditional field (where one gender comprises less than 25 percent of the persons employed in those occupations or fields of work).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19586">Career and Technical Education Nontraditional Completion</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? CteNonTraditionalCompletion { get => _CteNonTraditionalCompletion; set => SetProperty(ref _CteNonTraditionalCompletion, value); }

        /// <summary>
        /// Career and Technical Education Participant
        /// <para>
        /// An indication a student has met the state-defined threshold of Career and Technical Education participation as defined in the State's approved Perkins IV State Plan.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19585">Career and Technical Education Participant</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? CteParticipant { get => _CteParticipant; set => SetProperty(ref _CteParticipant, value); }

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
        /// Career Technical Education Nontraditional Gender Status
        /// <para>
        /// An indication of whether CTE participants were members of an underrepresented gender group (where one gender comprises less than 25 percent of the persons employed in those occupations or field of work).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19581">Career Technical Education Nontraditional Gender Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefNonTraditionalGenderStatusId { get => _RefNonTraditionalGenderStatusId; set => SetProperty(ref _RefNonTraditionalGenderStatusId, value); }

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

        /// <summary>
        /// Single Parent or Single Pregnant Woman Status
        /// <para>
        /// A student who, at some time during the school year, is either a pregnant female student who is unmarried; or a male or female student who is unmarried or legally separated from a spouse and has a minor child or children.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19573">Single Parent or Single Pregnant Woman Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? SingleParentOrSinglePregnantWoman { get => _SingleParentOrSinglePregnantWoman; set => SetProperty(ref _SingleParentOrSinglePregnantWoman, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationCte model)
        {
            IsBusy = true;
            Id = model.Id;
            CareerPathwaysProgramParticipationExitDate = model.CareerPathwaysProgramParticipationExitDate; // Career Pathways Program Participation Exit Date
            CareerPathwaysProgramParticipationStartDate = model.CareerPathwaysProgramParticipationStartDate; // Career Pathways Program Participation Start Date
            CteCompleter = model.CteCompleter; // Career and Technical Education Completer
            CteConcentrator = model.CteConcentrator; // Career and Technical Education Concentrator
            CteNonTraditionalCompletion = model.CteNonTraditionalCompletion; // Career and Technical Education Nontraditional Completion
            CteParticipant = model.CteParticipant; // Career and Technical Education Participant
            DisplacedHomemakerIndicator = model.DisplacedHomemakerIndicator; // Career-Technical-Adult Education Displaced Homemaker Indicator
            OutOfWorkforceIndicator = model.OutOfWorkforceIndicator; // Out of Workforce Indicator
            PersonProgramParticipationId = model.PersonProgramParticipationId; // 
            RefNonTraditionalGenderStatusId = model.RefNonTraditionalGenderStatusId; // Career Technical Education Nontraditional Gender Status
            RefWorkbasedLearningOpportunityTypeId = model.RefWorkbasedLearningOpportunityTypeId; // Work-based Learning Opportunity Type
            SingleParentOrSinglePregnantWoman = model.SingleParentOrSinglePregnantWoman; // Single Parent or Single Pregnant Woman Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefNonTraditionalGenderStatus List
        /// <summary>
        /// The complete Career Pathways Program Participation Exit Date List
        /// </summary>
        private static List<ReferenceModelBase> RefNonTraditionalGenderStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("dbf7ba44-2347-40c3-99ae-e2f4b55e334c"), Code="Underrepresented", Description="Members of an underrepresented gender group", Definition="CTE participants were members of an underrepresented gender group.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("1f4dd8d5-7313-4e15-9178-b4782ccc7090"), Code="NotUnderrepresented", Description="Not members of an underrepresented gender group", Definition="CTE participants were not members of an underrepresented gender group.", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion
    }
}
