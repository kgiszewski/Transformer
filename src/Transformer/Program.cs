namespace Transformer
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlTransformer = new Microsoft.Web.Publishing.Tasks.TransformXml();
            
            xmlTransformer.Source = args[0];
            xmlTransformer.Destination = args[0];
            xmlTransformer.Transform = args[1];
            xmlTransformer.BuildEngine = new ConsoleBuildEngine();

            xmlTransformer.Execute();
        }
    }
}
