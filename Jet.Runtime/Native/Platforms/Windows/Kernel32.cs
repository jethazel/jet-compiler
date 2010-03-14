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

namespace Jet.Runtime.Native.Platforms.Windows
{
    internal static unsafe class Kernel32
    {
        private const string Kernel32Path = "kernel32.dll";

        public static class VirtualMemAllocationType
        {
            public static int MemCommit = 0x1000;
            public static int MemReserve = 0x2000;
            public static int MemReset = 0x80000;
            public static int MemDecommit = 0x4000;
            public static int MemRelease = 0x8000;
        }

        public static class VirtualMemProtectionFlag
        {
            public static int PageExecute = 0x10;
            public static int PageExecuteRead = 0x20;
            public static int PageExecuteReadWrite = 0x40;
            public static int PageExecuteWriteCopy = 0x80;
            public static int PageNoAccess = 0x01;
            public static int PageReadOnly = 0x02;
            public static int PageReadWrite = 0x04;
            public static int PageWriteCopy = 0x08;
        }

        [DllImport(Kernel32Path)]
        public static extern IntPtr LoadLibrary(NativeZeroTerminatedCharArray filename);

        [DllImport(Kernel32Path)]
        public static extern IntPtr GetProc(NativeZeroTerminatedCharArray name);

        [DllImport(Kernel32Path)]
        public static extern IntPtr GetProcessHeap();

        [DllImport(Kernel32Path)]
        public static extern void* HeapAlloc(IntPtr heapHandle, int flags, IntPtr size);

        [DllImport(Kernel32Path)]
        public static extern IntPtr HeapCompact(IntPtr heapHandle, int flags);

        [DllImport(Kernel32Path)]
        public static extern IntPtr HeapCreate(int options, IntPtr initialSize, IntPtr maximumSize);

        [DllImport(Kernel32Path)]
        public static extern bool HeapDestroy(IntPtr heapHandle);

        [DllImport(Kernel32Path)]
        public static extern bool HeapFree(IntPtr heapHandle, int flags, void* pointer);

        [DllImport(Kernel32Path)]
        public static extern bool HeapLock(IntPtr heapHandle);

        [DllImport(Kernel32Path)]
        public static extern void* HeapReAlloc(IntPtr heapHandle, int flags, void* pointer, IntPtr size);

        [DllImport(Kernel32Path)]
        public static extern IntPtr HeapSize(IntPtr heapHandle, int flags, void* pointer);

        [DllImport(Kernel32Path)]
        public static extern bool HeapUnlock(IntPtr heapHandle);

        [DllImport(Kernel32Path)]
        public static extern bool HeapValidate(IntPtr heapHandle, int flags, void* pointer);

        [DllImport(Kernel32Path)]
        public static extern void* VirtualAlloc(void* optionalPointer, IntPtr size, int type, int protection);

        [DllImport(Kernel32Path)]
        public static extern void* VirtualAllocEx(IntPtr processHandle, void* optionalPointer, IntPtr size, int type,
                                                  int protection);

        [DllImport(Kernel32Path)]
        public static extern bool VirtualFree(void* pointer, IntPtr size, int freeType);

        [DllImport(Kernel32Path)]
        public static extern bool VirtualFreeEx(IntPtr processHandle, void* pointer, IntPtr size, int freeType);

        [DllImport(Kernel32Path)]
        public static extern bool VirtualProtect(void* optionalPointer, IntPtr size, int newProtection,
                                                 out int oldProtection);

        [DllImport(Kernel32Path)]
        public static extern bool VirtualProtectEx(IntPtr processHandle, void* optionalPointer, IntPtr size,
                                                   int newProtection, out int* oldProtection);

        [DllImport(Kernel32Path)]
        public static extern bool CopyMemory(void* from, void* to, IntPtr size);

        [DllImport(Kernel32Path)]
        public static extern bool MoveMemory(void* from, void* to, IntPtr size);

        [DllImport(Kernel32Path)]
        public static extern bool ZeroMemory(void* ptr, IntPtr size);
    }
}