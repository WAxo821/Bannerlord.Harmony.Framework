# RagdollFix
A lightweight Harmony patch for Mount&Blade II:Banneerlord(v1.3.14) that caps ragdoll velocity to reduce the"launching corpse"effect.
## What it does
Vanilla Bannerlord ragdoll work fine, but the corpses feel too soft and floppy just like noddles. This mod adjusts the "Linear velocity limit" to give
dead bodies more weight and rigidity, making death feel more impactful.
## How it works
-Uses"Harmony" to patch the game's ragdoll logic at runtime
- Reads a configurable velocity cap from "ModuleConfig.xml"
- Falls back to a default value of '5.0' if the XML is missing or invalid
## Why not a full rewrite?
The original goal was to overhaul the entire ragdoll system. However，the game's v1.3.14 API only exposes limited ragdoll parameters. Wroking within those constraints,adjusting the linear velocity limit was the most imactful change possible without engine level access.
## Configuration
Edit'Module/RagdollFix/ModuleConfig.xml:
'''xml
<Settings>
    <LinearVelocityLimit>5.0</LinearVelocityLimit>
</Settings>
Lower values=stiffer,heavier corpses.
Higher values=softer,more vanilla-like.

Requirements
Mount&Blade II:BannerlordV1.3.14
Harmony(bundled with the game)

Installation
1.Download the mod
2.Place the RagdollFix folder inside your Modules directory
3.Enable it in the Bannerlord launcher

Credits
Built as a hands-on learing project for Harmony patching,runtime C# modification,and working within real-world API constraints.Made by someone who thought corpses should feel like bodies,not noddles.
