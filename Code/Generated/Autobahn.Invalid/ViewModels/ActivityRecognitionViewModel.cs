//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ActivityRecognitionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ActivityRecognitionViewModel
     /// </summary>
    public partial class ActivityRecognitionViewModel : ViewModelBase, Interfaces.IActivityRecognition
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ActivityRecognition";

        // member variable for the RefActivityRecognitionTypeId property
        private Guid _RefActivityRecognitionTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ActivityRecognitionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefActivityRecognitionType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19229">Recognition for Participation or Performance in an Activity</a>
        /// </para>
        /// </summary>
        [DisplayName("Recognition for Participation or Performance in an Activity")]
        public Guid RefActivityRecognitionTypeId { get => _RefActivityRecognitionTypeId; set => SetProperty(ref _RefActivityRecognitionTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IActivityRecognition model)
        {
            IsBusy = true;
            Id = model.Id;
            RefActivityRecognitionTypeId = model.RefActivityRecognitionTypeId; // Recognition for Participation or Performance in an Activity
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
