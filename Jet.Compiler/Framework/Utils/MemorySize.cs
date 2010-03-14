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
using System;

namespace Jet.Compiler.Framework.Utils
{
    public struct MemorySize
    {
        public static readonly MemorySize KiloByte = new MemorySize(1024);
        public static readonly MemorySize MegaByte = new MemorySize(1024*1024);
        public static readonly MemorySize GigaByte = new MemorySize(1024*1024*1024);
        private readonly IntPtr value;

        public MemorySize(long value)
        {
            this.value = (IntPtr) value;
        }

        public MemorySize(ulong value)
        {
            this.value = (IntPtr) value;
        }

        public IntPtr Value
        {
            get { return value; }
        }

        public static implicit operator IntPtr(MemorySize m)
        {
            return m.value;
        }

        public static implicit operator int(MemorySize m)
        {
            return (int) m.value;
        }

        public static implicit operator uint(MemorySize m)
        {
            return (uint) m.value;
        }

        public static implicit operator long(MemorySize m)
        {
            return (long) m.value;
        }

        public static implicit operator ulong(MemorySize m)
        {
            return (ulong) m.value;
        }

        public static explicit operator MemorySize(int v)
        {
            return new MemorySize((uint) v);
        }

        public static explicit operator MemorySize(uint v)
        {
            return new MemorySize(v);
        }

        public static explicit operator MemorySize(long v)
        {
            return new MemorySize((ulong) v);
        }

        public static explicit operator MemorySize(ulong v)
        {
            return new MemorySize(v);
        }
    }
}