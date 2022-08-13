//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonMilitaryViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonMilitaryViewModel
     /// </summary>
    public partial class PersonMilitaryViewModel : ViewModelBase, Interfaces.IPersonMilitary
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonMilitary";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefMilitaryActiveStudentIndicatorId property
        private Guid? _RefMilitaryActiveStudentIndicatorId;

        // member variable for the RefMilitaryBranchId property
        private Guid? _RefMilitaryBranchId;

        // member variable for the RefMilitaryConnectedStudentIndicatorId property
        private Guid? _RefMilitaryConnectedStudentIndicatorId;

        // member variable for the RefMilitaryVeteranStudentIndicatorId property
        private Guid? _RefMilitaryVeteranStudentIndicatorId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonMilitaryViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryActiveStudentIndicator"/> model
        /// </summary>
        public Guid? RefMilitaryActiveStudentIndicatorId { get => _RefMilitaryActiveStudentIndicatorId; set => SetProperty(ref _RefMilitaryActiveStudentIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryBranch"/> model
        /// </summary>
        public Guid? RefMilitaryBranchId { get => _RefMilitaryBranchId; set => SetProperty(ref _RefMilitaryBranchId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryConnectedStudentIndicator"/> model
        /// </summary>
        public Guid? RefMilitaryConnectedStudentIndicatorId { get => _RefMilitaryConnectedStudentIndicatorId; set => SetProperty(ref _RefMilitaryConnectedStudentIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryVeteranStudentIndicator"/> model
        /// </summary>
        public Guid? RefMilitaryVeteranStudentIndicatorId { get => _RefMilitaryVeteranStudentIndicatorId; set => SetProperty(ref _RefMilitaryVeteranStudentIndicatorId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonMilitary model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            RefMilitaryActiveStudentIndicatorId = model.RefMilitaryActiveStudentIndicatorId;
            RefMilitaryBranchId = model.RefMilitaryBranchId;
            RefMilitaryConnectedStudentIndicatorId = model.RefMilitaryConnectedStudentIndicatorId;
            RefMilitaryVeteranStudentIndicatorId = model.RefMilitaryVeteranStudentIndicatorId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
