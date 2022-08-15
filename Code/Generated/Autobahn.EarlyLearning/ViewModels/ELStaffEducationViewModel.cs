//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELStaffEducationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELStaffEducationViewModel
     /// </summary>
    public partial class ELStaffEducationViewModel : ViewModelBase, Interfaces.IELStaffEducation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELStaffEducation";

        // member variable for the RefELLevelOfSpecializationId property
        private Guid? _RefELLevelOfSpecializationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELStaffEducationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELLevelOfSpecialization"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19340">Level of Specialization in Early Learning</a>
        /// </para>
        /// </summary>
        [DisplayName("Level of Specialization in Early Learning")]
        public Guid? RefELLevelOfSpecializationId { get => _RefELLevelOfSpecializationId; set => SetProperty(ref _RefELLevelOfSpecializationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELStaffEducation model)
        {
            IsBusy = true;
            Id = model.Id;
            RefELLevelOfSpecializationId = model.RefELLevelOfSpecializationId; // Level of Specialization in Early Learning
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
