//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELStaffEducationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELStaffEducation Model
     /// </summary>
    public partial class ELStaffEducationModel : AutobahnBase, Interfaces.IELStaffEducationModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ELStaff"/> model
        /// </summary>
        public Guid ELStaffId { get; set; }

        /// <summary>
        /// Defines the ELStaffEducation.ECDegreeOrCertificateHolder nullable property
        /// </summary>
        public System.Boolean? ECDegreeOrCertificateHolder { get; set; }

        /// <summary>
        /// Defines the ELStaffEducation.TotalCollegeCreditsEarned nullable property
        /// </summary>
        public System.Decimal? TotalCollegeCreditsEarned { get; set; }

        /// <summary>
        /// Defines the ELStaffEducation.TotalApprovedECCreditsEarned nullable property
        /// </summary>
        public System.Decimal? TotalApprovedECCreditsEarned { get; set; }

        /// <summary>
        /// Defines the ELStaffEducation.SchoolAgeEducationPSCredits nullable property
        /// </summary>
        public System.Decimal? SchoolAgeEducationPSCredits { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELLevelOfSpecialization"/> model
        /// </summary>
        public Guid? RefELLevelOfSpecializationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProfessionalDevelopmentTopicArea"/> model
        /// </summary>
        public Guid? RefELProfessionalDevelopmentTopicAreaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
