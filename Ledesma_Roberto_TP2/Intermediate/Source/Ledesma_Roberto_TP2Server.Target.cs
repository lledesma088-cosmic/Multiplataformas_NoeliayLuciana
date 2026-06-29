using UnrealBuildTool;

public class Ledesma_Roberto_TP2ServerTarget : TargetRules
{
	public Ledesma_Roberto_TP2ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Ledesma_Roberto_TP2");
	}
}
