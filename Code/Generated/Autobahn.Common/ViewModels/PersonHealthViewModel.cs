//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonHealthViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonHealth View Model
     /// </summary>
    public partial class PersonHealthViewModel : ViewModelBase, Interfaces.IPersonHealth
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonHealth";

        // DentalScreeningDate -- (backing property for Dental Screening Date)
        private System.DateTime _DentalScreeningDate;

        // HealthScreeningEquipmentUsed -- (backing property for Health Screening Equipment Used)
        private System.String _HealthScreeningEquipmentUsed;

        // HealthScreeningFollowUpRecommendation -- (backing property for Health Screening Follow-up Recommendation)
        private System.String _HealthScreeningFollowUpRecommendation;

        // HearingScreeningDate -- (backing property for Hearing Screening Date)
        private System.DateTime? _HearingScreeningDate;

        // member variable for the PersonId property
        private Guid _PersonId;

        // RefDentalInsuranceCoverageTypeId -- (backing property for Dental Insurance Coverage Type)
        private Guid? _RefDentalInsuranceCoverageTypeId;

        // RefDentalScreeningStatusId -- (backing property for Dental Screening Status)
        private Guid? _RefDentalScreeningStatusId;

        // RefHealthInsuranceCoverageId -- (backing property for Insurance Coverage)
        private Guid? _RefHealthInsuranceCoverageId;

        // RefHearingScreeningStatusId -- (backing property for Hearing Screening Status)
        private Guid? _RefHearingScreeningStatusId;

        // RefMedicalAlertIndicatorId -- (backing property for Medical Alert Indicator)
        private Guid? _RefMedicalAlertIndicatorId;

        // RefVisionScreeningStatusId -- (backing property for Vision Screening Status)
        private Guid? _RefVisionScreeningStatusId;

        // VisionScreeningDate -- (backing property for Vision Screening Date)
        private System.DateTime? _VisionScreeningDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Dental Screening Date
        /// <para>
        /// The year, month and day of a dental screening
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19682">Dental Screening Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime DentalScreeningDate { get => _DentalScreeningDate; set => SetProperty(ref _DentalScreeningDate, value); }

        /// <summary>
        /// Health Screening Equipment Used
        /// <para>
        /// The screening equipment used for the hearing screening or the method used for the vision screening
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20325">Health Screening Equipment Used</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String HealthScreeningEquipmentUsed { get => _HealthScreeningEquipmentUsed; set => SetProperty(ref _HealthScreeningEquipmentUsed, value); }

        /// <summary>
        /// Health Screening Follow-up Recommendation
        /// <para>
        /// Recommendations for follow-up after a health screening.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20326">Health Screening Follow-up Recommendation</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String HealthScreeningFollowUpRecommendation { get => _HealthScreeningFollowUpRecommendation; set => SetProperty(ref _HealthScreeningFollowUpRecommendation, value); }

        /// <summary>
        /// Hearing Screening Date
        /// <para>
        /// The year, month and day of a hearing screening.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19681">Hearing Screening Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? HearingScreeningDate { get => _HearingScreeningDate; set => SetProperty(ref _HearingScreeningDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Dental Insurance Coverage Type
        /// <para>
        /// The source of insurance covering an person's dental care.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19335">Dental Insurance Coverage Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefDentalInsuranceCoverageTypeId { get => _RefDentalInsuranceCoverageTypeId; set => SetProperty(ref _RefDentalInsuranceCoverageTypeId, value); }

        /// <summary>
        /// Dental Screening Status
        /// <para>
        /// The condition of a person's mouth or oral cavity; more specifically the condition of the hard tissues (i.e., teeth and jaws) and the soft tissues (i.e., gums, tongue, lips, palate, mouth floor, and inner cheeks). Good oral health denotes the absence of clinically manifested disease or abnormalities of the oral cavity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19310">Dental Screening Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefDentalScreeningStatusId { get => _RefDentalScreeningStatusId; set => SetProperty(ref _RefDentalScreeningStatusId, value); }

        /// <summary>
        /// Insurance Coverage
        /// <para>
        /// The nature of insurance covering an person's hospitalization and other health or medical care.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19334">Insurance Coverage</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefHealthInsuranceCoverageId { get => _RefHealthInsuranceCoverageId; set => SetProperty(ref _RefHealthInsuranceCoverageId, value); }

        /// <summary>
        /// Hearing Screening Status
        /// <para>
        /// Status of an examination used to measure a person's ability to perceive sounds.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19309">Hearing Screening Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefHearingScreeningStatusId { get => _RefHearingScreeningStatusId; set => SetProperty(ref _RefHearingScreeningStatusId, value); }

        /// <summary>
        /// Medical Alert Indicator
        /// <para>
        /// Alert indicator for a medical/health condition.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19429">Medical Alert Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefMedicalAlertIndicatorId { get => _RefMedicalAlertIndicatorId; set => SetProperty(ref _RefMedicalAlertIndicatorId, value); }

        /// <summary>
        /// Vision Screening Status
        /// <para>
        /// Status of an examination used to measure a person's ability to see.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19308">Vision Screening Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefVisionScreeningStatusId { get => _RefVisionScreeningStatusId; set => SetProperty(ref _RefVisionScreeningStatusId, value); }

        /// <summary>
        /// Vision Screening Date
        /// <para>
        /// The year, month and day of a vision screening.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19680">Vision Screening Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? VisionScreeningDate { get => _VisionScreeningDate; set => SetProperty(ref _VisionScreeningDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonHealth model)
        {
            IsBusy = true;
            Id = model.Id;
            DentalScreeningDate = model.DentalScreeningDate; // Dental Screening Date
            HealthScreeningEquipmentUsed = model.HealthScreeningEquipmentUsed; // Health Screening Equipment Used
            HealthScreeningFollowUpRecommendation = model.HealthScreeningFollowUpRecommendation; // Health Screening Follow-up Recommendation
            HearingScreeningDate = model.HearingScreeningDate; // Hearing Screening Date
            PersonId = model.PersonId; // 
            RefDentalInsuranceCoverageTypeId = model.RefDentalInsuranceCoverageTypeId; // Dental Insurance Coverage Type
            RefDentalScreeningStatusId = model.RefDentalScreeningStatusId; // Dental Screening Status
            RefHealthInsuranceCoverageId = model.RefHealthInsuranceCoverageId; // Insurance Coverage
            RefHearingScreeningStatusId = model.RefHearingScreeningStatusId; // Hearing Screening Status
            RefMedicalAlertIndicatorId = model.RefMedicalAlertIndicatorId; // Medical Alert Indicator
            RefVisionScreeningStatusId = model.RefVisionScreeningStatusId; // Vision Screening Status
            VisionScreeningDate = model.VisionScreeningDate; // Vision Screening Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefMedicalAlertIndicator List
        /// <summary>
        /// The complete <see cref="RefMedicalAlertIndicator"> List
        /// </summary>
        private static List<ReferenceModelBase> RefMedicalAlertIndicatorList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("de54c125-58ba-4144-855a-03749be03fd0"), Code="Chronic", Description="Chronic", Definition="The person has an alert indicator for a chronic medical/health condition.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("24305e4c-7f34-4fd6-86dd-342760b1e4b9"), Code="Acute", Description="Acute", Definition="The person has an alert indicator for an acute medical/health condition.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("d288f93f-6135-4021-a80e-6c9e719c804f"), Code="None", Description="None", Definition="The person does not have an alert indicator for a medical/health condition.", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion

        #region RefVisionScreeningStatus List
        /// <summary>
        /// The complete <see cref="RefVisionScreeningStatus"> List
        /// </summary>
        private static List<ReferenceModelBase> RefVisionScreeningStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("b0fbdec7-6781-424d-b163-724ccac9f03d"), Code="Passed", Description="Passed", Definition="The person passed the screening.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("c286961d-3eac-4ca7-a733-aecd6e101e8b"), Code="FurtherEvaluation", Description="Further Evaluation Needed", Definition="Further evaluation is needed.", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion
    }
}
