//**********************************************************
//* DomainName: Learning Resources
//* FileName:   PeerRatingSystemViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.LearningResources.ViewModels
{
     /// <summary>
     /// The PeerRatingSystem View Model
     /// </summary>
    public partial class PeerRatingSystemViewModel : ViewModelBase, Interfaces.IPeerRatingSystem
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PeerRatingSystem";

        // MaximumValue -- (backing property for Peer Rating System Maximum Value)
        private System.Decimal? _MaximumValue;

        // MinimumValue -- (backing property for Peer Rating System Minimum Value)
        private System.Decimal _MinimumValue;

        // Name -- (backing property for Peer Rating System Name)
        private System.String _Name;

        // OptimumValue -- (backing property for Peer Rating System Optimum Value)
        private System.Decimal? _OptimumValue;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Peer Rating System Maximum Value
        /// <para>
        ///  The maximum value allowed by the Peer Rating System.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20162">Peer Rating System Maximum Value</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? MaximumValue { get => _MaximumValue; set => SetProperty(ref _MaximumValue, value); }

        /// <summary>
        /// Peer Rating System Minimum Value
        /// <para>
        /// The minimum value allowed by the Peer Rating System.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20163">Peer Rating System Minimum Value</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal MinimumValue { get => _MinimumValue; set => SetProperty(ref _MinimumValue, value); }

        /// <summary>
        /// Peer Rating System Name
        /// <para>
        /// The name of the scaling system used to specify the Peer Rating.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20160">Peer Rating System Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// Peer Rating System Optimum Value
        /// <para>
        /// The optimum value allowed by the Peer Rating System.  The optimum or best rating may be the maximum value, the minimum value, or something in between.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20164">Peer Rating System Optimum Value</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? OptimumValue { get => _OptimumValue; set => SetProperty(ref _OptimumValue, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPeerRatingSystem model)
        {
            IsBusy = true;
            Id = model.Id;
            MaximumValue = model.MaximumValue; // Peer Rating System Maximum Value
            MinimumValue = model.MinimumValue; // Peer Rating System Minimum Value
            Name = model.Name; // Peer Rating System Name
            OptimumValue = model.OptimumValue; // Peer Rating System Optimum Value
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
