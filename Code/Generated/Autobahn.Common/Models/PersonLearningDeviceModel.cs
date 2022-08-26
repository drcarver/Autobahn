//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonLearningDeviceModel.cs
//***************************************************************************

using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonLearningDevice Model
     /// </summary>
    public partial class PersonLearningDeviceModel : AutobahnBase, IPersonLearningDevice
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Primary Learning Device Access
        /// <para>
        /// An indication of whether the primary learning device is shared or not shared with another individual
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20952">Primary Learning Device Access</a>
        /// </para>
        /// </summary>
        public Guid? RefPrimaryLearningDeviceAccessId { get; set; }

        /// <summary>
        /// Primary Learning Device Away From School
        /// <para>
        /// The type of device the student uses most often to complete learning activities away from school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20953">Primary Learning Device Away From School</a>
        /// </para>
        /// </summary>
        public Guid? RefPrimaryLearningDeviceAwayFromSchoolId { get; set; }

        /// <summary>
        /// Primary Learning Device Provider
        /// <para>
        /// The provider of the primary learning device.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20954">Primary Learning Device Provider</a>
        /// </para>
        /// </summary>
        public Guid? RefPrimaryLearningDeviceProviderId { get; set; }

    }
}
