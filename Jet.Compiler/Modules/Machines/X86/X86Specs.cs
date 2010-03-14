// Copyright 2010 jethazel@gmail.com.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 
using Jet.Compiler.Framework.Machines;

namespace Jet.Compiler.Modules.Machines.X86
{
    public static class X86Specs
    {
        public static readonly MachineSpec X86_16 = new MachineSpec("x86_16");
        public static readonly MachineSpec X86_32 = new MachineSpec("x86_32", X86_16);
        public static readonly MachineSpec X86 = X86_32;
        public static readonly MachineSpec MMX = new MachineSpec("mmx");
        public static readonly MachineSpec SSE_1 = new MachineSpec("sse1", MMX);
        public static readonly MachineSpec SSE_2 = new MachineSpec("sse2", SSE_1);
        public static readonly MachineSpec SSE_3 = new MachineSpec("sse2", SSE_2);
        public static readonly MachineSpec SSE_4 = new MachineSpec("sse2", SSE_3);
        public static readonly MachineSpec SSE_4_1 = new MachineSpec("sse4.1", SSE_4);
        public static readonly MachineSpec SSE_4_2 = new MachineSpec("sse4.2", SSE_4_1);
        public static readonly MachineSpec SSE_5 = new MachineSpec("sse4.2", SSE_5);
        public static readonly MachineSpec X86_64 = new MachineSpec("x86_64", X86_32, MMX, SSE_3);
        public static readonly MachineSpec AMD_3DNOW = new MachineSpec("3dnow");
        public static readonly MachineSpec AVX = new MachineSpec("avx");
        public static readonly MachineSpec NATIVE_CLIENT = new MachineSpec("x86_nacl");
    }
}