// *******************************************************************************************************
//   File:      IReferencePickListItem.cs
//   CreatedAt: 07/29/2022
// 
// 
//   Copyright ©2020 GoDungeon.com
// *******************************************************************************************************

namespace Autobahn.Core.Interface;

public interface IReferencePickListItem
{
    Guid Id { get; set; }
    string Description { get; set; }
    string Code { get; set; }
}