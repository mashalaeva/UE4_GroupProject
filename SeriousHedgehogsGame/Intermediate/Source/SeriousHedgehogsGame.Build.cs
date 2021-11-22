using UnrealBuildTool;

public class SeriousHedgehogsGame : ModuleRules
{
	public SeriousHedgehogsGame(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
