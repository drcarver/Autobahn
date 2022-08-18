//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAddressNcesSideViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonAddressNcesSide View Model
     /// </summary>
    public partial class PersonAddressNcesSideViewModel : ViewModelBase, Interfaces.IPersonAddressNcesSide
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonAddressNcesSide";

        // NcesSideDateProcessed -- (backing property for NCES SIDE Date Processed)
        private System.DateTime? _NcesSideDateProcessed;

        // NcesSideEstimate -- (backing property for NCES SIDE Estimate)
        private System.Decimal? _NcesSideEstimate;

        // NcesSideStandardError -- (backing property for NCES SIDE Standard Error)
        private System.Decimal? _NcesSideStandardError;

        // NcesSideVintageBeginYear -- (backing property for NCES SIDE Vintage Begin Year)
        private System.String _NcesSideVintageBeginYear;

        // NcesSideVintageEndYear -- (backing property for NCES SIDE Vintage End Year)
        private System.String _NcesSideVintageEndYear;

        // member variable for the PersonAddressId property
        private Guid _PersonAddressId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// NCES SIDE Date Processed
        /// <para>
        /// The year, month, and day on which the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE) was processed through the BlindSIDE resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20943">NCES SIDE Date Processed</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? NcesSideDateProcessed { get => _NcesSideDateProcessed; set => SetProperty(ref _NcesSideDateProcessed, value); }

        /// <summary>
        /// NCES SIDE Estimate
        /// <para>
        /// The National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE) based on the person's latitude and longitude location.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20944">NCES SIDE Estimate</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? NcesSideEstimate { get => _NcesSideEstimate; set => SetProperty(ref _NcesSideEstimate, value); }

        /// <summary>
        /// NCES SIDE Standard Error
        /// <para>
        /// The standard error applied to the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20945">NCES SIDE Standard Error</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? NcesSideStandardError { get => _NcesSideStandardError; set => SetProperty(ref _NcesSideStandardError, value); }

        /// <summary>
        /// NCES SIDE Vintage Begin Year
        /// <para>
        /// The begin year for the American Community Survey (ACS) period estimates used to construct the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20946">NCES SIDE Vintage Begin Year</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String NcesSideVintageBeginYear { get => _NcesSideVintageBeginYear; set => SetProperty(ref _NcesSideVintageBeginYear, value); }

        /// <summary>
        /// NCES SIDE Vintage End Year
        /// <para>
        /// The end year for the American Community Survey (ACS) period estimates used to construct the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20947">NCES SIDE Vintage End Year</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String NcesSideVintageEndYear { get => _NcesSideVintageEndYear; set => SetProperty(ref _NcesSideVintageEndYear, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonAddress"/> model
        /// </summary>
        public Guid PersonAddressId { get => _PersonAddressId; set => SetProperty(ref _PersonAddressId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonAddressNcesSide model)
        {
            IsBusy = true;
            Id = model.Id;
            NcesSideDateProcessed = model.NcesSideDateProcessed; // NCES SIDE Date Processed
            NcesSideEstimate = model.NcesSideEstimate; // NCES SIDE Estimate
            NcesSideStandardError = model.NcesSideStandardError; // NCES SIDE Standard Error
            NcesSideVintageBeginYear = model.NcesSideVintageBeginYear; // NCES SIDE Vintage Begin Year
            NcesSideVintageEndYear = model.NcesSideVintageEndYear; // NCES SIDE Vintage End Year
            PersonAddressId = model.PersonAddressId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
