//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonPersonalInformationVerificationViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonPersonalInformationVerification View Model
     /// </summary>
    public partial class PersonPersonalInformationVerificationViewModel : ViewModelBase, Interfaces.IPersonPersonalInformationVerification
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonPersonalInformationVerification";

        // member variable for the PersonAddressId property
        private Guid? _PersonAddressId;

        // member variable for the PersonDetailId property
        private Guid? _PersonDetailId;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the PersonTelephoneId property
        private Guid? _PersonTelephoneId;

        // RefPersonalInformationTypeId -- (backing property for Personal Information Type)
        private Guid? _RefPersonalInformationTypeId;

        // RefPersonalInformationVerificationId -- (backing property for Personal Information Verification)
        private Guid? _RefPersonalInformationVerificationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonAddress"/> model
        /// </summary>
        public Guid? PersonAddressId { get => _PersonAddressId; set => SetProperty(ref _PersonAddressId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonDetail"/> model
        /// </summary>
        public Guid? PersonDetailId { get => _PersonDetailId; set => SetProperty(ref _PersonDetailId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonTelephone"/> model
        /// </summary>
        public Guid? PersonTelephoneId { get => _PersonTelephoneId; set => SetProperty(ref _PersonTelephoneId, value); }

        /// <summary>
        /// Personal Information Type
        /// <para>
        /// The type of personal information verified through the Personal Information Verification evidence.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20951">Personal Information Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPersonalInformationTypeId { get => _RefPersonalInformationTypeId; set => SetProperty(ref _RefPersonalInformationTypeId, value); }

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

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonPersonalInformationVerification model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonAddressId = model.PersonAddressId; // 
            PersonDetailId = model.PersonDetailId; // 
            PersonId = model.PersonId; // 
            PersonTelephoneId = model.PersonTelephoneId; // 
            RefPersonalInformationTypeId = model.RefPersonalInformationTypeId; // Personal Information Type
            RefPersonalInformationVerificationId = model.RefPersonalInformationVerificationId; // Personal Information Verification
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefPersonalInformationType List
        /// <summary>
        /// The complete <see cref="RefPersonalInformationType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefPersonalInformationTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("26d140e3-b791-4a48-8df6-3e2b92f0d717"), Code="Address", Description="Address", Definition="Address is the type of personal information verified through the Personal Information Verification evidence.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("2dbd2c0a-20e0-440e-9028-65c28be95a87"), Code="Birthdate", Description="Birthdate", Definition="Birthdate is the type of personal information verified through the Personal Information Verification evidence.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("bdc88de7-7bc0-4486-b267-47a7a1268f2d"), Code="Name", Description="Name", Definition="Name is the type of personal information verified through the Personal Information Verification evidence.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("cd02a962-1d2c-4061-a185-37bbae0e9613"), Code="TelephoneNumber", Description="Telephone Number", Definition="Telephone Number is the type of personal information verified through the Personal Information Verification evidence.", SortOrder=Convert.ToDecimal("4.00") },
        };
        #endregion
    }
}
