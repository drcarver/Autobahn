//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12ProgramOrServiceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12ProgramOrServiceViewModel
     /// </summary>
    public partial class K12ProgramOrServiceViewModel : ViewModelBase, Interfaces.IK12ProgramOrService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12ProgramOrService";

        // member variable for the RefMepSessionTypeId property
        private Guid? _RefMepSessionTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12ProgramOrServiceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepSessionType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19187">Migrant Education Program Session Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Migrant Education Program Session Type")]
        public Guid? RefMepSessionTypeId { get => _RefMepSessionTypeId; set => SetProperty(ref _RefMepSessionTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12ProgramOrService model)
        {
            IsBusy = true;
            Id = model.Id;
            RefMepSessionTypeId = model.RefMepSessionTypeId; // Migrant Education Program Session Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
