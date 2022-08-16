//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationPersonRoleFTE.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPersonRoleFTE Interface
     /// </summary>
    public partial interface IOrganizationPersonRoleFTE : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         FullTimeEquivalency { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RecordStartDateTime { get; set; }

    }
}
