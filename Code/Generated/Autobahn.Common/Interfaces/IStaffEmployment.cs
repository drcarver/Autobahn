//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IStaffEmployment.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffEmployment Interface
     /// </summary>
    public partial interface IStaffEmployment : IAutobahnBase
    {
        /// <summary>
        /// Staff Full Time Equivalency
        /// <para>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19118">Staff Full Time Equivalency</a>
        /// </para>
        /// </summary>
        System.Decimal? FullTimeEquivalency { get; set; }

        /// <summary>
        /// Hire Date
        /// <para>
        /// The year, month and day on which a person was hired for a position, or consecutive positions within the same organization and job classification.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19143">Hire Date</a>
        /// </para>
        /// </summary>
        System.DateTime? HireDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Position Title
        /// <para>
        /// The descriptive name of a person's position.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19213">Position Title</a>
        /// </para>
        /// </summary>
        System.String PositionTitle { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefEmploymentSeparationReason"/> model
        /// </summary>
        Guid? RefEmploymentSeparationReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefEmploymentSeparationType"/> model
        /// </summary>
        Guid? RefEmploymentSeparationTypeId { get; set; }

        /// <summary>
        /// Standard Occupational Classification
        /// <para>
        /// A Bureau of Labor Statistics coding system for classifying occupations by work performed and, in some cases, on the skills, education and training needed to perform the work at a competent level.  See https://www.bls.gov/soc/2018/major_groups.htm.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19707">Standard Occupational Classification</a>
        /// </para>
        /// </summary>
        System.String StandardOccupationalClassification { get; set; }

        /// <summary>
        /// Union Membership Name
        /// <para>
        /// The name of the labor organization of which the person is a member.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20469">Union Membership Name</a>
        /// </para>
        /// </summary>
        System.String UnionMembershipName { get; set; }

        /// <summary>
        /// Weeks Employed Per Year
        /// <para>
        /// The number of weeks employed by year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20470">Weeks Employed Per Year</a>
        /// </para>
        /// </summary>
        System.Int32? WeeksEmployedPerYear { get; set; }

    }
}
