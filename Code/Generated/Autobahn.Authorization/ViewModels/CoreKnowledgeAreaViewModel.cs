//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   CoreKnowledgeAreaViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The CoreKnowledgeAreaViewModel
     /// </summary>
    public partial class CoreKnowledgeAreaViewModel : ViewModelBase, Interfaces.ICoreKnowledgeArea
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CoreKnowledgeArea";

        // member variable for the ProfessionalDevelopmentActivityId property
        private Guid _ProfessionalDevelopmentActivityId;

        // member variable for the RefCoreKnowledgeAreaId property
        private Guid _RefCoreKnowledgeAreaId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CoreKnowledgeAreaViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ProfessionalDevelopmentActivity"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get => _ProfessionalDevelopmentActivityId; set => SetProperty(ref _ProfessionalDevelopmentActivityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCoreKnowledgeArea"/> model
        /// </summary>
        public Guid RefCoreKnowledgeAreaId { get => _RefCoreKnowledgeAreaId; set => SetProperty(ref _RefCoreKnowledgeAreaId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICoreKnowledgeArea model)
        {
            IsBusy = true;
            Id = model.Id;
            ProfessionalDevelopmentActivityId = model.ProfessionalDevelopmentActivityId;
            RefCoreKnowledgeAreaId = model.RefCoreKnowledgeAreaId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
