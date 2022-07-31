// *******************************************************************************************************
//   File:      ReferencePickList.cs
//   CreatedAt: 07/29/2022
// 
// 
//   Copyright ©2020 GoDungeon.com
// *******************************************************************************************************

using Autobahn.Core.Interface;

namespace Autobahn.Core.Models;

public partial class ReferencePickList
{
    public string Title { get; set; }
    public List<IReferencePickListItem> ReferenceModelPickList { get; set; }
    public IReferencePickListItem SelectedItem { get; set; }
}
