//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAdmissionTestViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentAdmissionTestViewModel
     /// </summary>
    public partial class PsStudentAdmissionTestViewModel : ViewModelBase, Interfaces.IPsStudentAdmissionTest
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentAdmissionTest";

        // member variable for the StandardizedAdmissionTestScore property
        private System.Decimal? _StandardizedAdmissionTestScore;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentAdmissionTestViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The quantitative score on a standardized admission test reported to a postsecondary institution.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19265">Standardized Admission Test Score</a>
        /// </para>
        /// </summary>
        [DisplayName("Standardized Admission Test Score")]
        public System.Decimal? StandardizedAdmissionTestScore { get => _StandardizedAdmissionTestScore; set => SetProperty(ref _StandardizedAdmissionTestScore, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentAdmissionTest model)
        {
            IsBusy = true;
            Id = model.Id;
            StandardizedAdmissionTestScore = model.StandardizedAdmissionTestScore; // Standardized Admission Test Score
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
