//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonMilitaryViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonMilitary View Model
     /// </summary>
    public partial class PersonMilitaryViewModel : ViewModelBase, Interfaces.IPersonMilitary
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonMilitary";

        // member variable for the PersonId property
        private Guid _PersonId;

        // RefMilitaryActiveStudentIndicatorId -- (backing property for Military Active Student Indicator)
        private Guid? _RefMilitaryActiveStudentIndicatorId;

        // RefMilitaryBranchId -- (backing property for Military Branch)
        private Guid? _RefMilitaryBranchId;

        // RefMilitaryConnectedStudentIndicatorId -- (backing property for Military Connected Student Indicator)
        private Guid? _RefMilitaryConnectedStudentIndicatorId;

        // RefMilitaryVeteranStudentIndicatorId -- (backing property for Military Veteran Student Indicator)
        private Guid? _RefMilitaryVeteranStudentIndicatorId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Military Active Student Indicator
        /// <para>
        /// An indication that the student is currently serving on Active Duty, in the National Guard, or in the Reserve components of the United States military services
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20556">Military Active Student Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefMilitaryActiveStudentIndicatorId { get => _RefMilitaryActiveStudentIndicatorId; set => SetProperty(ref _RefMilitaryActiveStudentIndicatorId, value); }

        /// <summary>
        /// Military Branch
        /// <para>
        /// A branch of the U.S. Military applicable for specifying more details when using Military Connected Student Indicator, Military Active Student Indicator,  Military Veteran Student Indicator, and Military Enlistment After Exit elements.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20621">Military Branch</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefMilitaryBranchId { get => _RefMilitaryBranchId; set => SetProperty(ref _RefMilitaryBranchId, value); }

        /// <summary>
        /// Military Connected Student Indicator
        /// <para>
        /// An indication that the student's parent or guardian is on Active Duty, in the National Guard, or in the Reserve components of the United States military services
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20555">Military Connected Student Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefMilitaryConnectedStudentIndicatorId { get => _RefMilitaryConnectedStudentIndicatorId; set => SetProperty(ref _RefMilitaryConnectedStudentIndicatorId, value); }

        /// <summary>
        /// Military Veteran Student Indicator
        /// <para>
        /// An indication that the student is a veteran who served on Active Duty, in the National Guard, or in the Reserve components of the United States military services
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20557">Military Veteran Student Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefMilitaryVeteranStudentIndicatorId { get => _RefMilitaryVeteranStudentIndicatorId; set => SetProperty(ref _RefMilitaryVeteranStudentIndicatorId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonMilitary model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId; // 
            RefMilitaryActiveStudentIndicatorId = model.RefMilitaryActiveStudentIndicatorId; // Military Active Student Indicator
            RefMilitaryBranchId = model.RefMilitaryBranchId; // Military Branch
            RefMilitaryConnectedStudentIndicatorId = model.RefMilitaryConnectedStudentIndicatorId; // Military Connected Student Indicator
            RefMilitaryVeteranStudentIndicatorId = model.RefMilitaryVeteranStudentIndicatorId; // Military Veteran Student Indicator
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefMilitaryActiveStudentIndicator List
        /// <summary>
        /// The complete <see cref="RefMilitaryActiveStudentIndicator"> List
        /// </summary>
        private static List<ReferenceModelBase> RefMilitaryActiveStudentIndicatorList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("971f1059-51b8-4d47-aaeb-7dc4faab49e3"), Code="NotActive", Description="Not Active", Definition="Student is not active in the military.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("28e68afd-1f4b-4ace-822b-05519c04bf3b"), Code="Active", Description="Active", Definition="Student is an Active member of the Active Duty Forces, National Guard, or Reserve Forces.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("e79fec6d-8532-47c0-8569-137f6a03e1f3"), Code="Unknown", Description="Unknown", Definition="It is unknown whether or not the Student is active in the military.", SortOrder=Convert.ToDecimal("5.00") },
        };
        #endregion

        #region RefMilitaryBranch List
        /// <summary>
        /// The complete <see cref="RefMilitaryBranch"> List
        /// </summary>
        private static List<ReferenceModelBase> RefMilitaryBranchList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("5368af4a-d70b-40a2-8377-4c34293bcb8d"), Code="Army", Description="Army", Definition="U.S. Army", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("7ef0ad28-1140-47c4-a6b2-28d72831762c"), Code="MarineCorps", Description="Marine Corps", Definition="U.S. Marine Corps", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("355087fe-9242-4946-98d1-549f56f4847b"), Code="Navy", Description="Navy", Definition="U.S. Navy", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("7a10bea1-487e-447c-ab7d-f97350e25689"), Code="AirForce", Description="Air Force", Definition="U.S.  Air Force", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("5b80d2a2-afbf-4d0b-b2f6-17a75b64e9e9"), Code="SpaceForce", Description="Space Force", Definition="U.S. Space Force", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("0525e598-8a21-4101-9d48-6c312258272a"), Code="CoastGuard", Description="Coast Guard", Definition="U.S. Coast Guard", SortOrder=Convert.ToDecimal("6.00") },
        };
        #endregion

        #region RefMilitaryConnectedStudentIndicator List
        /// <summary>
        /// The complete <see cref="RefMilitaryConnectedStudentIndicator"> List
        /// </summary>
        private static List<ReferenceModelBase> RefMilitaryConnectedStudentIndicatorList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("71f267b4-0c94-4db2-be1e-be7e3e6407c9"), Code="NotMilitaryConnected", Description="Not Military Connected", Definition="Student is not military-connected.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("e0ffbad1-3ce5-4999-adf5-a0734731fdd7"), Code="ActiveDuty", Description="Active Duty", Definition="Student is a dependent of a member of the Active Duty Forces (full-time) Army, Navy, Air Force, Marine Corps, or Coast Guard or is a dependent of a member on Full-Time National Guard Duty.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("ddfc372a-7ecd-4080-85f2-25aaa3641feb"), Code="NationalGuardOrReserve", Description="National Guard Or Reserve", Definition="Student is a dependent of a member of the National Guard (not full-time duty) or Reserve Forces (Army, Navy, Air Force, Marine Corps, or Coast Guard).", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("2b00c382-e83e-4218-a284-f58bc6da6a92"), Code="Unknown", Description="Unknown", Definition="It is unknown whether or not the student is military-connected.", SortOrder=Convert.ToDecimal("7.00") },
        };
        #endregion

        #region RefMilitaryVeteranStudentIndicator List
        /// <summary>
        /// The complete <see cref="RefMilitaryVeteranStudentIndicator"> List
        /// </summary>
        private static List<ReferenceModelBase> RefMilitaryVeteranStudentIndicatorList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("01313a63-d201-4c80-b45a-72b2501a21e8"), Code="NotVeteran", Description="Not a Veteran", Definition="Student is not a veteran of the military.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("4cb04728-b30a-4406-bd72-f925ca3fac4e"), Code="Veteran", Description="Veteran", Definition="Student is a Veteran of the Active Duty Forces, National Guard, or Reserve Forces.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("1ae1d9cf-c967-4585-94c8-ddbc6565beb4"), Code="Unknown", Description="Unknown", Definition="It is unknown whether or not the Student is a veteran of the military.", SortOrder=Convert.ToDecimal("5.00") },
        };
        #endregion
    }
}
