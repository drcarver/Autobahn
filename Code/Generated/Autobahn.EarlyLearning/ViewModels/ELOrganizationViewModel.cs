//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELOrganization View Model
     /// </summary>
    public partial class ELOrganizationViewModel : ViewModelBase, Interfaces.IELOrganization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELOrganization";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefProfitStatusId -- (backing property for Facility Profit Status)
        private Guid? _RefProfitStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Facility Profit Status
        /// <para>
        /// An indication of the for-profit status of a facility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19834">Facility Profit Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefProfitStatusId { get => _RefProfitStatusId; set => SetProperty(ref _RefProfitStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELOrganization model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId; // 
            RefProfitStatusId = model.RefProfitStatusId; // Facility Profit Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefProfitStatus List
        /// <summary>
        /// The complete <see cref="RefProfitStatus"> List
        /// </summary>
        private static List<ReferenceModelBase> RefProfitStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("5b8d44ca-6561-4857-a912-e829c8f5cf2f"), Code="ForProfit", Description="For-profit facility", Definition="The facility is for-profit.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("dc9857e6-b9d5-424e-96ac-1200f777c819"), Code="NonProfit", Description="Non-profit facility", Definition="The facility is non-profit.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("c269eb3f-01f0-44d1-81a8-fec94498a293"), Code="GovernmentRun", Description="Government run facility", Definition="The facility is government run.", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion
    }
}
