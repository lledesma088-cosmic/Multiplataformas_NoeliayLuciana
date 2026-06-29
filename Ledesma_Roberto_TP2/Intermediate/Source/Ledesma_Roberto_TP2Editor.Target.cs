using UnrealBuildTool;

public class Ledesma_Roberto_TP2EditorTarget : TargetRules
{
	public Ledesma_Roberto_TP2EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Ledesma_Roberto_TP2");
	}
}
