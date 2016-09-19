﻿using System.Windows.Forms;

namespace JunkShop
{
    class ListtBoxEx : ListBox
    {
        int WM_KILLFOCUS = 0x8;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg != WM_KILLFOCUS)
            {
                base.WndProc(ref m);
            }
        }
    }
}

//Flicker free listbox