//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationIndicator.cs
//***************************************************************************

namespace Autobahn.Education.Interfaces.Common
{
     /// <summary>
     /// The IOrganizationIndicator Interface
     /// </summary>
    public partial interface IOrganizationIndicator : IAutobahnBase
    {
        #region IOrganizationIndicator
        System.String IndicatorValue { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Ability Grouping Status
        /// <para>
        /// An indication of whether the school has students who are ability grouped for classroom instruction in mathematics or English/reading/language arts.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19000">Ability Grouping Status</a>
        /// </para>
        /// </summary>
        Guid RefOrganizationIndicatorId { get; set; }

        #endregion
    }
}
