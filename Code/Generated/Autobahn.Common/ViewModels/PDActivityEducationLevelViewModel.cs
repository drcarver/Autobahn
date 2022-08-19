//**********************************************************
//* DomainName: Common Models
//* FileName:   PDActivityEducationLevelViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PDActivityEducationLevel View Model
     /// </summary>
    public partial class PDActivityEducationLevelViewModel : ViewModelBase, Interfaces.IPDActivityEducationLevel
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PDActivityEducationLevel";

        // member variable for the ProfessionalDevelopmentActivityId property
        private Guid _ProfessionalDevelopmentActivityId;

        // RefPDActivityEducationLevelsAddressedId -- (backing property for Professional Development Activity Education Levels Addressed)
        private Guid _RefPDActivityEducationLevelsAddressedId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentActivity"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get => _ProfessionalDevelopmentActivityId; set => SetProperty(ref _ProfessionalDevelopmentActivityId, value); }

        /// <summary>
        /// Professional Development Activity Education Levels Addressed
        /// <para>
        /// An age group or education level to which the professional development activity's content pertains.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20245">Professional Development Activity Education Levels Addressed</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefPDActivityEducationLevelsAddressedId { get => _RefPDActivityEducationLevelsAddressedId; set => SetProperty(ref _RefPDActivityEducationLevelsAddressedId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPDActivityEducationLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            ProfessionalDevelopmentActivityId = model.ProfessionalDevelopmentActivityId; // 
            RefPDActivityEducationLevelsAddressedId = model.RefPDActivityEducationLevelsAddressedId; // Professional Development Activity Education Levels Addressed
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefPDActivityEducationLevelsAddressed List
        /// <summary>
        /// The complete <see cref="RefPDActivityEducationLevelsAddressed"> List
        /// </summary>
        private static List<ReferenceModelBase> RefPDActivityEducationLevelsAddressedList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("9e0117e8-301a-4e8f-ae81-96c5e6626b18"), Code="IN", Description="Infant", Definition="Infant is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("73309d06-2f8f-4793-a274-c6bed292a3c1"), Code="TO", Description="Toddler", Definition="Toddler is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("2fd024b4-2014-44e2-ad75-70f204dd0b3d"), Code="PR", Description="Preschool", Definition="Preschool is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("1f9ce111-2767-44e5-b872-5aad38c096f6"), Code="PK", Description="Prekindergarten", Definition="Prekindergarten is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("678edaa1-a538-4160-8125-574d76000043"), Code="TK", Description="Transitional Kindergarten", Definition="Transitional Kindergarten is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("5285e617-9db5-419e-8b9b-da1f48e58ddf"), Code="KG", Description="Kindergarten", Definition="Kindergarten is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("a4f2e0ee-c17f-4044-862b-2a18bb56668c"), Code="01", Description="First grade", Definition="First grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("a555ce20-c691-4a3f-8609-3a085ae88cde"), Code="02", Description="Second grade", Definition="Second grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("05c12e70-3c18-4620-adcb-efa9dee94d16"), Code="03", Description="Third grade", Definition="Third grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("6400516e-f45a-4df8-b5cc-68d029f5a266"), Code="04", Description="Fourth grade", Definition="Fourth grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("600e212e-b65a-49d2-90d9-07e977f21bdd"), Code="05", Description="Fifth grade", Definition="Fifth grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("75a315cf-e802-4b16-9d5d-786f15d68331"), Code="06", Description="Sixth grade", Definition="Sixth grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("43300b88-54bb-4d28-9549-08f4d95dcb2c"), Code="07", Description="Seventh grade", Definition="Seventh grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("334ec001-908c-4f85-9fb1-3bef459462c0"), Code="08", Description="Eighth grade", Definition="Eighth grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("27.00") },
            new ReferenceModelBase { Id=Guid.Parse("63863e9b-4c5b-4e3d-8f3b-5097105629b0"), Code="09", Description="Ninth grade", Definition="Ninth grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("29.00") },
            new ReferenceModelBase { Id=Guid.Parse("054b0c1b-2c80-4755-ba9e-f8bea7dfb9dd"), Code="10", Description="Tenth grade", Definition="Tenth grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("31.00") },
            new ReferenceModelBase { Id=Guid.Parse("e4ee413f-7700-4a2e-9d12-940e712d593c"), Code="11", Description="Eleventh grade", Definition="Eleventh grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("33.00") },
            new ReferenceModelBase { Id=Guid.Parse("e6891166-74a6-44e2-9bf0-ad793736afb1"), Code="12", Description="Twelfth grade", Definition="Twelfth grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("35.00") },
            new ReferenceModelBase { Id=Guid.Parse("4af1b2aa-3b62-4b7f-9c50-31fd74b9a0f9"), Code="13", Description="Grade 13", Definition="Grade 13 is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("37.00") },
            new ReferenceModelBase { Id=Guid.Parse("39dbb928-b749-4cd3-b4e9-40fc0ef6cb9e"), Code="AS", Description="Associate's degree", Definition="Associate's degree is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("39.00") },
            new ReferenceModelBase { Id=Guid.Parse("1d199ca2-06e7-48f9-b364-103caaa3bf4f"), Code="BA", Description="Bachelor's degree", Definition="Bachelor's degree is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("41.00") },
            new ReferenceModelBase { Id=Guid.Parse("012470a4-c87f-447e-aca6-a98a0be7f998"), Code="PB", Description="Post-baccalaureate certificate", Definition="Post-baccalaureate certificate is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("43.00") },
            new ReferenceModelBase { Id=Guid.Parse("84817cd0-92eb-4638-8b03-caf024fc3dfb"), Code="MD", Description="Master's degree", Definition="Master's degree is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("45.00") },
            new ReferenceModelBase { Id=Guid.Parse("f4b223c4-bd75-475e-aae0-5b4ea2f20ffb"), Code="PM", Description="Post-master's certificate", Definition="Post-master's certificate is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("47.00") },
            new ReferenceModelBase { Id=Guid.Parse("3e4b9f7c-82b6-4480-b84a-d61b7d06524c"), Code="DO", Description="Doctoral degree", Definition="Doctoral degree is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("49.00") },
            new ReferenceModelBase { Id=Guid.Parse("206aabe5-6189-42ad-a820-c213a8b09afe"), Code="PD", Description="Post-doctoral certificate", Definition="Post-doctoral certificate is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("51.00") },
            new ReferenceModelBase { Id=Guid.Parse("093fb926-5369-4114-851a-fa9b1be09f56"), Code="AE", Description="Adult education", Definition="Adult education is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("53.00") },
            new ReferenceModelBase { Id=Guid.Parse("f8c008c0-ffba-4934-a00d-05292780c221"), Code="OT", Description="Other", Definition="The age group or education level to which the professional development activity's content pertains is not yet defined in CEDS.", SortOrder=Convert.ToDecimal("55.00") },
        };
        #endregion
    }
}
