//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefCriteriaViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialDefCriteria View Model
     /// </summary>
    public partial class CredentialDefCriteriaViewModel : ViewModelBase, Interfaces.ICredentialDefCriteria
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialDefCriteria";

        // member variable for the CompetencySetId property
        private Guid? _CompetencySetId;

        // member variable for the CredentialDefinitionId property
        private Guid _CredentialDefinitionId;

        // Criteria -- (backing property for Credential Definition Criteria)
        private System.String _Criteria;

        // CriteriaUrl -- (backing property for Credential Definition Criteria URL)
        private System.String _CriteriaUrl;

        // EstimatedDuration -- (backing property for Credential Definition Estimated Duration)
        private System.String _EstimatedDuration;

        // MaximumDuration -- (backing property for Credential Definition Maximum Duration)
        private System.String _MaximumDuration;

        // MinimumAge -- (backing property for Credential Definition Minimum Age)
        private System.Int32? _MinimumAge;

        // MinimumDuration -- (backing property for Credential Definition Minimum Duration)
        private System.String _MinimumDuration;

        // RefCredentialDefAssessMethodTypeId -- (backing property for Credential Definition Assessment Method Type)
        private Guid? _RefCredentialDefAssessMethodTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
        /// </summary>
        public Guid? CompetencySetId { get => _CompetencySetId; set => SetProperty(ref _CompetencySetId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get => _CredentialDefinitionId; set => SetProperty(ref _CredentialDefinitionId, value); }

        /// <summary>
        /// Credential Definition Criteria
        /// <para>
        /// The criteria for competency-based completion of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19896">Credential Definition Criteria</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Criteria { get => _Criteria; set => SetProperty(ref _Criteria, value); }

        /// <summary>
        /// Credential Definition Criteria URL
        /// <para>
        /// The Uniform Resource Locator (URL) for the unique address of a web page describing the competency-based completion criteria for the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20113">Credential Definition Criteria URL</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CriteriaUrl { get => _CriteriaUrl; set => SetProperty(ref _CriteriaUrl, value); }

        /// <summary>
        /// Credential Definition Estimated Duration
        /// <para>
        /// The estimated amount of time in minutes it will take to earn the credential.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20722">Credential Definition Estimated Duration</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String EstimatedDuration { get => _EstimatedDuration; set => SetProperty(ref _EstimatedDuration, value); }

        /// <summary>
        /// Credential Definition Maximum Duration
        /// <para>
        /// The maximum amount of time in minutes it will take to earn the described credential.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20727">Credential Definition Maximum Duration</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String MaximumDuration { get => _MaximumDuration; set => SetProperty(ref _MaximumDuration, value); }

        /// <summary>
        /// Credential Definition Minimum Age
        /// <para>
        /// The minimum allowed age in years at which a person is eligible for the credential.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20728">Credential Definition Minimum Age</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? MinimumAge { get => _MinimumAge; set => SetProperty(ref _MinimumAge, value); }

        /// <summary>
        /// Credential Definition Minimum Duration
        /// <para>
        /// The minimum amount of time in minutes it will take to earn the described credential.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20729">Credential Definition Minimum Duration</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String MinimumDuration { get => _MinimumDuration; set => SetProperty(ref _MinimumDuration, value); }

        /// <summary>
        /// Credential Definition Assessment Method Type
        /// <para>
        /// The method used to conduct the assessment being referenced.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20719">Credential Definition Assessment Method Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCredentialDefAssessMethodTypeId { get => _RefCredentialDefAssessMethodTypeId; set => SetProperty(ref _RefCredentialDefAssessMethodTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialDefCriteria model)
        {
            IsBusy = true;
            Id = model.Id;
            CompetencySetId = model.CompetencySetId; // 
            CredentialDefinitionId = model.CredentialDefinitionId; // 
            Criteria = model.Criteria; // Credential Definition Criteria
            CriteriaUrl = model.CriteriaUrl; // Credential Definition Criteria URL
            EstimatedDuration = model.EstimatedDuration; // Credential Definition Estimated Duration
            MaximumDuration = model.MaximumDuration; // Credential Definition Maximum Duration
            MinimumAge = model.MinimumAge; // Credential Definition Minimum Age
            MinimumDuration = model.MinimumDuration; // Credential Definition Minimum Duration
            RefCredentialDefAssessMethodTypeId = model.RefCredentialDefAssessMethodTypeId; // Credential Definition Assessment Method Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
