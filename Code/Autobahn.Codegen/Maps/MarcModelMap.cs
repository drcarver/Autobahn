using Autobahn.Codegen.Models;
using CsvHelper.Configuration;

namespace Autobahn.Codegen.Maps
{
    public sealed class MarcModelMap : ClassMap<ReferenceModel>
    {
        public MarcModelMap()
        {
            Map(x => x.Description).Index(2);
            Map(x => x.Code).Index(1);
            Map(x => x.Definition).Index(0);
        }
    }
}
