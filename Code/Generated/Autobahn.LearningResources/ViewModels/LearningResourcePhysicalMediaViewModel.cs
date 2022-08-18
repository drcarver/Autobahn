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
            new ReferenceModelBase { Id=Guid.Parse("d89dcd72-9149-40b5-b8b9-c917e86a53be"), Code="AudioCD", Description="Audio CD", Definition="Audio CD is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("53010b2a-7f4a-44ff-98b9-75b28f2f26b0"), Code="Audiotape", Description="Audiotape", Definition="Audiotape is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("2e73fb56-b654-4d9a-bf71-a25ba86900db"), Code="Calculator", Description="Calculator", Definition="Calculator is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("acf0ef49-58a5-4757-b602-4113e5f5afb4"), Code="CD-I", Description="CD-I", Definition="CD-I is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("ce65f081-b859-416e-8347-72e66db7c0ab"), Code="CD-ROM", Description="CD-ROM", Definition="CD-ROM is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("c0d26bb9-61c7-4138-b0ec-695e30389c5b"), Code="Diskette", Description="Diskette", Definition="Diskette is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("1b496fa5-c499-4e9a-8666-3fc4f8c19f40"), Code="DuplicationMaster", Description="Duplication Master", Definition="Duplication Master is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("c44c9282-0d5e-4582-8515-62b2c84ad9a4"), Code="DVD", Description="DVD/ Blu-ray", Definition="DVD/ Blu-ray is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("7d20ec9e-236f-44f7-8b26-f9fd84bfb371"), Code="E-Mail", Description="E-Mail", Definition="E-Mail is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("7ccfb35e-92e4-476d-bd26-61a1314cb67c"), Code="ElectronicSlides", Description="Electronic Slides", Definition="Electronic Slides is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("b21ab2bc-0621-43ad-b3b4-806d01b56e7d"), Code="FieldTrip", Description="Field Trip", Definition="Field Trip is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("4cf7df99-0f20-4e8d-b215-cbe0e538e6e5"), Code="Filmstrip", Description="Filmstrip", Definition="Filmstrip is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("41a2fc9c-cf73-42ef-a278-312f3e824349"), Code="Flash", Description="Flash", Definition="Flash is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("83b0f964-0a22-4f5d-824a-09a9f56548cb"), Code="Image", Description="Image", Definition="Image is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("5a69a19b-88f1-4154-9e49-4b7e3fc0212e"), Code="In-Person", Description="In-Person/Speaker", Definition="In-Person/Speaker is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("5124d1fe-7ddb-4834-9b51-7e2cf155a8bf"), Code="InteractiveWhiteboard", Description="Interactive Whiteboard", Definition="Interactive Whiteboard is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("24f9f97e-eda0-401a-9870-be3d1a267744"), Code="Manipulative", Description="Manipulative", Definition="Manipulative is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("b6e6527b-1238-4291-9c8c-6af3ec435743"), Code="MBL", Description="MBL (Microcomputer Based)", Definition="MBL (Microcomputer Based) is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("d0ece6ae-2454-48fa-aac6-478a866fccdc"), Code="Microfiche", Description="Microfiche", Definition="Microfiche is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("cc4a342f-e0db-4c03-9e01-aced37586b31"), Code="Overhead", Description="Overhead", Definition="Overhead is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("842a0e82-c071-498b-bfc8-954e5b25e635"), Code="Pamphlet", Description="Pamphlet", Definition="Pamphlet is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("89019e1a-bbdb-4f58-a515-497b88b3a899"), Code="PDF", Description="PDF", Definition="PDF is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("ba1216ca-bd1a-4643-adaa-d7cf44043140"), Code="Person-to-Person", Description="Person-to-Person", Definition="Person-to-Person is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("915d8efa-194e-42df-beab-62fbeb00590d"), Code="PhonographRecord", Description="Phonograph Record", Definition="Phonograph Record is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("ba30c800-4a1f-4631-a920-f97bf04bcadc"), Code="Photo", Description="Photo", Definition="Photo is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("02380c45-e073-4b97-a6d2-71194ae6cae2"), Code="Podcast", Description="Podcast", Definition="Podcast is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("975ec700-dc9e-41a5-ac8a-556a2fead339"), Code="Printed", Description="Printed", Definition="Printed is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("27.00") },
            new ReferenceModelBase { Id=Guid.Parse("57419cd5-4880-493e-84e0-b659f1c7c1dc"), Code="Radio", Description="Radio", Definition="Radio is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("28.00") },
            new ReferenceModelBase { Id=Guid.Parse("70de6e21-0aaa-478a-9b1a-85f855bf083e"), Code="Robotics", Description="Robotics", Definition="Robotics is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("29.00") },
            new ReferenceModelBase { Id=Guid.Parse("301109ab-0a5a-42aa-b2f2-4f59aebb1c36"), Code="Satellite", Description="Satellite", Definition="Satellite is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("30.00") },
            new ReferenceModelBase { Id=Guid.Parse("538eb586-c6de-4b13-add3-7c240afd5c53"), Code="Slides", Description="Slides", Definition="Slides is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("31.00") },
            new ReferenceModelBase { Id=Guid.Parse("50ff8d90-2dbb-4c33-8a27-c3fdc3300eea"), Code="Television", Description="Television", Definition="Television is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("32.00") },
            new ReferenceModelBase { Id=Guid.Parse("7618a982-c6ef-4143-8049-a4530cb33a2e"), Code="Transparency", Description="Transparency", Definition="Transparency is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("33.00") },
            new ReferenceModelBase { Id=Guid.Parse("f6108409-2759-43f7-a8fe-c33ca9705f63"), Code="VideoConference", Description="Video Conference", Definition="Video Conference is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("34.00") },
            new ReferenceModelBase { Id=Guid.Parse("1f4f548b-e48e-4048-b05d-fb3fefaf5b72"), Code="Videodisc", Description="Videodisc", Definition="Videodisc is a type of physical media on which the Learning Resource is delivered or available.", SortOrder=Convert.ToDecimal("35.00") },
        };
        #endregion
    }
}
