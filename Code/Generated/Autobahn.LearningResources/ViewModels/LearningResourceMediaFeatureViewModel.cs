//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceMediaFeatureViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.LearningResources.ViewModels
{
     /// <summary>
     /// The LearningResourceMediaFeature View Model
     /// </summary>
    public partial class LearningResourceMediaFeatureViewModel : ViewModelBase, Interfaces.ILearningResourceMediaFeature
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResourceMediaFeature";

        // member variable for the LearningResourceId property
        private Guid _LearningResourceId;

        // RefLearningResourceMediaFeatureTypeId -- (backing property for Learning Resource Media Feature Type)
        private Guid _RefLearningResourceMediaFeatureTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResource"/> model
        /// </summary>
        public Guid LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        /// <summary>
        /// Learning Resource Media Feature Type
        /// <para>
        /// Accessible content features included with the learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20368">Learning Resource Media Feature Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefLearningResourceMediaFeatureTypeId { get => _RefLearningResourceMediaFeatureTypeId; set => SetProperty(ref _RefLearningResourceMediaFeatureTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResourceMediaFeature model)
        {
            IsBusy = true;
            Id = model.Id;
            LearningResourceId = model.LearningResourceId; // 
            RefLearningResourceMediaFeatureTypeId = model.RefLearningResourceMediaFeatureTypeId; // Learning Resource Media Feature Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefLearningResourceMediaFeatureType List
        /// <summary>
        /// The complete <see cref="RefLearningResourceMediaFeatureType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceMediaFeatureTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("bcf3a1c6-d874-41f5-8adc-0fb6db03fa9d"), Code="alternativeText", Description="Alternative Text", Definition="Accessible content features included with the learning resource include Alternative Text.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("634b5340-74e0-425b-83e5-368f64a1d77e"), Code="audioDescription", Description="Audio Description", Definition="Accessible content features included with the learning resource include Audio Description.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("269234a5-98ab-47cd-9599-dde251e3502a"), Code="braille", Description="Braille", Definition="Accessible content features included with the learning resource include Braille.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("53289b7c-f751-4209-9328-e13ddb632c7d"), Code="captions", Description="Captions", Definition="Accessible content features included with the learning resource include Captions.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("259adeb8-bf14-402d-a53b-9264d02bc8ed"), Code="ChemML", Description="Chem M L", Definition="Accessible content features included with the learning resource include Chem M L.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("10ee4e37-c9f1-43ed-b603-134bcb9645d0"), Code="describedMath", Description="Described Math", Definition="Accessible content features included with the learning resource include Described Math.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("37cf6990-f9c9-42ab-ae15-0e4e553a4e41"), Code="displayTransformability", Description="Display Transformability", Definition="Accessible content features included with the learning resource include Display Transformability.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("a7dc37b7-6b51-403e-8043-e1999f2ab25f"), Code="haptic", Description="Haptic", Definition="Accessible content features included with the learning resource include Haptic.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("eb670773-cb08-44bc-8132-345fc14fd542"), Code="highContrast", Description="High Contrast", Definition="Accessible content features included with the learning resource include High Contrast.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("6b34cf11-6891-43b7-94c7-872de27a56b4"), Code="largePrint", Description="Large Print", Definition="Accessible content features included with the learning resource include Large Print.", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("ea2c1d96-091b-4dd5-b663-ee85082e3ecd"), Code="latex", Description="Latex", Definition="Accessible content features included with the learning resource include Latex.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("5d5f11aa-3ac5-4feb-aba1-2ea062d7204d"), Code="longDescription", Description="Long Description", Definition="Accessible content features included with the learning resource include Long Description.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("349476f5-57d1-4a72-a95c-eb593ad087ae"), Code="MathML", Description="Math M L", Definition="Accessible content features included with the learning resource include Math M L.", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("4fd126d4-e836-4b59-bb6d-9fee4c08fe96"), Code="musicBraille", Description="Music Braille", Definition="Accessible content features included with the learning resource include Music Braille.", SortOrder=Convert.ToDecimal("28.00") },
            new ReferenceModelBase { Id=Guid.Parse("9c00b936-d6c4-413a-935a-7635cf46b8be"), Code="nemethBraille", Description="Nemeth Braille", Definition="Accessible content features included with the learning resource include Nemeth Braille.", SortOrder=Convert.ToDecimal("30.00") },
            new ReferenceModelBase { Id=Guid.Parse("d9269df0-0725-4ad7-89d8-90a1a8967bf6"), Code="signLanguage", Description="Sign Language", Definition="Accessible content features included with the learning resource include Sign Language.", SortOrder=Convert.ToDecimal("32.00") },
            new ReferenceModelBase { Id=Guid.Parse("7136fd20-2850-4bf1-9934-59d84fab8a28"), Code="structuralNavigation", Description="Structural Navigation", Definition="Accessible content features included with the learning resource include Structural Navigation.", SortOrder=Convert.ToDecimal("34.00") },
            new ReferenceModelBase { Id=Guid.Parse("a549dd9b-ad8b-43d3-88dd-937354a29a38"), Code="tactileGraphics", Description="Tactile Graphics", Definition="Accessible content features included with the learning resource include Tactile Graphics.", SortOrder=Convert.ToDecimal("36.00") },
            new ReferenceModelBase { Id=Guid.Parse("f1696875-b628-4827-b14a-666559f28891"), Code="tactileObject", Description="Tactile Object", Definition="Accessible content features included with the learning resource include Tactile Object.", SortOrder=Convert.ToDecimal("37.00") },
            new ReferenceModelBase { Id=Guid.Parse("54ce7587-dbc2-4897-bae1-dcea2535faea"), Code="transcript", Description="Transcript", Definition="Accessible content features included with the learning resource include Transcript.", SortOrder=Convert.ToDecimal("38.00") },
        };
        #endregion
    }
}
