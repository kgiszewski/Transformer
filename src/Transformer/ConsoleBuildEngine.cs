using System;
using System.Collections;
using Microsoft.Build.Framework;

namespace Transformer
{
    public class ConsoleBuildEngine : IBuildEngine
    {
        public int ColumnNumberOfTaskNode
        {
            get { return 0; }
        }

        public bool ContinueOnError
        {
            get { return true; }
        }

        public int LineNumberOfTaskNode
        {
            get { return 0; }
        }

        public string ProjectFileOfTaskNode
        {
            get { return ""; }
        }

        public bool BuildProjectFile(string projectFileName, string[] targetNames, IDictionary globalProperties,
            IDictionary targetOutputs)
        {
            throw new NotImplementedException();
        }

        public void LogCustomEvent(CustomBuildEventArgs e)
        {
            Console.WriteLine("[Custom] " + e.Message);
        }

        public void LogErrorEvent(BuildErrorEventArgs e)
        {
            Console.WriteLine("[Error] " + e.Message);
        }

        public void LogMessageEvent(BuildMessageEventArgs e)
        {
            Console.WriteLine("[Message] " + e.Message);
        }

        public void LogWarningEvent(BuildWarningEventArgs e)
        {
            Console.WriteLine("[Warn] " + e.Message);
        }
    }
}
