//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourcePhysicalMediaViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.LearningResources.ViewModels
{
     /// <summary>
     /// The LearningResourcePhysicalMedia View Model
     /// </summary>
    public partial class LearningResourcePhysicalMediaViewModel : ViewModelBase, Interfaces.ILearningResourcePhysicalMedia
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResourcePhysicalMedia";

        // member variable for the LearningResourceId property
        private Guid _LearningResourceId;

        // RefLearningResourcePhysicalMediaTypeId -- (backing property for Learning Resource Physical Media Type)
        private Guid _RefLearningResourcePhysicalMediaTypeId;

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
        /// Learning Resource Physical Media Type
        /// <para>
        /// A type of physical media on which the Learning Resource is delivered or available.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20370">Learning Resource Physical Media Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefLearningResourcePhysicalMediaTypeId { get => _RefLearningResourcePhysicalMediaTypeId; set => SetProperty(ref _RefLearningResourcePhysicalMediaTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResourcePhysicalMedia model)
        {
            IsBusy = true;
            Id = model.Id;
            LearningResourceId = model.LearningResourceId; // 
            RefLearningResourcePhysicalMediaTypeId = model.RefLearningResourcePhysicalMediaTypeId; // Learning Resource Physical Media Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefLearningResourcePhysicalMediaType List
        /// <summary>
        /// The complete <see cref="RefLearningResourcePhysicalMediaType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourcePhysicalMediaTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("e10f9a77-1fc7-444b-97bd-83237e44db8b"), Code="AudioCD", Description="Audio CD", Definition="Audio CD is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("7305f90b-a468-4be6-9bec-29938c37b4ea"), Code="Audiotape", Description="Audiotape", Definition="Audiotape is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("37f6283f-a319-428d-95fd-f3943692ca25"), Code="Calculator", Description="Calculator", Definition="Calculator is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("b0047488-8aff-4462-b8eb-5ac7823e9744"), Code="CD-I", Description="CD-I", Definition="CD-I is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("552fc56b-136a-4df3-8316-2b3dc1f39310"), Code="CD-ROM", Description="CD-ROM", Definition="CD-ROM is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("dae6898b-8d8c-4a42-86d7-4bd85360bfab"), Code="Diskette", Description="Diskette", Definition="Diskette is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("56ffbaea-624d-4e3d-909c-a8455cf58637"), Code="DuplicationMaster", Description="Duplication Master", Definition="Duplication Master is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("dc34eab9-e5d9-480c-9133-acc19f41bb00"), Code="DVD", Description="DVD/ Blu-ray", Definition="DVD/ Blu-ray is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("2779ee02-9050-4d6b-b5df-a4d5cc7faf1a"), Code="E-Mail", Description="E-Mail", Definition="E-Mail is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("d399d411-6073-402d-8432-4fa1442925df"), Code="ElectronicSlides", Description="Electronic Slides", Definition="Electronic Slides is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("9df150fc-ab2f-4925-b658-e2e4b276da34"), Code="FieldTrip", Description="Field Trip", Definition="Field Trip is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("6d8011e7-2e3d-4591-b585-cb0183abb65d"), Code="Filmstrip", Description="Filmstrip", Definition="Filmstrip is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("fe55020f-a7de-4383-ac8b-db3997a5c2e8"), Code="Flash", Description="Flash", Definition="Flash is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("afd89869-d8e7-4757-b04f-2ecb1056a010"), Code="Image", Description="Image", Definition="Image is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("cd49dc74-9a64-4bb2-90fa-26738b277124"), Code="In-Person", Description="In-Person/Speaker", Definition="In-Person/Speaker is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("667364d7-2ea2-4f59-a242-e17935f7c2d9"), Code="InteractiveWhiteboard", Description="Interactive Whiteboard", Definition="Interactive Whiteboard is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("740fd092-f5fc-4bec-853a-61e1a21d093d"), Code="Manipulative", Description="Manipulative", Definition="Manipulative is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("7ea6cee7-1ba9-40ca-91f4-c8317671f355"), Code="MBL", Description="MBL (Microcomputer Based)", Definition="MBL (Microcomputer Based) is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("819383b8-dd9f-475b-826e-c59defd9bc9b"), Code="Microfiche", Description="Microfiche", Definition="Microfiche is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("8c281345-fa65-4aac-927d-2cb7a2aad611"), Code="Overhead", Description="Overhead", Definition="Overhead is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("6087d882-aa2b-4294-9c45-3bf103ed7ba9"), Code="Pamphlet", Description="Pamphlet", Definition="Pamphlet is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("adfdfc29-44e0-43fd-b021-cc321adbb31f"), Code="PDF", Description="PDF", Definition="PDF is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("a864522e-3c4e-4c0e-9103-e468f431c491"), Code="Person-to-Person", Description="Person-to-Person", Definition="Person-to-Person is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("00046c16-5b18-4683-bc61-7a0e3aae2c25"), Code="PhonographRecord", Description="Phonograph Record", Definition="Phonograph Record is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("a51ca8d0-f33b-4d4f-92ff-33be19734c4b"), Code="Photo", Description="Photo", Definition="Photo is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("ecb4c669-e575-49f7-902e-c33ff89d529e"), Code="Podcast", Description="Podcast", Definition="Podcast is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("d06bbedf-6ba5-4e7d-8964-11bd40513c79"), Code="Printed", Description="Printed", Definition="Printed is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("27.00") },
            new ReferenceModelBase { Id=Guid.Parse("5ffa9733-a4dd-4aa4-bca0-85d6af1f205e"), Code="Radio", Description="Radio", Definition="Radio is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("28.00") },
            new ReferenceModelBase { Id=Guid.Parse("485664ed-7521-4c50-9afe-dfbccd7c040e"), Code="Robotics", Description="Robotics", Definition="Robotics is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("29.00") },
            new ReferenceModelBase { Id=Guid.Parse("44e18bde-415f-4ed1-87d0-1b8eb821e9df"), Code="Satellite", Description="Satellite", Definition="Satellite is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("30.00") },
            new ReferenceModelBase { Id=Guid.Parse("eb028e14-5ea4-4a8d-a81a-932e8e81874f"), Code="Slides", Description="Slides", Definition="Slides is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("31.00") },
            new ReferenceModelBase { Id=Guid.Parse("a65877c8-369d-4d14-9e46-9a55a8a6c4c9"), Code="Television", Description="Television", Definition="Television is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("32.00") },
            new ReferenceModelBase { Id=Guid.Parse("45a462a2-5ee6-4d24-a24a-1645c4742ef9"), Code="Transparency", Description="Transparency", Definition="Transparency is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("33.00") },
            new ReferenceModelBase { Id=Guid.Parse("9d9942d8-c311-4910-bccf-4febb85ec88e"), Code="VideoConference", Description="Video Conference", Definition="Video Conference is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("34.00") },
            new ReferenceModelBase { Id=Guid.Parse("fa8ba0d1-3a0a-4229-8cc1-5d77b14ca3e1"), Code="Videodisc", Description="Videodisc", Definition="Videodisc is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("35.00") },
        };
        #endregion
    }
}
