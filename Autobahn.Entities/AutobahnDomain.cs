// *******************************************************************************************************
//   File:      AutobahnDomain.cs
//   CreatedAt: 08/08/2022
// 
// 
//   Copyright ©2020 GoDungeon.com
// *******************************************************************************************************

using System;

namespace Autobahn.Entities
{
    public class AutobahnDomain
    {
        public string Module { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
    }
}