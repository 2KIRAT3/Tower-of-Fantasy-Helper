using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tower_of_Fantasy_Helper
{
    public static class Exc_KeyBoard
    {
		[DllImport("user32.dll")]
		public static extern UInt32 GetWindowThreadProcessId(IntPtr hwnd, ref Int32 pid);


		[DllImport("user32.dll")]
		public static extern IntPtr GetForegroundWindow();

		public const byte VK_LSHIFT = 0xA0;

		public const byte VK_SPACE = 0x20;

		public const byte W_KEY = 0x57;

		public const byte VK_LCONTROL = 0xA2;

		[DllImport("User32.dll")]
		public static extern bool GetAsyncKeyState(int Key);

		public const uint KEYEVENTF_KEYUP = 0x0002;

		[DllImport("user32.dll")]
		public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

		[DllImport("user32.dll")]
		public static extern void mouse_event(UInt32 dwFlags, UInt32 dx, UInt32 dy, UInt32 dwData, IntPtr dwExtraInfo);

		public const UInt32 MouseEventLeftDown = 0x0002;
		public const UInt32 MouseEventLeftUp = 0x0004;

		public const UInt32 MouseEventRightDown = 0x0008;
		public const UInt32 MouseEventRightUp = 0x0010;
        public static string[] KeyNames = {
		"Unknown",
		"VK_LBUTTON",
		"VK_RBUTTON",
		"VK_CANCEL",
		"VK_MBUTTON",
		"VK_XBUTTON1",
		"VK_XBUTTON2",
		"Unknown",
		"VK_BACK",
		"VK_TAB",
		"Unknown",
		"Unknown",
		"VK_CLEAR",
		"VK_RETURN",
		"Unknown",
		"Unknown",
		"VK_SHIFT",
		"VK_CONTROL",
		"VK_MENU",
		"VK_PAUSE",
		"VK_CAPITAL",
		"VK_KANA",
		"Unknown",
		"VK_JUNJA",
		"VK_FINAL",
		"VK_KANJI",
		"Unknown",
		"VK_ESCAPE",
		"VK_CONVERT",
		"VK_NONCONVERT",
		"VK_ACCEPT",
		"VK_MODECHANGE",
		"VK_SPACE",
		"VK_PRIOR",
		"VK_NEXT",
		"VK_END",
		"VK_HOME",
		"VK_LEFT",
		"VK_UP",
		"VK_RIGHT",
		"VK_DOWN",
		"VK_SELECT",
		"VK_PRINT",
		"VK_EXECUTE",
		"VK_SNAPSHOT",
		"VK_INSERT",
		"VK_DELETE",
		"VK_HELP",
		"0",
		"1",
		"2",
		"3",
		"4",
		"5",
		"6",
		"7",
		"8",
		"9",
		"Unknown",
		"Unknown",
		"Unknown",
		"Unknown",
		"Unknown",
		"Unknown",
		"Unknown",
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
		"VK_LWIN",
		"VK_RWIN",
		"VK_APPS",
		"Unknown",
		"VK_SLEEP",
		"VK_NUMPAD0",
		"VK_NUMPAD1",
		"VK_NUMPAD2",
		"VK_NUMPAD3",
		"VK_NUMPAD4",
		"VK_NUMPAD5",
		"VK_NUMPAD6",
		"VK_NUMPAD7",
		"VK_NUMPAD8",
		"VK_NUMPAD9",
		"VK_MULTIPLY",
		"VK_ADD",
		"VK_SEPARATOR",
		"VK_SUBTRACT",
		"VK_DECIMAL",
		"VK_DIVIDE",
		"VK_F1",
		"VK_F2",
		"VK_F3",
		"VK_F4",
		"VK_F5",
		"VK_F6",
		"VK_F7",
		"VK_F8",
		"VK_F9",
		"VK_F10",
		"VK_F11",
		"VK_F12",
		"VK_F13",
		"VK_F14",
		"VK_F15",
		"VK_F16",
		"VK_F17",
		"VK_F18",
		"VK_F19",
		"VK_F20",
		"VK_F21",
		"VK_F22",
		"VK_F23",
		"VK_F24",
		"Unknown",
		"Unknown",
		"Unknown",
		"Unknown",
		"Unknown",
		"Unknown",
		"Unknown",
		"Unknown",
		"VK_NUMLOCK",
		"VK_SCROLL",
		"VK_OEM_NEC_EQUAL",
		"VK_OEM_FJ_MASSHOU",
		"VK_OEM_FJ_TOUROKU",
		"VK_OEM_FJ_LOYA",
		"VK_OEM_FJ_ROYA",
		"Unknown",
		"Unknown",
		"Unknown",
		"Unknown",
		"Unknown",
		"Unknown",
		"Unknown",
		"Unknown",
		"Unknown",
		"VK_LSHIFT",
		"VK_RSHIFT",
		"VK_LCONTROL",
		"VK_RCONTROL",
		"VK_LMENU",
		"VK_RMENU"
		};
	}
}
