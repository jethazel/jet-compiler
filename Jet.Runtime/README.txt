Jet Runtime

Jet Runtime is a virtual machine (VM).
It targets the Common Language Runtime (CLR) standard.
Everything is written in C#, a modern programming language.
Licensed under the Apache 2.0 License.

Objectives:
	- Easy to understand, modify and extend.

=============================================================================
Compilation:
=============================================================================
1. Source code to .NET assembly
Jet.Runtime.Native code needs one of the following flags:
- PLATFORM_WINDOWS
- PLATFORM_OS_X
- PLATFORM_LINUX

2. .NET assembly to native binary
The runtime's .NET assembly is compiled to native binary using Jet Compiler's
ahead-of-time compilation.

Note:
The runtime can be also run inside any CLR (Microsoft CLR, Mono CLR, etc.).
Nice for debugging.

=============================================================================
Dependencies:
=============================================================================

Jet.Compiler
	License: Apache 2.0 License
	Used by Jet Runtime's Just-In-Time Compiler (JIT).

Mono Base Class Library (http://mono-project.com)
	License: MIT X11
	Provides a standard .NET class library.