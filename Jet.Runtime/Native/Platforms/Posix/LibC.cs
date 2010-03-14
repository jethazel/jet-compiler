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
using System.Runtime.InteropServices;

namespace Jet.Runtime.Native.Platforms.Posix
{
    internal static unsafe class LibC
    {
#if OS_X
        private const string LibCPath = "libc.dylib";
#else
        private const string LibCPath = "libc.so";
#endif

        [DllImport(LibCPath)]
        public static extern void* malloc(IntPtr size);

        [DllImport(LibCPath)]
        public static extern void* realloc(void* ptr, IntPtr size);

        [DllImport(LibCPath)]
        public static extern void free(void* ptr);

        [DllImport(LibCPath)]
        public static extern void* memcpy(void* str1, void* str2, IntPtr size);

        [DllImport(LibCPath)]
        public static extern void* memmove(void* str1, void* str2, IntPtr size);

        [DllImport(LibCPath)]
        public static extern void* memset(void* str1, void* str2, IntPtr size);
    }
}