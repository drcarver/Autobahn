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
            new ReferenceModelBase { Id=Guid.Parse("c0b1211e-3525-40de-ad08-0135e59d430e"), Code="NotShared", Description="Not Shared", Definition="The primary learning device is not shared with another individual.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("405cf2e0-4342-4fd2-af82-aaccf92a3afc"), Code="Shared", Description="Shared", Definition="The primary learning device is shared with another individual.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("c44548fd-1c7d-492d-a62c-0c387dece12a"), Code="Unknown", Description="Unknown", Definition="It is not known whether the primary learning device is shared with another individual.", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion

        #region RefPrimaryLearningDeviceAwayFromSchool List
        /// <summary>
        /// The complete <see cref="RefPrimaryLearningDeviceAwayFromSchool"> List
        /// </summary>
        private static List<ReferenceModelBase> RefPrimaryLearningDeviceAwayFromSchoolList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("bbe42e74-25f5-4b8f-8936-b0a3d99246c4"), Code="Chromebook", Description="Chromebook", Definition="A Chromebook is the type of device the student uses most often to complete learning activities away from school.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("2e0d923c-05da-4a72-ad75-02d1060a111a"), Code="DesktopComputer", Description="Desktop Computer", Definition="A desktop computer is the type of device the student uses most often to complete learning activities away from school.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("eee4dc64-8df6-484a-995a-1bc880a65abb"), Code="LaptopComputer", Description="Laptop Computer", Definition="A Laptop Computer is the type of device the student uses most often to complete learning activities away from school.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("a2797df9-94bd-4135-9abd-046548fa6231"), Code="None", Description="None", Definition="There is not a device the student uses to complete learning activities away from school.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("2d9f9dc7-be15-4b57-a07c-3e5b92cd0624"), Code="Smartphone", Description="Smartphone", Definition="A Smartphone is the type of device the student uses most often to complete learning activities away from school.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("d89388bf-cfb6-45b9-bc9e-a0263b3cda8e"), Code="Tablet", Description="Tablet", Definition="A Tablet is the type of device the student uses most often to complete learning activities away from school.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("18f064bc-a518-47ef-bb39-b14381215fde"), Code="Other", Description="Other", Definition="The type of device the student uses most often to complete learning activities away from school is not yet defined.", SortOrder=Convert.ToDecimal("99.00") },
        };
        #endregion

        #region RefPrimaryLearningDeviceProvider List
        /// <summary>
        /// The complete <see cref="RefPrimaryLearningDeviceProvider"> List
        /// </summary>
        private static List<ReferenceModelBase> RefPrimaryLearningDeviceProviderList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("f7bc7e1b-a014-49b5-ad09-d93014a1c8b4"), Code="Personal", Description="Personal", Definition="The provider of the primary learning device is the student or guardian.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("7eacae43-1485-40f4-9202-999073f83b8c"), Code="School", Description="School", Definition="The provider of the primary learning device is the school.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("736d5290-c02c-41a9-bd91-913542571602"), Code="Other", Description="Other", Definition="The provider of the primary learning device is not yet defined.", SortOrder=Convert.ToDecimal("99.00") },
        };
        #endregion
    }
}
