//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SeaViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12Sea View Model
     /// </summary>
    public partial class K12SeaViewModel : ViewModelBase, Interfaces.IK12Sea
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12Sea";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefStateANSICodeId -- (backing property for State ANSI Code)
        private Guid? _RefStateANSICodeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// State ANSI Code
        /// <para>
        /// The American National Standards Institute (ANSI) two-digit code for the state.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19414">State ANSI Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefStateANSICodeId { get => _RefStateANSICodeId; set => SetProperty(ref _RefStateANSICodeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12Sea model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId; // 
            RefStateANSICodeId = model.RefStateANSICodeId; // State ANSI Code
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefStateANSICode List
        /// <summary>
        /// The complete <see cref="RefStateANSICode"> List
        /// </summary>
        private static List<ReferenceModelBase> RefStateANSICodeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("976f474e-c7d8-43cf-9d11-794211aae679"), Code="Alabama", Description="01", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("7c245f71-feee-48a8-a7c5-98726775859b"), Code="Alaska", Description="02", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("70319d95-cb4d-4a3a-9033-ed7d67caa97b"), Code="Arizona", Description="04", Definition="", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("ed739986-61c2-405c-8463-009ac2445512"), Code="Arkansas", Description="05", Definition="", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("634c26a5-b27c-43fe-a68e-d40ecfee758c"), Code="California", Description="06", Definition="", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("7eb1caec-1326-4e98-a2dc-75f8baa4e747"), Code="Colorado", Description="08", Definition="", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("b61b44c6-2905-40b0-9045-c87bd8e7a2f8"), Code="Connecticut", Description="09", Definition="", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("b6ff7cd5-1bdf-4a5e-9376-79b79c402bee"), Code="Delaware", Description="10", Definition="", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("7f45f21d-9970-4939-847f-99a98c5dc7e4"), Code="District of Columbia", Description="11", Definition="", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("28dc05f3-6680-4138-8d9e-83365b8cbe71"), Code="Florida", Description="12", Definition="", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("57b6f449-7ac6-4703-b57d-2b9ff1bb8d13"), Code="Georgia", Description="13", Definition="", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("a228063d-0e3b-4140-88ed-3b52e64ea959"), Code="Hawaii", Description="15", Definition="", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("b6ed44b9-b965-48f2-8d3f-d23947ae1cf6"), Code="Idaho", Description="16", Definition="", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("1574195f-bbd6-4ed3-93cc-b0a7ef399bc4"), Code="Illinois", Description="17", Definition="", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("d5ff736c-5220-482d-8aed-450e8c6f7acb"), Code="Indiana", Description="18", Definition="", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("f49d791b-882d-448e-8ff4-2e040c9a36a2"), Code="Iowa", Description="19", Definition="", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("d12fa0c6-52cc-4210-ae15-60a6bb694089"), Code="Kansas ", Description="20", Definition="", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("41c0b1ef-2f5a-4459-ade9-48844d0fde91"), Code="Kentucky", Description="21", Definition="", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("38bbb5a5-8e62-41d2-82c2-8ce52bf95311"), Code="Louisiana", Description="22", Definition="", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("be24894d-7de5-40bf-84b6-c88362cad7d2"), Code="Maine", Description="23", Definition="", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("27e70bfe-b5e5-4e3f-9b22-f123538d160a"), Code="Maryland", Description="24", Definition="", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("b391e236-0fbc-49e3-b4cc-f8bf215298dc"), Code="Massachusetts", Description="25", Definition="", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("2632aa05-f1a5-40e3-add9-3cf49abfdfc3"), Code="Michigan", Description="26", Definition="", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("a9840c88-41de-49da-9cef-c1fefa47c748"), Code="Minnesota", Description="27", Definition="", SortOrder=Convert.ToDecimal("27.00") },
            new ReferenceModelBase { Id=Guid.Parse("8b4e7ab1-4f17-411a-821e-23975af957d3"), Code="Mississippi", Description="28", Definition="", SortOrder=Convert.ToDecimal("28.00") },
            new ReferenceModelBase { Id=Guid.Parse("6d75c9c6-6635-4331-93f7-a6450ed8fd33"), Code="Missouri", Description="29", Definition="", SortOrder=Convert.ToDecimal("29.00") },
            new ReferenceModelBase { Id=Guid.Parse("1b412d09-c0db-46b6-9bc7-f9404e99beb4"), Code="Montana", Description="30", Definition="", SortOrder=Convert.ToDecimal("30.00") },
            new ReferenceModelBase { Id=Guid.Parse("1920fb14-8f4b-4949-86f2-de063bfc8be6"), Code="Nebraska", Description="31", Definition="", SortOrder=Convert.ToDecimal("31.00") },
            new ReferenceModelBase { Id=Guid.Parse("057fcf09-9377-44f6-937e-15d73eb7af1b"), Code="Nevada", Description="32", Definition="", SortOrder=Convert.ToDecimal("32.00") },
            new ReferenceModelBase { Id=Guid.Parse("c2c8ceb1-00d3-4f1d-946f-a3d877bddc89"), Code="New Hampshire", Description="33", Definition="", SortOrder=Convert.ToDecimal("33.00") },
            new ReferenceModelBase { Id=Guid.Parse("55cc4e01-2b7f-4597-9711-e20d5e3e8f3e"), Code="New Jersey", Description="34", Definition="", SortOrder=Convert.ToDecimal("34.00") },
            new ReferenceModelBase { Id=Guid.Parse("78e9201a-bc76-4613-b69d-d463cdafc47f"), Code="New Mexico", Description="35", Definition="", SortOrder=Convert.ToDecimal("35.00") },
            new ReferenceModelBase { Id=Guid.Parse("0d20c299-1503-4d0f-930f-098c448bd0a6"), Code="New York", Description="36", Definition="", SortOrder=Convert.ToDecimal("36.00") },
            new ReferenceModelBase { Id=Guid.Parse("9ecd5926-313e-4153-9aa5-4c827c57d7a0"), Code="North Carolina", Description="37", Definition="", SortOrder=Convert.ToDecimal("37.00") },
            new ReferenceModelBase { Id=Guid.Parse("836f904f-a9a9-46c2-9150-ecbe29aabc3a"), Code="North Dakota", Description="38", Definition="", SortOrder=Convert.ToDecimal("38.00") },
            new ReferenceModelBase { Id=Guid.Parse("d61cc24f-3c1b-4bd5-9c02-8a63696aa1e1"), Code="Ohio", Description="39", Definition="", SortOrder=Convert.ToDecimal("39.00") },
            new ReferenceModelBase { Id=Guid.Parse("79390846-c3f5-4139-86fe-981b5024890a"), Code="Oklahoma", Description="40", Definition="", SortOrder=Convert.ToDecimal("40.00") },
            new ReferenceModelBase { Id=Guid.Parse("b8282df9-5a9a-4781-bfb0-45342f739c1e"), Code="Oregon", Description="41", Definition="", SortOrder=Convert.ToDecimal("41.00") },
            new ReferenceModelBase { Id=Guid.Parse("998c61d8-6bf8-42f6-aa79-f8ef2e26a846"), Code="Pennsylvania", Description="42", Definition="", SortOrder=Convert.ToDecimal("42.00") },
            new ReferenceModelBase { Id=Guid.Parse("b62c4ab5-ce95-48d2-82a9-d941a43bcbdb"), Code="Rhode Island", Description="44", Definition="", SortOrder=Convert.ToDecimal("44.00") },
            new ReferenceModelBase { Id=Guid.Parse("1052a2b0-9068-4d08-86db-354d8e4923ab"), Code="South Carolina", Description="45", Definition="", SortOrder=Convert.ToDecimal("45.00") },
            new ReferenceModelBase { Id=Guid.Parse("b60922b6-5867-45d5-bc21-0dc5e6f779de"), Code="South Dakota", Description="46", Definition="", SortOrder=Convert.ToDecimal("46.00") },
            new ReferenceModelBase { Id=Guid.Parse("58b44f41-8bdc-4241-92c7-cb5fd9c573ea"), Code="Tennessee", Description="47", Definition="", SortOrder=Convert.ToDecimal("47.00") },
            new ReferenceModelBase { Id=Guid.Parse("4e0f7de7-989d-4f23-b66f-6d516132ab39"), Code="Texas", Description="48", Definition="", SortOrder=Convert.ToDecimal("48.00") },
            new ReferenceModelBase { Id=Guid.Parse("1989487e-a713-4f18-a95d-d274057a69a9"), Code="Utah", Description="49", Definition="", SortOrder=Convert.ToDecimal("49.00") },
            new ReferenceModelBase { Id=Guid.Parse("58c71e3f-ed5e-40f0-b447-bc62d0e85b43"), Code="Vermont", Description="50", Definition="", SortOrder=Convert.ToDecimal("50.00") },
            new ReferenceModelBase { Id=Guid.Parse("9fe69e3b-502a-4811-917c-ef83ea2d6086"), Code="Virginia", Description="51", Definition="", SortOrder=Convert.ToDecimal("51.00") },
            new ReferenceModelBase { Id=Guid.Parse("d23af857-9510-40d0-9d9c-5f0edc237601"), Code="Washington", Description="53", Definition="", SortOrder=Convert.ToDecimal("53.00") },
            new ReferenceModelBase { Id=Guid.Parse("cda866ed-0e73-4d3b-bcad-a05535def8b3"), Code="West Virginia", Description="54", Definition="", SortOrder=Convert.ToDecimal("54.00") },
            new ReferenceModelBase { Id=Guid.Parse("12db4902-f445-4dad-8e69-499fa56c4837"), Code="Wisconsin", Description="55", Definition="", SortOrder=Convert.ToDecimal("55.00") },
            new ReferenceModelBase { Id=Guid.Parse("34449d96-aeaa-429b-9f0f-9e9262f78778"), Code="Wyoming", Description="56", Definition="", SortOrder=Convert.ToDecimal("56.00") },
            new ReferenceModelBase { Id=Guid.Parse("460170ed-ed74-4419-b80e-eedab53a2ce9"), Code="American Samoa", Description="60", Definition="", SortOrder=Convert.ToDecimal("60.00") },
            new ReferenceModelBase { Id=Guid.Parse("a63d0a35-85ad-4ed1-b043-5162c0ca353a"), Code="Federated States of Micronesia", Description="64", Definition="", SortOrder=Convert.ToDecimal("64.00") },
            new ReferenceModelBase { Id=Guid.Parse("68c76aa8-e1aa-45f1-835f-c488e2865ffe"), Code="Guam", Description="66", Definition="", SortOrder=Convert.ToDecimal("66.00") },
            new ReferenceModelBase { Id=Guid.Parse("bb6d3ad6-b6bb-4093-bace-a5add43d9b88"), Code="Marshall Islands", Description="68", Definition="", SortOrder=Convert.ToDecimal("68.00") },
            new ReferenceModelBase { Id=Guid.Parse("da89c60c-c625-423a-b1d2-4cda704793e3"), Code="Northern Mariana Islands", Description="69", Definition="", SortOrder=Convert.ToDecimal("69.00") },
            new ReferenceModelBase { Id=Guid.Parse("3a56cde9-6249-48f9-99b8-512f8937a7c5"), Code="Palau ", Description="70", Definition="", SortOrder=Convert.ToDecimal("70.00") },
            new ReferenceModelBase { Id=Guid.Parse("0c8b432c-6e87-44ef-a801-333eac2f6f32"), Code="Puerto Rico", Description="72", Definition="", SortOrder=Convert.ToDecimal("72.00") },
            new ReferenceModelBase { Id=Guid.Parse("b459764a-3567-4207-a693-6f180be7b66f"), Code="Virgin Islands of the U.S.", Description="78", Definition="", SortOrder=Convert.ToDecimal("78.00") },
        };
        #endregion
    }
}
