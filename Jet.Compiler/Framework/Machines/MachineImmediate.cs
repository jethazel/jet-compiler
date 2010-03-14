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
namespace Jet.Compiler.Framework.Machines
{
    public class MachineImmediate : IMachineOperand, IMachineImmediateOrRegister
    {
        public MachineImmediate()
        {
        }

        public MachineImmediate(uint value)
        {
            Value = value;
        }

        public MachineImmediate(int value)
        {
            Value = value;
        }

        public MachineImmediate(ushort value)
        {
            Value = value;
        }

        public MachineImmediate(short value)
        {
            Value = value;
        }

        public MachineImmediate(ulong value)
        {
            Value = value;
        }

        public MachineImmediate(long value)
        {
            Value = value;
        }

        public object Value { get; set; }
    }
}