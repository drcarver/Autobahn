//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceEducationLevelViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.LearningResources.ViewModels
{
     /// <summary>
     /// The LearningResourceEducationLevel View Model
     /// </summary>
    public partial class LearningResourceEducationLevelViewModel : ViewModelBase, Interfaces.ILearningResourceEducationLevel
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResourceEducationLevel";

        // member variable for the LearningResourceId property
        private Guid _LearningResourceId;

        // RefEducationLevelId -- (backing property for Learning Resource Education Level�)
        private Guid _RefEducationLevelId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResource"/> model
        /// </summary>
        public Guid LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        /// <summary>
        /// Learning Resource Education Level�
        /// <para>
        /// The education level, grade level or primary instructional level at which a Learning Resource is intended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20212">Learning Resource Education Level�</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefEducationLevelId { get => _RefEducationLevelId; set => SetProperty(ref _RefEducationLevelId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResourceEducationLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            LearningResourceId = model.LearningResourceId; // 
            RefEducationLevelId = model.RefEducationLevelId; // Learning Resource Education Level�
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
