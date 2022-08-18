//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffTechnicalAssistanceViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffTechnicalAssistance View Model
     /// </summary>
    public partial class StaffTechnicalAssistanceViewModel : ViewModelBase, Interfaces.IStaffTechnicalAssistance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffTechnicalAssistance";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefTechnicalAssistanceDeliveryTypeId -- (backing property for Technical Assistance Delivery Type)
        private Guid? _RefTechnicalAssistanceDeliveryTypeId;

        // RefTechnicalAssistanceTypeId -- (backing property for Technical Assistance Type)
        private Guid? _RefTechnicalAssistanceTypeId;

        // TechnicalAssistanceApprovedInd -- (backing property for Technical Assistance Approved Indicator)
        private System.Boolean? _TechnicalAssistanceApprovedInd;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Technical Assistance Delivery Type
        /// <para>
        /// The method of delivery of technical assistance received/provided
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20466">Technical Assistance Delivery Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTechnicalAssistanceDeliveryTypeId { get => _RefTechnicalAssistanceDeliveryTypeId; set => SetProperty(ref _RefTechnicalAssistanceDeliveryTypeId, value); }

        /// <summary>
        /// Technical Assistance Type
        /// <para>
        /// The type of technical assistance provided.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20467">Technical Assistance Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTechnicalAssistanceTypeId { get => _RefTechnicalAssistanceTypeId; set => SetProperty(ref _RefTechnicalAssistanceTypeId, value); }

        /// <summary>
        /// Technical Assistance Approved Indicator
        /// <para>
        /// Indicates whether or not the technical assistance was approved.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20465">Technical Assistance Approved Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? TechnicalAssistanceApprovedInd { get => _TechnicalAssistanceApprovedInd; set => SetProperty(ref _TechnicalAssistanceApprovedInd, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffTechnicalAssistance model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefTechnicalAssistanceDeliveryTypeId = model.RefTechnicalAssistanceDeliveryTypeId; // Technical Assistance Delivery Type
            RefTechnicalAssistanceTypeId = model.RefTechnicalAssistanceTypeId; // Technical Assistance Type
            TechnicalAssistanceApprovedInd = model.TechnicalAssistanceApprovedInd; // Technical Assistance Approved Indicator
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
