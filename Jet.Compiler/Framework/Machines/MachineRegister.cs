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

namespace Jet.Compiler.Framework.Machines
{
    public class MachineRegister : IMachineOperand, IMachineImmediateOrRegister
    {
        private readonly HashSet<MachineSpec> instructionSets = new HashSet<MachineSpec>();

        public MachineRegister(string name, int code, int bits, MachineSpec spec)
        {
            Name = name;
            Code = code;
            Bits = bits;
            InstructionSets.Add(spec);
        }

        public MachineRegister(string name, int code, MachineRegisterType type, MachineSpec spec)
        {
            Name = name;
            Code = code;
            RegisterType = type;
            Bits = type.Bits;
            InstructionSets.Add(spec);
        }

        public int Code { get; protected set; }
        public string Name { get; protected set; }
        public int Bits { get; protected set; }
        public MachineRegisterType RegisterType { get; set; }

        public ICollection<MachineSpec> InstructionSets
        {
            get { return instructionSets; }
        }

        public override string ToString()
        {
            return Name ?? base.ToString();
        }
    }
}