﻿//VirtualKeyCodes
public static partial class RawInputHelper
{
    //An enum of all virtual key codes up to 0xFF.
    public enum VKCode : ushort
    {
        Unassigned_00 = 0x00,
        LeftMouseButton = 0x01,
        RightMouseButton = 0x02,
        Cancel = 0x03,
        MiddleMouseButton = 0x04,
        MouseButtonX1 = 0x05,
        MouseButtonX2 = 0x06,
        Reserved_07 = 0x07,
        Backspace = 0x08,
        Tab = 0x09,
        Reserved_0A = 0x0A,
        Reserved_0B = 0x0B,
        Clear = 0x0C,
        Enter = 0x0D,
        Unassigned_0E = 0x0E,
        Unassigned_0F = 0x0F,
        Shift = 0x10,
        Control = 0x11,
        Alt = 0x12,
        Pause = 0x13,
        CapsLock = 0x14,
        IME_HangulOrKana = 0x15,
        IME_On = 0x16,
        IME_Junja = 0x17,
        IME_Final = 0x18,
        IME_HanjaOrKanji = 0x19,
        IME_Off = 0x1A,
        Escape = 0x1B,
        IME_Convert = 0x1C,
        IME_NonConvert = 0x1D,
        IME_Accept = 0x1E,
        IME_ModeChange = 0x1F,
        Space = 0x20,
        PageUp = 0x21,
        PageDown = 0x22,
        End = 0x23,
        Home = 0x24,
        LeftArrow = 0x25,
        UpArrow = 0x26,
        RightArrow = 0x27,
        DownArrow = 0x28,
        Select = 0x29,
        Print = 0x2A,
        Execute = 0x2B,
        Snapshot = 0x2C,
        Insert = 0x2D,
        Delete = 0x2E,
        Help = 0x2F,
        Zero = 0x30,
        One = 0x31,
        Two = 0x32,
        Three = 0x33,
        Four = 0x34,
        Five = 0x35,
        Six = 0x36,
        Seven = 0x37,
        Eight = 0x38,
        Nine = 0x39,
        Unassigned_3A = 0x3A,
        Unassigned_3B = 0x3B,
        Unassigned_3C = 0x3C,
        Unassigned_3D = 0x3D,
        Unassigned_3E = 0x3E,
        Unassigned_3F = 0x3F,
        Unassigned_40 = 0x40,
        A = 0x41,
        B = 0x42,
        C = 0x43,
        D = 0x44,
        E = 0x45,
        F = 0x46,
        G = 0x47,
        H = 0x48,
        I = 0x49,
        J = 0x4A,
        K = 0x4B,
        L = 0x4C,
        M = 0x4D,
        N = 0x4E,
        O = 0x4F,
        P = 0x50,
        Q = 0x51,
        R = 0x52,
        S = 0x53,
        T = 0x54,
        U = 0x55,
        V = 0x56,
        W = 0x57,
        X = 0x58,
        Y = 0x59,
        Z = 0x5A,
        LeftWindows = 0x5B,
        RightWindows = 0x5C,
        Apps = 0x5D,
        Reserved_5E = 0x5E,
        Sleep = 0x5F,
        NumPad_0 = 0x60,
        NumPad_1 = 0x61,
        NumPad_2 = 0x62,
        NumPad_3 = 0x63,
        NumPad_4 = 0x64,
        NumPad_5 = 0x65,
        NumPad_6 = 0x66,
        NumPad_7 = 0x67,
        NumPad_8 = 0x68,
        NumPad_9 = 0x69,
        Multiply = 0x6A,
        Add = 0x6B,
        Separator = 0x6C,
        Subtract = 0x6D,
        Decimal = 0x6E,
        Divide = 0x6F,
        F1 = 0x70,
        F2 = 0x71,
        F3 = 0x72,
        F4 = 0x73,
        F5 = 0x74,
        F6 = 0x75,
        F7 = 0x76,
        F8 = 0x77,
        F9 = 0x78,
        F10 = 0x79,
        F11 = 0x7A,
        F12 = 0x7B,
        F13 = 0x7C,
        F14 = 0x7D,
        F15 = 0x7E,
        F16 = 0x7F,
        F17 = 0x80,
        F18 = 0x81,
        F19 = 0x82,
        F20 = 0x83,
        F21 = 0x84,
        F22 = 0x85,
        F23 = 0x86,
        F24 = 0x87,
        Reserved_88 = 0x88,
        Reserved_89 = 0x89,
        Reserved_8A = 0x8A,
        Reserved_8B = 0x8B,
        Reserved_8C = 0x8C,
        Reserved_8D = 0x8D,
        Reserved_8E = 0x8E,
        Reserved_8F = 0x8F,
        NumLock = 0x90,
        ScrollLock = 0x91,
        OEMSpecific_92 = 0x92,
        OEMSpecific_93 = 0x93,
        OEMSpecific_94 = 0x94,
        OEMSpecific_95 = 0x95,
        OEMSpecific_96 = 0x96,
        Unassigned_97 = 0x97,
        Unassigned_98 = 0x98,
        Unassigned_99 = 0x99,
        Unassigned_9A = 0x9A,
        Unassigned_9B = 0x9B,
        Unassigned_9C = 0x9C,
        Unassigned_9D = 0x9D,
        Unassigned_9E = 0x9E,
        Unassigned_9F = 0x9F,
        LeftShift = 0xA0,
        RightShift = 0xA1,
        LeftControl = 0xA2,
        RightControl = 0xA3,
        LeftMenu = 0xA4,
        RightMenu = 0xA5,
        Browser_Back = 0xA6,
        Browser_Forward = 0xA7,
        Browser_Refresh = 0xA8,
        Browser_Stop = 0xA9,
        Browser_Search = 0xAA,
        Browser_Favorites = 0xAB,
        Browser_Home = 0xAC,
        Mute = 0xAD,
        VolumeDown = 0xAE,
        VolumeUp = 0xAF,
        Media_SkipNext = 0xB0,
        Media_SkipPrevious = 0xB1,
        Media_Stop = 0xB2,
        Media_PlayPause = 0xB3,
        Launch_Mail = 0xB4,
        Launch_MediaSelect = 0xB5,
        Launch_CustomApp1 = 0xB6,
        Launch_CustomApp2 = 0xB7,
        Reserved_B8 = 0xB8,
        Reserved_B9 = 0xB9,
        OEMSpecific_BA = 0xBA,
        OEM_Plus = 0xBB,
        OEM_Comma = 0xBC,
        OEM_Minus = 0xBD,
        OEM_Period = 0xBE,
        OEMSpecific_BF = 0xBF,
        OEMSpecific_C0 = 0xC0,
        Reserved_C1 = 0xC1,
        Reserved_C2 = 0xC2,
        Reserved_C3 = 0xC3,
        Reserved_C4 = 0xC4,
        Reserved_C5 = 0xC5,
        Reserved_C6 = 0xC6,
        Reserved_C7 = 0xC7,
        Reserved_C8 = 0xC8,
        Reserved_C9 = 0xC9,
        Reserved_CA = 0xCA,
        Reserved_CB = 0xCB,
        Reserved_CC = 0xCC,
        Reserved_CD = 0xCD,
        Reserved_CE = 0xCE,
        Reserved_CF = 0xCF,
        Reserved_D0 = 0xD0,
        Reserved_D1 = 0xD1,
        Reserved_D2 = 0xD2,
        Reserved_D3 = 0xD3,
        Reserved_D4 = 0xD4,
        Reserved_D5 = 0xD5,
        Reserved_D6 = 0xD6,
        Reserved_D7 = 0xD7,
        Reserved_D8 = 0xD8,
        Reserved_D9 = 0xD9,
        Reserved_DA = 0xDA,
        OEMSpecific_DB = 0xDB,
        OEMSpecific_DC = 0xDC,
        OEMSpecific_DD = 0xDD,
        OEMSpecific_DE = 0xDE,
        OEMSpecific_DF = 0xDF,
        Reserved_E0 = 0xE0,
        OEMSpecific_E1 = 0xE1,
        OEMSpecific_E2 = 0xE2,
        OEMSpecific_E3 = 0xE3,
        OEMSpecific_E4 = 0xE4,
        IME_Process = 0xE5,
        OEMSpecific_E6 = 0xE6,
        UnicodePacket = 0xE7,
        Unassigned_E8 = 0xE8,
        OEMSpecific_E9 = 0xE9,
        OEMSpecific_EA = 0xEA,
        OEMSpecific_EB = 0xEB,
        OEMSpecific_EC = 0xEC,
        OEMSpecific_ED = 0xED,
        OEMSpecific_EE = 0xEE,
        OEMSpecific_EF = 0xEF,
        OEMSpecific_F0 = 0xF0,
        OEMSpecific_F1 = 0xF1,
        OEMSpecific_F2 = 0xF2,
        OEMSpecific_F3 = 0xF3,
        OEMSpecific_F4 = 0xF4,
        OEMSpecific_F5 = 0xF5,
        Attention = 0xF6,
        CursorSelect = 0xF7,
        ExtentSelection = 0xF8,
        EraseToEndOfFile = 0xF9,
        Play = 0xFA,
        Zoom = 0xFB,
        Reserved_FC = 0xFC,
        ProgramAttention = 0xFD,
        OEM_Clear = 0xFE,
        Unassignned_FF = 0xFF,
    }
    //The names of all virtual key codes up to 0xFF.
    public static readonly string[] VKNames = new string[256]
    {
            "Unassigned",
            "LeftMouseButton",
            "RightMouseButton",
            "Cancel",
            "MiddleMouseButton",
            "MouseButtonX1",
            "MouseButtonX2",
            "Reserved",
            "Backspace",
            "Tab",
            "Reserved",
            "Reserved",
            "Clear",
            "Enter",
            "Unassigned",
            "Unassigned",
            "Shift",
            "Control",
            "Alt",
            "Pause",
            "CapsLock",
            "IME_HangulOrKana",
            "IME_On",
            "IME_Junja",
            "IME_Final",
            "IME_HanjaOrKanji",
            "IME_Off",
            "Escape",
            "IME_Convert",
            "IME_NonConvert",
            "IME_Accept",
            "IME_ModeChange",
            "Space",
            "PageUp",
            "PageDown",
            "End",
            "Home",
            "LeftArrow",
            "UpArrow",
            "RightArrow",
            "DownArrow",
            "Select",
            "Print",
            "Execute",
            "Snapshot",
            "Insert",
            "Delete",
            "Help",
            "Zero",
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Unassigned",
            "Unassigned",
            "Unassigned",
            "Unassigned",
            "Unassigned",
            "Unassigned",
            "Unassigned",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "LeftWindows",
            "RightWindows",
            "Apps",
            "Reserved",
            "Sleep",
            "NumPad_0",
            "NumPad_1",
            "NumPad_2",
            "NumPad_3",
            "NumPad_4",
            "NumPad_5",
            "NumPad_6",
            "NumPad_7",
            "NumPad_8",
            "NumPad_9",
            "Multiply",
            "Add",
            "Separator",
            "Subtract",
            "Decimal",
            "Divide",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "F13",
            "F14",
            "F15",
            "F16",
            "F17",
            "F18",
            "F19",
            "F20",
            "F21",
            "F22",
            "F23",
            "F24",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "NumLock",
            "ScrollLock",
            "OEMSpecific",
            "OEMSpecific",
            "OEMSpecific",
            "OEMSpecific",
            "OEMSpecific",
            "Unassigned",
            "Unassigned",
            "Unassigned",
            "Unassigned",
            "Unassigned",
            "Unassigned",
            "Unassigned",
            "Unassigned",
            "Unassigned",
            "LeftShift",
            "RightShift",
            "LeftControl",
            "RightControl",
            "LeftMenu",
            "RightMenu",
            "Browser_Back",
            "Browser_Forward",
            "Browser_Refresh",
            "Browser_Stop",
            "Browser_Search",
            "Browser_Favorites",
            "Browser_Home",
            "Mute",
            "VolumeDown",
            "VolumeUp",
            "Media_SkipNext",
            "Media_SkipPrevious",
            "Media_Stop",
            "Media_PlayPause",
            "Launch_Mail",
            "Launch_MediaSelect",
            "Launch_CustomApp1",
            "Launch_CustomApp2",
            "Reserved",
            "Reserved",
            "OEMSpecific",
            "OEM_Plus",
            "OEM_Comma",
            "OEM_Minus",
            "OEM_Period",
            "OEMSpecific",
            "OEMSpecific",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "OEMSpecific",
            "OEMSpecific",
            "OEMSpecific",
            "OEMSpecific",
            "OEMSpecific",
            "Reserved",
            "OEMSpecific",
            "OEMSpecific",
            "OEMSpecific",
            "OEMSpecific",
            "IME_Process",
            "OEMSpecific",
            "UnicodePacket",
            "Unassigned",
            "OEMSpecific",
            "OEMSpecific",
            "OEMSpecific",
            "OEMSpecific",
            "OEMSpecific",
            "OEMSpecific",
            "OEMSpecific",
            "OEMSpecific",
            "OEMSpecific",
            "OEMSpecific",
            "OEMSpecific",
            "OEMSpecific",
            "OEMSpecific",
            "Attention",
            "CursorSelect",
            "ExtentSelection",
            "EraseToEndOfFile",
            "Play",
            "Zoom",
            "Reserved",
            "ProgramAttention",
            "OEM_Clear",
            "Unassignned"
    };
    //Coverts an arbitrary virtual key code into its string representation.
    public static string VKCodeToString(ushort vkCode)
    {
        if(vkCode <= 0xFF)
        {
            return VKNames[vkCode];
        }
        else
        {
            return "Unassignned";
        }
    }
}