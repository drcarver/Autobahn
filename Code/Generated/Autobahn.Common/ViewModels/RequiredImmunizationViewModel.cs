//**********************************************************
//* DomainName: Common Models
//* FileName:   RequiredImmunizationViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RequiredImmunization View Model
     /// </summary>
    public partial class RequiredImmunizationViewModel : ViewModelBase, Interfaces.IRequiredImmunization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RequiredImmunization";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefImmunizationTypeId -- (backing property for Required Immunization)
        private Guid _RefImmunizationTypeId;

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
        /// Required Immunization
        /// <para>
        /// An indication that an immunization is specifically required by an organization or governing body.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19307">Required Immunization</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefImmunizationTypeId { get => _RefImmunizationTypeId; set => SetProperty(ref _RefImmunizationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRequiredImmunization model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId; // 
            RefImmunizationTypeId = model.RefImmunizationTypeId; // Required Immunization
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
