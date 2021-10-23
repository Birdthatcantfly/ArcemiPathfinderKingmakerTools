﻿namespace Arcemi.Pathfinder.Kingmaker
{
    public class ImportOptions
    {
        public static ImportOptions CodeScripts = new ImportOptions {
            Deep = true,
            IncludeSystemProperties = false,
            Arrays = ImportArrayOptions.Replace,
            Objects = ImportObjectOptions.Replace
        };

        public bool Deep { get; set; }
        public bool IncludeSystemProperties { get; set; }
        public ImportArrayOptions Arrays { get; set; }
        public ImportObjectOptions Objects { get; set; }
    }
    public enum ImportArrayOptions
    {
        Concat,
        Replace,
        Overwrite
    }
    public enum ImportObjectOptions
    {
        Replace,
        Overwrite
    }
}