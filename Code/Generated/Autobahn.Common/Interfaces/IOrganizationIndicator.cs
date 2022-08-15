//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationIndicator.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationIndicator Interface
     /// </summary>
    public partial interface IOrganizationIndicator : IAutobahnBase
    {
        /// <summary>
        /// An indication of whether the school has students who are ability grouped for classroom instruction in mathematics or English/reading/language arts.
        /// </summary>
        Guid RefOrganizationIndicatorId { get; set; }

    }
}
