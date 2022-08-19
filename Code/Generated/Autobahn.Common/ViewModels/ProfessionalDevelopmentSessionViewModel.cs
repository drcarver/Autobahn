//**********************************************************
//* DomainName: Common Models
//* FileName:   ProfessionalDevelopmentSessionViewModel.cs
//* Name:       Professional Development Session Capacity
//* Definition: The total number of participants that can be accommodated by a professional development session.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The total number of participants that can be accommodated by a professional development session.
     /// </summary>
    public partial class ProfessionalDevelopmentSessionViewModel : ViewModelBase, Interfaces.IProfessionalDevelopmentSession
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProfessionalDevelopmentSession";

        // Capacity -- (backing property for Professional Development Session Capacity)
        private System.Int32? _Capacity;

        // EndDate -- (backing property for Professional Development Session End Date)
        private System.DateTime? _EndDate;

        // EndTime -- (backing property for Professional Development Session End Time)
        private System.String _EndTime;

        // EvaluationMethod -- (backing property for Professional Development Session Evaluation Method)
        private System.String _EvaluationMethod;

        // EvaluationScore -- (backing property for Professional Development Session Evaluation Score)
        private System.String _EvaluationScore;

        // ExpirationDate -- (backing property for Professional Development Activity Expiration Date)
        private System.DateTime? _ExpirationDate;

        // FundingSource -- (backing property for Professional Development Funding Source)
        private System.String _FundingSource;

        // LocationName -- (backing property for Professional Development Session Location Name)
        private System.String _LocationName;

        // member variable for the ProfessionalDevelopmentActivityId property
        private Guid _ProfessionalDevelopmentActivityId;

        // RefELTrainerCoreKnowledgeAreaId -- (backing property for Early Learning Trainer Core Knowledge Area)
        private Guid? _RefELTrainerCoreKnowledgeAreaId;

        // RefLanguageId -- (backing property for Professional Development Session Language)
        private Guid? _RefLanguageId;

        // RefPDDeliveryMethodId -- (backing property for Professional Development Delivery Method)
        private Guid? _RefPDDeliveryMethodId;

        // RefPDInstructionalDeliveryModeId -- (backing property for Professional Development Instructional Delivery Mode)
        private Guid? _RefPDInstructionalDeliveryModeId;

        // RefPDSessionStatusId -- (backing property for Professional Development Session Status)
        private Guid? _RefPDSessionStatusId;

        // SessionIdentifier -- (backing property for Professional Development Session Identifier)
        private System.String _SessionIdentifier;

        // SponsoringAgencyName -- (backing property for Sponsoring Agency Name)
        private System.String _SponsoringAgencyName;

        // StartDate -- (backing property for Professional Development Session Start Date)
        private System.DateTime? _StartDate;

        // StartTime -- (backing property for Professional Development Session Start Time)
        private System.String _StartTime;

        // TrainingAndTechnicalAssistanceLevel -- (backing property for Training and Technical Assistance Level)
        private System.String _TrainingAndTechnicalAssistanceLevel;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Professional Development Session Capacity
        /// <para>
        /// The total number of participants that can be accommodated by a professional development session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20416">Professional Development Session Capacity</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? Capacity { get => _Capacity; set => SetProperty(ref _Capacity, value); }

        /// <summary>
        /// Professional Development Session End Date
        /// <para>
        /// The year, month and day a professional development session ends.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20417">Professional Development Session End Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        /// <summary>
        /// Professional Development Session End Time
        /// <para>
        /// The time at which a professional development session ends.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20418">Professional Development Session End Time</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String EndTime { get => _EndTime; set => SetProperty(ref _EndTime, value); }

        /// <summary>
        /// Professional Development Session Evaluation Method
        /// <para>
        /// The method used to evaluate a professional development session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20419">Professional Development Session Evaluation Method</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String EvaluationMethod { get => _EvaluationMethod; set => SetProperty(ref _EvaluationMethod, value); }

        /// <summary>
        /// Professional Development Session Evaluation Score
        /// <para>
        /// The score or rating used to determine if a professional development session was successful.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20420">Professional Development Session Evaluation Score</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String EvaluationScore { get => _EvaluationScore; set => SetProperty(ref _EvaluationScore, value); }

        /// <summary>
        /// Professional Development Activity Expiration Date
        /// <para>
        /// The year, month, and day on which any certificate awarded as part of a professional development activity expires.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20421">Professional Development Activity Expiration Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ExpirationDate { get => _ExpirationDate; set => SetProperty(ref _ExpirationDate, value); }

        /// <summary>
        /// Professional Development Funding Source
        /// <para>
        /// The primary source of funding for a professional development session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20413">Professional Development Funding Source</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FundingSource { get => _FundingSource; set => SetProperty(ref _FundingSource, value); }

        /// <summary>
        /// Professional Development Session Location Name
        /// <para>
        /// The name of a location where a professional development session will be held.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20424">Professional Development Session Location Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String LocationName { get => _LocationName; set => SetProperty(ref _LocationName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentActivity"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get => _ProfessionalDevelopmentActivityId; set => SetProperty(ref _ProfessionalDevelopmentActivityId, value); }

        /// <summary>
        /// Early Learning Trainer Core Knowledge Area
        /// <para>
        /// A description of the core knowledge expertise of a trainer of a professional development experience.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20585">Early Learning Trainer Core Knowledge Area</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefELTrainerCoreKnowledgeAreaId { get => _RefELTrainerCoreKnowledgeAreaId; set => SetProperty(ref _RefELTrainerCoreKnowledgeAreaId, value); }

        /// <summary>
        /// Professional Development Session Language
        /// <para>
        /// The language in which the professional development session is delivered.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20357">Professional Development Session Language</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// Professional Development Delivery Method
        /// <para>
        /// The method by which a session is delivered
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20401">Professional Development Delivery Method</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPDDeliveryMethodId { get => _RefPDDeliveryMethodId; set => SetProperty(ref _RefPDDeliveryMethodId, value); }

        /// <summary>
        /// Professional Development Instructional Delivery Mode
        /// <para>
        /// The primary setting or medium of professional development delivery.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20429">Professional Development Instructional Delivery Mode</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPDInstructionalDeliveryModeId { get => _RefPDInstructionalDeliveryModeId; set => SetProperty(ref _RefPDInstructionalDeliveryModeId, value); }

        /// <summary>
        /// Professional Development Session Status
        /// <para>
        /// The current status of a professional development session
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20428">Professional Development Session Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPDSessionStatusId { get => _RefPDSessionStatusId; set => SetProperty(ref _RefPDSessionStatusId, value); }

        /// <summary>
        /// Professional Development Session Identifier
        /// <para>
        /// The unique, non-duplicated,  identification number assigned by the registry data system for a session of a particular professional development activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20422">Professional Development Session Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String SessionIdentifier { get => _SessionIdentifier; set => SetProperty(ref _SessionIdentifier, value); }

        /// <summary>
        /// Sponsoring Agency Name
        /// <para>
        /// The name of the sponsoring agency.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20461">Sponsoring Agency Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String SponsoringAgencyName { get => _SponsoringAgencyName; set => SetProperty(ref _SponsoringAgencyName, value); }

        /// <summary>
        /// Professional Development Session Start Date
        /// <para>
        /// The year, month, and day a professional development session begins.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20426">Professional Development Session Start Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        /// <summary>
        /// Professional Development Session Start Time
        /// <para>
        /// The time at which a professional development session begins.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20427">Professional Development Session Start Time</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String StartTime { get => _StartTime; set => SetProperty(ref _StartTime, value); }

        /// <summary>
        /// Training and Technical Assistance Level
        /// <para>
        /// The level of expertise an individual training and technical assistance specialist has based on a set of established criteria.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20609">Training and Technical Assistance Level</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String TrainingAndTechnicalAssistanceLevel { get => _TrainingAndTechnicalAssistanceLevel; set => SetProperty(ref _TrainingAndTechnicalAssistanceLevel, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProfessionalDevelopmentSession model)
        {
            IsBusy = true;
            Id = model.Id;
            Capacity = model.Capacity; // Professional Development Session Capacity
            EndDate = model.EndDate; // Professional Development Session End Date
            EndTime = model.EndTime; // Professional Development Session End Time
            EvaluationMethod = model.EvaluationMethod; // Professional Development Session Evaluation Method
            EvaluationScore = model.EvaluationScore; // Professional Development Session Evaluation Score
            ExpirationDate = model.ExpirationDate; // Professional Development Activity Expiration Date
            FundingSource = model.FundingSource; // Professional Development Funding Source
            LocationName = model.LocationName; // Professional Development Session Location Name
            ProfessionalDevelopmentActivityId = model.ProfessionalDevelopmentActivityId; // 
            RefELTrainerCoreKnowledgeAreaId = model.RefELTrainerCoreKnowledgeAreaId; // Early Learning Trainer Core Knowledge Area
            RefLanguageId = model.RefLanguageId; // Professional Development Session Language
            RefPDDeliveryMethodId = model.RefPDDeliveryMethodId; // Professional Development Delivery Method
            RefPDInstructionalDeliveryModeId = model.RefPDInstructionalDeliveryModeId; // Professional Development Instructional Delivery Mode
            RefPDSessionStatusId = model.RefPDSessionStatusId; // Professional Development Session Status
            SessionIdentifier = model.SessionIdentifier; // Professional Development Session Identifier
            SponsoringAgencyName = model.SponsoringAgencyName; // Sponsoring Agency Name
            StartDate = model.StartDate; // Professional Development Session Start Date
            StartTime = model.StartTime; // Professional Development Session Start Time
            TrainingAndTechnicalAssistanceLevel = model.TrainingAndTechnicalAssistanceLevel; // Training and Technical Assistance Level
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefPDDeliveryMethod List
        /// <summary>
        /// The complete Professional Development Session Capacity List
        /// </summary>
        private static List<ReferenceModelBase> RefPDDeliveryMethodList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("88196db0-f565-4f86-9d06-8535942d7e39"), Code="Onsite", Description="Onsite", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("9f9404df-afa8-4472-821a-a68808af3222"), Code="Virtual", Description="Virtual classroom", Definition="", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("0e01daa1-9a7f-488e-aaac-27b493baa86f"), Code="Off-Site", Description="Off-site classroom", Definition="", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("37397885-f4ea-4516-bf2e-05f3b1b53337"), Code="Conference", Description="Conference", Definition="", SortOrder=Convert.ToDecimal("8.00") },
        };
        #endregion

        #region RefPDInstructionalDeliveryMode List
        /// <summary>
        /// The complete Professional Development Session Capacity List
        /// </summary>
        private static List<ReferenceModelBase> RefPDInstructionalDeliveryModeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("ea691a62-3e61-48a1-8295-b21fa372f30b"), Code="Broadcast", Description="Broadcast", Definition="The primary setting or medium of the professional development delivery is Broadcast.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("ce322e91-cb4f-4c4e-9478-23ad0ba3275e"), Code="Correspondence", Description="Correspondence", Definition="The primary setting or medium of the professional development delivery is Correspondence.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("c8ca2b59-1ca7-4bff-99bc-517896bbf5bd"), Code="EarlyCollege", Description="Early College", Definition="The primary setting or medium of the professional development delivery is Early College.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("8c8894a7-57da-4f3f-a2a6-8b6d4dc6a5c8"), Code="AudioVideo", Description="Interactive Audio/Video", Definition="The primary setting or medium of the professional development delivery is Interactive Audio/Video.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("4e6de7d0-d309-4120-b8eb-c6b0d8b53d53"), Code="Conference", Description="Conference", Definition="The primary setting or medium of the professional development delivery is Conference.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("122f069d-06e0-4a48-9215-4f03462e8fe5"), Code="Online", Description="Online", Definition="The primary setting or medium of the professional development delivery is Online.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("e6c95ae8-d56a-4de4-8bdc-2dbf561b00da"), Code="IndependentStudy", Description="Independent Study", Definition="The primary setting or medium of the professional development delivery is Independent Study.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("151df5b5-506d-4237-a5b3-b009ae93e16a"), Code="FaceToFace", Description="Face To Face", Definition="The primary setting or medium of the professional development delivery is Face To Face.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("02b3ee9a-4d95-4e69-9227-d3f19c5e755e"), Code="BlendedLearning", Description="Blended Learning", Definition="The primary setting or medium of the professional development delivery is Blended Learning.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("acac133b-af09-4062-a582-9434a7f8fb49"), Code="Other", Description="Other", Definition="The primary setting or medium of the professional development delivery is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("20.00") },
        };
        #endregion

        #region RefPDSessionStatus List
        /// <summary>
        /// The complete Professional Development Session Capacity List
        /// </summary>
        private static List<ReferenceModelBase> RefPDSessionStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("1b9da9c5-a524-4005-a80e-05dd30ab7409"), Code="Registering", Description="Registering", Definition="The person is registering for the professional development session.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("c6641a24-5482-47da-89a5-80cfe399a0df"), Code="Completed", Description="Completed", Definition="The person completed the professional development session.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("29367ec9-7e60-4790-8b87-fb53c98995b4"), Code="Cancelled", Description="Cancelled", Definition="The professional development session was cancelled.", SortOrder=Convert.ToDecimal("6.00") },
        };
        #endregion
    }
}
