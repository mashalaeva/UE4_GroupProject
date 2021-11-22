using UnrealBuildTool;

public class SeriousHedgehogsGameTarget : TargetRules
{
	public SeriousHedgehogsGameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("SeriousHedgehogsGame");
	}
}
