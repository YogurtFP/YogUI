using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using YogUILibrary.Code.Structs;
namespace YogUILibrary.Code.Managers
{
    public class InputManager
    {
        private static KeyboardState KeyboardState;
        private static KeyboardState oldKeyboardState;
        private static MouseState MouseState;
        private static MouseState oldMouseState;
        private int scrollValue = 0;

        private static List<CodeBoundMouse> boundMouse = new List<CodeBoundMouse>();
        private static List<CodeBoundKey> boundKey = new List<CodeBoundKey>();

        public static void BindKey(Action lambda, Keys key, bool constant = false, bool press = true, string identifier = "bind")
        {
            boundKey.Add(new CodeBoundKey(lambda, key, constant, press, identifier));
        }

        public static void BindMouse(Action a, MouseButton button, bool press = true, bool constant = false, string identifier = "bind")
        {
            boundMouse.Add(new CodeBoundMouse(a, button, press, constant, identifier));
        }

        public static Point GetMousePos()
        {
            return new Point(MouseState.X, MouseState.Y);
        }

        public static Vector2 GetMousePosV()
        {
            return new Vector2(GetMousePos().X, GetMousePos().Y);
        }

        public void Update(GameTime time)
        {
            KeyboardState = Keyboard.GetState();
            MouseState = Mouse.GetState();
            int scroll = MouseState.ScrollWheelValue - scrollValue;
            scrollValue = MouseState.ScrollWheelValue;
            if (YogUI.theGame.IsActive)
            {
                try
                {
                    foreach (CodeBoundMouse b in boundMouse)
                    {
                        switch (b.boundMouseButton)
                        {
                            case MouseButton.Left:
                                if (MouseState.LeftButton != oldMouseState.LeftButton || b.constant)
                                {
                                    if (b.press && MouseState.LeftButton == ButtonState.Pressed)
                                        b.lambda();
                                    else if (!b.press && MouseState.LeftButton == ButtonState.Released)
                                        b.lambda();
                                }
                                break;
                            case MouseButton.Middle:
                                if (MouseState.MiddleButton != oldMouseState.MiddleButton || b.constant)
                                {
                                    if (b.press && MouseState.MiddleButton == ButtonState.Pressed)
                                        b.lambda();
                                    else if (!b.press && MouseState.MiddleButton == ButtonState.Released)
                                        b.lambda();
                                }
                                break;

                            case MouseButton.Right:
                                if (MouseState.RightButton != oldMouseState.RightButton || b.constant)
                                {
                                    if (b.press && MouseState.RightButton == ButtonState.Pressed)
                                        b.lambda();
                                    else if (!b.press && MouseState.RightButton == ButtonState.Released)
                                        b.lambda();
                                }
                                break;

                            case MouseButton.Scroll:
                                if (scroll != 0)
                                    b.lambda();
                                break;

                            case MouseButton.Scrolldown:
                                if (scroll < 0)
                                    b.lambda();
                                break;
                            case MouseButton.Scrollup:
                                if (scroll > 0)
                                    b.lambda();
                                break;

                            case MouseButton.Movement:
                                if (MouseState.Y != oldMouseState.Y || MouseState.X != oldMouseState.X)
                                {
                                    b.lambda();
                                }
                                break;
                        }
                    }
                }
                catch (Exception)
                {

                }

                try
                {
                    foreach (CodeBoundKey b in boundKey)
                    {
                        Keys k = b.boundKey;
                        bool newP = KeyboardState.IsKeyDown(k);
                        bool oldP = oldKeyboardState.IsKeyDown(k);
                        bool constant = b.constant;
                        bool press = b.press;

                        if ((newP != oldP || constant))
                        {
                            if (press && newP)
                                b.lambda();
                            else if (!press && !newP)
                                b.lambda();
                        }
                    }
                }
                catch (Exception)
                {

                }
            }

            oldMouseState = MouseState;
            oldKeyboardState = KeyboardState;
        }

        public static bool isKeyPressed(Keys k)
        {
            if (KeyboardState.IsKeyDown(k))
                return true;
            return false;
        }
    }
    public enum MouseButton
    {
        Left,
        Middle,
        Right,
        Scrollup,
        Scrolldown,
        Scroll,
        Movement
    }
    public enum TextAlign
    {
        Left,
        Center,
        Right
    }
}
