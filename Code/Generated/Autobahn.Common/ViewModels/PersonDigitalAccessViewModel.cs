//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDigitalAccessViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDigitalAccess View Model
     /// </summary>
    public partial class PersonDigitalAccessViewModel : ViewModelBase, Interfaces.IPersonDigitalAccess
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonDigitalAccess";

        // InternetAccessInResidence -- (backing property for Internet Access In Residence)
        private System.Boolean? _InternetAccessInResidence;

        // member variable for the PersonAddressId property
        private Guid? _PersonAddressId;

        // member variable for the PersonId property
        private Guid _PersonId;

        // RefBarrierToInternetAccessInResidenceId -- (backing property for Barrier to Internet Access In Residence)
        private Guid? _RefBarrierToInternetAccessInResidenceId;

        // RefInternetAccessTypeInResidenceId -- (backing property for Internet Access Type In Residence)
        private Guid? _RefInternetAccessTypeInResidenceId;

        // RefInternetPerformanceInResidenceId -- (backing property for Internet Performance In Residence)
        private Guid? _RefInternetPerformanceInResidenceId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Internet Access In Residence
        /// <para>
        /// An indication of whether the student is able to access the internet in their primary place of residence.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20936">Internet Access In Residence</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? InternetAccessInResidence { get => _InternetAccessInResidence; set => SetProperty(ref _InternetAccessInResidence, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonAddress"/> model
        /// </summary>
        public Guid? PersonAddressId { get => _PersonAddressId; set => SetProperty(ref _PersonAddressId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Barrier to Internet Access In Residence
        /// <para>
        /// An indication of the barrier to having internet access in the student's primary place of residence.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20916">Barrier to Internet Access In Residence</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBarrierToInternetAccessInResidenceId { get => _RefBarrierToInternetAccessInResidenceId; set => SetProperty(ref _RefBarrierToInternetAccessInResidenceId, value); }

        /// <summary>
        /// Internet Access Type In Residence
        /// <para>
        /// The primary type of internet service used in the student's primary place of residence.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20937">Internet Access Type In Residence</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefInternetAccessTypeInResidenceId { get => _RefInternetAccessTypeInResidenceId; set => SetProperty(ref _RefInternetAccessTypeInResidenceId, value); }

        /// <summary>
        /// Internet Performance In Residence
        /// <para>
        /// An indication of whether the student can complete the full range of learning activities, including video streaming and assignment upload, without interruptions caused by poor internet performance in their primary place of residence.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20939">Internet Performance In Residence</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefInternetPerformanceInResidenceId { get => _RefInternetPerformanceInResidenceId; set => SetProperty(ref _RefInternetPerformanceInResidenceId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDigitalAccess model)
        {
            IsBusy = true;
            Id = model.Id;
            InternetAccessInResidence = model.InternetAccessInResidence; // Internet Access In Residence
            PersonAddressId = model.PersonAddressId; // 
            PersonId = model.PersonId; // 
            RefBarrierToInternetAccessInResidenceId = model.RefBarrierToInternetAccessInResidenceId; // Barrier to Internet Access In Residence
            RefInternetAccessTypeInResidenceId = model.RefInternetAccessTypeInResidenceId; // Internet Access Type In Residence
            RefInternetPerformanceInResidenceId = model.RefInternetPerformanceInResidenceId; // Internet Performance In Residence
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
