//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELQualityInitiativeViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELQualityInitiative View Model
     /// </summary>
    public partial class ELQualityInitiativeViewModel : ViewModelBase, Interfaces.IELQualityInitiative
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELQualityInitiative";

        // MaximumScore -- (backing property for Quality Initiative Maximum Score)
        private System.String _MaximumScore;

        // MinimumScore -- (backing property for Quality Initiative Minimum Score)
        private System.String _MinimumScore;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // ParticipationEndDate -- (backing property for Quality Initiative Participation End Date)
        private System.DateTime? _ParticipationEndDate;

        // ParticipationIndicator -- (backing property for Quality Initiative Participation Indicator)
        private System.Boolean? _ParticipationIndicator;

        // ParticipationStartDate -- (backing property for Quality Initiative Participation Start Date)
        private System.DateTime? _ParticipationStartDate;

        // ProgramHeathSafetyChecklistUseStatus -- (backing property for Program Health Safety Checklist Use Status)
        private System.Boolean? _ProgramHeathSafetyChecklistUseStatus;

        // ScoreLevel -- (backing property for Quality Initiative Score Level)
        private System.String _ScoreLevel;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Quality Initiative Maximum Score
        /// <para>
        /// The maximum score option for the QRIS or other quality initiative.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20432">Quality Initiative Maximum Score</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String MaximumScore { get => _MaximumScore; set => SetProperty(ref _MaximumScore, value); }

        /// <summary>
        /// Quality Initiative Minimum Score
        /// <para>
        /// The minimum score option for the QRIS or other quality initiative.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20433">Quality Initiative Minimum Score</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String MinimumScore { get => _MinimumScore; set => SetProperty(ref _MinimumScore, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Quality Initiative Participation End Date
        /// <para>
        /// The quality initiative end date.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20436">Quality Initiative Participation End Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ParticipationEndDate { get => _ParticipationEndDate; set => SetProperty(ref _ParticipationEndDate, value); }

        /// <summary>
        /// Quality Initiative Participation Indicator
        /// <para>
        /// Site participates in a quality improvement initiative component other than QRIS.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20435">Quality Initiative Participation Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? ParticipationIndicator { get => _ParticipationIndicator; set => SetProperty(ref _ParticipationIndicator, value); }

        /// <summary>
        /// Quality Initiative Participation Start Date
        /// <para>
        /// The quality initiative start date.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20437">Quality Initiative Participation Start Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ParticipationStartDate { get => _ParticipationStartDate; set => SetProperty(ref _ParticipationStartDate, value); }

        /// <summary>
        /// Program Health Safety Checklist Use Status
        /// <para>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19851">Program Health Safety Checklist Use Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? ProgramHeathSafetyChecklistUseStatus { get => _ProgramHeathSafetyChecklistUseStatus; set => SetProperty(ref _ProgramHeathSafetyChecklistUseStatus, value); }

        /// <summary>
        /// Quality Initiative Score Level
        /// <para>
        /// The score, rating or level received by a program for its Quality Rating and Improvement System (QRIS) or other quality initiative.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20434">Quality Initiative Score Level</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ScoreLevel { get => _ScoreLevel; set => SetProperty(ref _ScoreLevel, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELQualityInitiative model)
        {
            IsBusy = true;
            Id = model.Id;
            MaximumScore = model.MaximumScore; // Quality Initiative Maximum Score
            MinimumScore = model.MinimumScore; // Quality Initiative Minimum Score
            OrganizationId = model.OrganizationId; // 
            ParticipationEndDate = model.ParticipationEndDate; // Quality Initiative Participation End Date
            ParticipationIndicator = model.ParticipationIndicator; // Quality Initiative Participation Indicator
            ParticipationStartDate = model.ParticipationStartDate; // Quality Initiative Participation Start Date
            ProgramHeathSafetyChecklistUseStatus = model.ProgramHeathSafetyChecklistUseStatus; // Program Health Safety Checklist Use Status
            ScoreLevel = model.ScoreLevel; // Quality Initiative Score Level
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
