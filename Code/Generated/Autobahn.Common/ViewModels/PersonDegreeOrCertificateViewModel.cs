//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDegreeOrCertificateViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDegreeOrCertificateViewModel
     /// </summary>
    public partial class PersonDegreeOrCertificateViewModel : ViewModelBase, Interfaces.IPersonDegreeOrCertificate
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonDegreeOrCertificate";

        // member variable for the AwardDate property
        private System.DateTime? _AwardDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonDegreeOrCertificateViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19081">Diploma or Credential Award Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Diploma or Credential Award Date")]
        public System.DateTime? AwardDate { get => _AwardDate; set => SetProperty(ref _AwardDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDegreeOrCertificate model)
        {
            IsBusy = true;
            Id = model.Id;
            AwardDate = model.AwardDate; // Diploma or Credential Award Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
