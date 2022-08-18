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
            new ReferenceModelBase { Id=Guid.Parse("304fb5f2-7449-4109-a60b-dbc91cdcc87f"), Code="Onsite", Description="Onsite", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("e46ef58f-f744-4780-a402-aa866025f113"), Code="Virtual", Description="Virtual classroom", Definition="", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("7b6f7b6a-bc6f-4ccd-b67f-b443caa68892"), Code="Off-Site", Description="Off-site classroom", Definition="", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("7dd10033-c644-4aed-b2f8-a504fb4ef7e1"), Code="Conference", Description="Conference", Definition="", SortOrder=Convert.ToDecimal("8.00") },
        };
        #endregion

        #region RefPDInstructionalDeliveryMode List
        /// <summary>
        /// The complete Professional Development Session Capacity List
        /// </summary>
        private static List<ReferenceModelBase> RefPDInstructionalDeliveryModeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("6d1480fd-4f31-4260-b807-19c239d6b8d4"), Code="Broadcast", Description="Broadcast", Definition="The primary setting or medium of the professional development delivery is Broadcast.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("f5d06a8e-edf7-414c-80de-115c05ed6e72"), Code="Correspondence", Description="Correspondence", Definition="The primary setting or medium of the professional development delivery is Correspondence.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("a3e3d706-8d8b-4e40-8fb8-308637531bed"), Code="EarlyCollege", Description="Early College", Definition="The primary setting or medium of the professional development delivery is Early College.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("a5c1a25d-181f-4408-84ea-39bc1a40415e"), Code="AudioVideo", Description="Interactive Audio/Video", Definition="The primary setting or medium of the professional development delivery is Interactive Audio/Video.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("b9ec8fd2-8e55-4f6c-a84c-7bb2cb9ca700"), Code="Conference", Description="Conference", Definition="The primary setting or medium of the professional development delivery is Conference.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("081fb3ee-0b6a-4be4-810b-cd3ab588e5da"), Code="Online", Description="Online", Definition="The primary setting or medium of the professional development delivery is Online.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("568edcc4-4e91-4511-8d96-0eb10902868a"), Code="IndependentStudy", Description="Independent Study", Definition="The primary setting or medium of the professional development delivery is Independent Study.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("73c6bc55-2f9e-4229-ac4e-22d0e74b1169"), Code="FaceToFace", Description="Face To Face", Definition="The primary setting or medium of the professional development delivery is Face To Face.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("e86ab815-2071-4ed4-8145-bc0dbcc3c9ce"), Code="BlendedLearning", Description="Blended Learning", Definition="The primary setting or medium of the professional development delivery is Blended Learning.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("bfa2fd10-5e8a-414c-b4d8-6e17b37f2e7a"), Code="Other", Description="Other", Definition="The primary setting or medium of the professional development delivery is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("20.00") },
        };
        #endregion

        #region RefPDSessionStatus List
        /// <summary>
        /// The complete Professional Development Session Capacity List
        /// </summary>
        private static List<ReferenceModelBase> RefPDSessionStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("3b782f5b-014c-4597-ad00-839caeb22694"), Code="Registering", Description="Registering", Definition="The person is registering for the professional development session.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("a9bb7c48-1432-47e3-903f-22b8191ceb58"), Code="Completed", Description="Completed", Definition="The person completed the professional development session.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("53f1a59a-e9ac-4be0-80b7-9258e43feaf3"), Code="Cancelled", Description="Cancelled", Definition="The professional development session was cancelled.", SortOrder=Convert.ToDecimal("6.00") },
        };
        #endregion
    }
}
