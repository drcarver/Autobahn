//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeProviderModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The AeProvider Model
     /// </summary>
    public partial class AeProviderModel : AutobahnBase, Interfaces.IAeProvider
    {
        /// <summary>
        /// A classification of whether a postsecondary institution's highest level of offering is a program of 4-years or higher (4 year), 2-but-less-than 4-years (2 year), or less than 2-years.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// A classification of whether a postsecondary institution's highest level of offering is a program of 4-years or higher (4 year), 2-but-less-than 4-years (2 year), or less than 2-years.
        /// </summary>
        public Guid RefLevelOfInstitutionId { get; set; }

    }
}
