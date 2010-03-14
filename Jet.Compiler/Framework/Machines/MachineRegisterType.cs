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
    public class MachineRegisterType
    {
        public static MachineRegisterType General256BitRegister = new MachineRegisterType("general256", 256);
        public static MachineRegisterType General128BitRegister = new MachineRegisterType("general128", 128);
        public static MachineRegisterType General64BitRegister = new MachineRegisterType("general64", 64);
        public static MachineRegisterType General32BitRegister = new MachineRegisterType("general32", 32);
        public static MachineRegisterType General16BitRegister = new MachineRegisterType("general16", 16);
        public static MachineRegisterType General8BitRegister = new MachineRegisterType("general8", 8);

        private MachineRegisterType(string title, params MachineRegisterType[] parentTypes)
        {
            Title = title;
            ParentTypes = new HashSet<MachineRegisterType>();
            foreach (var t in parentTypes) ParentTypes.Add(t);
        }

        private MachineRegisterType(string title, int bits, params MachineRegisterType[] parentTypes)
        {
            Title = title;
            Bits = bits;
            ParentTypes = new HashSet<MachineRegisterType>();
            foreach (var t in parentTypes) ParentTypes.Add(t);
        }

        public string Title { get; protected set; }
        public int Bits { get; set; }
        public ICollection<MachineRegisterType> ParentTypes { get; protected set; }
    }
}