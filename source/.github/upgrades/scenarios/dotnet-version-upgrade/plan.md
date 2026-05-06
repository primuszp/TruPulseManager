# Plan

## Strategy
- Convert legacy .NET Framework 3.5 projects to SDK-style and migrate to .NET 8.0.
- Do changes incrementally per project and validate by building solution after each project conversion.
- Commit after each task.

## Tasks
1. 01-convert-project-file — Convert the TruPulseManager project to SDK-style and update target framework to net8.0.
2. 02-update-packages — Update NuGet packages to versions compatible with net8.0 or replace them.
3. 03-fix-code — Apply code changes to address API breaking changes.
4. 04-validate-build — Build solution and run any tests, fix remaining errors.

## Commit Strategy
- After Each Task
