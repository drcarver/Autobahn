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
            new ReferenceModelBase { Id=Guid.Parse("f4ff89df-73e5-408e-9b97-c87e8e4a04d0"), Code="IN", Description="Infant", Definition="Infant is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("94f01954-894c-42f2-aab6-af0bf2842a89"), Code="TO", Description="Toddler", Definition="Toddler is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("b798daad-dd59-43ef-b543-c9af2c2c7a19"), Code="PR", Description="Preschool", Definition="Preschool is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("7e1184f0-3945-4596-8f4d-8845df24781f"), Code="PK", Description="Prekindergarten", Definition="Prekindergarten is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("cc1be11e-678d-419d-b9dc-b657eb684f2f"), Code="TK", Description="Transitional Kindergarten", Definition="Transitional Kindergarten is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("1c214459-ad25-4056-9537-7fb2784bacbf"), Code="KG", Description="Kindergarten", Definition="Kindergarten is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("7f1b2222-5ec2-40be-a5a1-60441e17b5d6"), Code="01", Description="First grade", Definition="First grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("81a0ae40-c78e-41d3-8f4f-5f0b4d821875"), Code="02", Description="Second grade", Definition="Second grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("18e022ae-559e-4167-936b-491b69d70ada"), Code="03", Description="Third grade", Definition="Third grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("b9ea8283-4e72-41e3-90b4-aa7545b2521d"), Code="04", Description="Fourth grade", Definition="Fourth grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("8f1caa8b-b2e6-4415-a555-9310c5f6e786"), Code="05", Description="Fifth grade", Definition="Fifth grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("7425d6bf-bda0-460c-a50b-ebdb1fe0c67a"), Code="06", Description="Sixth grade", Definition="Sixth grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("ed3549fa-093a-43f2-97b6-2fbbb9ffd345"), Code="07", Description="Seventh grade", Definition="Seventh grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("106f97fe-3e5e-43ce-9047-33184dcd0b9a"), Code="08", Description="Eighth grade", Definition="Eighth grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("27.00") },
            new ReferenceModelBase { Id=Guid.Parse("3d6cef61-8ad6-420e-96df-c3259e9e8f64"), Code="09", Description="Ninth grade", Definition="Ninth grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("29.00") },
            new ReferenceModelBase { Id=Guid.Parse("ffadc07d-fccb-4a03-b6fb-d94bbf74b219"), Code="10", Description="Tenth grade", Definition="Tenth grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("31.00") },
            new ReferenceModelBase { Id=Guid.Parse("2ff1e7e3-5811-4507-bb47-5996dc32b857"), Code="11", Description="Eleventh grade", Definition="Eleventh grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("33.00") },
            new ReferenceModelBase { Id=Guid.Parse("0bab97ae-6880-4be4-8ccd-534cfe35cb5b"), Code="12", Description="Twelfth grade", Definition="Twelfth grade is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("35.00") },
            new ReferenceModelBase { Id=Guid.Parse("1b1a3a33-9122-49bf-891a-a79c9ad4b91e"), Code="13", Description="Grade 13", Definition="Grade 13 is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("37.00") },
            new ReferenceModelBase { Id=Guid.Parse("8e13e2e1-73a0-4616-abe2-1b46c2cbaef0"), Code="AS", Description="Associate's degree", Definition="Associate's degree is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("39.00") },
            new ReferenceModelBase { Id=Guid.Parse("c0679c14-8e54-4bfb-b84f-6655283f1a2d"), Code="BA", Description="Bachelor's degree", Definition="Bachelor's degree is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("41.00") },
            new ReferenceModelBase { Id=Guid.Parse("1abdf480-8fe0-426c-b699-f0e0111c3b46"), Code="PB", Description="Post-baccalaureate certificate", Definition="Post-baccalaureate certificate is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("43.00") },
            new ReferenceModelBase { Id=Guid.Parse("e2813bbf-9389-4f87-be97-41680716fd0d"), Code="MD", Description="Master's degree", Definition="Master's degree is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("45.00") },
            new ReferenceModelBase { Id=Guid.Parse("e1a1a8cc-ae58-4733-89b0-720841a11a91"), Code="PM", Description="Post-master's certificate", Definition="Post-master's certificate is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("47.00") },
            new ReferenceModelBase { Id=Guid.Parse("157c7460-85dc-4d36-b5f5-5a4e9a71b53c"), Code="DO", Description="Doctoral degree", Definition="Doctoral degree is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("49.00") },
            new ReferenceModelBase { Id=Guid.Parse("63a33191-0c26-4233-946d-d11fee51f95c"), Code="PD", Description="Post-doctoral certificate", Definition="Post-doctoral certificate is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("51.00") },
            new ReferenceModelBase { Id=Guid.Parse("41a4246c-1e37-4cbe-a2fc-6972b26a41ce"), Code="AE", Description="Adult education", Definition="Adult education is the age group or education level to which the professional development activity's content pertains.", SortOrder=Convert.ToDecimal("53.00") },
            new ReferenceModelBase { Id=Guid.Parse("b306052e-2cd5-4a0d-b405-0f866ead7a54"), Code="OT", Description="Other", Definition="The age group or education level to which the professional development activity's content pertains is not yet defined in CEDS.", SortOrder=Convert.ToDecimal("55.00") },
        };
        #endregion
    }
}
