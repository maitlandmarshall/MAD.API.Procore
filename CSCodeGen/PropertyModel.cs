using System.Collections.Generic;

namespace CSCodeGen
{
    public class PropertyModel
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Type { get; set; }

        public bool IsNullable { get; set; }

        public string Getter { get; set; }
        public string Setter { get; set; }

        public bool Override { get; set; }

        public IList<string> Attributes { get; } = new List<string>();
    }
}