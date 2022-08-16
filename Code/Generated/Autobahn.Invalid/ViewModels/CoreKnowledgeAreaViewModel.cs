//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CoreKnowledgeAreaViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The CoreKnowledgeAreaViewModel
     /// </summary>
    public partial class CoreKnowledgeAreaViewModel : ViewModelBase, Interfaces.ICoreKnowledgeArea
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CoreKnowledgeArea";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCoreKnowledgeAreaId property
        private Guid? _RefCoreKnowledgeAreaId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCoreKnowledgeArea"/> model
        /// </summary>
        public Guid? RefCoreKnowledgeAreaId { get => _RefCoreKnowledgeAreaId; set => SetProperty(ref _RefCoreKnowledgeAreaId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICoreKnowledgeArea model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCoreKnowledgeAreaId = model.RefCoreKnowledgeAreaId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
