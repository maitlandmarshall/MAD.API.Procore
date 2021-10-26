using System.Collections.Generic;

namespace CSCodeGen
{
    public class ClassModel
    {
        public string Name { get; set; }
        public string Namespace { get; set; }
        public ClassModel BaseClass { get; set; }

        public string AccessModifier { get; set; }

        public IList<string> Generics { get; } = new List<string>();
        public IList<string> Usings { get; } = new List<string>();
        public IList<PropertyModel> Properties { get; } = new List<PropertyModel>();
    }
}
