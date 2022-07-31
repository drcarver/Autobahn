// *******************************************************************************************************
//   File:      ReferencePickListItem.cs
//   CreatedAt: 07/29/2022
// 
// 
//   Copyright ©2020 GoDungeon.com
// *******************************************************************************************************

using Autobahn.Core.Interface;

namespace Autobahn.Core.Models;

public partial class ReferencePickListItem : IReferencePickListItem
{
    public Guid Id { get; set; }
    public string Description { get; set; }
    public string Code { get; set; }
}