//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELStaffEducationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELStaffEducation Model
     /// </summary>
    public partial class ELStaffEducationModel : AutobahnBase, Interfaces.IELStaffEducation
    {
        /// <summary>
        /// The extent to which a person concentrates upon a particular subject matter area during his or her period of study at an educational institution.
        /// </summary>
        public System.Boolean? ECDegreeOrCertificateHolder { get; set; }

        /// <summary>
        /// The extent to which a person concentrates upon a particular subject matter area during his or her period of study at an educational institution.
        /// </summary>
        public Guid ELStaffId { get; set; }

        /// <summary>
        /// The extent to which a person concentrates upon a particular subject matter area during his or her period of study at an educational institution.
        /// </summary>
        public Guid? RefELLevelOfSpecializationId { get; set; }

        /// <summary>
        /// The extent to which a person concentrates upon a particular subject matter area during his or her period of study at an educational institution.
        /// </summary>
        public Guid? RefELProfessionalDevelopmentTopicAreaId { get; set; }

        /// <summary>
        /// The extent to which a person concentrates upon a particular subject matter area during his or her period of study at an educational institution.
        /// </summary>
        public System.Decimal? SchoolAgeEducationPSCredits { get; set; }

        /// <summary>
        /// The extent to which a person concentrates upon a particular subject matter area during his or her period of study at an educational institution.
        /// </summary>
        public System.Decimal? TotalApprovedECCreditsEarned { get; set; }

        /// <summary>
        /// The extent to which a person concentrates upon a particular subject matter area during his or her period of study at an educational institution.
        /// </summary>
        public System.Decimal? TotalCollegeCreditsEarned { get; set; }

    }
}
