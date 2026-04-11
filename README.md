# Bannerlord Harmony Patching Framework

## Overview
A lightweight Harmony-based runtime patching infrastructure for Mount & Blade II: Bannerlord, demonstrating IL injection and cross-version compatibility techniques in a closed-source .NET environment.

## Technical Highlights
- **Runtime Patching**: Successfully hooks into `Agent.SetVelocityLimitsOnRagdoll` to override physics behavior.
- **Harmony Integration**: Utilizes `Harmony.PatchAll()` for clean, maintainable IL injection.
- **Exception Shielding**: Prefix patch safely modifies `linearVelocityLimit` without disrupting host execution.

## Skills Demonstrated
This project serves as a portfolio piece showcasing:
1. Reverse-engineering and extending proprietary .NET applications.
2. Clean, maintainable C# code with Harmony patching patterns.
3. Long-term project maintenance with documented iteration history.

## Project Structure
- `src/Main.cs` – Harmony patch source code (prefix patch on `Agent.SetVelocityLimitsOnRagdoll`).
- `SubModule.xml` – Bannerlord module manifest.
- `bin/` – Compiled assembly output.
- `.gitignore` – Excludes build artifacts from version control.

*Maintained as a technical portfolio piece for ACS skills assessment.*
