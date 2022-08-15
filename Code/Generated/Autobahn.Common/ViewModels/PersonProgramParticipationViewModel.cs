//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonProgramParticipationViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonProgramParticipationViewModel
     /// </summary>
    public partial class PersonProgramParticipationViewModel : ViewModelBase, Interfaces.IPersonProgramParticipation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonProgramParticipation";

        // member variable for the RefParticipationTypeId property
        private Guid? _RefParticipationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonProgramParticipationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParticipationType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19120">GED Preparation Program Participation Status</a>
        /// </para>
        /// </summary>
        [DisplayName("GED Preparation Program Participation Status")]
        public Guid? RefParticipationTypeId { get => _RefParticipationTypeId; set => SetProperty(ref _RefParticipationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonProgramParticipation model)
        {
            IsBusy = true;
            Id = model.Id;
            RefParticipationTypeId = model.RefParticipationTypeId; // GED Preparation Program Participation Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
