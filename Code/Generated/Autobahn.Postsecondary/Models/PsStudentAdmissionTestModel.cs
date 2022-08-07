//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentAdmissionTestModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentAdmissionTest Model
     /// </summary>
    public partial class PsStudentAdmissionTestModel : AutobahnBase, Interfaces.IPsStudentAdmissionTestModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefStandardizedAdmissionTest"/> model
        /// </summary>
        public Guid RefStandardizedAdmissionTestId { get; set; }

        /// <summary>
        /// Defines the PsStudentAdmissionTest.StandardizedAdmissionTestScore nullable property
        /// </summary>
        public System.Decimal? StandardizedAdmissionTestScore { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
