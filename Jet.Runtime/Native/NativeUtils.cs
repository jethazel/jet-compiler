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
#if !(PLATFORM_WINDOWS || PLATFORM_OS_X || PLATFORM_LINUX)
#error One of the following flags is required: PLATFORM_WINDOWS, PLATFORM_OS_X, PLATFORM_LINUX
#endif
#if PLATFORM_OS_X || PLATFORM_LINUX
#define PLATFORM_POSIX
#endif

#if PLATFORM_WINDOWS
using System;
using NativeUtilsImplementation = Jet.Runtime.Native.Platforms.Windows.WindowsNativeUtils;

#else
using NativeUtilsImplementation = Jet.Runtime.Native.Platforms.Posix.PosixNativeUtils;
#endif

namespace Jet.Runtime.Native
{
    internal static unsafe class NativeUtils
    {
        public static void* HeapAlloc(IntPtr size)
        {
            return NativeUtilsImplementation.HeapAlloc(size);
        }

        public static bool HeapFree(void* pointer)
        {
            return NativeUtilsImplementation.HeapFree(pointer);
        }

        public static void MemoryCopy(void* sourcePointer, IntPtr size, void* destinationPointer)
        {
            NativeUtilsImplementation.MemoryCopy(sourcePointer, size, destinationPointer);
        }

        public static void* VirtualMemoryAlloc(IntPtr size)
        {
            return NativeUtilsImplementation.VirtualMemoryAlloc(size);
        }

        public static void VirtualMemoryFree(void* pointer, IntPtr size)
        {
            NativeUtilsImplementation.VirtualMemoryFree(pointer, size);
        }

        public static void VirtualMemorySetProtection(void* pointer, IntPtr size, MemoryProtection protection)
        {
            NativeUtilsImplementation.VirtualMemorySetProtection(pointer, size, protection);
        }
    }
}