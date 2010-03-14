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

namespace Jet.Compiler.Modules.Machines.Arm
{
    public static class ArmRegisters
    {
        // Argument 1 / return value, temporary register
        public static readonly MachineRegister R0 = Create("r0", 0, 32, ArmSpecs.ARM);
        // Argument 2 / return value second half, temporary register
        public static readonly MachineRegister R1 = Create("r1", 1, 32, ArmSpecs.ARM);
        // Arguments, temporary registers
        public static readonly MachineRegister R2 = Create("r2", 2, 32, ArmSpecs.ARM);
        public static readonly MachineRegister R3 = Create("r3", 3, 32, ArmSpecs.ARM);
        // Permanent registers
        public static readonly MachineRegister R4 = Create("r4", 4, 32, ArmSpecs.ARM);
        public static readonly MachineRegister R5 = Create("r5", 5, 32, ArmSpecs.ARM);
        public static readonly MachineRegister R6 = Create("r6", 6, 32, ArmSpecs.ARM);
        // THUMB frame pointer
        public static readonly MachineRegister R7 = Create("r7", 7, 32, ArmSpecs.ARM);
        public static readonly MachineRegister R8 = Create("r8", 8, 32, ArmSpecs.ARM);
        public static readonly MachineRegister R9 = Create("r9", 9, 32, ArmSpecs.ARM);
        public static readonly MachineRegister R10 = Create("r10", 10, 32, ArmSpecs.ARM);
        // Frame pointer
        public static readonly MachineRegister R11 = Create("r11", 11, 32, ArmSpecs.ARM);
        // Temporary register
        public static readonly MachineRegister R12 = Create("r12", 12, 32, ArmSpecs.ARM);
        // Stack pointer
        public static readonly MachineRegister R13 = Create("r13", 13, 32, ArmSpecs.ARM);
        // Link register
        public static readonly MachineRegister R14 = Create("r14", 14, 32, ArmSpecs.ARM);
        // Program counter
        public static readonly MachineRegister R16 = Create("r15", 15, 32, ArmSpecs.ARM);

        public static readonly ICollection<MachineRegister> AllRegisters = new HashSet<MachineRegister>();

        private static MachineRegister Create(string name, int number, int size, MachineSpec set)
        {
            var r = new MachineRegister(name, number, size, set);
            AllRegisters.Add(r);
            return r;
        }
    }
}