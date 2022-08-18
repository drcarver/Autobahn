//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonEmailAddressViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonEmailAddress View Model
     /// </summary>
    public partial class PersonEmailAddressViewModel : ViewModelBase, Interfaces.IPersonEmailAddress
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonEmailAddress";

        // DoNotPublishIndicator -- (backing property for Do Not Publish Indicator)
        private System.Boolean? _DoNotPublishIndicator;

        // EmailAddress -- (backing property for Electronic Mail Address)
        private System.String _EmailAddress;

        // member variable for the PersonId property
        private Guid _PersonId;

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
        public System.String EmailAddress { get => _EmailAddress; set => SetProperty(ref _EmailAddress, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

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
        public void Load(Interfaces.IPersonEmailAddress model)
        {
            IsBusy = true;
            Id = model.Id;
            DoNotPublishIndicator = model.DoNotPublishIndicator; // Do Not Publish Indicator
            EmailAddress = model.EmailAddress; // Electronic Mail Address
            PersonId = model.PersonId; // 
            RefEmailTypeId = model.RefEmailTypeId; // Electronic Mail Address Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
