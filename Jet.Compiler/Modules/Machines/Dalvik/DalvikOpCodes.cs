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
namespace Jet.Compiler.Modules.Machines.Dalvik
{
    public static class DalvikOpCodes
    {
        public static readonly DalvikOpCode OP_NOP = 0x00;
        public static readonly DalvikOpCode OP_MOVE = 0x01;
        public static readonly DalvikOpCode OP_MOVE_FROM16 = 0x02;
        public static readonly DalvikOpCode OP_MOVE_16 = 0x03;
        public static readonly DalvikOpCode OP_MOVE_WIDE = 0x04;
        public static readonly DalvikOpCode OP_MOVE_WIDE_FROM16 = 0x05;
        public static readonly DalvikOpCode OP_MOVE_WIDE_16 = 0x06;
        public static readonly DalvikOpCode OP_MOVE_OBJECT = 0x07;
        public static readonly DalvikOpCode OP_MOVE_OBJECT_FROM16 = 0x08;
        public static readonly DalvikOpCode OP_MOVE_OBJECT_16 = 0x09;

        public static readonly DalvikOpCode OP_MOVE_RESULT = 0x0a;
        public static readonly DalvikOpCode OP_MOVE_RESULT_WIDE = 0x0b;
        public static readonly DalvikOpCode OP_MOVE_RESULT_OBJECT = 0x0c;
        public static readonly DalvikOpCode OP_MOVE_EXCEPTION = 0x0d;

        public static readonly DalvikOpCode OP_RETURN_VOID = 0x0e;
        public static readonly DalvikOpCode OP_RETURN = 0x0f;
        public static readonly DalvikOpCode OP_RETURN_WIDE = 0x10;
        public static readonly DalvikOpCode OP_RETURN_OBJECT = 0x11;

        public static readonly DalvikOpCode OP_CONST_4 = 0x12;
        public static readonly DalvikOpCode OP_CONST_16 = 0x13;
        public static readonly DalvikOpCode OP_CONST = 0x14;
        public static readonly DalvikOpCode OP_CONST_HIGH16 = 0x15;
        public static readonly DalvikOpCode OP_CONST_WIDE_16 = 0x16;
        public static readonly DalvikOpCode OP_CONST_WIDE_32 = 0x17;
        public static readonly DalvikOpCode OP_CONST_WIDE = 0x18;
        public static readonly DalvikOpCode OP_CONST_WIDE_HIGH16 = 0x19;
        public static readonly DalvikOpCode OP_CONST_STRING = 0x1a;
        public static readonly DalvikOpCode OP_CONST_STRING_JUMBO = 0x1b;
        public static readonly DalvikOpCode OP_CONST_CLASS = 0x1c;

        public static readonly DalvikOpCode OP_MONITOR_ENTER = 0x1d;
        public static readonly DalvikOpCode OP_MONITOR_EXIT = 0x1e;

        public static readonly DalvikOpCode OP_CHECK_CAST = 0x1f;
        public static readonly DalvikOpCode OP_INSTANCE_OF = 0x20;

        public static readonly DalvikOpCode OP_ARRAY_LENGTH = 0x21;

        public static readonly DalvikOpCode OP_NEW_INSTANCE = 0x22;
        public static readonly DalvikOpCode OP_NEW_ARRAY = 0x23;

        public static readonly DalvikOpCode OP_FILLED_NEW_ARRAY = 0x24;
        public static readonly DalvikOpCode OP_FILLED_NEW_ARRAY_RANGE = 0x25;
        public static readonly DalvikOpCode OP_FILL_ARRAY_DATA = 0x26;

        public static readonly DalvikOpCode OP_THROW = 0x27;
        public static readonly DalvikOpCode OP_GOTO = 0x28;
        public static readonly DalvikOpCode OP_GOTO_16 = 0x29;
        public static readonly DalvikOpCode OP_GOTO_32 = 0x2a;
        public static readonly DalvikOpCode OP_PACKED_SWITCH = 0x2b;
        public static readonly DalvikOpCode OP_SPARSE_SWITCH = 0x2c;

        public static readonly DalvikOpCode OP_CMPL_FLOAT = 0x2d;
        public static readonly DalvikOpCode OP_CMPG_FLOAT = 0x2e;
        public static readonly DalvikOpCode OP_CMPL_DOUBLE = 0x2f;
        public static readonly DalvikOpCode OP_CMPG_DOUBLE = 0x30;
        public static readonly DalvikOpCode OP_CMP_LONG = 0x31;

        public static readonly DalvikOpCode OP_IF_EQ = 0x32;
        public static readonly DalvikOpCode OP_IF_NE = 0x33;
        public static readonly DalvikOpCode OP_IF_LT = 0x34;
        public static readonly DalvikOpCode OP_IF_GE = 0x35;
        public static readonly DalvikOpCode OP_IF_GT = 0x36;
        public static readonly DalvikOpCode OP_IF_LE = 0x37;
        public static readonly DalvikOpCode OP_IF_EQZ = 0x38;
        public static readonly DalvikOpCode OP_IF_NEZ = 0x39;
        public static readonly DalvikOpCode OP_IF_LTZ = 0x3a;
        public static readonly DalvikOpCode OP_IF_GEZ = 0x3b;
        public static readonly DalvikOpCode OP_IF_GTZ = 0x3c;
        public static readonly DalvikOpCode OP_IF_LEZ = 0x3d;

        public static readonly DalvikOpCode OP_UNUSED_3e = 0x3e;
        public static readonly DalvikOpCode OP_UNUSED_3f = 0x3f;
        public static readonly DalvikOpCode OP_UNUSED_40 = 0x40;
        public static readonly DalvikOpCode OP_UNUSED_41 = 0x41;
        public static readonly DalvikOpCode OP_UNUSED_42 = 0x42;
        public static readonly DalvikOpCode OP_UNUSED_43 = 0x43;

        public static readonly DalvikOpCode OP_AGET = 0x44;
        public static readonly DalvikOpCode OP_AGET_WIDE = 0x45;
        public static readonly DalvikOpCode OP_AGET_OBJECT = 0x46;
        public static readonly DalvikOpCode OP_AGET_BOOLEAN = 0x47;
        public static readonly DalvikOpCode OP_AGET_BYTE = 0x48;
        public static readonly DalvikOpCode OP_AGET_CHAR = 0x49;
        public static readonly DalvikOpCode OP_AGET_SHORT = 0x4a;
        public static readonly DalvikOpCode OP_APUT = 0x4b;
        public static readonly DalvikOpCode OP_APUT_WIDE = 0x4c;
        public static readonly DalvikOpCode OP_APUT_OBJECT = 0x4d;
        public static readonly DalvikOpCode OP_APUT_BOOLEAN = 0x4e;
        public static readonly DalvikOpCode OP_APUT_BYTE = 0x4f;
        public static readonly DalvikOpCode OP_APUT_CHAR = 0x50;
        public static readonly DalvikOpCode OP_APUT_SHORT = 0x51;

        public static readonly DalvikOpCode OP_IGET = 0x52;
        public static readonly DalvikOpCode OP_IGET_WIDE = 0x53;
        public static readonly DalvikOpCode OP_IGET_OBJECT = 0x54;
        public static readonly DalvikOpCode OP_IGET_BOOLEAN = 0x55;
        public static readonly DalvikOpCode OP_IGET_BYTE = 0x56;
        public static readonly DalvikOpCode OP_IGET_CHAR = 0x57;
        public static readonly DalvikOpCode OP_IGET_SHORT = 0x58;
        public static readonly DalvikOpCode OP_IPUT = 0x59;
        public static readonly DalvikOpCode OP_IPUT_WIDE = 0x5a;
        public static readonly DalvikOpCode OP_IPUT_OBJECT = 0x5b;
        public static readonly DalvikOpCode OP_IPUT_BOOLEAN = 0x5c;
        public static readonly DalvikOpCode OP_IPUT_BYTE = 0x5d;
        public static readonly DalvikOpCode OP_IPUT_CHAR = 0x5e;
        public static readonly DalvikOpCode OP_IPUT_SHORT = 0x5f;

        public static readonly DalvikOpCode OP_SGET = 0x60;
        public static readonly DalvikOpCode OP_SGET_WIDE = 0x61;
        public static readonly DalvikOpCode OP_SGET_OBJECT = 0x62;
        public static readonly DalvikOpCode OP_SGET_BOOLEAN = 0x63;
        public static readonly DalvikOpCode OP_SGET_BYTE = 0x64;
        public static readonly DalvikOpCode OP_SGET_CHAR = 0x65;
        public static readonly DalvikOpCode OP_SGET_SHORT = 0x66;
        public static readonly DalvikOpCode OP_SPUT = 0x67;
        public static readonly DalvikOpCode OP_SPUT_WIDE = 0x68;
        public static readonly DalvikOpCode OP_SPUT_OBJECT = 0x69;
        public static readonly DalvikOpCode OP_SPUT_BOOLEAN = 0x6a;
        public static readonly DalvikOpCode OP_SPUT_BYTE = 0x6b;
        public static readonly DalvikOpCode OP_SPUT_CHAR = 0x6c;
        public static readonly DalvikOpCode OP_SPUT_SHORT = 0x6d;

        public static readonly DalvikOpCode OP_INVOKE_VIRTUAL = 0x6e;
        public static readonly DalvikOpCode OP_INVOKE_SUPER = 0x6f;
        public static readonly DalvikOpCode OP_INVOKE_DIRECT = 0x70;
        public static readonly DalvikOpCode OP_INVOKE_STATIC = 0x71;
        public static readonly DalvikOpCode OP_INVOKE_INTERFACE = 0x72;

        public static readonly DalvikOpCode OP_UNUSED_73 = 0x73;

        public static readonly DalvikOpCode OP_INVOKE_VIRTUAL_RANGE = 0x74;
        public static readonly DalvikOpCode OP_INVOKE_SUPER_RANGE = 0x75;
        public static readonly DalvikOpCode OP_INVOKE_DIRECT_RANGE = 0x76;
        public static readonly DalvikOpCode OP_INVOKE_STATIC_RANGE = 0x77;
        public static readonly DalvikOpCode OP_INVOKE_INTERFACE_RANGE = 0x78;

        public static readonly DalvikOpCode OP_UNUSED_79 = 0x79;
        public static readonly DalvikOpCode OP_UNUSED_7A = 0x7a;

        public static readonly DalvikOpCode OP_NEG_INT = 0x7b;
        public static readonly DalvikOpCode OP_NOT_INT = 0x7c;
        public static readonly DalvikOpCode OP_NEG_LONG = 0x7d;
        public static readonly DalvikOpCode OP_NOT_LONG = 0x7e;
        public static readonly DalvikOpCode OP_NEG_FLOAT = 0x7f;
        public static readonly DalvikOpCode OP_NEG_DOUBLE = 0x80;
        public static readonly DalvikOpCode OP_INT_TO_LONG = 0x81;
        public static readonly DalvikOpCode OP_INT_TO_FLOAT = 0x82;
        public static readonly DalvikOpCode OP_INT_TO_DOUBLE = 0x83;
        public static readonly DalvikOpCode OP_LONG_TO_INT = 0x84;
        public static readonly DalvikOpCode OP_LONG_TO_FLOAT = 0x85;
        public static readonly DalvikOpCode OP_LONG_TO_DOUBLE = 0x86;
        public static readonly DalvikOpCode OP_FLOAT_TO_INT = 0x87;
        public static readonly DalvikOpCode OP_FLOAT_TO_LONG = 0x88;
        public static readonly DalvikOpCode OP_FLOAT_TO_DOUBLE = 0x89;
        public static readonly DalvikOpCode OP_DOUBLE_TO_INT = 0x8a;
        public static readonly DalvikOpCode OP_DOUBLE_TO_LONG = 0x8b;
        public static readonly DalvikOpCode OP_DOUBLE_TO_FLOAT = 0x8c;
        public static readonly DalvikOpCode OP_INT_TO_BYTE = 0x8d;
        public static readonly DalvikOpCode OP_INT_TO_CHAR = 0x8e;
        public static readonly DalvikOpCode OP_INT_TO_SHORT = 0x8f;

        public static readonly DalvikOpCode OP_ADD_INT = 0x90;
        public static readonly DalvikOpCode OP_SUB_INT = 0x91;
        public static readonly DalvikOpCode OP_MUL_INT = 0x92;
        public static readonly DalvikOpCode OP_DIV_INT = 0x93;
        public static readonly DalvikOpCode OP_REM_INT = 0x94;
        public static readonly DalvikOpCode OP_AND_INT = 0x95;
        public static readonly DalvikOpCode OP_OR_INT = 0x96;
        public static readonly DalvikOpCode OP_XOR_INT = 0x97;
        public static readonly DalvikOpCode OP_SHL_INT = 0x98;
        public static readonly DalvikOpCode OP_SHR_INT = 0x99;
        public static readonly DalvikOpCode OP_USHR_INT = 0x9a;

        public static readonly DalvikOpCode OP_ADD_LONG = 0x9b;
        public static readonly DalvikOpCode OP_SUB_LONG = 0x9c;
        public static readonly DalvikOpCode OP_MUL_LONG = 0x9d;
        public static readonly DalvikOpCode OP_DIV_LONG = 0x9e;
        public static readonly DalvikOpCode OP_REM_LONG = 0x9f;
        public static readonly DalvikOpCode OP_AND_LONG = 0xa0;
        public static readonly DalvikOpCode OP_OR_LONG = 0xa1;
        public static readonly DalvikOpCode OP_XOR_LONG = 0xa2;
        public static readonly DalvikOpCode OP_SHL_LONG = 0xa3;
        public static readonly DalvikOpCode OP_SHR_LONG = 0xa4;
        public static readonly DalvikOpCode OP_USHR_LONG = 0xa5;

        public static readonly DalvikOpCode OP_ADD_FLOAT = 0xa6;
        public static readonly DalvikOpCode OP_SUB_FLOAT = 0xa7;
        public static readonly DalvikOpCode OP_MUL_FLOAT = 0xa8;
        public static readonly DalvikOpCode OP_DIV_FLOAT = 0xa9;
        public static readonly DalvikOpCode OP_REM_FLOAT = 0xaa;
        public static readonly DalvikOpCode OP_ADD_DOUBLE = 0xab;
        public static readonly DalvikOpCode OP_SUB_DOUBLE = 0xac;
        public static readonly DalvikOpCode OP_MUL_DOUBLE = 0xad;
        public static readonly DalvikOpCode OP_DIV_DOUBLE = 0xae;
        public static readonly DalvikOpCode OP_REM_DOUBLE = 0xaf;

        public static readonly DalvikOpCode OP_ADD_INT_2ADDR = 0xb0;
        public static readonly DalvikOpCode OP_SUB_INT_2ADDR = 0xb1;
        public static readonly DalvikOpCode OP_MUL_INT_2ADDR = 0xb2;
        public static readonly DalvikOpCode OP_DIV_INT_2ADDR = 0xb3;
        public static readonly DalvikOpCode OP_REM_INT_2ADDR = 0xb4;
        public static readonly DalvikOpCode OP_AND_INT_2ADDR = 0xb5;
        public static readonly DalvikOpCode OP_OR_INT_2ADDR = 0xb6;
        public static readonly DalvikOpCode OP_XOR_INT_2ADDR = 0xb7;
        public static readonly DalvikOpCode OP_SHL_INT_2ADDR = 0xb8;
        public static readonly DalvikOpCode OP_SHR_INT_2ADDR = 0xb9;
        public static readonly DalvikOpCode OP_USHR_INT_2ADDR = 0xba;

        public static readonly DalvikOpCode OP_ADD_LONG_2ADDR = 0xbb;
        public static readonly DalvikOpCode OP_SUB_LONG_2ADDR = 0xbc;
        public static readonly DalvikOpCode OP_MUL_LONG_2ADDR = 0xbd;
        public static readonly DalvikOpCode OP_DIV_LONG_2ADDR = 0xbe;
        public static readonly DalvikOpCode OP_REM_LONG_2ADDR = 0xbf;
        public static readonly DalvikOpCode OP_AND_LONG_2ADDR = 0xc0;
        public static readonly DalvikOpCode OP_OR_LONG_2ADDR = 0xc1;
        public static readonly DalvikOpCode OP_XOR_LONG_2ADDR = 0xc2;
        public static readonly DalvikOpCode OP_SHL_LONG_2ADDR = 0xc3;
        public static readonly DalvikOpCode OP_SHR_LONG_2ADDR = 0xc4;
        public static readonly DalvikOpCode OP_USHR_LONG_2ADDR = 0xc5;

        public static readonly DalvikOpCode OP_ADD_FLOAT_2ADDR = 0xc6;
        public static readonly DalvikOpCode OP_SUB_FLOAT_2ADDR = 0xc7;
        public static readonly DalvikOpCode OP_MUL_FLOAT_2ADDR = 0xc8;
        public static readonly DalvikOpCode OP_DIV_FLOAT_2ADDR = 0xc9;
        public static readonly DalvikOpCode OP_REM_FLOAT_2ADDR = 0xca;
        public static readonly DalvikOpCode OP_ADD_DOUBLE_2ADDR = 0xcb;
        public static readonly DalvikOpCode OP_SUB_DOUBLE_2ADDR = 0xcc;
        public static readonly DalvikOpCode OP_MUL_DOUBLE_2ADDR = 0xcd;
        public static readonly DalvikOpCode OP_DIV_DOUBLE_2ADDR = 0xce;
        public static readonly DalvikOpCode OP_REM_DOUBLE_2ADDR = 0xcf;

        public static readonly DalvikOpCode OP_ADD_INT_LIT16 = 0xd0;
        public static readonly DalvikOpCode OP_RSUB_INT = 0xd1; /* no _LIT16 suffix for this */
        public static readonly DalvikOpCode OP_MUL_INT_LIT16 = 0xd2;
        public static readonly DalvikOpCode OP_DIV_INT_LIT16 = 0xd3;
        public static readonly DalvikOpCode OP_REM_INT_LIT16 = 0xd4;
        public static readonly DalvikOpCode OP_AND_INT_LIT16 = 0xd5;
        public static readonly DalvikOpCode OP_OR_INT_LIT16 = 0xd6;
        public static readonly DalvikOpCode OP_XOR_INT_LIT16 = 0xd7;

        public static readonly DalvikOpCode OP_ADD_INT_LIT8 = 0xd8;
        public static readonly DalvikOpCode OP_RSUB_INT_LIT8 = 0xd9;
        public static readonly DalvikOpCode OP_MUL_INT_LIT8 = 0xda;
        public static readonly DalvikOpCode OP_DIV_INT_LIT8 = 0xdb;
        public static readonly DalvikOpCode OP_REM_INT_LIT8 = 0xdc;
        public static readonly DalvikOpCode OP_AND_INT_LIT8 = 0xdd;
        public static readonly DalvikOpCode OP_OR_INT_LIT8 = 0xde;
        public static readonly DalvikOpCode OP_XOR_INT_LIT8 = 0xdf;
        public static readonly DalvikOpCode OP_SHL_INT_LIT8 = 0xe0;
        public static readonly DalvikOpCode OP_SHR_INT_LIT8 = 0xe1;
        public static readonly DalvikOpCode OP_USHR_INT_LIT8 = 0xe2;

        public static readonly DalvikOpCode OP_UNUSED_E3 = 0xe3;
        public static readonly DalvikOpCode OP_UNUSED_E4 = 0xe4;
        public static readonly DalvikOpCode OP_UNUSED_E5 = 0xe5;
        public static readonly DalvikOpCode OP_UNUSED_E6 = 0xe6;
        public static readonly DalvikOpCode OP_UNUSED_E7 = 0xe7;
        public static readonly DalvikOpCode OP_UNUSED_E8 = 0xe8;
        public static readonly DalvikOpCode OP_UNUSED_E9 = 0xe9;
        public static readonly DalvikOpCode OP_UNUSED_EA = 0xea;
        public static readonly DalvikOpCode OP_UNUSED_EB = 0xeb;
        public static readonly DalvikOpCode OP_UNUSED_EC = 0xec;
        public static readonly DalvikOpCode OP_UNUSED_ED = 0xed;

        /* optimizer output -- these are never generated by "dx" */
        public static readonly DalvikOpCode OP_EXECUTE_INLINE = 0xee;
        public static readonly DalvikOpCode OP_UNUSED_EF = 0xef; /* OP_EXECUTE_INLINE_RANGE? */

        public static readonly DalvikOpCode OP_INVOKE_DIRECT_EMPTY = 0xf0;
        public static readonly DalvikOpCode OP_UNUSED_F1 = 0xf1; /* OP_INVOKE_DIRECT_EMPTY_RANGE? */
        public static readonly DalvikOpCode OP_IGET_QUICK = 0xf2;
        public static readonly DalvikOpCode OP_IGET_WIDE_QUICK = 0xf3;
        public static readonly DalvikOpCode OP_IGET_OBJECT_QUICK = 0xf4;
        public static readonly DalvikOpCode OP_IPUT_QUICK = 0xf5;
        public static readonly DalvikOpCode OP_IPUT_WIDE_QUICK = 0xf6;
        public static readonly DalvikOpCode OP_IPUT_OBJECT_QUICK = 0xf7;

        public static readonly DalvikOpCode OP_INVOKE_VIRTUAL_QUICK = 0xf8;
        public static readonly DalvikOpCode OP_INVOKE_VIRTUAL_QUICK_RANGE = 0xf9;
        public static readonly DalvikOpCode OP_INVOKE_SUPER_QUICK = 0xfa;
        public static readonly DalvikOpCode OP_INVOKE_SUPER_QUICK_RANGE = 0xfb;
        public static readonly DalvikOpCode OP_UNUSED_FC = 0xfc; /* OP_INVOKE_DIRECT_QUICK? */
        public static readonly DalvikOpCode OP_UNUSED_FD = 0xfd; /* OP_INVOKE_DIRECT_QUICK_RANGE? */
        public static readonly DalvikOpCode OP_UNUSED_FE = 0xfe; /* OP_INVOKE_INTERFACE_QUICK? */
        public static readonly DalvikOpCode OP_UNUSED_FF = 0xff; /* OP_INVOKE_INTERFACE_QUICK_RANGE*/
    }
}