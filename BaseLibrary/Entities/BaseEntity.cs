using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        //Relationship : One To Many
        [JsonIgnore] //Prevent this property from being serialized and deserialized
        public List<Employee>? Employees { get; set; }
    }
}
