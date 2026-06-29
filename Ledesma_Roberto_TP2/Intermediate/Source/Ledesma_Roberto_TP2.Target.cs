using UnrealBuildTool;

public class Ledesma_Roberto_TP2Target : TargetRules
{
	public Ledesma_Roberto_TP2Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Ledesma_Roberto_TP2");
	}
}
