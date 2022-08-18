//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PSStudentEnrollmentViewModel.cs
//* Name:       Displaced Student Status
//* Definition: A student who was enrolled, or eligible for enrollment, but has enrolled in another place because of a crisis.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// A student who was enrolled, or eligible for enrollment, but has enrolled in another place because of a crisis.
     /// </summary>
    public partial class PSStudentEnrollmentViewModel : ViewModelBase, Interfaces.IPSStudentEnrollment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PSStudentEnrollment";

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
        public void Load(Interfaces.IPSStudentEnrollment model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
