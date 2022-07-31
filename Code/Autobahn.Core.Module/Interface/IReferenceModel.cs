// *******************************************************************************************************
//   File:      IReferenceModel.cs
//   CreatedAt: 07/26/2022
// 
// 
//   Copyright ©2020 GoDungeon.com
// *******************************************************************************************************

namespace Autobahn.Core.Interface;

public interface IReferenceModel
{
    Guid Id { get; set; }
    public string Description { get; set; }
    public string Code { get; set; }
    public string Definition { get; set; }
    public Guid? RefJurisdictionId { get; set; }
    public decimal? SortOrder { get; set; }
    public DateTime? RecordStartDateTime { get; set; }
    public DateTime? RecordEndDateTime { get; set; }
}