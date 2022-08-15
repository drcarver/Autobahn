//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentLevelsForWhichDesignedViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentLevelsForWhichDesignedViewModel
     /// </summary>
    public partial class AssessmentLevelsForWhichDesignedViewModel : ViewModelBase, Interfaces.IAssessmentLevelsForWhichDesigned
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentLevelsForWhichDesigned";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentLevelsForWhichDesignedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentLevelsForWhichDesigned model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
