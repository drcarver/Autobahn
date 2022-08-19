//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDemographicRaceViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDemographicRace View Model
     /// </summary>
    public partial class PersonDemographicRaceViewModel : ViewModelBase, Interfaces.IPersonDemographicRace
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonDemographicRace";

        // FederalRaceAndEthnicityDeclined -- (backing property for Federal Race and Ethnicity Declined)
        private System.Boolean? _FederalRaceAndEthnicityDeclined;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefRaceId property
        private Guid _RefRaceId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Federal Race and Ethnicity Declined
        /// <para>
        /// A parent, guardian, or student declined to report sufficient information for identifying a student's federal race and/or ethnicity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20932">Federal Race and Ethnicity Declined</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? FederalRaceAndEthnicityDeclined { get => _FederalRaceAndEthnicityDeclined; set => SetProperty(ref _FederalRaceAndEthnicityDeclined, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRace"/> model
        /// </summary>
        public Guid RefRaceId { get => _RefRaceId; set => SetProperty(ref _RefRaceId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDemographicRace model)
        {
            IsBusy = true;
            Id = model.Id;
            FederalRaceAndEthnicityDeclined = model.FederalRaceAndEthnicityDeclined; // Federal Race and Ethnicity Declined
            PersonId = model.PersonId; // 
            RefRaceId = model.RefRaceId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefRace List
        /// <summary>
        /// The complete <see cref="RefRace"> List
        /// </summary>
        private static List<ReferenceModelBase> RefRaceList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("917a529f-d0a6-42b6-80a8-ae06ff2fe7b4"), Code="RaceAmericanIndianorAlaskaNative", Description="American Indian or Alaska Native", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("29cb3007-03a3-4595-ab1f-a7dbf9a74a73"), Code="RaceAsian", Description="Asian", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("6c1a14f0-c967-4940-b572-ae0e14c7afdb"), Code="RaceBlackorAfricanAmerican", Description="Black or African American", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("2c8b9a06-d2ee-4a2e-9dbf-7b9116595552"), Code="RaceNativeHawaiianorOtherPacificIslander", Description="Native Hawaiian or Other Pacific Islander", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("469341ff-93e0-4d8d-a6e1-54bf0f4b35b6"), Code="RaceWhite", Description="White", Definition="", SortOrder=Convert.ToDecimal("") },
        };
        #endregion
    }
}
