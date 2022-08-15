//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IEPPresentLevelViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IEPPresentLevelViewModel
     /// </summary>
    public partial class IEPPresentLevelViewModel : ViewModelBase, Interfaces.IIEPPresentLevel
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IEPPresentLevel";

        // member variable for the AcademicDescription property
        private System.String _AcademicDescription;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IEPPresentLevelViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20686">IEP Present Level Academic Description</a>
        /// </para>
        /// </summary>
        [DisplayName("IEP Present Level Academic Description")]
        public System.String AcademicDescription { get => _AcademicDescription; set => SetProperty(ref _AcademicDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIEPPresentLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            AcademicDescription = model.AcademicDescription; // IEP Present Level Academic Description
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
