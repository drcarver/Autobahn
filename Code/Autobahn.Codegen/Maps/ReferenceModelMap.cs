using Autobahn.Codegen.Models;
using Autobahn.Entities.Common;
using CsvHelper.Configuration;

namespace Autobahn.Codegen.Maps
{
    public sealed class ReferenceModelMap : ClassMap<EntityReferenceBase>
    {
        public ReferenceModelMap()
        {
            Map(x => x.Description).Index(1);
            Map(x => x.Code).Index(2);
            Map(x => x.Definition).Index(3);
            Map(x => x.SortOrder).Index(5);
        }
    }
}
