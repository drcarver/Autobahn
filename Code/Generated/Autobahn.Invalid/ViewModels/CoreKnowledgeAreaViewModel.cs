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

        // member variable for the RefCoreKnowledgeAreaId property
        private Guid _RefCoreKnowledgeAreaId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CoreKnowledgeAreaViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCoreKnowledgeArea"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19812">Early Learning Core Knowledge Area</a>
        /// </para>
        /// </summary>
        [DisplayName("Early Learning Core Knowledge Area")]
        public Guid RefCoreKnowledgeAreaId { get => _RefCoreKnowledgeAreaId; set => SetProperty(ref _RefCoreKnowledgeAreaId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICoreKnowledgeArea model)
        {
            IsBusy = true;
            Id = model.Id;
            RefCoreKnowledgeAreaId = model.RefCoreKnowledgeAreaId; // Early Learning Core Knowledge Area
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
