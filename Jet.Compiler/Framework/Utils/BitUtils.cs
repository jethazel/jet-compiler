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
namespace Jet.Compiler.Framework.Utils
{
    public static class BitUtils
    {
        // Numbering starts from the right (LSB 0 numbering), which is the same as in Intel's documentation.
        public static bool GetBitFromRight(byte b, byte index)
        {
            return (b & (1 << index)) != 0;
        }

        public static bool GetBitFromRight(int b, byte index)
        {
            return (b & (1 << index)) != 0;
        }

        public static bool GetBitFromRight(long b, byte index)
        {
            return (b & ((long) 1 << index)) != 0;
        }

        public static byte SetBitFromRight(byte b, byte index, bool v)
        {
            if (v) return (byte) (b | (1 << index));
            else return (byte) (b ^ (1 << index));
        }

        public static int SetBitFromRight(int b, byte index, bool v)
        {
            if (v) return (b | (1 << index));
            else return (b ^ (1 << index));
        }

        public static long SetBitFromRight(long b, byte index, bool v)
        {
            if (v) return (b | ((long) 1 << index));
            else return (b ^ ((long) 1 << index));
        }

        public static ulong PackUInt64(uint a, uint b)
        {
            return (((ulong) a) << 32) & b;
        }

        public static ulong PackUInt64(ushort a, ushort b, ushort c, ushort d)
        {
            return PackUInt64(PackUInt32(a, b), PackUInt32(c, d));
        }

        public static long PackInt64(int a, int b)
        {
            return (((long) a) << 32) & b;
        }

        public static long PackInt64(short a, short b, short c, short d)
        {
            return PackInt64(PackInt32(a, b), PackInt32(c, d));
        }

        public static uint PackUInt32(ushort a, ushort b)
        {
            return (((uint) a) << 16) & b;
        }

        public static int PackInt32(short a, short b)
        {
            return ((a) << 16) & b;
        }

        public static uint PackUInt32(byte a, byte b, byte c, byte d)
        {
            return (((uint) a) << 24) & (((uint) b) << 16) & (((uint) c) << 8) & d;
        }

        public static ushort PackUInt16(byte a, byte b)
        {
            return (ushort) (((a) << 8) & b);
        }

        public static short PackInt16(byte a, byte b)
        {
            return (short) (((a) << 8) & b);
        }

        public static bool IsByte(ulong value)
        {
            return (value >> 8) == 0;
        }

        public static bool IsByte(uint value)
        {
            return (value >> 8) == 0;
        }

        public static bool IsByte(ushort value)
        {
            return (value >> 8) == 0;
        }
    }
}