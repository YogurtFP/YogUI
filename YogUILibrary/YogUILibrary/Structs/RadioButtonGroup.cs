﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YogUILibrary.Code.UIComponents;

namespace YogUILibrary.Code.Structs
{
    public class RadioButtonGroup
    {
        List<RadioButton> buttons = new List<RadioButton>();

        public void addButton(RadioButton b)
        {
            if (!buttons.Contains(b))
            {
                buttons.Add(b);
                b.group = this;
            }
        }

        public void buttonPressed(RadioButton b)
        {
            foreach (RadioButton b2 in buttons)
            {
                if (b2 != b)
                    b2.selected = false;
            }
        }
    }
}
