using UnrealBuildTool;

public class JamCraftTarget : TargetRules
{
	public JamCraftTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("JamCraft");
	}
}
