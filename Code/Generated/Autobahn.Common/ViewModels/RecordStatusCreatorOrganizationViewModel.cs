//**********************************************************
//* DomainName: Common Models
//* FileName:   RecordStatusCreatorOrganizationViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RecordStatusCreatorOrganization View Model
     /// </summary>
    public partial class RecordStatusCreatorOrganizationViewModel : ViewModelBase, Interfaces.IRecordStatusCreatorOrganization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RecordStatusCreatorOrganization";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRecordStatusCreatorOrganization model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}