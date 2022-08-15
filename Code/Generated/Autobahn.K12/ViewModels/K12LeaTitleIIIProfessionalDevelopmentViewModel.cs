//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaTitleIIIProfessionalDevelopmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaTitleIIIProfessionalDevelopmentViewModel
     /// </summary>
    public partial class K12LeaTitleIIIProfessionalDevelopmentViewModel : ViewModelBase, Interfaces.IK12LeaTitleIIIProfessionalDevelopment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaTitleIIIProfessionalDevelopment";

        // member variable for the RefTitleIIIProfessionalDevelopmentTypeId property
        private Guid _RefTitleIIIProfessionalDevelopmentTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12LeaTitleIIIProfessionalDevelopmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIIIProfessionalDevelopmentType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19478">Title III Professional Development Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Title III Professional Development Type")]
        public Guid RefTitleIIIProfessionalDevelopmentTypeId { get => _RefTitleIIIProfessionalDevelopmentTypeId; set => SetProperty(ref _RefTitleIIIProfessionalDevelopmentTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaTitleIIIProfessionalDevelopment model)
        {
            IsBusy = true;
            Id = model.Id;
            RefTitleIIIProfessionalDevelopmentTypeId = model.RefTitleIIIProfessionalDevelopmentTypeId; // Title III Professional Development Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
