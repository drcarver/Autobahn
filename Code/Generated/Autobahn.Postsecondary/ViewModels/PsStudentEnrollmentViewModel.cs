//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PSStudentEnrollmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PSStudentEnrollmentViewModel
     /// </summary>
    public partial class PSStudentEnrollmentViewModel : ViewModelBase, Interfaces.IPSStudentEnrollment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PSStudentEnrollment";

        // member variable for the DisplacedStudentStatus property
        private  _DisplacedStudentStatus;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  DisplacedStudentStatus { get => _DisplacedStudentStatus; set => SetProperty(ref _DisplacedStudentStatus, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPSStudentEnrollment model)
        {
            IsBusy = true;
            Id = model.Id;
            DisplacedStudentStatus = model.DisplacedStudentStatus; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
