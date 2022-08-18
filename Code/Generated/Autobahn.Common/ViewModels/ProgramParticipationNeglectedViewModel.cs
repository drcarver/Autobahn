//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationNeglectedViewModel.cs
//* Name:       Neglected or Delinquent Academic Achievement Indicator
//* Definition: Student was served by Title I, Part D, Subpart 1 of ESEA as amended for at least 90 consecutive days during the reporting period who took both a pre- and post-test.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// Student was served by Title I, Part D, Subpart 1 of ESEA as amended for at least 90 consecutive days during the reporting period who took both a pre- and post-test.
     /// </summary>
    public partial class ProgramParticipationNeglectedViewModel : ViewModelBase, Interfaces.IProgramParticipationNeglected
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationNeglected";

        // AchievementIndicator -- (backing property for Neglected or Delinquent Academic Achievement Indicator)
        private System.Boolean? _AchievementIndicator;

        // ObtainedEmployment -- (backing property for Neglected or Delinquent Obtained Employment)
        private System.Boolean? _ObtainedEmployment;

        // OutcomeIndicator -- (backing property for Neglected or Delinquent Academic Outcome Indicator)
        private System.Boolean? _OutcomeIndicator;

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // RefNeglectedProgramTypeId -- (backing property for Neglected or Delinquent Program Type)
        private Guid? _RefNeglectedProgramTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Neglected or Delinquent Academic Achievement Indicator
        /// <para>
        /// Student was served by Title I, Part D, Subpart 1 of ESEA as amended for at least 90 consecutive days during the reporting period who took both a pre- and post-test.
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? AchievementIndicator { get => _AchievementIndicator; set => SetProperty(ref _AchievementIndicator, value); }

        /// <summary>
        /// Neglected or Delinquent Obtained Employment
        /// <para>
        /// An indication that a Neglected or Delinquent student obtained employment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19475">Neglected or Delinquent Obtained Employment</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? ObtainedEmployment { get => _ObtainedEmployment; set => SetProperty(ref _ObtainedEmployment, value); }

        /// <summary>
        /// Neglected or Delinquent Academic Outcome Indicator
        /// <para>
        /// Student was served by Title I, Part D, Subpart 2 of ESEA as amended for at least 90 consecutive days during the reporting period who took both a pre- and post-test.
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? OutcomeIndicator { get => _OutcomeIndicator; set => SetProperty(ref _OutcomeIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// Neglected or Delinquent Program Type
        /// <para>
        /// The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19194">Neglected or Delinquent Program Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefNeglectedProgramTypeId { get => _RefNeglectedProgramTypeId; set => SetProperty(ref _RefNeglectedProgramTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationNeglected model)
        {
            IsBusy = true;
            Id = model.Id;
            AchievementIndicator = model.AchievementIndicator; // Neglected or Delinquent Academic Achievement Indicator
            ObtainedEmployment = model.ObtainedEmployment; // Neglected or Delinquent Obtained Employment
            OutcomeIndicator = model.OutcomeIndicator; // Neglected or Delinquent Academic Outcome Indicator
            PersonProgramParticipationId = model.PersonProgramParticipationId; // 
            RefNeglectedProgramTypeId = model.RefNeglectedProgramTypeId; // Neglected or Delinquent Program Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefNeglectedProgramType List
        /// <summary>
        /// The complete Neglected or Delinquent Academic Achievement Indicator List
        /// </summary>
        private static List<ReferenceModelBase> RefNeglectedProgramTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("cda0fb77-4bed-4b52-88c8-1e17c4db0682"), Code="NeglectedPrograms", Description="Neglected programs", Definition="Neglected programs is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("b070017a-0dc8-4d6d-b28f-f348d71f087c"), Code="JuvenileDetention", Description="Juvenile Detention", Definition="Juvenile Detention is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("48f293dd-6dcd-4df7-9fb8-3d3b124335c6"), Code="JuvenileCorrection", Description="Juvenile Correction", Definition="Juvenile Correction is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("3ab17815-ba57-4801-a3b0-b1359fbdbcf6"), Code="AdultCorrection", Description="Adult Correction", Definition="Adult Correction is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("b8f75dde-181c-4ff4-8115-b706f6b6f486"), Code="AtRiskPrograms", Description="At-risk programs", Definition="At-risk programs is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("1fe703a8-7dc1-4911-bab4-931658fa6c5e"), Code="OtherPrograms", Description="Other Programs", Definition="Other Programs is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=Convert.ToDecimal("6.00") },
        };
        #endregion
    }
}
