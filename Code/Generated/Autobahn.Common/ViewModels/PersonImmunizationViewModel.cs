//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonImmunizationViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonImmunization View Model
     /// </summary>
    public partial class PersonImmunizationViewModel : ViewModelBase, Interfaces.IPersonImmunization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonImmunization";

        // ImmunizationDate -- (backing property for Immunization Date)
        private System.DateTime _ImmunizationDate;

        // member variable for the PersonId property
        private Guid _PersonId;

        // RefImmunizationTypeId -- (backing property for Immunization Type)
        private Guid _RefImmunizationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Immunization Date
        /// <para>
        /// The year, month and day of an immunization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19306">Immunization Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime ImmunizationDate { get => _ImmunizationDate; set => SetProperty(ref _ImmunizationDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Immunization Type
        /// <para>
        /// An indication of the type of immunization that an individual has satisfactorily received. (Note: The International Classification of Diseases (ICD) is maintained by the World Health Organization. The ICD is revised periodically to incorporate changes in the medical field, the most updated and detailed list of International Statistical Classification of Diseases and Related Health Problems can be found at http://www.who.int/classifications/apps/icd/icd10online).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20214">Immunization Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefImmunizationTypeId { get => _RefImmunizationTypeId; set => SetProperty(ref _RefImmunizationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonImmunization model)
        {
            IsBusy = true;
            Id = model.Id;
            ImmunizationDate = model.ImmunizationDate; // Immunization Date
            PersonId = model.PersonId; // 
            RefImmunizationTypeId = model.RefImmunizationTypeId; // Immunization Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
