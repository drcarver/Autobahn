//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IRoleStatus.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRoleStatus Interface
     /// </summary>
    public partial interface IRoleStatus : IAutobahnBase
    {
        /// <summary>
        /// An indication as to whether a student's name was, is, or will be officially registered on the roll of a school or schools.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// An indication as to whether a student's name was, is, or will be officially registered on the roll of a school or schools.
        /// </summary>
        Guid? RefRoleStatusId { get; set; }

        /// <summary>
        /// An indication as to whether a student's name was, is, or will be officially registered on the roll of a school or schools.
        /// </summary>
        System.DateTime? StatusEndDate { get; set; }

        /// <summary>
        /// An indication as to whether a student's name was, is, or will be officially registered on the roll of a school or schools.
        /// </summary>
        System.DateTime StatusStartDate { get; set; }

    }
}
