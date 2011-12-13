using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
namespace YogUI.Code.Structs
{
    public class CodeBoundKey
    {
        public Action lambda;
        public Keys boundKey;
        public string identifier = "bind";
        public bool constant;
        public bool press;


        public CodeBoundKey(Action a, Keys key, bool constant = false, bool pressing = true, string identifier = "bind")
        {
            lambda = a;
            boundKey = key;
            press = pressing;
            this.constant = (pressing) ? constant : false;
            this.identifier = identifier;
        }
    }
}
