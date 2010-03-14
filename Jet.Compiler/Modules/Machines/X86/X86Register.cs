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
    public class X86Register : MachineRegister
    {
        public X86Register(string name, int code, int bits, MachineSpec spec) : base(name, code, bits, spec)
        {
        }

        public X86Register(string name, int code, MachineRegisterType type, MachineSpec spec)
            : base(name, code, type, spec)
        {
        }

        public static explicit operator byte(X86Register r)
        {
            return (byte) r.Code;
        }

        public static explicit operator X86Register(int i)
        {
            return (byte) r.Code;
        }
    }
}