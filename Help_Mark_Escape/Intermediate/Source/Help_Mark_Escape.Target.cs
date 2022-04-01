using UnrealBuildTool;

public class Help_Mark_EscapeTarget : TargetRules
{
	public Help_Mark_EscapeTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Help_Mark_Escape");
	}
}
