using System.Collections.Generic;

namespace GitPublishTool.Model
{
    public class PublishPathModel
    {
        public string ProjectPath { get; set; }

        public List<string> CsprojPaths { get; set; }
    }
}