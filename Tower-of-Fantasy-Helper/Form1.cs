using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tower_of_Fantasy_Helper
{

	public partial class Form1 : Form
	{
		public static class Binds
		{
			public static int Key_SamirDashAtkCancels;

			public static int Key_StaminaFreeWallClimb;

			public static int Key_Clicker;

			public static int Key_Holder;

			public static bool Holder;
		}
		public Form1()
		{
			InitializeComponent();
			MaximizeBox = false;
			ActiveControl = label1;
		}

		private void textBox1_Click(object sender, EventArgs e)
		{
			Binds.Key_SamirDashAtkCancels = 0;
			textBox1.Text = "Press any button";
		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			textBox1.Text = "";
			textBox1.Text = Exc_KeyBoard.KeyNames[e.KeyValue];
			Binds.Key_SamirDashAtkCancels = e.KeyValue;
			ActiveControl = label1;

		}

		private void textBox2_KeyDown(object sender, KeyEventArgs e)
		{
			textBox2.Text = "";
			textBox2.Text = Exc_KeyBoard.KeyNames[e.KeyValue];
			Binds.Key_StaminaFreeWallClimb = e.KeyValue;
			ActiveControl = label1;

		}
		private void textBox3_KeyDown(object sender, KeyEventArgs e)
		{
			textBox3.Text = "";
			textBox3.Text = Exc_KeyBoard.KeyNames[e.KeyValue];
			Binds.Key_Clicker = e.KeyValue;
			ActiveControl = label1;
		}

		private void textBox4_KeyDown(object sender, KeyEventArgs e)
		{
			textBox4.Text = "";
			textBox4.Text = Exc_KeyBoard.KeyNames[e.KeyValue];
			Binds.Key_Holder = e.KeyValue;
			ActiveControl = label1;
		}

		private void textBox2_Click(object sender, EventArgs e)
		{
			Binds.Key_StaminaFreeWallClimb = 0;
			textBox2.Text = "Press any button";
		}
		private void textBox3_Click(object sender, EventArgs e)
		{
			Binds.Key_Clicker = 0;
			textBox3.Text = "Press any button";
		}

		private void textBox4_Click(object sender, EventArgs e)
		{
			Binds.Key_Holder = 0;
			textBox4.Text = "Press any button";
		}

		async void samir_dash_atk_cancels()
        {
			Exc_KeyBoard.mouse_event(Exc_KeyBoard.MouseEventRightDown, 0,0,0, new System.IntPtr());
			Exc_KeyBoard.mouse_event(Exc_KeyBoard.MouseEventRightUp, 0, 0, 0, new System.IntPtr());
			await Task.Delay(350);
			Exc_KeyBoard.mouse_event(Exc_KeyBoard.MouseEventLeftDown, 0, 0, 0, new System.IntPtr());
			Exc_KeyBoard.mouse_event(Exc_KeyBoard.MouseEventLeftUp, 0, 0, 0, new System.IntPtr());
			await Task.Delay(200);
			Exc_KeyBoard.keybd_event(Exc_KeyBoard.VK_SPACE, 0, 0, 0);
			Exc_KeyBoard.keybd_event(Exc_KeyBoard.VK_SPACE, 0, Exc_KeyBoard.KEYEVENTF_KEYUP, 0);
			await Task.Delay(10);
		}

		async void StaminaFreeWallClimb()
        {
			Exc_KeyBoard.keybd_event(Exc_KeyBoard.VK_LCONTROL, 0, 0, 0);
			Exc_KeyBoard.keybd_event(Exc_KeyBoard.VK_LCONTROL, 0, Exc_KeyBoard.KEYEVENTF_KEYUP, 0);
			await Task.Delay(100);
			Exc_KeyBoard.keybd_event(Exc_KeyBoard.VK_SPACE, 0, 0, 0);
			Exc_KeyBoard.keybd_event(Exc_KeyBoard.VK_SPACE, 0, Exc_KeyBoard.KEYEVENTF_KEYUP, 0);
			await Task.Delay(30);
			Exc_KeyBoard.keybd_event(Exc_KeyBoard.VK_SPACE, 0, 0, 0);
			Exc_KeyBoard.keybd_event(Exc_KeyBoard.VK_SPACE, 0, Exc_KeyBoard.KEYEVENTF_KEYUP, 0);
			await Task.Delay(30);
			Exc_KeyBoard.keybd_event(Exc_KeyBoard.W_KEY, 0, 0, 0);
			await Task.Delay(25);
			Exc_KeyBoard.keybd_event(Exc_KeyBoard.W_KEY, 0, Exc_KeyBoard.KEYEVENTF_KEYUP, 0);
			await Task.Delay(350);

		}

		void Clicker()
        {
			Exc_KeyBoard.mouse_event(Exc_KeyBoard.MouseEventLeftDown, 0, 0, 0, new System.IntPtr());
			Exc_KeyBoard.mouse_event(Exc_KeyBoard.MouseEventLeftUp, 0, 0, 0, new System.IntPtr());
		}

		async void HoldAtk()
        {
			Exc_KeyBoard.mouse_event(Exc_KeyBoard.MouseEventLeftDown, 0, 0, 0, new System.IntPtr());
			await Task.Delay(10000);
		}

		private void CheckProcess_Tick(object sender, EventArgs e)
        {
			try
			{
				IntPtr h = Exc_KeyBoard.GetForegroundWindow();
				int pid = 0;
				Exc_KeyBoard.GetWindowThreadProcessId(h, ref pid);
				int id = Process.GetProcessesByName("QRSL")[0].Id;
				if (pid == id)
				{
					if (Exc_KeyBoard.GetAsyncKeyState(Binds.Key_StaminaFreeWallClimb))
						ClimbTimer.Enabled = true;
					else
						ClimbTimer.Enabled = false;
					if (Exc_KeyBoard.GetAsyncKeyState(Binds.Key_Clicker))
						ClickerTimer.Enabled = true;
					else
						ClickerTimer.Enabled = false;
				}
			}
            catch
			{
				CheckProcess.Enabled = false;
				MessageBox.Show("Process not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
			}
		}

		private void clicker_timer_Tick(object sender, EventArgs e)
		{
			Clicker();
		}

		private void ClickerTimer_Tick(object sender, EventArgs e)
        {
			Clicker();
		}

		private void ClimbTimer_Tick(object sender, EventArgs e)
        {
			StaminaFreeWallClimb();
		}
    }

}
