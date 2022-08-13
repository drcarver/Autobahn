//***************************************************************************
//* DomainName: Workforce Interfaces (used by both models and View Models
//* FileName:   IWorkforceEmploymentQuarterlyData.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Workforce.Interfaces
{
     /// <summary>
     /// The IWorkforceEmploymentQuarterlyData Interface
     /// </summary>
    public partial interface IWorkforceEmploymentQuarterlyData : IAutobahnBase
    {
        /// <summary>
        /// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, and at the same time is enrolled in secondary, postsecondary, or adult education or workforce programs.
        /// </summary>
        System.Decimal? EmployedInMultipleJobsCount { get; set; }

        /// <summary>
        /// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, and at the same time is enrolled in secondary, postsecondary, or adult education or workforce programs.
        /// </summary>
        System.Boolean? MilitaryEnlistmentAfterExit { get; set; }

        /// <summary>
        /// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, and at the same time is enrolled in secondary, postsecondary, or adult education or workforce programs.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, and at the same time is enrolled in secondary, postsecondary, or adult education or workforce programs.
        /// </summary>
        Guid? RefEmployedAfterExitId { get; set; }

        /// <summary>
        /// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, and at the same time is enrolled in secondary, postsecondary, or adult education or workforce programs.
        /// </summary>
        Guid? RefEmployedWhileEnrolledId { get; set; }

    }
}
