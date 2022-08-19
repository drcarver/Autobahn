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
            new ReferenceModelBase { Id=Guid.Parse("756fe1be-0d1e-41ac-b5bf-d345480628be"), Code="Alabama", Description="01", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("dc428f71-9b81-496b-a835-a62111060217"), Code="Alaska", Description="02", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("44c8976a-d233-4106-878f-06ba7048060b"), Code="Arizona", Description="04", Definition="", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("e27b7b4e-54b6-4107-b89e-63f72525d9f3"), Code="Arkansas", Description="05", Definition="", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("90305909-21b4-4ec7-9e17-31aa0ea7dd32"), Code="California", Description="06", Definition="", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("3df07d76-0dbf-4c0a-802f-ff9a0889b925"), Code="Colorado", Description="08", Definition="", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("e2839799-85ee-4116-8a8b-d4ce664e7100"), Code="Connecticut", Description="09", Definition="", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("b6bc657f-65c7-4a8a-8646-7387e0904596"), Code="Delaware", Description="10", Definition="", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("24f526f4-dbcd-4897-a8b4-0b4a031bb1f0"), Code="District of Columbia", Description="11", Definition="", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("b7e2f478-03b8-48c2-884c-e7d0bf30d4f4"), Code="Florida", Description="12", Definition="", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("43670d99-09ef-4294-bd88-4fb89b17c7a9"), Code="Georgia", Description="13", Definition="", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("7e059edc-a34d-4a96-bdb5-cab77a882b4d"), Code="Hawaii", Description="15", Definition="", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("c3e23977-421f-44b6-8a13-e626980ead07"), Code="Idaho", Description="16", Definition="", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("3554653e-c9ca-4060-b321-beab897fdf6f"), Code="Illinois", Description="17", Definition="", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("46959ad0-2434-4877-b28d-12a3d7aa2e85"), Code="Indiana", Description="18", Definition="", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("67930d10-c494-47fe-af14-6edbc776715b"), Code="Iowa", Description="19", Definition="", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("f965c6ee-a3f3-4304-b9d1-97c0877ce351"), Code="Kansas ", Description="20", Definition="", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("ac81968a-176a-4384-b847-248627285597"), Code="Kentucky", Description="21", Definition="", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("9d428bec-ac84-4cab-8b78-39c6b944cb0b"), Code="Louisiana", Description="22", Definition="", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("42cb9619-bdda-4970-b354-b7d3b55f18e2"), Code="Maine", Description="23", Definition="", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("010e6f0a-f930-4943-9083-15812a29d560"), Code="Maryland", Description="24", Definition="", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("8e124e13-42c3-451c-96c4-f4c20fdef54a"), Code="Massachusetts", Description="25", Definition="", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("547bb308-4f69-4bec-9125-23571a0a99c6"), Code="Michigan", Description="26", Definition="", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("b477d987-9b83-4c94-a618-9a692685f2e9"), Code="Minnesota", Description="27", Definition="", SortOrder=Convert.ToDecimal("27.00") },
            new ReferenceModelBase { Id=Guid.Parse("6f4998aa-8f68-4a7d-a06b-cf534cf28a58"), Code="Mississippi", Description="28", Definition="", SortOrder=Convert.ToDecimal("28.00") },
            new ReferenceModelBase { Id=Guid.Parse("72540d71-5cd3-440f-b66c-3d680d7dc9e5"), Code="Missouri", Description="29", Definition="", SortOrder=Convert.ToDecimal("29.00") },
            new ReferenceModelBase { Id=Guid.Parse("696eaf2d-aa60-4805-924d-36ca454ebd7c"), Code="Montana", Description="30", Definition="", SortOrder=Convert.ToDecimal("30.00") },
            new ReferenceModelBase { Id=Guid.Parse("b3507a2a-94cb-4dfa-8e17-0145d86ba11b"), Code="Nebraska", Description="31", Definition="", SortOrder=Convert.ToDecimal("31.00") },
            new ReferenceModelBase { Id=Guid.Parse("be368c3f-fa7f-41f4-8016-8c38845c6a82"), Code="Nevada", Description="32", Definition="", SortOrder=Convert.ToDecimal("32.00") },
            new ReferenceModelBase { Id=Guid.Parse("37c0c0f1-ad8c-4fe3-9e0e-1902830e441a"), Code="New Hampshire", Description="33", Definition="", SortOrder=Convert.ToDecimal("33.00") },
            new ReferenceModelBase { Id=Guid.Parse("1ca0beeb-0cc0-429a-9f8c-5ea37f236bb3"), Code="New Jersey", Description="34", Definition="", SortOrder=Convert.ToDecimal("34.00") },
            new ReferenceModelBase { Id=Guid.Parse("5e1afd7e-7069-4e1a-88a6-05962b39982a"), Code="New Mexico", Description="35", Definition="", SortOrder=Convert.ToDecimal("35.00") },
            new ReferenceModelBase { Id=Guid.Parse("f026d2f3-22a9-4f7d-bc9d-92405d91ce44"), Code="New York", Description="36", Definition="", SortOrder=Convert.ToDecimal("36.00") },
            new ReferenceModelBase { Id=Guid.Parse("67ed2969-de03-4a2e-b853-37e6a2ccf501"), Code="North Carolina", Description="37", Definition="", SortOrder=Convert.ToDecimal("37.00") },
            new ReferenceModelBase { Id=Guid.Parse("58c3accd-f7fd-4d3b-b574-1738610d3c4a"), Code="North Dakota", Description="38", Definition="", SortOrder=Convert.ToDecimal("38.00") },
            new ReferenceModelBase { Id=Guid.Parse("3d7f2279-72e0-4271-86be-52aaf9e2f703"), Code="Ohio", Description="39", Definition="", SortOrder=Convert.ToDecimal("39.00") },
            new ReferenceModelBase { Id=Guid.Parse("45930557-3943-42bd-87a1-ba01ab471e8e"), Code="Oklahoma", Description="40", Definition="", SortOrder=Convert.ToDecimal("40.00") },
            new ReferenceModelBase { Id=Guid.Parse("31b30fff-b631-4fce-a35e-15ba56ef5fec"), Code="Oregon", Description="41", Definition="", SortOrder=Convert.ToDecimal("41.00") },
            new ReferenceModelBase { Id=Guid.Parse("c2f91890-316d-4c5c-88e0-fb53d2db118e"), Code="Pennsylvania", Description="42", Definition="", SortOrder=Convert.ToDecimal("42.00") },
            new ReferenceModelBase { Id=Guid.Parse("57b044e6-3124-4e3b-8c57-49921b1188da"), Code="Rhode Island", Description="44", Definition="", SortOrder=Convert.ToDecimal("44.00") },
            new ReferenceModelBase { Id=Guid.Parse("0c33e614-a5ca-4973-bf7e-0b9a942ca76a"), Code="South Carolina", Description="45", Definition="", SortOrder=Convert.ToDecimal("45.00") },
            new ReferenceModelBase { Id=Guid.Parse("dd186caf-29a8-42c3-b17b-7ed596f93606"), Code="South Dakota", Description="46", Definition="", SortOrder=Convert.ToDecimal("46.00") },
            new ReferenceModelBase { Id=Guid.Parse("581fb18b-35bb-4f63-a4a0-2ed3e749d334"), Code="Tennessee", Description="47", Definition="", SortOrder=Convert.ToDecimal("47.00") },
            new ReferenceModelBase { Id=Guid.Parse("c0867274-130a-4f75-932d-2cdd8dfa75c0"), Code="Texas", Description="48", Definition="", SortOrder=Convert.ToDecimal("48.00") },
            new ReferenceModelBase { Id=Guid.Parse("c2f2f349-aa30-4677-b787-cc2ce75a5cf7"), Code="Utah", Description="49", Definition="", SortOrder=Convert.ToDecimal("49.00") },
            new ReferenceModelBase { Id=Guid.Parse("f51f2764-cad3-4a91-9b6f-f1d1b4be932f"), Code="Vermont", Description="50", Definition="", SortOrder=Convert.ToDecimal("50.00") },
            new ReferenceModelBase { Id=Guid.Parse("9bfd1063-91aa-4b9f-9abc-e88d9ef71496"), Code="Virginia", Description="51", Definition="", SortOrder=Convert.ToDecimal("51.00") },
            new ReferenceModelBase { Id=Guid.Parse("82e5e966-456b-407e-bb23-60553c490488"), Code="Washington", Description="53", Definition="", SortOrder=Convert.ToDecimal("53.00") },
            new ReferenceModelBase { Id=Guid.Parse("620dfede-db75-4228-8356-f12b3ce0645d"), Code="West Virginia", Description="54", Definition="", SortOrder=Convert.ToDecimal("54.00") },
            new ReferenceModelBase { Id=Guid.Parse("fa4b623b-2e81-4834-acb2-bff2f65d0322"), Code="Wisconsin", Description="55", Definition="", SortOrder=Convert.ToDecimal("55.00") },
            new ReferenceModelBase { Id=Guid.Parse("70b7bf60-f97c-406c-978b-5061b4099c13"), Code="Wyoming", Description="56", Definition="", SortOrder=Convert.ToDecimal("56.00") },
            new ReferenceModelBase { Id=Guid.Parse("71e0da56-539f-4ce7-982b-1f5b33372310"), Code="American Samoa", Description="60", Definition="", SortOrder=Convert.ToDecimal("60.00") },
            new ReferenceModelBase { Id=Guid.Parse("dad1f3fb-e9a9-4e3b-a68c-fd26475f336a"), Code="Federated States of Micronesia", Description="64", Definition="", SortOrder=Convert.ToDecimal("64.00") },
            new ReferenceModelBase { Id=Guid.Parse("3aff9cec-4adb-48fb-87d6-2c4760007147"), Code="Guam", Description="66", Definition="", SortOrder=Convert.ToDecimal("66.00") },
            new ReferenceModelBase { Id=Guid.Parse("2929de7d-cfd1-40d8-9812-ce84949f83b0"), Code="Marshall Islands", Description="68", Definition="", SortOrder=Convert.ToDecimal("68.00") },
            new ReferenceModelBase { Id=Guid.Parse("3678d3bb-e620-43ae-9806-2fd8c4bc297e"), Code="Northern Mariana Islands", Description="69", Definition="", SortOrder=Convert.ToDecimal("69.00") },
            new ReferenceModelBase { Id=Guid.Parse("e33524a2-fc20-4abc-873f-313b83927488"), Code="Palau ", Description="70", Definition="", SortOrder=Convert.ToDecimal("70.00") },
            new ReferenceModelBase { Id=Guid.Parse("c86e38ce-6988-4891-838f-8fc238084d71"), Code="Puerto Rico", Description="72", Definition="", SortOrder=Convert.ToDecimal("72.00") },
            new ReferenceModelBase { Id=Guid.Parse("9252f766-66c1-4cac-b9c6-61185f11d4cc"), Code="Virgin Islands of the U.S.", Description="78", Definition="", SortOrder=Convert.ToDecimal("78.00") },
        };
        #endregion
    }
}
