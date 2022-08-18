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
            new ReferenceModelBase { Id=Guid.Parse("17898cb8-1977-4538-9f21-9b922569234e"), Code="NotActive", Description="Not Active", Definition="Student is not active in the military.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("355fcccc-cf56-48eb-81a3-ac6bc5f498f4"), Code="Active", Description="Active", Definition="Student is an Active member of the Active Duty Forces, National Guard, or Reserve Forces.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("2620f974-6191-458e-8c14-9c63ab5cbfe9"), Code="Unknown", Description="Unknown", Definition="It is unknown whether or not the Student is active in the military.", SortOrder=Convert.ToDecimal("5.00") },
        };
        #endregion

        #region RefMilitaryBranch List
        /// <summary>
        /// The complete <see cref="RefMilitaryBranch"> List
        /// </summary>
        private static List<ReferenceModelBase> RefMilitaryBranchList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("40d0e1f9-515e-41d9-80a4-f5752153bf7c"), Code="Army", Description="Army", Definition="U.S. Army", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("d9eb9c9e-33ad-45cf-a7ef-f885a8399795"), Code="MarineCorps", Description="Marine Corps", Definition="U.S. Marine Corps", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("c2ea7ac5-decb-4fe8-b2b2-11c7d42ad2bb"), Code="Navy", Description="Navy", Definition="U.S. Navy", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("488c6282-b435-421f-a349-c39300a5649b"), Code="AirForce", Description="Air Force", Definition="U.S.  Air Force", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("bda8a427-68ec-450f-be1b-de54169a28fc"), Code="SpaceForce", Description="Space Force", Definition="U.S. Space Force", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("4c72d123-b4d5-4a84-b355-f323dbd8e6c7"), Code="CoastGuard", Description="Coast Guard", Definition="U.S. Coast Guard", SortOrder=Convert.ToDecimal("6.00") },
        };
        #endregion

        #region RefMilitaryConnectedStudentIndicator List
        /// <summary>
        /// The complete <see cref="RefMilitaryConnectedStudentIndicator"> List
        /// </summary>
        private static List<ReferenceModelBase> RefMilitaryConnectedStudentIndicatorList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("9bbafd88-797d-47ad-a128-bea6305aaf1d"), Code="NotMilitaryConnected", Description="Not Military Connected", Definition="Student is not military-connected.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("f048a4e2-a16f-4b5e-b22c-ec64793f4aa9"), Code="ActiveDuty", Description="Active Duty", Definition="Student is a dependent of a member of the Active Duty Forces (full-time) Army, Navy, Air Force, Marine Corps, or Coast Guard or is a dependent of a member on Full-Time National Guard Duty.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("f308cf5e-77f5-431b-8c32-1b0d0d2a40de"), Code="NationalGuardOrReserve", Description="National Guard Or Reserve", Definition="Student is a dependent of a member of the National Guard (not full-time duty) or Reserve Forces (Army, Navy, Air Force, Marine Corps, or Coast Guard).", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("5df3f518-ca0e-45b6-94fa-25eaa74641ef"), Code="Unknown", Description="Unknown", Definition="It is unknown whether or not the student is military-connected.", SortOrder=Convert.ToDecimal("7.00") },
        };
        #endregion

        #region RefMilitaryVeteranStudentIndicator List
        /// <summary>
        /// The complete <see cref="RefMilitaryVeteranStudentIndicator"> List
        /// </summary>
        private static List<ReferenceModelBase> RefMilitaryVeteranStudentIndicatorList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("3b9f37a3-6c2c-4a2b-a935-1db3209f9b48"), Code="NotVeteran", Description="Not a Veteran", Definition="Student is not a veteran of the military.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("c884fc13-0b66-4c01-81c0-ebf0ebe925ce"), Code="Veteran", Description="Veteran", Definition="Student is a Veteran of the Active Duty Forces, National Guard, or Reserve Forces.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("8e6df294-d6b1-478a-b49e-cba815f2efa6"), Code="Unknown", Description="Unknown", Definition="It is unknown whether or not the Student is a veteran of the military.", SortOrder=Convert.ToDecimal("5.00") },
        };
        #endregion
    }
}
