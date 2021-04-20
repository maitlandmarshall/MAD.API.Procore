using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCodeGen
{
    public static class ClassSerialization
    {
        public static string Serialize(ClassModel classModel)
        {
            StringBuilder sb = new StringBuilder();

            string usings = string.Join(Environment.NewLine, classModel.Usings.Select(y => "using " + y + ";"));
            sb.AppendLine(usings);

            sb.AppendLine($"namespace {classModel.Namespace} {{");
            sb.Append($"\t{classModel.AccessModifier ?? "public"} class {classModel.Name}");

            if (classModel.BaseClass != null)
            {
                sb.Append($" : {classModel.BaseClass.Name}");

                if(classModel.BaseClass.Generics.Any())
                {
                    sb.Append($"<{string.Join(",", classModel.BaseClass.Generics)}>");
                }
            }

            sb.AppendLine(" {");

            foreach (var p in classModel.Properties)
            {
                sb.AppendLine();
                sb.AppendLine(Serialize(p, "\t\t"));
            }

            sb.AppendLine("\t}");
            sb.AppendLine("}");

            return sb.ToString();
        }

        private static string Serialize(PropertyModel propertyModel, string tabs = "")
        {
            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrEmpty(propertyModel.Comment))
            {
                var comment = propertyModel.Comment.Replace("\n", $"\n{tabs}/// ");

                sb.AppendLine($"{tabs}/// <summary>");
                sb.AppendLine($"{tabs}/// {comment}");
                sb.AppendLine($"{tabs}/// </summary>");
            }

            sb.Append(tabs);
            sb.Append(string.Join("", propertyModel.Attributes.Select(y => "[" + y + "]")));

            if (propertyModel.Attributes.Any())
                sb.Append("\t");

            sb.Append($"public {(propertyModel.Override ? "override" : "")} {propertyModel.Type}{(propertyModel.IsNullable ? "?" :"")} {propertyModel.Name} {{ get ");

            if(string.IsNullOrEmpty(propertyModel.Getter)
                && string.IsNullOrEmpty(propertyModel.Setter))
            {
                sb.Append("; set; ");
            }
            else
            {
                if (!string.IsNullOrEmpty(propertyModel.Getter))
                {
                    sb.Append("=> ");
                    sb.Append(propertyModel.Getter);

                    if (!propertyModel.Getter.EndsWith(";"))
                        sb.Append(";");
                }
                else
                {
                    sb.Append(";");
                }

                if (!string.IsNullOrEmpty(propertyModel.Setter))
                {
                    sb.Append("=> ");
                    sb.Append(propertyModel.Setter);

                    if (!propertyModel.Setter.EndsWith(";"))
                        sb.Append(";");
                }
            }

            sb.Append("}");

            return sb.ToString();
        }
    }
}
