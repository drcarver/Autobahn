//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationEmailViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationEmail View Model
     /// </summary>
    public partial class OrganizationEmailViewModel : ViewModelBase, Interfaces.IOrganizationEmail
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationEmail";

        // DoNotPublishIndicator -- (backing property for Do Not Publish Indicator)
        private System.Boolean? _DoNotPublishIndicator;

        // ElectronicMailAddress -- (backing property for Electronic Mail Address)
        private System.String _ElectronicMailAddress;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefEmailTypeId -- (backing property for Electronic Mail Address Type)
        private Guid? _RefEmailTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Do Not Publish Indicator
        /// <para>
        /// An indication that the record should not be published.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20905">Do Not Publish Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? DoNotPublishIndicator { get => _DoNotPublishIndicator; set => SetProperty(ref _DoNotPublishIndicator, value); }

        /// <summary>
        /// Electronic Mail Address
        /// <para>
        /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19088">Electronic Mail Address</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ElectronicMailAddress { get => _ElectronicMailAddress; set => SetProperty(ref _ElectronicMailAddress, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Electronic Mail Address Type
        /// <para>
        /// The type of electronic mail (e-mail) address listed for a person or organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19089">Electronic Mail Address Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefEmailTypeId { get => _RefEmailTypeId; set => SetProperty(ref _RefEmailTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationEmail model)
        {
            IsBusy = true;
            Id = model.Id;
            DoNotPublishIndicator = model.DoNotPublishIndicator; // Do Not Publish Indicator
            ElectronicMailAddress = model.ElectronicMailAddress; // Electronic Mail Address
            OrganizationId = model.OrganizationId; // 
            RefEmailTypeId = model.RefEmailTypeId; // Electronic Mail Address Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
