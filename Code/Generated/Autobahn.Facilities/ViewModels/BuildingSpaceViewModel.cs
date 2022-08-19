//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSpaceViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The BuildingSpace View Model
     /// </summary>
    public partial class BuildingSpaceViewModel : ViewModelBase, Interfaces.IBuildingSpace
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from BuildingSpace";

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // RefBuildingAdministrativeSpaceTypeId -- (backing property for Building Administrative Space Type)
        private Guid? _RefBuildingAdministrativeSpaceTypeId;

        // RefBuildingArtSpecialtySpaceTypeId -- (backing property for Building Art Specialty Space Type)
        private Guid? _RefBuildingArtSpecialtySpaceTypeId;

        // RefBuildingAssemblySpaceTypeId -- (backing property for Building Assembly Space Type)
        private Guid? _RefBuildingAssemblySpaceTypeId;

        // RefBuildingBasicClassroomDesignTypeId -- (backing property for Building Basic Classroom Design Type)
        private Guid? _RefBuildingBasicClassroomDesignTypeId;

        // RefBuildingCareerTechEducationSpaceTypeId -- (backing property for Building Career-Technical Education Space Type)
        private Guid? _RefBuildingCareerTechEducationSpaceTypeId;

        // RefBuildingCirculationSpaceTypeId -- (backing property for Building Circulation Space Type)
        private Guid? _RefBuildingCirculationSpaceTypeId;

        // RefBuildingFoodServiceSpaceTypeId -- (backing property for Building Food Service Space Type)
        private Guid? _RefBuildingFoodServiceSpaceTypeId;

        // RefBuildingFullServiceKitchenTypeId -- (backing property for Building Full Service Kitchen Type)
        private Guid? _RefBuildingFullServiceKitchenTypeId;

        // RefBuildingIndoorAthleticOrPhysEdSpaceTypeId -- (backing property for Building Indoor Athletic or Physical Education Space Type)
        private Guid? _RefBuildingIndoorAthleticOrPhysEdSpaceTypeId;

        // RefBuildingLibMediaCenterSpecialtySpaceTypeId -- (backing property for Building Library or Media Center Specialty Space Type)
        private Guid? _RefBuildingLibMediaCenterSpecialtySpaceTypeId;

        // RefBuildingOperationsOrMaintSpaceTypeId -- (backing property for Building Operations or Maintenance Space Type)
        private Guid? _RefBuildingOperationsOrMaintSpaceTypeId;

        // RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId -- (backing property for Building Outdoor Athletic or Physical Education Space Type)
        private Guid? _RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId;

        // RefBuildingOutdoorOrNonathleticSpaceTypeId -- (backing property for Building Outdoor or Non-athletic Space Type)
        private Guid? _RefBuildingOutdoorOrNonathleticSpaceTypeId;

        // RefBuildingPerformingArtsSpecialtySpaceTypeId -- (backing property for Building Performing Arts Specialty Space Type)
        private Guid? _RefBuildingPerformingArtsSpecialtySpaceTypeId;

        // RefBuildingScienceSpecialtySpaceTypeId -- (backing property for Building Science Specialty Space Type)
        private Guid? _RefBuildingScienceSpecialtySpaceTypeId;

        // RefBuildingSpaceDesignTypeId -- (backing property for Building Space Design Type)
        private Guid? _RefBuildingSpaceDesignTypeId;

        // RefBuildingSpecEdSpecialtySpaceTypeId -- (backing property for Building Special Education Specialty Space Type)
        private Guid? _RefBuildingSpecEdSpecialtySpaceTypeId;

        // RefBuildingStudentSupportSpaceTypeId -- (backing property for Building Student Support Space Type)
        private Guid? _RefBuildingStudentSupportSpaceTypeId;

        // RefSpaceUseTypeId -- (backing property for Facility Space Use Type)
        private Guid? _RefSpaceUseTypeId;

        // SpaceDescription -- (backing property for Facility Space Description)
        private System.String _SpaceDescription;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// Building Administrative Space Type
        /// <para>
        /// The space designed primarily for conducting administrative and business functions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20794">Building Administrative Space Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingAdministrativeSpaceTypeId { get => _RefBuildingAdministrativeSpaceTypeId; set => SetProperty(ref _RefBuildingAdministrativeSpaceTypeId, value); }

        /// <summary>
        /// Building Art Specialty Space Type
        /// <para>
        /// The space designed to support the teaching and learning of 2 dimensional or 3 dimensional visual arts.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20795">Building Art Specialty Space Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingArtSpecialtySpaceTypeId { get => _RefBuildingArtSpecialtySpaceTypeId; set => SetProperty(ref _RefBuildingArtSpecialtySpaceTypeId, value); }

        /// <summary>
        /// Building Assembly Space Type
        /// <para>
        /// An area designed primarily for theater productions, assemblies, and other large gatherings.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20817">Building Assembly Space Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingAssemblySpaceTypeId { get => _RefBuildingAssemblySpaceTypeId; set => SetProperty(ref _RefBuildingAssemblySpaceTypeId, value); }

        /// <summary>
        /// Building Basic Classroom Design Type
        /// <para>
        /// A classroom designed for instruction of a particular age group, but not a specific subject.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20796">Building Basic Classroom Design Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingBasicClassroomDesignTypeId { get => _RefBuildingBasicClassroomDesignTypeId; set => SetProperty(ref _RefBuildingBasicClassroomDesignTypeId, value); }

        /// <summary>
        /// Building Career-Technical Education Space Type
        /// <para>
        /// The classroom, laboratory, or shop specially located, designed, furnished, and equipped to support instruction of technical and technology related curriculum, usually tied to particular industry, for example, bio-tech, construction, or agriculture.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20798">Building Career-Technical Education Space Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingCareerTechEducationSpaceTypeId { get => _RefBuildingCareerTechEducationSpaceTypeId; set => SetProperty(ref _RefBuildingCareerTechEducationSpaceTypeId, value); }

        /// <summary>
        /// Building Circulation Space Type
        /// <para>
        /// A space designed to enable people to move within the building.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20799">Building Circulation Space Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingCirculationSpaceTypeId { get => _RefBuildingCirculationSpaceTypeId; set => SetProperty(ref _RefBuildingCirculationSpaceTypeId, value); }

        /// <summary>
        /// Building Food Service Space Type
        /// <para>
        /// The space located, designed, furnished and equipped to support meal programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20802">Building Food Service Space Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingFoodServiceSpaceTypeId { get => _RefBuildingFoodServiceSpaceTypeId; set => SetProperty(ref _RefBuildingFoodServiceSpaceTypeId, value); }

        /// <summary>
        /// Building Full Service Kitchen Type
        /// <para>
        /// The type of kitchen housed in the facility as defined by whether it prepares food to be served onsite and/or at additional locations.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20824">Building Full Service Kitchen Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingFullServiceKitchenTypeId { get => _RefBuildingFullServiceKitchenTypeId; set => SetProperty(ref _RefBuildingFullServiceKitchenTypeId, value); }

        /// <summary>
        /// Building Indoor Athletic or Physical Education Space Type
        /// <para>
        /// The indoor space designed, located, furnished, and equipped for instruction and support of a physical education curriculum and athletic program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20803">Building Indoor Athletic or Physical Education Space Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingIndoorAthleticOrPhysEdSpaceTypeId { get => _RefBuildingIndoorAthleticOrPhysEdSpaceTypeId; set => SetProperty(ref _RefBuildingIndoorAthleticOrPhysEdSpaceTypeId, value); }

        /// <summary>
        /// Building Library or Media Center Specialty Space Type
        /// <para>
        /// The primary and auxiliary space designed to provide and support student and staff access to books, periodicals, software, videos, and the Internet.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20804">Building Library or Media Center Specialty Space Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingLibMediaCenterSpecialtySpaceTypeId { get => _RefBuildingLibMediaCenterSpecialtySpaceTypeId; set => SetProperty(ref _RefBuildingLibMediaCenterSpecialtySpaceTypeId, value); }

        /// <summary>
        /// Building Operations or Maintenance Space Type
        /// <para>
        /// The area designed primarily for conducting activities concerned with maintaining the grounds, buildings, and equipment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20805">Building Operations or Maintenance Space Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingOperationsOrMaintSpaceTypeId { get => _RefBuildingOperationsOrMaintSpaceTypeId; set => SetProperty(ref _RefBuildingOperationsOrMaintSpaceTypeId, value); }

        /// <summary>
        /// Building Outdoor Athletic or Physical Education Space Type
        /// <para>
        /// The outdoor space designed, located, furnished, and equipped for instruction and support of a physical education curriculum and athletic program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20806">Building Outdoor Athletic or Physical Education Space Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId { get => _RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId; set => SetProperty(ref _RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId, value); }

        /// <summary>
        /// Building Outdoor or Non-athletic Space Type
        /// <para>
        /// The outdoor space located, designed, furnished, and equipped primarily for recreation, play and outdoor environmental education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20807">Building Outdoor or Non-athletic Space Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingOutdoorOrNonathleticSpaceTypeId { get => _RefBuildingOutdoorOrNonathleticSpaceTypeId; set => SetProperty(ref _RefBuildingOutdoorOrNonathleticSpaceTypeId, value); }

        /// <summary>
        /// Building Performing Arts Specialty Space Type
        /// <para>
        /// The space designed, located, furnished, and equipped for instruction and support of music and drama curricula and productions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20808">Building Performing Arts Specialty Space Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingPerformingArtsSpecialtySpaceTypeId { get => _RefBuildingPerformingArtsSpecialtySpaceTypeId; set => SetProperty(ref _RefBuildingPerformingArtsSpecialtySpaceTypeId, value); }

        /// <summary>
        /// Building Science Specialty Space Type
        /// <para>
        /// The space designed, located, furnished, and equipped for instruction and experimentation in science.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20810">Building Science Specialty Space Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingScienceSpecialtySpaceTypeId { get => _RefBuildingScienceSpecialtySpaceTypeId; set => SetProperty(ref _RefBuildingScienceSpecialtySpaceTypeId, value); }

        /// <summary>
        /// Building Space Design Type
        /// <para>
        /// The primary design or purpose of a space, as determined by its physical layout and built-in systems and equipment, regardless of its current use.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20812">Building Space Design Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingSpaceDesignTypeId { get => _RefBuildingSpaceDesignTypeId; set => SetProperty(ref _RefBuildingSpaceDesignTypeId, value); }

        /// <summary>
        /// Building Special Education Specialty Space Type
        /// <para>
        /// The space designed, located, furnished, and equipped to support instruction of children with special physical, emotional, and/or educational needs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20813">Building Special Education Specialty Space Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingSpecEdSpecialtySpaceTypeId { get => _RefBuildingSpecEdSpecialtySpaceTypeId; set => SetProperty(ref _RefBuildingSpecEdSpecialtySpaceTypeId, value); }

        /// <summary>
        /// Building Student Support Space Type
        /// <para>
        /// The space designed to provide student support services such as administrative, technical (e.g., guidance and health), and logistical support to facilitate and enhance instruction.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20814">Building Student Support Space Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingStudentSupportSpaceTypeId { get => _RefBuildingStudentSupportSpaceTypeId; set => SetProperty(ref _RefBuildingStudentSupportSpaceTypeId, value); }

        /// <summary>
        /// Facility Space Use Type
        /// <para>
        /// The primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20175">Facility Space Use Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefSpaceUseTypeId { get => _RefSpaceUseTypeId; set => SetProperty(ref _RefSpaceUseTypeId, value); }

        /// <summary>
        /// Facility Space Description
        /// <para>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20174">Facility Space Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String SpaceDescription { get => _SpaceDescription; set => SetProperty(ref _SpaceDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IBuildingSpace model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId; // 
            RefBuildingAdministrativeSpaceTypeId = model.RefBuildingAdministrativeSpaceTypeId; // Building Administrative Space Type
            RefBuildingArtSpecialtySpaceTypeId = model.RefBuildingArtSpecialtySpaceTypeId; // Building Art Specialty Space Type
            RefBuildingAssemblySpaceTypeId = model.RefBuildingAssemblySpaceTypeId; // Building Assembly Space Type
            RefBuildingBasicClassroomDesignTypeId = model.RefBuildingBasicClassroomDesignTypeId; // Building Basic Classroom Design Type
            RefBuildingCareerTechEducationSpaceTypeId = model.RefBuildingCareerTechEducationSpaceTypeId; // Building Career-Technical Education Space Type
            RefBuildingCirculationSpaceTypeId = model.RefBuildingCirculationSpaceTypeId; // Building Circulation Space Type
            RefBuildingFoodServiceSpaceTypeId = model.RefBuildingFoodServiceSpaceTypeId; // Building Food Service Space Type
            RefBuildingFullServiceKitchenTypeId = model.RefBuildingFullServiceKitchenTypeId; // Building Full Service Kitchen Type
            RefBuildingIndoorAthleticOrPhysEdSpaceTypeId = model.RefBuildingIndoorAthleticOrPhysEdSpaceTypeId; // Building Indoor Athletic or Physical Education Space Type
            RefBuildingLibMediaCenterSpecialtySpaceTypeId = model.RefBuildingLibMediaCenterSpecialtySpaceTypeId; // Building Library or Media Center Specialty Space Type
            RefBuildingOperationsOrMaintSpaceTypeId = model.RefBuildingOperationsOrMaintSpaceTypeId; // Building Operations or Maintenance Space Type
            RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId = model.RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId; // Building Outdoor Athletic or Physical Education Space Type
            RefBuildingOutdoorOrNonathleticSpaceTypeId = model.RefBuildingOutdoorOrNonathleticSpaceTypeId; // Building Outdoor or Non-athletic Space Type
            RefBuildingPerformingArtsSpecialtySpaceTypeId = model.RefBuildingPerformingArtsSpecialtySpaceTypeId; // Building Performing Arts Specialty Space Type
            RefBuildingScienceSpecialtySpaceTypeId = model.RefBuildingScienceSpecialtySpaceTypeId; // Building Science Specialty Space Type
            RefBuildingSpaceDesignTypeId = model.RefBuildingSpaceDesignTypeId; // Building Space Design Type
            RefBuildingSpecEdSpecialtySpaceTypeId = model.RefBuildingSpecEdSpecialtySpaceTypeId; // Building Special Education Specialty Space Type
            RefBuildingStudentSupportSpaceTypeId = model.RefBuildingStudentSupportSpaceTypeId; // Building Student Support Space Type
            RefSpaceUseTypeId = model.RefSpaceUseTypeId; // Facility Space Use Type
            SpaceDescription = model.SpaceDescription; // Facility Space Description
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefSpaceUseType List
        /// <summary>
        /// The complete <see cref="RefSpaceUseType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefSpaceUseTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("b2d28c7e-90dc-4feb-b715-dc7347bd0190"), Code="02633", Description="Administration", Definition="Administration is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("12d5e254-8c47-47d6-bdb3-03cff2c4de73"), Code="02634", Description="Assembly", Definition="Assembly is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("3caee2c0-4c74-4693-a506-984834e2ee1a"), Code="02631", Description="Athletic", Definition="Athletic is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("5132e1e9-5c9d-4966-a812-d936890b3ba6"), Code="02628", Description="Basic classroom", Definition="Basic classroom is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("ab58d88d-ebc5-4625-8c89-d63ec864a2eb"), Code="02635", Description="Corridors", Definition="Corridors is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("574f89cb-3e61-4a20-98e3-a006b8bc9d8e"), Code="02639", Description="Dormitory room", Definition="Dormitory room is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("45eef1cb-24af-46db-9538-d8795b115a57"), Code="02638", Description="Food service", Definition="Food service is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("9a3db1e0-7525-475c-84b8-dd472a61b088"), Code="02630", Description="Library/media", Definition="Library/media is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("25223532-f7bf-4982-b905-e6cb59763ef0"), Code="02773", Description="Multi-purpose room", Definition="Multi-purpose room is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("fa607dd2-ed86-4bab-83cb-2ec22d861ab5"), Code="02636", Description="Operational support", Definition="Operational support is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("254aaefa-fa29-4d2c-bcf4-07631f3d96e0"), Code="03017", Description="Restroom", Definition="Restroom is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("fdf2ce7c-91cf-49f6-ad84-2761b084dfd0"), Code="02629", Description="Specialty classroom", Definition="Specialty classroom is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("755404fb-3219-4224-949f-cc2e4fde837d"), Code="02637", Description="Storage", Definition="Storage is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("0b3c2b88-5bf8-40b6-bb97-685600fd29e6"), Code="02788", Description="Storage - hazardous materials", Definition="Storage - hazardous materials is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("28.00") },
            new ReferenceModelBase { Id=Guid.Parse("fbd68515-8f28-46eb-ab31-9b1eeb4dab23"), Code="02632", Description="Student support", Definition="Student support is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("30.00") },
            new ReferenceModelBase { Id=Guid.Parse("421208c2-f535-48f1-af11-07a143a1c2b6"), Code="09999", Description="Other", Definition="The primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("32.00") },
        };
        #endregion
    }
}
