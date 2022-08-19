//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildHealthViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildHealth View Model
     /// </summary>
    public partial class ELChildHealthViewModel : ViewModelBase, Interfaces.IELChildHealth
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildHealth";

        // member variable for the PersonId property
        private Guid _PersonId;

        // RefScheduledWellChildScreeningId -- (backing property for Scheduled Well Child Screening)
        private Guid? _RefScheduledWellChildScreeningId;

        // WellChildScreeningReceivedDate -- (backing property for Well Child Screening Received Date)
        private System.DateTime? _WellChildScreeningReceivedDate;

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
        /// Scheduled Well Child Screening
        /// <para>
        /// The individual well child visit scheduled according to the AAP recommended periodicity schedule.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20602">Scheduled Well Child Screening</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefScheduledWellChildScreeningId { get => _RefScheduledWellChildScreeningId; set => SetProperty(ref _RefScheduledWellChildScreeningId, value); }

        /// <summary>
        /// Well Child Screening Received Date
        /// <para>
        /// The year, month and day of a well child visit.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20612">Well Child Screening Received Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? WellChildScreeningReceivedDate { get => _WellChildScreeningReceivedDate; set => SetProperty(ref _WellChildScreeningReceivedDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildHealth model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId; // 
            RefScheduledWellChildScreeningId = model.RefScheduledWellChildScreeningId; // Scheduled Well Child Screening
            WellChildScreeningReceivedDate = model.WellChildScreeningReceivedDate; // Well Child Screening Received Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefScheduledWellChildScreening List
        /// <summary>
        /// The complete <see cref="RefScheduledWellChildScreening"> List
        /// </summary>
        private static List<ReferenceModelBase> RefScheduledWellChildScreeningList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("36df8f2c-12f5-4288-b70b-b60f18be599a"), Code="Newborn", Description="Newborn well child visit", Definition="Newborn well child visit.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("bca318b0-6396-4775-8d21-8db67d802606"), Code="3To5Days", Description="3 to 5 days well child visit", Definition="3 to 5 days well child visit.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("b950e081-477e-4757-8ef0-7ccd523d538e"), Code="1Month", Description="1 month well child visit", Definition="1 month well child visit.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("426510f0-68ab-4772-933d-c8788ef33a28"), Code="2Months", Description="2 months well child visit", Definition="2 months well child visit.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("98ab0605-2501-4c22-a5d1-5118653398ba"), Code="4Months", Description="4 months well child visit", Definition="4 months well child visit.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("14ce175d-3176-4af1-83d0-a527a9eac9d9"), Code="6Months", Description="6 months well child visit", Definition="6 months well child visit.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("a2f4dbff-f037-47cd-af5c-2da99cdfb608"), Code="9Months", Description="9 months well child visit", Definition="9 months well child visit.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("b21f4ba8-93fa-4782-b69b-79eb21e60a42"), Code="12Months", Description="12 months well child visit", Definition="12 months well child visit.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("71c22007-b208-49d4-90c5-2d6f8dee734f"), Code="15Months", Description="15 months well child visit", Definition="15 months well child visit.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("df56d45f-1766-4b7c-b46c-75fabbe06954"), Code="18Months", Description="18 months well child visit", Definition="18 months well child visit.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("03a0d087-5c35-4c23-a968-c184af35bc66"), Code="24Months", Description="24 months well child visit", Definition="24 months well child visit.", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("31d48447-def0-4303-a484-f387298e7507"), Code="30Months", Description="30 months well child visit", Definition="30 months well child visit.", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("ea01ee98-bf85-4492-afa8-66a1ed526f8f"), Code="36Months", Description="36 months well child visit", Definition="36 months well child visit.", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("430b8516-c8bd-4408-a315-e1ebce639417"), Code="48Months", Description="48 months well child visit", Definition="48 months well child visit.", SortOrder=Convert.ToDecimal("27.00") },
            new ReferenceModelBase { Id=Guid.Parse("b1e4f568-cf57-4967-a16f-dee779c37bf0"), Code="60Months", Description="60 months well child visit", Definition="60 months well child visit.", SortOrder=Convert.ToDecimal("29.00") },
        };
        #endregion
    }
}
