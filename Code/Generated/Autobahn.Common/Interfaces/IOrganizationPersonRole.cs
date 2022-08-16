//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationPersonRole.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPersonRole Interface
     /// </summary>
    public partial interface IOrganizationPersonRole : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? EntryDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ExitDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

    }
}
