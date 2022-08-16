//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IRole.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRole Interface
     /// </summary>
    public partial interface IRole : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefRoleId { get; set; }

    }
}
