//**********************************************************
//* DomainName: Common Models
//* FileName:   IRefK12LeaTitleISupportService.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefK12LeaTitleISupportService Interface Model
     /// </summary>
    public partial interface IRefK12LeaTitleISupportService : IReferenceModel
    {
        /// <summary>
        /// The type of support services provided to students in Title I programs.
        /// </summary>
        Guid RefK12LEATitleISupportServiceId { get; set; }

    }
}
