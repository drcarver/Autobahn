//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDigitalAccessSpeedViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDigitalAccessSpeed View Model
     /// </summary>
    public partial class PersonDigitalAccessSpeedViewModel : ViewModelBase, Interfaces.IPersonDigitalAccessSpeed
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonDigitalAccessSpeed";

        // InternetDownloadSpeed -- (backing property for Internet Download Speed)
        private System.Decimal? _InternetDownloadSpeed;

        // InternetSpeedTestDateTime -- (backing property for Internet Speed Test Date Time)
        private System.DateTime? _InternetSpeedTestDateTime;

        // InternetUploadSpeed -- (backing property for Internet Upload Speed)
        private System.Decimal? _InternetUploadSpeed;

        // member variable for the PersonDigitalAccessId property
        private Guid? _PersonDigitalAccessId;

        // member variable for the PersonLearningDeviceId property
        private Guid? _PersonLearningDeviceId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Internet Download Speed
        /// <para>
        /// The speed that data or information can be downloaded from a server on the internet to one's device in megabits per second.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20938">Internet Download Speed</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? InternetDownloadSpeed { get => _InternetDownloadSpeed; set => SetProperty(ref _InternetDownloadSpeed, value); }

        /// <summary>
        /// Internet Speed Test Date Time
        /// <para>
        /// The date and, optionally, time that the information was gathered.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20940">Internet Speed Test Date Time</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? InternetSpeedTestDateTime { get => _InternetSpeedTestDateTime; set => SetProperty(ref _InternetSpeedTestDateTime, value); }

        /// <summary>
        /// Internet Upload Speed
        /// <para>
        /// The speed that data or information can be sent from one's device to another device or server on the internet in megabits per second.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20941">Internet Upload Speed</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? InternetUploadSpeed { get => _InternetUploadSpeed; set => SetProperty(ref _InternetUploadSpeed, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonDigitalAccess"/> model
        /// </summary>
        public Guid? PersonDigitalAccessId { get => _PersonDigitalAccessId; set => SetProperty(ref _PersonDigitalAccessId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonLearningDevice"/> model
        /// </summary>
        public Guid? PersonLearningDeviceId { get => _PersonLearningDeviceId; set => SetProperty(ref _PersonLearningDeviceId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDigitalAccessSpeed model)
        {
            IsBusy = true;
            Id = model.Id;
            InternetDownloadSpeed = model.InternetDownloadSpeed; // Internet Download Speed
            InternetSpeedTestDateTime = model.InternetSpeedTestDateTime; // Internet Speed Test Date Time
            InternetUploadSpeed = model.InternetUploadSpeed; // Internet Upload Speed
            PersonDigitalAccessId = model.PersonDigitalAccessId; // 
            PersonLearningDeviceId = model.PersonLearningDeviceId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
