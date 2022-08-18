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
            new ReferenceModelBase { Id=Guid.Parse("21b220bc-b606-4727-83c7-1abdf243e78d"), Code="Newborn", Description="Newborn well child visit", Definition="Newborn well child visit.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("d185faf3-c851-49c7-891a-fff3d25da8ea"), Code="3To5Days", Description="3 to 5 days well child visit", Definition="3 to 5 days well child visit.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("fc299d62-8ce3-43fa-9b38-2f4cda1f91c6"), Code="1Month", Description="1 month well child visit", Definition="1 month well child visit.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("89af8bb7-167a-4acc-873e-93e2cd7bdecc"), Code="2Months", Description="2 months well child visit", Definition="2 months well child visit.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("22ba391a-bca5-4cba-9bda-7712da3bc999"), Code="4Months", Description="4 months well child visit", Definition="4 months well child visit.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("9fe95982-2c17-4d70-a0e7-3300e2f3660d"), Code="6Months", Description="6 months well child visit", Definition="6 months well child visit.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("7a1585cf-d92c-4507-8d92-97e7c8e359f1"), Code="9Months", Description="9 months well child visit", Definition="9 months well child visit.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("6a2bfdf4-5a08-4427-8cad-dd3e00463a4a"), Code="12Months", Description="12 months well child visit", Definition="12 months well child visit.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("5aed71b9-a983-44e9-8a1a-a5cd63bc8475"), Code="15Months", Description="15 months well child visit", Definition="15 months well child visit.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("53268268-5a6e-4b31-be95-bd6560776750"), Code="18Months", Description="18 months well child visit", Definition="18 months well child visit.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("29a0944a-a727-4f8e-bb97-bac0051d0e2d"), Code="24Months", Description="24 months well child visit", Definition="24 months well child visit.", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("14ff4e19-a972-4ab5-adff-b9920fa7d77a"), Code="30Months", Description="30 months well child visit", Definition="30 months well child visit.", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("a721dfae-2d03-461a-8a3f-a15323faa7fa"), Code="36Months", Description="36 months well child visit", Definition="36 months well child visit.", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("c5e21d65-f426-4ca2-84b4-5dcff63a7aaa"), Code="48Months", Description="48 months well child visit", Definition="48 months well child visit.", SortOrder=Convert.ToDecimal("27.00") },
            new ReferenceModelBase { Id=Guid.Parse("9603314e-7aeb-4ef1-80c3-157baae498c4"), Code="60Months", Description="60 months well child visit", Definition="60 months well child visit.", SortOrder=Convert.ToDecimal("29.00") },
        };
        #endregion
    }
}
