//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefAssociationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencyDefAssociationViewModel
     /// </summary>
    public partial class CompetencyDefAssociationViewModel : ViewModelBase, Interfaces.ICompetencyDefAssociation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CompetencyDefAssociation";

        // member variable for the AssociatedEntityId property
        private Guid _AssociatedEntityId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CompetencyDefAssociationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssociatedEntity"/> model
        /// </summary>
        [DisplayName("Competency Definition Prerequisite Identifier")]
        public Guid AssociatedEntityId { get => _AssociatedEntityId; set => SetProperty(ref _AssociatedEntityId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencyDefAssociation model)
        {
            IsBusy = true;
            Id = model.Id;
            AssociatedEntityId = model.AssociatedEntityId; // Competency Definition Prerequisite Identifier
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region "ICommands for Navigation Properties"
        /// <summary>
        /// The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
        /// <para>
        /// <a href="">Competency Definition Prerequisite Identifier</a>
        /// </para>
        /// </summary>
        public ICommand AssociatedEntityCommand { get; set; }

        #endregion
    }
}
