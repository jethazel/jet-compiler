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
    public class X86Register64 : X86Register
    {
        public X86Register64(string name, int code, int bits, MachineSpec spec) : base(name, code, bits, spec)
        {
        }

        public X86Register64(string name, int code, MachineRegisterType type, MachineSpec spec)
            : base(name, code, type, spec)
        {
        }
    }
}