//**********************************************************
//* DomainName: Common Models
//* FileName:   TeacherStudentDataLinkExclusionViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The TeacherStudentDataLinkExclusionViewModel
     /// </summary>
    public partial class TeacherStudentDataLinkExclusionViewModel : ViewModelBase, Interfaces.ITeacherStudentDataLinkExclusion
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from TeacherStudentDataLinkExclusion";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the TeacherStudentDataLinkExclusionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ITeacherStudentDataLinkExclusion model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
