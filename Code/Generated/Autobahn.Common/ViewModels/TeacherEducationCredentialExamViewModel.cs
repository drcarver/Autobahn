//**********************************************************
//* DomainName: Common Models
//* FileName:   TeacherEducationCredentialExamViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The TeacherEducationCredentialExamViewModel
     /// </summary>
    public partial class TeacherEducationCredentialExamViewModel : ViewModelBase, Interfaces.ITeacherEducationCredentialExam
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from TeacherEducationCredentialExam";

        // member variable for the RefTeacherEducationTestCompanyId property
        private Guid? _RefTeacherEducationTestCompanyId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the TeacherEducationCredentialExamViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherEducationTestCompany"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19748">Teacher Education Test Company</a>
        /// </para>
        /// </summary>
        [DisplayName("Teacher Education Test Company")]
        public Guid? RefTeacherEducationTestCompanyId { get => _RefTeacherEducationTestCompanyId; set => SetProperty(ref _RefTeacherEducationTestCompanyId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ITeacherEducationCredentialExam model)
        {
            IsBusy = true;
            Id = model.Id;
            RefTeacherEducationTestCompanyId = model.RefTeacherEducationTestCompanyId; // Teacher Education Test Company
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
