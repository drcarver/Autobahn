//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELEnrollmentOtherFundingViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELEnrollmentOtherFunding View Model
     /// </summary>
    public partial class ELEnrollmentOtherFundingViewModel : ViewModelBase, Interfaces.IELEnrollmentOtherFunding
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELEnrollmentOtherFunding";

        // member variable for the PersonId property
        private Guid _PersonId;

        // RefELOtherFederalFundingSourcesId -- (backing property for Early Learning Other Federal Funding Sources)
        private Guid _RefELOtherFederalFundingSourcesId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Early Learning Other Federal Funding Sources
        /// <para>
        /// The other contributing funding sources.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20302">Early Learning Other Federal Funding Sources</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefELOtherFederalFundingSourcesId { get => _RefELOtherFederalFundingSourcesId; set => SetProperty(ref _RefELOtherFederalFundingSourcesId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELEnrollmentOtherFunding model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId; // 
            RefELOtherFederalFundingSourcesId = model.RefELOtherFederalFundingSourcesId; // Early Learning Other Federal Funding Sources
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
