//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaTitleISupportServiceViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaTitleISupportService View Model
     /// </summary>
    public partial class K12LeaTitleISupportServiceViewModel : ViewModelBase, Interfaces.IK12LeaTitleISupportService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaTitleISupportService";

        // member variable for the K12LeaId property
        private Guid _K12LeaId;

        // RefK12LeaTitleISupportServiceId -- (backing property for Title I Support Services)
        private Guid _RefK12LeaTitleISupportServiceId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12Lea"/> model
        /// </summary>
        public Guid K12LeaId { get => _K12LeaId; set => SetProperty(ref _K12LeaId, value); }

        /// <summary>
        /// Title I Support Services
        /// <para>
        /// The type of support services provided to students in Title I programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19289">Title I Support Services</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefK12LeaTitleISupportServiceId { get => _RefK12LeaTitleISupportServiceId; set => SetProperty(ref _RefK12LeaTitleISupportServiceId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaTitleISupportService model)
        {
            IsBusy = true;
            Id = model.Id;
            K12LeaId = model.K12LeaId; // 
            RefK12LeaTitleISupportServiceId = model.RefK12LeaTitleISupportServiceId; // Title I Support Services
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefK12LeaTitleISupportService List
        /// <summary>
        /// The complete <see cref="RefK12LeaTitleISupportService"> List
        /// </summary>
        private static List<ReferenceModelBase> RefK12LeaTitleISupportServiceList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("d428a51e-1141-438a-9973-bbdada990573"), Code="HealthDentalEyeCare", Description="Health, Dental and Eye Care", Definition="Health, Dental and Eye Care is the type of support services provided to students in Title I programs.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("b34f7a11-bbf7-4c80-9773-e22e49f7d683"), Code="GuidanceAdvocacy", Description="Supporting Guidance/Advocacy", Definition="Supporting Guidance/Advocacy is the type of support services provided to students in Title I programs.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("b34ab642-8aec-452e-a413-9c1edb5705ec"), Code="Other", Description="Other", Definition="Any other type of support services provided to students in Title I programs.", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion
    }
}
