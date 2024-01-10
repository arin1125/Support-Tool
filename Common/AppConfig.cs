﻿using Nucs.JsonSettings;
using Nucs.JsonSettings.Modulation;

namespace Support_Tool.Common;
public class AppConfig : JsonSettings, IVersionable
{
    [EnforcedVersion("1.0.0.0")]
    public virtual Version Version { get; set; } = new Version(1, 0, 0, 0);

    public override string FileName { get; set; } = Constants.AppConfigPath;

    public virtual string LastUpdateCheck { get; set; }

    // Docs: https://github.com/Nucs/JsonSettings
}
