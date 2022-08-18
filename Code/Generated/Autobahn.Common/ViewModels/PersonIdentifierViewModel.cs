//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonIdentifierViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonIdentifier View Model
     /// </summary>
    public partial class PersonIdentifierViewModel : ViewModelBase, Interfaces.IPersonIdentifier
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonIdentifier";

        // Identifier -- (backing property for Staff Member Identifier)
        private System.String _Identifier;

        // member variable for the PersonId property
        private Guid _PersonId;

        // RefPersonalInformationVerificationId -- (backing property for Personal Information Verification)
        private Guid? _RefPersonalInformationVerificationId;

        // RefPersonIdentificationSystemId -- (backing property for Staff Member Identification System)
        private Guid _RefPersonIdentificationSystemId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Staff Member Identifier
        /// <para>
        /// A unique number or alphanumeric code assigned to a staff member by a school, school system, a state, registry, or other agency or entity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19156">Staff Member Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Personal Information Verification
        /// <para>
        /// The evidence by which a persons name, address, date of birth, etc. is confirmed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19611">Personal Information Verification</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPersonalInformationVerificationId { get => _RefPersonalInformationVerificationId; set => SetProperty(ref _RefPersonalInformationVerificationId, value); }

        /// <summary>
        /// Staff Member Identification System
        /// <para>
        /// A coding scheme that is used for identification and record-keeping purposes by schools, social services, registry, or other agencies to refer to a staff member.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19162">Staff Member Identification System</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefPersonIdentificationSystemId { get => _RefPersonIdentificationSystemId; set => SetProperty(ref _RefPersonIdentificationSystemId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonIdentifier model)
        {
            IsBusy = true;
            Id = model.Id;
            Identifier = model.Identifier; // Staff Member Identifier
            PersonId = model.PersonId; // 
            RefPersonalInformationVerificationId = model.RefPersonalInformationVerificationId; // Personal Information Verification
            RefPersonIdentificationSystemId = model.RefPersonIdentificationSystemId; // Staff Member Identification System
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefPersonentificationSystem List
        /// <summary>
        /// The complete <see cref="RefPersonentificationSystem"> List
        /// </summary>
        private static List<ReferenceModelBase> RefPersonentificationSystemList = new List<ReferenceModelBase>
        {
        };
        #endregion
    }
}
