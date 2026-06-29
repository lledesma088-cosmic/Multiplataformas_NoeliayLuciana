using UnrealBuildTool;

public class Ledesma_Roberto_TP2ClientTarget : TargetRules
{
	public Ledesma_Roberto_TP2ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Ledesma_Roberto_TP2");
	}
}
