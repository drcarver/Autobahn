//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonHealthBirthViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonHealthBirth View Model
     /// </summary>
    public partial class PersonHealthBirthViewModel : ViewModelBase, Interfaces.IPersonHealthBirth
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonHealthBirth";

        // MultipleBirthIndicator -- (backing property for Multiple Birth Indicator)
        private System.Boolean? _MultipleBirthIndicator;

        // member variable for the PersonId property
        private Guid _PersonId;

        // RefTrimesterWhenPrenatalCareBeganId -- (backing property for Trimester When Prenatal Care Began)
        private Guid? _RefTrimesterWhenPrenatalCareBeganId;

        // WeeksOfGestation -- (backing property for Weeks of Gestation)
        private System.Int32? _WeeksOfGestation;

        // WeightAtBirth -- (backing property for Weight at Birth)
        private System.String _WeightAtBirth;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Multiple Birth Indicator
        /// <para>
        /// An indication that the person is a twin, triplet, etc.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19421">Multiple Birth Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? MultipleBirthIndicator { get => _MultipleBirthIndicator; set => SetProperty(ref _MultipleBirthIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Trimester When Prenatal Care Began
        /// <para>
        /// The trimester of pregnancy in which a child's mother began receiving prenatal health care.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20611">Trimester When Prenatal Care Began</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTrimesterWhenPrenatalCareBeganId { get => _RefTrimesterWhenPrenatalCareBeganId; set => SetProperty(ref _RefTrimesterWhenPrenatalCareBeganId, value); }

        /// <summary>
        /// Weeks of Gestation
        /// <para>
        /// The number of weeks during gestational period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19313">Weeks of Gestation</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? WeeksOfGestation { get => _WeeksOfGestation; set => SetProperty(ref _WeeksOfGestation, value); }

        /// <summary>
        /// Weight at Birth
        /// <para>
        /// The weight of a child at birth in pounds and ounces.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19312">Weight at Birth</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String WeightAtBirth { get => _WeightAtBirth; set => SetProperty(ref _WeightAtBirth, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonHealthBirth model)
        {
            IsBusy = true;
            Id = model.Id;
            MultipleBirthIndicator = model.MultipleBirthIndicator; // Multiple Birth Indicator
            PersonId = model.PersonId; // 
            RefTrimesterWhenPrenatalCareBeganId = model.RefTrimesterWhenPrenatalCareBeganId; // Trimester When Prenatal Care Began
            WeeksOfGestation = model.WeeksOfGestation; // Weeks of Gestation
            WeightAtBirth = model.WeightAtBirth; // Weight at Birth
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefTrimesterWhenPrenatalCareBegan List
        /// <summary>
        /// The complete <see cref="RefTrimesterWhenPrenatalCareBegan"> List
        /// </summary>
        private static List<ReferenceModelBase> RefTrimesterWhenPrenatalCareBeganList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("1e2b06a7-078e-405e-b382-2e4bbfb2e597"), Code="FirstTrimester", Description="First trimester", Definition="The  child's mother began receiving prenatal health care in the first trimester.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("91fadc10-87a6-4cba-85e3-47fa620872f0"), Code="SecondTrimester", Description="Second trimester", Definition="The  child's mother began receiving prenatal health care in the second trimester.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("249b26ac-b82e-47ec-8966-0d0499c614f5"), Code="ThirdTrimester", Description="Third trimester", Definition="The  child's mother began receiving prenatal health care in the third trimester.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("02570374-0d71-4be6-adfa-1a8e9abe0081"), Code="NoPrenatalHealthCare", Description="No prenatal health care", Definition="The  child's mother did not receive prenatal health care.", SortOrder=Convert.ToDecimal("7.00") },
        };
        #endregion
    }
}
