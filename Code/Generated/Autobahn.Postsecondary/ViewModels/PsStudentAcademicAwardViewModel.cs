//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAcademicAwardViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentAcademicAwardViewModel
     /// </summary>
    public partial class PsStudentAcademicAwardViewModel : ViewModelBase, Interfaces.IPsStudentAcademicAward
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentAcademicAward";

        // member variable for the AcademicAwardDate property
        private System.String _AcademicAwardDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentAcademicAwardViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day or year and month on which the academic award was conferred.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19001">Academic Award Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Academic Award Date")]
        public System.String AcademicAwardDate { get => _AcademicAwardDate; set => SetProperty(ref _AcademicAwardDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentAcademicAward model)
        {
            IsBusy = true;
            Id = model.Id;
            AcademicAwardDate = model.AcademicAwardDate; // Academic Award Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
