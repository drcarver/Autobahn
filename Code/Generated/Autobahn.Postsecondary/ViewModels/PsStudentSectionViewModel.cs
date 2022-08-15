//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentSectionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentSectionViewModel
     /// </summary>
    public partial class PsStudentSectionViewModel : ViewModelBase, Interfaces.IPsStudentSection
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentSection";

        // member variable for the AcademicGrade property
        private System.String _AcademicGrade;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentSectionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19053">Course Academic Grade</a>
        /// </para>
        /// </summary>
        [DisplayName("Course Academic Grade")]
        public System.String AcademicGrade { get => _AcademicGrade; set => SetProperty(ref _AcademicGrade, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentSection model)
        {
            IsBusy = true;
            Id = model.Id;
            AcademicGrade = model.AcademicGrade; // Course Academic Grade
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
