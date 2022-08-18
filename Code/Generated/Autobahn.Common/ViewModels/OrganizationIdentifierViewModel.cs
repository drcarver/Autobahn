//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationIdentifierViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationIdentifier View Model
     /// </summary>
    public partial class OrganizationIdentifierViewModel : ViewModelBase, Interfaces.IOrganizationIdentifier
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationIdentifier";

        // Identifier -- (backing property for Course Identifier)
        private System.String _Identifier;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefOrganizationIdentificationSystemId -- (backing property for Course Code System)
        private Guid? _RefOrganizationIdentificationSystemId;

        // RefOrganizationIdentifierTypeId -- (backing property for Activity Identifier)
        private Guid? _RefOrganizationIdentifierTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Course Identifier
        /// <para>
        /// The actual code that identifies the organization of subject matter and related learning experiences provided for the instruction of students.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19055">Course Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Course Code System
        /// <para>
        /// A system that is used to identify the organization of subject matter and related learning experiences provided for the instruction of students.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19056">Course Code System</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefOrganizationIdentificationSystemId { get => _RefOrganizationIdentificationSystemId; set => SetProperty(ref _RefOrganizationIdentificationSystemId, value); }

        /// <summary>
        /// Activity Identifier
        /// <para>
        /// A unique number or alphanumeric code used in the local system to identify an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19006">Activity Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefOrganizationIdentifierTypeId { get => _RefOrganizationIdentifierTypeId; set => SetProperty(ref _RefOrganizationIdentifierTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationIdentifier model)
        {
            IsBusy = true;
            Id = model.Id;
            Identifier = model.Identifier; // Course Identifier
            OrganizationId = model.OrganizationId; // 
            RefOrganizationIdentificationSystemId = model.RefOrganizationIdentificationSystemId; // Course Code System
            RefOrganizationIdentifierTypeId = model.RefOrganizationIdentifierTypeId; // Activity Identifier
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefOrganizationentificationSystem List
        /// <summary>
        /// The complete <see cref="RefOrganizationentificationSystem"> List
        /// </summary>
        private static List<ReferenceModelBase> RefOrganizationentificationSystemList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefOrganizationentifierType List
        /// <summary>
        /// The complete <see cref="RefOrganizationentifierType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefOrganizationentifierTypeList = new List<ReferenceModelBase>
        {
        };
        #endregion
    }
}
