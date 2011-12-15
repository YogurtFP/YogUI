using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YogUILibrary.Code.Managers;
namespace YogUILibrary.Code.Structs
{
    public class CodeBoundMouse
    {
        public Action lambda;
        public MouseButton boundMouseButton;
        public string identifier = "bind";
        public bool press;
        public bool constant;


        public CodeBoundMouse(Action a, MouseButton button, bool pressing = true, bool constant = false, string identifier = "bind")
        {
            lambda = a;
            boundMouseButton = button;
            press = pressing;
            this.constant = (pressing) ? constant : false;
            this.identifier = identifier;
        }
    }
}
