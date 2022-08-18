//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaSafeDrugFreeViewModel.cs
//* Name:       Safe and Drug Free Baseline
//* Definition: The baseline of the performance indicator of student behavior under the Safe and Drug-Free Schools and Communities Act.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The baseline of the performance indicator of student behavior under the Safe and Drug-Free Schools and Communities Act.
     /// </summary>
    public partial class K12LeaSafeDrugFreeViewModel : ViewModelBase, Interfaces.IK12LeaSafeDrugFree
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaSafeDrugFree";

        // Baseline -- (backing property for Safe and Drug Free Baseline)
        private System.String _Baseline;

        // BaselineYear -- (backing property for Safe and Drug Free Baseline Year)
        private System.String _BaselineYear;

        // CollectionFrequency -- (backing property for Safe and Drug Free Collection Frequency)
        private System.String _CollectionFrequency;

        // IndicatorName -- (backing property for Safe and Drug Free Indicator Name)
        private System.String _IndicatorName;

        // Instrument -- (backing property for Safe and Drug Free Instrument)
        private System.String _Instrument;

        // member variable for the K12LeaId property
        private Guid _K12LeaId;

        // MostRecentCollection -- (backing property for Safe and Drug Free Year Most Recent Collection)
        private System.String _MostRecentCollection;

        // Performance -- (backing property for Safe and Drug Free Performance)
        private System.String _Performance;

        // Target -- (backing property for Safe and Drug Free Target)
        private System.String _Target;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Safe and Drug Free Baseline
        /// <para>
        /// The baseline of the performance indicator of student behavior under the Safe and Drug-Free Schools and Communities Act.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19468">Safe and Drug Free Baseline</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Baseline { get => _Baseline; set => SetProperty(ref _Baseline, value); }

        /// <summary>
        /// Safe and Drug Free Baseline Year
        /// <para>
        /// The academic year the baseline was established.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19469">Safe and Drug Free Baseline Year</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String BaselineYear { get => _BaselineYear; set => SetProperty(ref _BaselineYear, value); }

        /// <summary>
        /// Safe and Drug Free Collection Frequency
        /// <para>
        ///  The frequency of data collection for performance indicator under the Safe and Drug-Free Schools and Communities Act.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19463">Safe and Drug Free Collection Frequency</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CollectionFrequency { get => _CollectionFrequency; set => SetProperty(ref _CollectionFrequency, value); }

        /// <summary>
        /// Safe and Drug Free Indicator Name
        /// <para>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19461">Safe and Drug Free Indicator Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String IndicatorName { get => _IndicatorName; set => SetProperty(ref _IndicatorName, value); }

        /// <summary>
        /// Safe and Drug Free Instrument
        /// <para>
        /// The instrument or data source for reported performance indicator of student behavior under the Safe and Drug-Free Schools and Communities Act.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19462">Safe and Drug Free Instrument</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Instrument { get => _Instrument; set => SetProperty(ref _Instrument, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12Lea"/> model
        /// </summary>
        public Guid K12LeaId { get => _K12LeaId; set => SetProperty(ref _K12LeaId, value); }

        /// <summary>
        /// Safe and Drug Free Year Most Recent Collection
        /// <para>
        /// The academic year of the most recent collection of the performance indicator under the Sage and Drug-Free Schools and Communities Act.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19464">Safe and Drug Free Year Most Recent Collection</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String MostRecentCollection { get => _MostRecentCollection; set => SetProperty(ref _MostRecentCollection, value); }

        /// <summary>
        /// Safe and Drug Free Performance
        /// <para>
        /// Actual performance for the given  indicator of student behavior under the Safe and Drug-Free Schools and Communities Act
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19466">Safe and Drug Free Performance</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Performance { get => _Performance; set => SetProperty(ref _Performance, value); }

        /// <summary>
        /// Safe and Drug Free Target
        /// <para>
        /// The targeted performance for the given  indicator of student behavior under the Safe and Drug-Free Schools and Communities Act.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19465">Safe and Drug Free Target</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Target { get => _Target; set => SetProperty(ref _Target, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaSafeDrugFree model)
        {
            IsBusy = true;
            Id = model.Id;
            Baseline = model.Baseline; // Safe and Drug Free Baseline
            BaselineYear = model.BaselineYear; // Safe and Drug Free Baseline Year
            CollectionFrequency = model.CollectionFrequency; // Safe and Drug Free Collection Frequency
            IndicatorName = model.IndicatorName; // Safe and Drug Free Indicator Name
            Instrument = model.Instrument; // Safe and Drug Free Instrument
            K12LeaId = model.K12LeaId; // 
            MostRecentCollection = model.MostRecentCollection; // Safe and Drug Free Year Most Recent Collection
            Performance = model.Performance; // Safe and Drug Free Performance
            Target = model.Target; // Safe and Drug Free Target
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
