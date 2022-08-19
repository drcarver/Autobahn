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
            new ReferenceModelBase { Id=Guid.Parse("40369ea3-7a04-4815-b970-f0b5974057c3"), Code="alternativeText", Description="Alternative Text", Definition="Accessible content features included with the learning resource include Alternative Text.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("419b1c01-25c6-4bfe-b869-2a1a36ac2195"), Code="audioDescription", Description="Audio Description", Definition="Accessible content features included with the learning resource include Audio Description.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("d98ab3e0-c9d1-4583-b100-1354473880b8"), Code="braille", Description="Braille", Definition="Accessible content features included with the learning resource include Braille.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("52a22bbb-782a-4f9a-bf14-2c26b4785f7a"), Code="captions", Description="Captions", Definition="Accessible content features included with the learning resource include Captions.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("6d835f61-2fe4-4a20-bc47-88cba94e44e9"), Code="ChemML", Description="Chem M L", Definition="Accessible content features included with the learning resource include Chem M L.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("a2ea5c6e-7dad-4e6b-8a71-a7227569cee3"), Code="describedMath", Description="Described Math", Definition="Accessible content features included with the learning resource include Described Math.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("9c372bb0-123b-4fcd-a2cc-d41c6b74f2ad"), Code="displayTransformability", Description="Display Transformability", Definition="Accessible content features included with the learning resource include Display Transformability.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("77072af5-3687-4082-936d-354a2ad75dd6"), Code="haptic", Description="Haptic", Definition="Accessible content features included with the learning resource include Haptic.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("ed245000-47fc-48d3-a215-5d7364059dfb"), Code="highContrast", Description="High Contrast", Definition="Accessible content features included with the learning resource include High Contrast.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("11d44ca8-4373-464a-a3f5-93854ec80768"), Code="largePrint", Description="Large Print", Definition="Accessible content features included with the learning resource include Large Print.", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("bfc54ae1-4f0c-4158-8058-dc2d389a43f4"), Code="latex", Description="Latex", Definition="Accessible content features included with the learning resource include Latex.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("1670c47d-0cc3-456e-bd88-df948f26b6ab"), Code="longDescription", Description="Long Description", Definition="Accessible content features included with the learning resource include Long Description.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("37e61a58-fe39-408e-9fd9-b557adb459ea"), Code="MathML", Description="Math M L", Definition="Accessible content features included with the learning resource include Math M L.", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("98e693ca-f1dc-403b-a687-de48acb1b430"), Code="musicBraille", Description="Music Braille", Definition="Accessible content features included with the learning resource include Music Braille.", SortOrder=Convert.ToDecimal("28.00") },
            new ReferenceModelBase { Id=Guid.Parse("5552731c-507a-49a7-a1e0-bd73ad3288f7"), Code="nemethBraille", Description="Nemeth Braille", Definition="Accessible content features included with the learning resource include Nemeth Braille.", SortOrder=Convert.ToDecimal("30.00") },
            new ReferenceModelBase { Id=Guid.Parse("e652edc5-9791-4c3d-aaa9-494f47a2c3dd"), Code="signLanguage", Description="Sign Language", Definition="Accessible content features included with the learning resource include Sign Language.", SortOrder=Convert.ToDecimal("32.00") },
            new ReferenceModelBase { Id=Guid.Parse("ca9d44a7-d58e-4c98-873d-72c48a434a14"), Code="structuralNavigation", Description="Structural Navigation", Definition="Accessible content features included with the learning resource include Structural Navigation.", SortOrder=Convert.ToDecimal("34.00") },
            new ReferenceModelBase { Id=Guid.Parse("64493305-07f6-482f-8e67-ced037325ded"), Code="tactileGraphics", Description="Tactile Graphics", Definition="Accessible content features included with the learning resource include Tactile Graphics.", SortOrder=Convert.ToDecimal("36.00") },
            new ReferenceModelBase { Id=Guid.Parse("10c9445f-3c3b-41c2-9fd0-0d331f5d3f54"), Code="tactileObject", Description="Tactile Object", Definition="Accessible content features included with the learning resource include Tactile Object.", SortOrder=Convert.ToDecimal("37.00") },
            new ReferenceModelBase { Id=Guid.Parse("d63c43e0-929a-4d1a-97f8-693d5f11a032"), Code="transcript", Description="Transcript", Definition="Accessible content features included with the learning resource include Transcript.", SortOrder=Convert.ToDecimal("38.00") },
        };
        #endregion
    }
}
