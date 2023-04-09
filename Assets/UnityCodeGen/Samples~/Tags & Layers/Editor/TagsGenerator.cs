using System.Linq;
using UnityEditorInternal;

namespace UnityCodeGen.Samples.TagsAndLayers
{
    [Generator]
    public class TagsGenerator : ICodeGenerator
    {
        public void Execute(GeneratorContext context)
        {
            var tags = InternalEditorUtility.tags
                .Select(x => $"public const string {x.Replace(" ", string.Empty)} = \"{x}\";");
            var fields = string.Join("\n\t", tags);
            var code =
@$"//<auto-generated/>
public static class Tags
{{
    {fields}
}}";
            context.AddCode("Tags & Layers/Tags.Generated.cs", code);
        }
    }
}