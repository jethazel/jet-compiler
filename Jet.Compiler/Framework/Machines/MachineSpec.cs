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
    public class MachineSpec
    {
        private readonly HashSet<MachineSpec> supportedSpecs = new HashSet<MachineSpec>();

        public MachineSpec(string name, params MachineSpec[] supportedSpecs)
        {
            Name = name;
            this.supportedSpecs.UnionWith(supportedSpecs);
        }

        public string Name { get; set; }

        public ICollection<MachineSpec> SupportedSpecs
        {
            get { return supportedSpecs; }
        }

        public override string ToString()
        {
            return Name ?? base.ToString();
        }
    }
}