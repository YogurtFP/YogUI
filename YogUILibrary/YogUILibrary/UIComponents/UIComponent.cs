using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using YogUILibrary.Managers;
using System.Diagnostics;
using YogUILibrary.Managers;
namespace YogUILibrary.UIComponents
{
    public class UIComponent
    {
        public bool mouseOver = false;
        public bool active = true;
        public Action onMouseOver = null;
        public Action onMouseOff = null;
        public Action onMouseClick = null;
        public Action onMouseDrag = null;
        private string toolText = "";

        public Vector2 Position = Vector2.Zero;

        public virtual Rectangle BoundBox
        {
            get
            {
                return new Rectangle();
            }
        }
        

        public void UIC_Initialize(bool bind = true)
        {
            if (bind)
            {
                InputManager.BindMouse(() =>
                {
                    Point p = InputManager.GetMousePos();
                    if (BoundBox.Contains(p) && active)
                        OnMouseClick();
                }, MouseButton.Left);

                InputManager.BindMouse(() =>
                {
                    Point p = InputManager.GetMousePos();
                    if (BoundBox.Contains(p) && active)
                        OnMouseDrag();
                }, MouseButton.Movement, true, true);

                InputManager.BindMouse(() =>
                {
                    Point p = InputManager.GetMousePos();
                    if (BoundBox.Contains(p) && active && !mouseOver)
                    {
                        OnMouseOver();
                        mouseOver = true;
                    }
                }, MouseButton.Movement);

                InputManager.BindMouse(() =>
                {
                    Point p = InputManager.GetMousePos();
                    if (!BoundBox.Contains(p) && mouseOver && active)
                    {
                        OnMouseOff();
                        mouseOver = false;
                    }
                }, MouseButton.Movement);
            }
        }

        public virtual void OnMouseClick()
        {
            if (onMouseClick != null && active)
                onMouseClick();
        }

        public virtual void OnMouseOver()
        {
            if (onMouseOver != null && active)
                onMouseOver();
        }

        public virtual void OnMouseOff()
        {
            if (onMouseOff != null && active)
                onMouseOff();
        }

        public virtual void OnMouseDrag()
        {
            if (onMouseDrag != null && active)
                onMouseDrag();
        }


        public void SetOnMouseClick(Action a)
        {
            onMouseClick = a;
        }

        public void SetOnMouseOver(Action a)
        {
            onMouseOver = a;
        }

        public void SetOnMouseOff(Action a)
        {
            onMouseOff = a;
        }

        public void SetOnMouseDrag(Action a)
        {
            onMouseDrag = a;
        }

        public virtual void Update(GameTime theTime)
        {
            if (mouseOver && toolText != "")
            {
            }
        }

        public virtual void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
        }
    }
}
