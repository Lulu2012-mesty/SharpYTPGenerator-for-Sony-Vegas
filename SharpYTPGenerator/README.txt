SharpYTPGenerator
=================

A simple WinForms tool built for SharpDevelop / .NET Framework 4.0 that creates a **Vegas Pro 14** C# script
to auto-assemble a chaotic YTP-style timeline from a folder of media.

Workflow
--------
1) Open the solution in SharpDevelop (or Visual Studio 2010+).
2) Build & run the app.
3) Pick your source folder and tweak options.
4) Choose an output filename (e.g., `GeneratedYTP.cs`).
5) Click **Generate Vegas Script**.
6) In **VEGAS Pro 14**: `Tools > Scripting > Run Script...` and choose the `.cs` you generated.

Notes
-----
- This app DOES NOT create a `.veg` file. Instead, it emits a C# script that VEGAS Pro compiles and runs.
- The script places tiny random video/audio snippets on fresh tracks. Audio "stutter" is created by slicing short audio repeats.
- If VEGAS complains about stream indices: make sure your media has audio/video streams. The script guards most exceptions.
- You can re-run the script many times to re-roll randomness (change Seed to reproduce).

Tested Targets
--------------
- .NET Framework 4.0
- SharpDevelop 4.x/5.x (legacy) and VS 2010+.

License
-------
Public Domain / Unlicense.
