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
using System.Collections.Generic;
using Jet.Compiler.Framework.Machines;

namespace Jet.Compiler.Modules.Machines.X86
{
    public static class X86Registers
    {
        // Flags and instruction pointer
        public static readonly X86Register EFLAGS = Create("eflags", 0, 32, X86Specs.X86);
        public static readonly X86Register EIP = Create("eip", 0, 32, X86Specs.X86);
        // 64-bit extensions
        public static readonly X86Register RFLAGS = Create("rflags", 0, 64, X86Specs.X86_64);
        public static readonly X86Register RIP = Create("rip", 0, 64, X86Specs.X86_64);

        // 8-bit general-purpose registers
        public static readonly X86Register AL = Create8("al", 0, X86Specs.X86);
        public static readonly X86Register CL = Create8("cl", 1, X86Specs.X86);
        public static readonly X86Register DL = Create8("dl", 2, X86Specs.X86);
        public static readonly X86Register BL = Create8("bl", 3, X86Specs.X86);
        public static readonly X86Register AH = Create8("ah", 4, X86Specs.X86);
        public static readonly X86Register CH = Create8("ch", 5, X86Specs.X86);
        public static readonly X86Register DH = Create8("dh", 6, X86Specs.X86);
        public static readonly X86Register BH = Create8("bh", 7, X86Specs.X86);

        // 16-bit general-purpose registers
        public static readonly X86Register AX = Create16("ax", 0, X86Specs.X86);
        public static readonly X86Register CX = Create16("cx", 1, X86Specs.X86);
        public static readonly X86Register DX = Create16("dx", 2, X86Specs.X86);
        public static readonly X86Register BX = Create16("bx", 3, X86Specs.X86);
        public static readonly X86Register SP = Create16("sp", 4, X86Specs.X86);
        public static readonly X86Register BP = Create16("bp", 5, X86Specs.X86);
        public static readonly X86Register SI = Create16("si", 6, X86Specs.X86);
        public static readonly X86Register DI = Create16("di", 7, X86Specs.X86);

        // 32-bit general-purpose registers:
        public static readonly X86Register EAX = Create32("eax", 0, X86Specs.X86);
        public static readonly X86Register ECX = Create32("ecx", 1, X86Specs.X86);
        public static readonly X86Register EDX = Create32("edx", 2, X86Specs.X86);
        public static readonly X86Register EBX = Create32("ebx", 3, X86Specs.X86);
        public static readonly X86Register ESP = Create32("esp", 4, X86Specs.X86);
        public static readonly X86Register EBP = Create32("ebp", 5, X86Specs.X86);
        public static readonly X86Register ESI = Create32("esi", 6, X86Specs.X86);
        public static readonly X86Register EDI = Create32("edi", 7, X86Specs.X86);


        // 64-bit general-purpose registers:
        public static readonly X86Register RAX = Create64("rax", 0, X86Specs.X86_64);
        public static readonly X86Register RBX = Create64("rbx", 1, X86Specs.X86_64);
        public static readonly X86Register RCX = Create64("rcx", 2, X86Specs.X86_64);
        public static readonly X86Register RDX = Create64("rdx", 3, X86Specs.X86_64);
        public static readonly X86Register RSP = Create64("rsp", 4, X86Specs.X86_64);
        public static readonly X86Register RBP = Create64("rbp", 5, X86Specs.X86_64);
        public static readonly X86Register RSI = Create64("rsi", 6, X86Specs.X86_64);
        public static readonly X86Register RDI = Create64("rdi", 7, X86Specs.X86_64);
        // Extra registers
        public static readonly X86Register R8 = Create("r8", 8, 64, X86Specs.X86_64);
        public static readonly X86Register R9 = Create("r9", 9, 64, X86Specs.X86_64);
        public static readonly X86Register R10 = Create("r10", 10, 64, X86Specs.X86_64);
        public static readonly X86Register R11 = Create("r11", 11, 64, X86Specs.X86_64);
        public static readonly X86Register R12 = Create("r12", 12, 64, X86Specs.X86_64);
        public static readonly X86Register R13 = Create("r13", 13, 64, X86Specs.X86_64);
        public static readonly X86Register R14 = Create("r14", 14, 64, X86Specs.X86_64);
        public static readonly X86Register R15 = Create("r15", 15, 64, X86Specs.X86_64);

        // MMX registers
        public static readonly X86Register MM0 = Create("mm0", 0, 64, X86Specs.MMX);
        public static readonly X86Register MM1 = Create("mm1", 1, 64, X86Specs.MMX);
        public static readonly X86Register MM2 = Create("mm2", 2, 64, X86Specs.MMX);
        public static readonly X86Register MM3 = Create("mm3", 3, 64, X86Specs.MMX);
        public static readonly X86Register MM4 = Create("mm4", 4, 64, X86Specs.MMX);
        public static readonly X86Register MM5 = Create("mm5", 5, 64, X86Specs.MMX);
        public static readonly X86Register MM6 = Create("mm6", 6, 64, X86Specs.MMX);
        public static readonly X86Register MM7 = Create("mm7", 7, 64, X86Specs.MMX);

        // SSE registers
        public static readonly X86Register XMM0 = Create("xmm0", 0, 64, X86Specs.SSE_1);
        public static readonly X86Register XMM1 = Create("xmm1", 1, 64, X86Specs.SSE_1);
        public static readonly X86Register XMM2 = Create("xmm2", 2, 64, X86Specs.SSE_1);
        public static readonly X86Register XMM3 = Create("xmm3", 3, 64, X86Specs.SSE_1);
        public static readonly X86Register XMM4 = Create("xmm4", 4, 64, X86Specs.SSE_1);
        public static readonly X86Register XMM5 = Create("xmm5", 5, 64, X86Specs.SSE_1);
        public static readonly X86Register XMM6 = Create("xmm6", 6, 64, X86Specs.SSE_1);
        public static readonly X86Register XMM7 = Create("xmm7", 7, 64, X86Specs.SSE_1);
        // In x86-64 the number of registers was doubled
        public static readonly X86Register XMM8 = Create("xmm8", 8, 64, X86Specs.X86_64);
        public static readonly X86Register XMM9 = Create("xmm9", 9, 64, X86Specs.X86_64);
        public static readonly X86Register XMM10 = Create("xmm10", 10, 64, X86Specs.X86_64);
        public static readonly X86Register XMM11 = Create("xmm11", 11, 64, X86Specs.X86_64);
        public static readonly X86Register XMM12 = Create("xmm12", 12, 64, X86Specs.X86_64);
        public static readonly X86Register XMM13 = Create("xmm13", 13, 64, X86Specs.X86_64);
        public static readonly X86Register XMM14 = Create("xmm14", 14, 64, X86Specs.X86_64);
        public static readonly X86Register XMM15 = Create("xmm15", 15, 64, X86Specs.X86_64);

        // AVX registers
        public static readonly X86Register YMM0 = Create("ymm0", 0, 256, X86Specs.AVX);
        public static readonly X86Register YMM1 = Create("ymm1", 1, 256, X86Specs.AVX);
        public static readonly X86Register YMM2 = Create("ymm2", 2, 256, X86Specs.AVX);
        public static readonly X86Register YMM3 = Create("ymm3", 3, 256, X86Specs.AVX);
        public static readonly X86Register YMM4 = Create("ymm4", 4, 256, X86Specs.AVX);
        public static readonly X86Register YMM5 = Create("ymm5", 5, 256, X86Specs.AVX);
        public static readonly X86Register YMM6 = Create("ymm6", 6, 256, X86Specs.AVX);
        public static readonly X86Register YMM7 = Create("ymm7", 7, 256, X86Specs.AVX);
        public static readonly X86Register YMM8 = Create("ymm8", 8, 256, X86Specs.AVX);
        public static readonly X86Register YMM9 = Create("ymm9", 9, 256, X86Specs.AVX);
        public static readonly X86Register YMM10 = Create("ymm10", 10, 256, X86Specs.AVX);
        public static readonly X86Register YMM11 = Create("ymm11", 11, 256, X86Specs.AVX);
        public static readonly X86Register YMM12 = Create("ymm12", 12, 256, X86Specs.AVX);
        public static readonly X86Register YMM13 = Create("ymm13", 13, 256, X86Specs.AVX);
        public static readonly X86Register YMM14 = Create("ymm14", 14, 256, X86Specs.AVX);
        public static readonly X86Register YMM15 = Create("ymm15", 15, 256, X86Specs.AVX);

        public static readonly ICollection<X86Register> AllRegisters = new HashSet<X86Register>();

        private static X86Register Create(string name, int number, int size, MachineSpec set)
        {
            var r = new X86Register(name, number, size, set);
            AllRegisters.Add(r);
            return r;
        }

        private static X86Register8 Create8(string name, int number, MachineSpec set)
        {
            var r = new X86Register8(name, number, size, set);
            AllRegisters.Add(r);
            return r;
        }

        private static X86Register16 Create16(string name, int number, MachineSpec set)
        {
            var r = new X86Register16(name, number, size, set);
            AllRegisters.Add(r);
            return r;
        }

        private static X86Register32 Create32(string name, int number, MachineSpec set)
        {
            var r = new X86Register32(name, number, size, set);
            AllRegisters.Add(r);
            return r;
        }

        private static X86Register64 Create64(string name, int number, MachineSpec set)
        {
            var r = new X86Register64(name, number, size, set);
            AllRegisters.Add(r);
            return r;
        }

        private static Dictionary<string, X86Register> registerDict;

        public static X86Register GetRegister(string s)
        {
            if (registerDict == null)
            {
                registerDict = new Dictionary<string, X86Register>();
                foreach (X86Register r in AllRegisters)
                {
                    registerDict.Add(r.Name.ToLowerInvariant(), r);
                }
            }
            return registerDict[s];
        }
    }
}