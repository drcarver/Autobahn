//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonLearningDeviceViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonLearningDevice View Model
     /// </summary>
    public partial class PersonLearningDeviceViewModel : ViewModelBase, Interfaces.IPersonLearningDevice
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonLearningDevice";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefPrimaryLearningDeviceAccessId -- (backing property for Primary Learning Device Access)
        private Guid? _RefPrimaryLearningDeviceAccessId;

        // RefPrimaryLearningDeviceAwayFromSchoolId -- (backing property for Primary Learning Device Away From School)
        private Guid? _RefPrimaryLearningDeviceAwayFromSchoolId;

        // RefPrimaryLearningDeviceProviderId -- (backing property for Primary Learning Device Provider)
        private Guid? _RefPrimaryLearningDeviceProviderId;

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
        /// Primary Learning Device Access
        /// <para>
        /// An indication of whether the primary learning device is shared or not shared with another individual
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20952">Primary Learning Device Access</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPrimaryLearningDeviceAccessId { get => _RefPrimaryLearningDeviceAccessId; set => SetProperty(ref _RefPrimaryLearningDeviceAccessId, value); }

        /// <summary>
        /// Primary Learning Device Away From School
        /// <para>
        /// The type of device the student uses most often to complete learning activities away from school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20953">Primary Learning Device Away From School</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPrimaryLearningDeviceAwayFromSchoolId { get => _RefPrimaryLearningDeviceAwayFromSchoolId; set => SetProperty(ref _RefPrimaryLearningDeviceAwayFromSchoolId, value); }

        /// <summary>
        /// Primary Learning Device Provider
        /// <para>
        /// The provider of the primary learning device.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20954">Primary Learning Device Provider</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPrimaryLearningDeviceProviderId { get => _RefPrimaryLearningDeviceProviderId; set => SetProperty(ref _RefPrimaryLearningDeviceProviderId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonLearningDevice model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefPrimaryLearningDeviceAccessId = model.RefPrimaryLearningDeviceAccessId; // Primary Learning Device Access
            RefPrimaryLearningDeviceAwayFromSchoolId = model.RefPrimaryLearningDeviceAwayFromSchoolId; // Primary Learning Device Away From School
            RefPrimaryLearningDeviceProviderId = model.RefPrimaryLearningDeviceProviderId; // Primary Learning Device Provider
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefPrimaryLearningDeviceAccess List
        /// <summary>
        /// The complete <see cref="RefPrimaryLearningDeviceAccess"> List
        /// </summary>
        private static List<ReferenceModelBase> RefPrimaryLearningDeviceAccessList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("d24ed7f3-4127-4ae4-aa99-41baa978a74d"), Code="NotShared", Description="Not Shared", Definition="The primary learning device is not shared with another individual.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("cafeb6a0-8bba-4e6f-be96-db7d270a4692"), Code="Shared", Description="Shared", Definition="The primary learning device is shared with another individual.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("e08534cb-be67-4b30-a5da-44591614c5dc"), Code="Unknown", Description="Unknown", Definition="It is not known whether the primary learning device is shared with another individual.", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion

        #region RefPrimaryLearningDeviceAwayFromSchool List
        /// <summary>
        /// The complete <see cref="RefPrimaryLearningDeviceAwayFromSchool"> List
        /// </summary>
        private static List<ReferenceModelBase> RefPrimaryLearningDeviceAwayFromSchoolList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("f60290f6-3600-48d0-af0f-5b3416b08c23"), Code="Chromebook", Description="Chromebook", Definition="A Chromebook is the type of device the student uses most often to complete learning activities away from school.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("5c19adb2-bc26-458c-ab96-dbd6b5f4d75c"), Code="DesktopComputer", Description="Desktop Computer", Definition="A desktop computer is the type of device the student uses most often to complete learning activities away from school.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("2f77a169-1b76-4cf6-a385-aa555f28c551"), Code="LaptopComputer", Description="Laptop Computer", Definition="A Laptop Computer is the type of device the student uses most often to complete learning activities away from school.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("7a37229f-33d1-4eff-b99d-9511f8ac6745"), Code="None", Description="None", Definition="There is not a device the student uses to complete learning activities away from school.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("4f087f32-0113-42d0-b53a-77a01486502d"), Code="Smartphone", Description="Smartphone", Definition="A Smartphone is the type of device the student uses most often to complete learning activities away from school.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("f002c331-f28e-483a-b892-8373dd72a831"), Code="Tablet", Description="Tablet", Definition="A Tablet is the type of device the student uses most often to complete learning activities away from school.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("29201250-be9d-4b96-abbb-f267b0de2e55"), Code="Other", Description="Other", Definition="The type of device the student uses most often to complete learning activities away from school is not yet defined.", SortOrder=Convert.ToDecimal("99.00") },
        };
        #endregion

        #region RefPrimaryLearningDeviceProvider List
        /// <summary>
        /// The complete <see cref="RefPrimaryLearningDeviceProvider"> List
        /// </summary>
        private static List<ReferenceModelBase> RefPrimaryLearningDeviceProviderList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("67938185-61ae-4654-ae75-aff3f4cb4e0f"), Code="Personal", Description="Personal", Definition="The provider of the primary learning device is the student or guardian.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("e23e639e-cb57-4d3e-9a4b-ac3b08642b9b"), Code="School", Description="School", Definition="The provider of the primary learning device is the school.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("ba512ee1-0ef0-437e-8bfa-82b60f0e2ef8"), Code="Other", Description="Other", Definition="The provider of the primary learning device is not yet defined.", SortOrder=Convert.ToDecimal("99.00") },
        };
        #endregion
    }
}
