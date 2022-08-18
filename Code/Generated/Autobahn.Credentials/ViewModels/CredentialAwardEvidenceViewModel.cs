//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardEvidenceViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialAwardEvidence View Model
     /// </summary>
    public partial class CredentialAwardEvidenceViewModel : ViewModelBase, Interfaces.ICredentialAwardEvidence
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialAwardEvidence";

        // member variable for the AssessmentResultId property
        private Guid? _AssessmentResultId;

        // member variable for the CredentialAwardId property
        private Guid _CredentialAwardId;

        // Statement -- (backing property for Credential Evidence Statement)
        private System.String _Statement;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentResult"/> model
        /// </summary>
        public Guid? AssessmentResultId { get => _AssessmentResultId; set => SetProperty(ref _AssessmentResultId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialAward"/> model
        /// </summary>
        public Guid CredentialAwardId { get => _CredentialAwardId; set => SetProperty(ref _CredentialAwardId, value); }

        /// <summary>
        /// Credential Evidence Statement
        /// <para>
        /// A statement or reference describing the evidence that the learner met the criteria for attainment of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19901">Credential Evidence Statement</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Statement { get => _Statement; set => SetProperty(ref _Statement, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialAwardEvidence model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentResultId = model.AssessmentResultId; // 
            CredentialAwardId = model.CredentialAwardId; // 
            Statement = model.Statement; // Credential Evidence Statement
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
