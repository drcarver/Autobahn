//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentCohortViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentCohortViewModel
     /// </summary>
    public partial class K12StudentCohortViewModel : BindableBase, IK12StudentCohort
    {
#region "Backing Fields"
        // member variable for the CohortYear property
        private System.String _CohortYear;

        // member variable for the CohortGraduationYear property
        private System.String _CohortGraduationYear;

        // member variable for the GraduationRateSurveyCohortYear property
        private System.String _GraduationRateSurveyCohortYear;

        // member variable for the GraduationRateSurveyIndicator property
        private System.Boolean? _GraduationRateSurveyIndicator;

        // member variable for the CohortDescription property
        private System.String _CohortDescription;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        public System.String CohortYear  { get => _CohortYear; set => SetProperty(ref _CohortYear, value); }

        public System.String CohortGraduationYear  { get => _CohortGraduationYear; set => SetProperty(ref _CohortGraduationYear, value); }

        public System.String GraduationRateSurveyCohortYear  { get => _GraduationRateSurveyCohortYear; set => SetProperty(ref _GraduationRateSurveyCohortYear, value); }

        public System.Boolean? GraduationRateSurveyIndicator { get => _GraduationRateSurveyIndicator; set => SetProperty(ref _GraduationRateSurveyIndicator, value); }

        public System.String CohortDescription  { get => _CohortDescription; set => SetProperty(ref _CohortDescription, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IK12StudentCohort model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            CohortYear = model.CohortYear;
            CohortGraduationYear = model.CohortGraduationYear;
            GraduationRateSurveyCohortYear = model.GraduationRateSurveyCohortYear;
            GraduationRateSurveyIndicator = model.GraduationRateSurveyIndicator;
            CohortDescription = model.CohortDescription;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
