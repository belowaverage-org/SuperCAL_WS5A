﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SuperCAL_WS5A
{
    public partial class Main : Form
    {
        [DllImport("coredll.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

        public Main()
        {
            InitializeComponent();
            hWnd = Handle;
            SetWindowsPosition((Screen.PrimaryScreen.Bounds.Width / 2) - (Width / 2), (Screen.PrimaryScreen.Bounds.Height / 2) - (Height / 2));
        }

        private static IntPtr hWnd;

        private static void SetWindowsPosition(int x, int y)
        {
            try
            {
                SetWindowPos(hWnd, IntPtr.Zero, x, y, 0, 0, 0x0001);
            }
            catch(Exception)
            {
                Console.WriteLine("Failed to set window position.");
            }
        }
    }
}
