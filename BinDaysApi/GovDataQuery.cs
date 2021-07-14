using System.IO;
using System.Net;

namespace BinDaysApi
{
    public class GovDataQuery
    {
        private readonly string api = "https://data.gov.au/geoserver/ballarat-garbage-collection/wfs";
        private readonly string options = "?request=GetFeature&typeName=ckan_4a7a3e5b_a20c_431e_bd21_ada983b0566f&outputFormat=json";
    }
}
