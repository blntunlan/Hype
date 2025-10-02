// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Hype : ModuleRules
{
	public Hype(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Hype",
			"Hype/Variant_Platforming",
			"Hype/Variant_Platforming/Animation",
			"Hype/Variant_Combat",
			"Hype/Variant_Combat/AI",
			"Hype/Variant_Combat/Animation",
			"Hype/Variant_Combat/Gameplay",
			"Hype/Variant_Combat/Interfaces",
			"Hype/Variant_Combat/UI",
			"Hype/Variant_SideScrolling",
			"Hype/Variant_SideScrolling/AI",
			"Hype/Variant_SideScrolling/Gameplay",
			"Hype/Variant_SideScrolling/Interfaces",
			"Hype/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
