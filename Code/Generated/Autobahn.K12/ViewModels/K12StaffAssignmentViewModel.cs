//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StaffAssignmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StaffAssignmentViewModel
     /// </summary>
    public partial class K12StaffAssignmentViewModel : ViewModelBase, Interfaces.IK12StaffAssignment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StaffAssignment";

        // member variable for the RefK12StaffClassificationId property
        private Guid? _RefK12StaffClassificationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12StaffAssignmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12StaffClassification"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19087">K12 Staff Classification</a>
        /// </para>
        /// </summary>
        [DisplayName("K12 Staff Classification")]
        public Guid? RefK12StaffClassificationId { get => _RefK12StaffClassificationId; set => SetProperty(ref _RefK12StaffClassificationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StaffAssignment model)
        {
            IsBusy = true;
            Id = model.Id;
            RefK12StaffClassificationId = model.RefK12StaffClassificationId; // K12 Staff Classification
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
