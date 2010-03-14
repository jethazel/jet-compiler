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

namespace Jet.Runtime.Native.Platforms.Windows
{
    internal static unsafe class WindowsNativeUtils
    {
        public static void* HeapAlloc(IntPtr size)
        {
            return Kernel32.HeapAlloc(Kernel32.GetProcessHeap(), 0, (IntPtr) ((size.ToInt32()/4)*4 + 1));
        }

        public static bool HeapFree(void* ptr)
        {
            return Kernel32.HeapFree(Kernel32.GetProcessHeap(), 0, ptr);
        }

        public static void MemoryCopy(void* sourcePointer, IntPtr size, void* destinationPointer)
        {
            Kernel32.CopyMemory(sourcePointer, destinationPointer, size);
        }

        public static void* VirtualMemoryAlloc(IntPtr size)
        {
            return Kernel32.VirtualAlloc(null, size, Kernel32.VirtualMemAllocationType.MemCommit,
                                         Kernel32.VirtualMemProtectionFlag.PageReadWrite);
        }

        public static void VirtualMemoryFree(void* pointer, IntPtr size)
        {
            Kernel32.VirtualFree(pointer, size, Kernel32.VirtualMemAllocationType.MemRelease);
        }

        public static void VirtualMemorySetProtection(void* pointer, IntPtr size, MemoryProtection protection)
        {
            int old;
            switch (protection)
            {
                case MemoryProtection.Execute:
                    Kernel32.VirtualProtect(pointer, size, Kernel32.VirtualMemProtectionFlag.PageExecute, out old);
                    break;
                case MemoryProtection.ReadWrite:
                    Kernel32.VirtualProtect(pointer, size, Kernel32.VirtualMemProtectionFlag.PageReadWrite, out old);
                    break;
            }
        }
    }
}