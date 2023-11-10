namespace UnityCodeGen
{
    public interface ICodeGenerator
    {
        public void Execute(GeneratorContext context);

    }


    public interface ICodeGenerator<TAdditionalParam>
    {
        public void Execute(GeneratorContext context, TAdditionalParam additionalParam);
    }
}
