//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SeaFederalFundAllocationViewModel.cs
//* Name:       Federal Program Code
//* Definition: The unique five-digit number assigned to each federal program as listed in the Catalog of Federal Domestic Assistance (CFDA) Programs.  See http://www.cfda.gov/.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The unique five-digit number assigned to each federal program as listed in the Catalog of Federal Domestic Assistance (CFDA) Programs.  See http://www.cfda.gov/.
     /// </summary>
    public partial class K12SeaFederalFundAllocationViewModel : ViewModelBase, Interfaces.IK12SeaFederalFundAllocation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12SeaFederalFundAllocation";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12SeaFederalFundAllocation model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
