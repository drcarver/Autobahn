//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonHealthViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonHealthViewModel
     /// </summary>
    public partial class PersonHealthViewModel : ViewModelBase, Interfaces.IPersonHealth
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonHealth";

        // member variable for the RefVisionScreeningStatusId property
        private Guid? _RefVisionScreeningStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonHealthViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefVisionScreeningStatus"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19308">Vision Screening Status</a>
        /// </para>
        /// </summary>
        [DisplayName("Vision Screening Status")]
        public Guid? RefVisionScreeningStatusId { get => _RefVisionScreeningStatusId; set => SetProperty(ref _RefVisionScreeningStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonHealth model)
        {
            IsBusy = true;
            Id = model.Id;
            RefVisionScreeningStatusId = model.RefVisionScreeningStatusId; // Vision Screening Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
