using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

#if UNITY_EDITOR
using UnityEditor;
#endif

public static class e
{
    public static Key A = Key.A;
    public static Key B = Key.B;
    public static Key C = Key.C;
    public static Key D = Key.D;
    public static Key E = Key.E; 
    public static Key F = Key.F;
    public static Key G = Key.G;
    public static Key H = Key.H;
    public static Key I = Key.I; 
    public static Key J = Key.J;
    public static Key K = Key.K;
    public static Key L = Key.L;
    public static Key M = Key.M; 
    public static Key N = Key.N;
    public static Key O = Key.O;
    public static Key P = Key.P;
    public static Key Q = Key.Q;
    public static Key R = Key.R;
    public static Key S = Key.S;
    public static Key T = Key.T;
    public static Key U = Key.U;
    public static Key V = Key.V;
    public static Key W = Key.W;
    public static Key X = Key.X;
    public static Key Y = Key.Y;
    public static Key Z = Key.Z;
    public static Key k0 = Key.Digit0;
    public static Key k1 = Key.Digit1;
    public static Key k2 = Key.Digit2;
    public static Key k3 = Key.Digit3;
    public static Key k4 = Key.Digit4; 
    public static Key k5 = Key.Digit5;
    public static Key k6 = Key.Digit6;
    public static Key k7 = Key.Digit7;
    public static Key k8 = Key.Digit8;
    public static Key k9 = Key.Digit9;
    public static Key num0 = Key.Numpad0;
    public static Key num1 = Key.Numpad1;
    public static Key num2 = Key.Numpad2;
    public static Key num3 = Key.Numpad3;
    public static Key num4 = Key.Numpad4;
    public static Key num5 = Key.Numpad5;
    public static Key num6 = Key.Numpad6;
    public static Key num7 = Key.Numpad7;
    public static Key num8 = Key.Numpad8;
    public static Key num9 = Key.Numpad9;
    public static Key f1 = Key.F1;
    public static Key f2 = Key.F2;
    public static Key f3 = Key.F3;
    public static Key f4 = Key.F4;
    public static Key f5 = Key.F5;
    public static Key f6 = Key.F6;
    public static Key f7 = Key.F7;
    public static Key f8 = Key.F8;
    public static Key f9 = Key.F9;
    public static Key f10 = Key.F10;
    public static Key f11 = Key.F11;
    public static Key f12 = Key.F12;
    public static Key lAlt = Key.LeftAlt;
    public static Key lApple = Key.LeftApple;
    public static Key lBracket = Key.LeftBracket;
    public static Key lCommand = Key.LeftCommand; 
    public static Key lCtrl = Key.LeftCtrl;
    public static Key lMeta = Key.LeftMeta;
    public static Key lShift = Key.LeftShift;
    public static Key lWin = Key.LeftWindows;
    public static Key rAlt = Key.RightAlt;
    public static Key rApple = Key.RightApple;
    public static Key rBracket = Key.RightBracket;
    public static Key rCommand = Key.RightCommand;
    public static Key rCtrl = Key.RightCtrl;
    public static Key rMeta = Key.RightMeta;
    public static Key rShift = Key.RightShift;
    public static Key rWin = Key.RightWindows; 
    public static Key minus = Key.Minus;
    public static Key pageDown = Key.PageDown;
    public static Key pageUp = Key.PageUp; 
    public static Key arrowRight = Key.RightArrow; 
    public static Key arrowLeft = Key.LeftArrow;
    public static Key arrowUp = Key.UpArrow;
    public static Key arrowDown = Key.DownArrow;
    public static Key end = Key.End; 
    public static Key enter = Key.Enter;
    public static Key numEnter = Key.NumpadEnter;
    public static Key escape = Key.Escape;
    public static Key equals = Key.Equals;
    public static Key comma = Key.Comma;
    public static Key capsLock = Key.CapsLock;
    public static Key backspace = Key.Backspace;
    public static Key backslash = Key.Backslash;
    public static Key backqute = Key.Backquote;
    public static Key altGr = Key.AltGr;
    public static Key contexMenu = Key.ContextMenu;
    public static Key delete = Key.Delete;
    public static Key home = Key.Home;
    public static Key IMEselected = Key.IMESelected;
    public static Key insert = Key.Insert;
    public static Key none = Key.None;
    public static Key numLock = Key.NumLock;
    public static Key numDivide = Key.NumpadDivide;
    public static Key numEquals = Key.NumpadEquals;
    public static Key numMinus = Key.NumpadMinus;
    public static Key numMultiply = Key.NumpadMultiply;
    public static Key numPeriod = Key.NumpadPeriod;
    public static Key numPlus = Key.NumpadPlus;
    public static Key oem1 = Key.OEM1;
    public static Key oem2 = Key.OEM2;
    public static Key oem3 = Key.OEM3;
    public static Key oem4 = Key.OEM4;
    public static Key oem5 = Key.OEM5; 
    public static Key pause = Key.Pause;
    public static Key printScreen = Key.PrintScreen;
    public static Key quote = Key.Quote;
    public static Key scrollLock = Key.ScrollLock;
    public static Key semicolon = Key.Semicolon;
    public static Key slash = Key.Slash;
    public static Key space = Key.Space;
    public static Key tab = Key.Tab;
}


public class EZMONO : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}

public class EZ 
{

    /*
     * Would you have wanted to write it all down, I don't think so
     * ;) 
     * written by AzeS 
     * v 1.3
     */
    static AzeSCon a;



    //Controller Var??s
    static bool A_Pressed, X_Pressed, B_Pressed, Y_Pressed, LB_Pressed, RB_Pressed, LT_Pressed, RT_Pressed, L3_Pressed, R3_Pressed, Up_Pressed, Down_Pressed, left_Pressed, right_Pressed, select_Pressed, start_Pressed;
    static bool A_Down, X_Down, B_Down, Y_Down, LB_Down, RB_Down, LT_Down, RT_Down, L3_Down, R3_Down, Up_Down, Down_Down, left_Down, right_Down, select_Down, start_Down;
    static bool A_up, X_up, B_up, Y_up, LB_up, RB_up, LT_up, RT_up, L3_up, R3_up, Up_up, Down_up, left_up, right_up, select_up, start_up;
    static float RT_trigger, LT_trigger;
    static Vector2 LS, RS, arrows;


    //Mouse Var??s
    static bool isMouseLeft, isMouseRight, isMouseMiddel, MouseLeft_Down, MouseRight_Down, MouseMiddel_Down, MouseLeft_Up, MouseRight_Up, MouseMiddel_Up;
    public static bool MouseBack, MouseForward;
    public static Mouse _mouse;
    public static Vector2 Mouse_Position, Mouse_Delta;
    public static float Mouse_Wheel;
    static bool drag;
    public static bool onMouse;
    public static int clicks;
    static GameObject enterbuff, overbuff, lastbuff;
    public static bool controllerCursor = false;
    public static int controllerCursorControllerIndex = 1;
    public static float controllerCursorMoveSpeed = 55;
    //Keyboard
    static Keyboard aKey,bKey,cKey;
    static bool kdown, kup;
    public static float Horizontal, Vertical;
    public static bool anykey;
    static KeyControl bufferkey;

    public static bool DebugMouse = false, DebugPosition = false, DebugDelta = false, DebugKeyboard = false, dl = false,dr=false,dm=false,df=false,db=false;
    public static Key debugKey;


    [RuntimeInitializeOnLoadMethod]
    static void Onwake()
    {
        
        
        a = new AzeSCon();
        a.Enable();

        
        a.Controller.A.performed += ctx => A_Pressed = true;
        a.Controller.A.canceled += ctx => A_Pressed = false;
        a.Controller.A.started += ctx => A_Down = true;
        a.Controller.A.canceled += ctx => A_up = true;

        a.Controller.X.performed += ctx => X_Pressed = true;
        a.Controller.X.canceled += ctx => X_Pressed = false;
        a.Controller.X.started += ctx => X_Down = true;
        a.Controller.X.canceled += ctx => X_up = true;

        a.Controller.B.performed += ctx => B_Pressed = true;
        a.Controller.B.canceled += ctx => B_Pressed = false;
        a.Controller.B.started += ctx => B_Down = true;
        a.Controller.B.canceled += ctx => B_up = true;

        a.Controller.Y.performed += ctx => Y_Pressed = true;
        a.Controller.Y.canceled += ctx => Y_Pressed = false;
        a.Controller.Y.started += ctx => Y_Down = true;
        a.Controller.Y.canceled += ctx => Y_up = true;

        a.Controller.LB.performed += ctx => LB_Pressed = true;
        a.Controller.LB.canceled += ctx => LB_Pressed = false;
        a.Controller.LB.started += ctx => LB_Down = true;
        a.Controller.LB.canceled += ctx => LB_up = true;
        a.Controller.L3.performed += ctx => L3_Pressed = true;
        a.Controller.L3.canceled += ctx => L3_Pressed = false;
        a.Controller.L3.started += ctx => L3_Down = true;
        a.Controller.L3.canceled += ctx => L3_up = true;
        a.Controller.LT.performed += ctx => LT_Pressed = true;
        a.Controller.LT.canceled += ctx => LT_Pressed = false;
        a.Controller.LT.started += ctx => LT_Down = true;
        a.Controller.LT.canceled += ctx => LT_up = true;

        a.Controller.RB.performed += ctx => RB_Pressed = true;
        a.Controller.RB.canceled += ctx => RB_Pressed = false;
        a.Controller.RB.started += ctx => RB_Down = true;
        a.Controller.RB.canceled += ctx => RB_up = true;
        a.Controller.RT.performed += ctx => RT_Pressed = true;
        a.Controller.RT.canceled += ctx => RT_Pressed = false;
        a.Controller.RT.started += ctx => RT_Down = true;
        a.Controller.RT.canceled += ctx => RT_up = true;
        a.Controller.R3.performed += ctx => R3_Pressed = true;
        a.Controller.R3.canceled += ctx => R3_Pressed = false;
        a.Controller.R3.started += ctx => R3_Down = true;
        a.Controller.R3.canceled += ctx => R3_up = true;

        a.Controller.Select.performed += ctx => select_Pressed = true;
        a.Controller.Select.canceled += ctx => select_Pressed = false;
        a.Controller.Select.started += ctx => select_Down = true;
        a.Controller.Select.canceled += ctx => select_up = true;

        a.Controller.Start.performed += ctx => start_Pressed = true;
        a.Controller.Start.canceled += ctx => start_Pressed = false;
        a.Controller.Start.started += ctx => start_Down = true;
        a.Controller.Start.canceled += ctx => start_up = true;

        a.Controller.Arrows.performed += ctx => Up_Pressed = ctx.ReadValue<Vector2>() == Vector2.up;
        a.Controller.Arrows.canceled += ctx => Up_Pressed = false;
        a.Controller.Arrows.started += ctx => Up_Down = ctx.ReadValue<Vector2>() == Vector2.up;
        a.Controller.Arrows.performed += ctx => Down_Pressed = ctx.ReadValue<Vector2>() == -Vector2.up;
        a.Controller.Arrows.canceled += ctx => Down_Pressed = false;
        a.Controller.Arrows.started += ctx => Down_Down = ctx.ReadValue<Vector2>() == -Vector2.up;
        a.Controller.Arrows.performed += ctx => right_Pressed = ctx.ReadValue<Vector2>() == Vector2.right;
        a.Controller.Arrows.canceled += ctx => right_Pressed = false;
        a.Controller.Arrows.started += ctx => right_Down = ctx.ReadValue<Vector2>() == Vector2.right;
        a.Controller.Arrows.performed += ctx => left_Pressed = ctx.ReadValue<Vector2>() == -Vector2.right;
        a.Controller.Arrows.canceled += ctx => left_Pressed = false;
        a.Controller.Arrows.started += ctx => left_Down = ctx.ReadValue<Vector2>() == -Vector2.right;

        a.Controller.RT.performed += ctx => RT_trigger = ctx.ReadValue<float>();
        a.Controller.LT.performed += ctx => LT_trigger = ctx.ReadValue<float>();
        a.Controller.RT.canceled += ctx => RT_trigger = 0;
        a.Controller.LT.canceled += ctx => LT_trigger = 0;

        a.Controller.RightStick.performed += ctx => RS = ctx.ReadValue<Vector2>();
        a.Controller.RightStick.canceled += ctx => RS = Vector2.zero;
        a.Controller.LeftStick.performed += ctx => LS = ctx.ReadValue<Vector2>();
        a.Controller.LeftStick.canceled += ctx => LS = Vector2.zero;

        a.Controller.Arrows.performed += ctx => arrows = ctx.ReadValue<Vector2>();
        a.Controller.Arrows.canceled += ctx => arrows = Vector2.zero;


        a.Mouse.LeftButton.performed += ctx => isMouseLeft = true;
        a.Mouse.LeftButton.canceled += ctx => isMouseLeft = false;
        a.Mouse.LeftButton.started += ctx => MouseLeft_Down = true;
        a.Mouse.LeftButton.canceled += ctx => MouseLeft_Down = false;
        a.Mouse.LeftButton.started += ctx => MouseLeft_Up = false;
        a.Mouse.LeftButton.canceled += ctx => MouseLeft_Up = true;

        a.Mouse.RightButton.performed += ctx => isMouseRight = true;
        a.Mouse.RightButton.canceled += ctx => isMouseRight = false;
        a.Mouse.RightButton.started += ctx => MouseRight_Down = true;
        a.Mouse.RightButton.canceled += ctx => MouseRight_Down = false;
        a.Mouse.RightButton.started += ctx => MouseRight_Up = false;
        a.Mouse.RightButton.canceled += ctx => MouseRight_Up = true;

        a.Mouse.MiddelButton.performed += ctx => isMouseMiddel = true;
        a.Mouse.MiddelButton.canceled += ctx => isMouseMiddel = false;
        a.Mouse.MiddelButton.started += ctx => MouseMiddel_Down = true;
        a.Mouse.MiddelButton.canceled += ctx => MouseMiddel_Down = false;
        a.Mouse.MiddelButton.started += ctx => MouseMiddel_Up = false;
        a.Mouse.MiddelButton.canceled += ctx => MouseMiddel_Up = true;

        a.Mouse.Position.performed += ctx => Mouse_Position = ctx.ReadValue<Vector2>();
        a.Mouse.Position.performed += ctx => getOverObject();
        a.Mouse.Position.started += ctx => getOverObject();
        a.Mouse.Position.canceled += ctx => getOverObject();

        a.Mouse.Delta.performed += ctx => Mouse_Delta = ctx.ReadValue<Vector2>();
        a.Mouse.Delta.canceled += ctx => Mouse_Delta = Vector2.zero;

        a.Mouse.Wheel.performed += ctx => Mouse_Wheel = ctx.ReadValue<float>();
        a.Mouse.Wheel.canceled += ctx => Mouse_Wheel = 0;

        a.Mouse.MausEingabe.performed += ctx => onMouse = true;
        a.Mouse.MausEingabe.canceled += ctx => onMouse = false;
        a.Mouse.MausEingabe.started += ctx => clicks++;
        a.Mouse.forword.performed += ctx => MouseForward = true;
        a.Mouse.forword.canceled += ctx => MouseForward = false;
        a.Mouse.back.performed += ctx => MouseBack = true;
        a.Mouse.back.canceled += ctx => MouseBack = false;

        
        _mouse = Mouse.current;
        a.Keyboard.TastenEingabe.performed += ctx => aKey = Keyboard.current;
        a.Keyboard.TastenEingabe.performed += ctx => setBufferKey();
       a.Keyboard.TastenEingabe.performed += ctx => anykey = true;
        a.Keyboard.TastenEingabe.started += ctx => kdown = true;
        a.Keyboard.TastenEingabe.canceled += ctx => kup = true;
        a.Keyboard.TastenEingabe.canceled += ctx => anykey = false;


        a.Keyboard.Horizontel.performed += ctx => Horizontal = ctx.ReadValue<float>();
        a.Keyboard.Horizontel.canceled += ctx => Horizontal = 0;
        a.Keyboard.Verticel.performed += ctx => Vertical = ctx.ReadValue<float>();
        a.Keyboard.Verticel.canceled += ctx => Vertical = 0;

        GameObject g = new GameObject("EZ-Inputs");
        g.transform.SetAsFirstSibling();
        var e = g.AddComponent<EZMONO>();
        e.StartCoroutine(update());


    }

    static void setBufferKey()
    {
        foreach(KeyControl k in aKey.allKeys)
        {
            if (k.isPressed && k.wasPressedThisFrame)
            {
                kdown = true;
                bufferkey = k;
            }
        }
    }

    static bool enter;
    static Camera c;

    static void getOverObject()
    {
        RaycastHit hit;

        if (c == null) c = Camera.main;
        if (c == null) c = Camera.current;

        if (Physics.Raycast(c.ScreenPointToRay(Mouse_Position), out hit))
        {
            enterbuff = hit.collider.gameObject;
        }
        else enterbuff = null;
        
    }

   

    /// <summary>
    /// sent a fake mouse klick from player??s device
    /// index :
    /// 0 = left
    /// 1 = right
    /// 2 = middel
    /// 3 = forward
    /// 4 = back
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public static bool GhostClick(int index = 0)
    {
        if (index == 0)
        {
            _mouse.leftButton.QueueValueChange<float>(1);
            if (_mouse.leftButton.isPressed) return true;
        }
        else if (index == 1)
        {
            _mouse.rightButton.QueueValueChange<float>(1);
            if (_mouse.rightButton.isPressed) return true;
        }
        else if (index == 2)
        {
            _mouse.middleButton.QueueValueChange<float>(1);
            if (_mouse.middleButton.isPressed) return true;
        }
        else if (index == 3)
        {
            _mouse.forwardButton.QueueValueChange<float>(1);
            if (_mouse.forwardButton.isPressed) return true;

        }
        else if (index == 4)
        {
            _mouse.backButton.QueueValueChange<float>(1);
            if (_mouse.backButton.isPressed) return true;

        }
        return false;
    }

    /// <summary>
    /// sent a fake mouse click at screen position from player??s device
    /// index :
    /// 0 = left
    /// 1 = right
    /// 2 = middel
    /// 3 = forward
    /// 4 = back
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public static bool GhostClickAtPosition(int index, float x, float y)
    {
        MouseState button = new MouseState();
        Vector2 pos = new Vector2(x, y);

        if (index == 0)
        {
            button = button.WithButton(MouseButton.Left, true);
            InputSystem.QueueStateEvent<MouseState>(_mouse, button);

            _mouse.WarpCursorPosition(pos);
            _mouse.leftButton.QueueValueChange<float>(1);
            if (_mouse.leftButton.isPressed) return true;
        }
        else if (index == 1)
        {
            _mouse.WarpCursorPosition(pos);
            _mouse.rightButton.QueueValueChange<float>(1);
            if (_mouse.rightButton.isPressed) return true;
        }
        else if (index == 2)
        {
            _mouse.WarpCursorPosition(pos);
            _mouse.middleButton.QueueValueChange<float>(1);
            if (_mouse.middleButton.isPressed) return true;
        }
        else if (index == 3)
        {
            _mouse.WarpCursorPosition(pos);
            _mouse.forwardButton.QueueValueChange<float>(1);
            if (_mouse.forwardButton.isPressed) return true;

        }
        else if (index == 4)
        {
            _mouse.WarpCursorPosition(pos);
            _mouse.backButton.QueueValueChange<float>(1);
            if (_mouse.backButton.isPressed) return true;

        }
        return false;
    }
    /// <summary>
     /// sent a fake mouse click at screen position from player??s device
     /// index :
     /// 0 = left
     /// 1 = right
     /// 2 = middel
     /// 3 = forward
     /// 4 = back
     /// </summary>
     /// <param name="index"></param>
     /// <returns></returns>
    public static bool GhostClickAtPosition(int index, Vector2 pos)
    {
        
        if (index == 0)
        {
            Debug.Log("Mouse");
            Mouse.current.WarpCursorPosition(pos);
            _mouse.leftButton.QueueValueChange<float>(1); 
           
            if (_mouse.leftButton.isPressed) return true;
        }
        else if (index == 1)
        {
            _mouse.WarpCursorPosition(pos);
            _mouse.rightButton.QueueValueChange<float>(1);
            if (_mouse.rightButton.isPressed) return true;
        }
        else if (index == 2)
        {
            _mouse.WarpCursorPosition(pos);
            _mouse.middleButton.QueueValueChange<float>(1);
            if (_mouse.middleButton.isPressed) return true;
        }
        else if (index == 3)
        {
            _mouse.WarpCursorPosition(pos);
            _mouse.forwardButton.QueueValueChange<float>(1);
            if (_mouse.forwardButton.isPressed) return true;

        }
        else if (index == 4)
        {
            _mouse.WarpCursorPosition(pos);
            _mouse.backButton.QueueValueChange<float>(1);
            if (_mouse.backButton.isPressed) return true;

        }
        return false;
    }
    
    public static bool isMouseEnter(GameObject g)
    {
        if(g == enterbuff && !enter)
        {
            enter = true;
            lastbuff = g;
            return true;
        }
        return false;
    }

    public static bool isMouseExit(GameObject g)
    {
        if(g == lastbuff && enterbuff != g && enter)
        {
            enter = false;
            return true;
        }
        return false;
    }

    public static bool isMouseOver(GameObject g)
    {

        if (g == enterbuff) return true;
        return false;
    }

    #region
    public static bool A_ButtonDown(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = A_Down;
            A_Down = false;
            return buff;
        }
        else return false;
    }
    public static bool A_ButtonUp(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = A_up;
            A_up = false;
            return buff;
        }
        else return false;
    }
    public static bool A_ButtonPressed(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return A_Pressed;
        else return false;
    }
    public static bool X_ButtonDown(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = X_Down;
            X_Down = false;
            return buff;
        }
        else return false;
    }
    public static bool X_ButtonUp(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = X_up;
            X_up = false;
            return buff;
        }
        else return false;
    }
    public static bool X_ButtonPressed(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return X_Pressed;
        else return false;
    }
    public static bool B_ButtonDown(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = B_Down;
            B_Down = false;
            return buff;
        }
        else return false;
    }
    public static bool B_ButtonUp(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = B_up;
            B_up = false;
            return buff;
        }
        else return false;
    }
    public static bool B_ButtonPressed(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return B_Pressed;
        else return false;
    }
    public static bool Y_ButtonDown(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = Y_Down;
            Y_Down = false;
            return buff;
        }
        else return false;
    }
    public static bool Y_ButtonUp(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = Y_up;
            Y_up = false;
            return buff;
        }
        else return false;
    }
    public static bool Y_ButtonPressed(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return Y_Pressed;
        else return false;
    }
    public static bool RB_ButtonDown(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = RB_Down;
            RB_Down = false;
            return buff;
        }
        else return false;
    }
    public static bool RB_ButtonUp(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = RB_up;
            RB_up = false;
            return buff;
        }
        else return false;
    }
    public static bool RB_ButtonPressed(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return RB_Pressed;
        else return false;
    }
    public static bool LB_ButtonDown(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = LB_Down;
            LB_Down = false;
            return buff;
        }
        else return false;
    }
    public static bool LB_ButtonUp(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = LB_up;
            LB_up = false;
            return buff;
        }
        else return false;
    }
    public static bool LB_ButtonPressed(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return LB_Pressed;
        else return false;
    }
    public static bool LT_ButtonDown(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = LT_Down;
            LT_Down = false;
            return buff;
        }
        else return false;
    }
    public static bool LT_ButtonUp(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = LT_up;
            LT_up = false;
            return buff;
        }
        else return false;
    }
    public static bool LT_ButtonPressed(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return LT_Pressed;
        else return false;
    }
    public static bool RT_ButtonDown(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = RT_Down;
            RT_Down = false;
            return buff;
        }
        else return false;
    }
    public static bool RT_ButtonUp(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = RT_up;
            RT_up = false;
            return buff;
        }
        else return false;
    }
    public static bool RT_ButtonPressed(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return RT_Pressed;
        else return false;
    }
    public static bool R3_ButtonDown(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = R3_Down;
            R3_Down = false;
            return buff;
        }
        else return false;
    }
    public static bool R3_ButtonUp(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = R3_up;
            R3_up = false;
            return buff;
        }
        else return false;
    }
    public static bool R3_ButtonPressed(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return R3_Pressed;
        else return false;
    }
    public static bool L3_ButtonDown(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = L3_Down;
            L3_Down = false;
            return buff;
        }
        else return false;
    }
    public static bool L3_ButtonUp(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = L3_up;
            L3_up = false;
            return buff;
        }
        else return false;
    }
    public static bool L3_ButtonPressed(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return L3_Pressed;
        else return false;
    }
    public static bool Select_ButtonDown(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = select_Down;
            select_Down = false;
            return buff;
        }
        else return false;
    }
    public static bool Select_ButtonUp(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = select_up;
            select_up = false;
            return buff;
        }
        else return false;
    }
    public static bool Select_ButtonPressed(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return select_Pressed;
        else return false;
    }
    public static bool Start_ButtonDown(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = start_Down;
            start_Down = false;
            return buff;
        }
        else return false;
    }
    public static bool Start_ButtonUp(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = start_up;
            start_up = false;
            return buff;
        }
        else return false;
    }
    public static bool Start_ButtonPressed(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return start_Pressed;
        else return false;
    }
    public static float LT_RawValue(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return LT_trigger;
        else return 0;
    }
    public static float RT_RawValue(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return RT_trigger;
        else return 0;
    }
    public static float LT_Value(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return Mathf.Round(LT_trigger * 100f) / 100f;
        else return 0;
    }
    public static float RT_Value(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return Mathf.Round(RT_trigger * 100f) / 100f;
        else return 0;
    }
    public static float LT_RoundValue(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return Mathf.Round(LT_trigger * 10f) / 10f;
        else return 0;
    }
    public static float RT_RoundValue(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return Mathf.Round(RT_trigger * 10f) / 10f;
        else return 0;
    }
    public static Vector2 RightStick(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return RS;
        else return Vector2.zero;
    }
    public static Vector2 RightStick(int index, Vector2 minInput)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            var x = Mathf.Abs(RS.x);
            var y = Mathf.Abs(RS.y);
            if(x >= minInput.x && y >= minInput.y)return RS;
        }
        
        return Vector2.zero;
    }
    public static Vector2 LeftStick(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return LS;
        else return Vector2.zero;
    }
    public static Vector2 LeftStick(int index, Vector2 minInput)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            var x = Mathf.Abs(LS.x);
            var y = Mathf.Abs(LS.y);
            if (x >= minInput.x && y >= minInput.y) return LS;
        }
        return Vector2.zero;
    }
    public static float RawXRight(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return RS.x;
        else return 0;
    }
    public static float RawYRight(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return RS.y;
        else return 0;
    }
    public static float RoundXRight(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return Mathf.Round(RS.x * 10f) / 10f;
        else return 0;
    }
    public static float RoundYRight(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return Mathf.Round(RS.y * 10f) / 10f;
        else return 0;
    }
    public static float XRight(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return Mathf.Round(RS.x * 100f) / 100f;
        else return 0;
    }
    public static float YRight(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return Mathf.Round(RS.y * 100f) / 100f;
        else return 0;
    }
    public static float RawXLeft(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
            return LS.x;
        else
            return 0;
    }
    public static float RawYLeft(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return LS.y;
        else return 0;
    }
    public static float RoundXLeft(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return Mathf.Round(LS.x * 10f) / 10f;
        else return 0;
    }
    public static float RoundYLeft(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return Mathf.Round(LS.y * 10f) / 10f;
        else return 0;
    }
    public static float XLeft(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return Mathf.Round(LS.x * 100f) / 100f;
        else return 0;
    }
    public static float YLeft(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return Mathf.Round(LS.y * 100f) / 100f;
        else return 0;
    }
    public static Vector2 Arrows(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return arrows;
        else return Vector2.zero;
    }
    public static bool Up_ButtonDown(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = Up_Down;
            Up_Down = false;
            return buff;
        }
        else return false;
    }
    public static bool Up_ButtonUp(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = Up_up;
            Up_up = false;
            return buff;
        }
        else return false;
    }
    public static bool Up_ButtonPressed(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return Up_Pressed;
        else return false;
    }
    public static bool Down_ButtonDown(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = Down_Down;
            Down_Down = false;
            return buff;
        }
        else return false;
    }
    public static bool Down_ButtonUp(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = Down_up;
            Down_up = false;
            return buff;
        }
        else return false;
    }
    public static bool Down_ButtonPressed(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return Down_Pressed;
        else return false;
    }
    public static bool Right_ButtonDown(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = right_Down;
            right_Down = false;
            return buff;
        }
        else return false;
    }
    public static bool Right_ButtonUp(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = right_up;
            right_up = false;
            return buff;
        }
        else return false;
    }
    public static bool Right_ButtonPressed(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return right_Pressed;
        else return false;
    }
    public static bool Left_ButtonDown(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = left_Down;
            left_Down = false;
            return buff;
        }
        else return false;
    }
    public static bool Left_ButtonUp(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1])
        {
            bool buff = left_up;
            left_up = false;
            return buff;
        }
        else return false;
    }
    public static bool Left_ButtonPressed(int index)
    {
        if (Gamepad.current == Gamepad.all[index - 1]) return left_Pressed;
        else return false;
    }

    #endregion

    #region
    /// <summary>
    /// Is mouse button pressed
    /// </summary>
    /// <param name="index">0 = left | 1 = right | 2 = middel</param>
    /// <returns></returns>
    public static bool isMouse(int index)
    {
        switch (index)
        {
            case 0:
                return isMouseLeft;
            case 1:
                return isMouseRight;
            case 2:
                return isMouseMiddel;
            default:
                return false;
        }
    }
    /// <summary>
    /// is mouse button down
    /// </summary>
    /// <param name="index">0 = left | 1 = right | 2 = middel</param>
    /// <returns></returns>
    public static bool isMouseDown(int index)
    {
        bool i = false;
        switch (index)
        {
            case 0:
                i = MouseLeft_Down;
                MouseLeft_Down = false;
                return i;
            case 1:
                i = MouseRight_Down;
                MouseRight_Down = false;
                return i;
            case 2:
                i = MouseMiddel_Down;
                MouseMiddel_Down = false;
                return i;
            default:
                return i;
        }

    }
    /// <summary>
    /// is mouse button up
    /// </summary>
    /// <param name="index">0 = left | 1 = right | 2 = middel</param>
    /// <returns></returns>
    public static bool isMouseUp(int index)
    {
        bool i = false;
        switch (index)
        {
            case 0:
                i = MouseLeft_Up;
                MouseLeft_Up = false;
                return i;
            case 1:
                i = MouseRight_Up;
                MouseRight_Up = false;
                return i;
            case 2:
                i = MouseMiddel_Up;
                MouseMiddel_Up = false;
                return i;
            default:
                return i;
        }
    }

    public static Vector2 MousePosition()
    {
        return Mouse_Position;
    }
    public static Vector2 MouseDelta()
    {
        return Mouse_Delta;
    }
    
    /// <summary>
    /// return the horzontal delta 
    /// </summary>
    /// <returns></returns>
    public static float Mouse_X()
    {
        return Mouse_Delta.x;
    }

    /// <summary>
    /// return the vertical delta
    /// </summary>
    /// <returns></returns>
    public static float Mouse_Y()
    {
        return Mouse_Delta.y;
    }

    /// <summary>
    /// Return the Mouse Wheel value
    /// </summary>
    /// <returns></returns>
    public static float MouseWheel()
    {
        return Mouse_Wheel;
    }
    /// <summary>
    /// Return the Mouse wheel value as negativ or positiv 
    ///   -1 || 1 
    /// down || up
    /// </summary>
    /// <returns></returns>
    public static float MouseWheelOneValue()
    {
        if (Mouse_Wheel > 0) return 1;
        else if (Mouse_Wheel < 0) return -1;
        else return 0;
    }

  
   public static void setMousePosition(Vector2 pos)
   {
        _mouse.WarpCursorPosition(pos);
   }

    private static float T;

    /// <summary>
    /// is Mouse dopple clicket in time of clickSpeed defalte value is 0.5f
    /// </summary>
    /// <param name="clickSpeed"></param>
    /// <returns></returns>
    public static bool MouseDoppleClick(float clickSpeed = .5f)
    {
        T += Time.deltaTime;
        if (T >= clickSpeed)
        {
            T = 0;
            clicks = 0;
            return false;
        }
        if (clicks >= 2)
        {
            T = 0;
            clicks = 0;
            return true;
        }

        return false;
    }
    /// <summary>
    /// check for Keyboard key
    /// </summary>
    /// <param name="key">UnityEngine.InputSystem.Key.W</param>
    /// <returns></returns>
    public static bool isKey(Key key)
    {
        if (aKey != null)
        {
            foreach (KeyControl k in aKey.allKeys)
            {
                 if(k.isPressed)if (k.keyCode == key) return true;
            }
        }
        return false;
    }

    /// <summary>
    /// check for key by his name as string
    /// </summary>
    /// <param name="key">"name" z.b "w" </param>
    /// <returns></returns>
    public static bool isKey(string key)
    {
        if (aKey != null)
        {
            foreach (KeyControl k in aKey.allKeys)
            {
                if (k.isPressed) if (k.shortDisplayName == key.ToUpper() || k.displayName == key.ToUpper()) return true;
            }
        }
        return false;
    }
 
    /// <summary>
    /// check for Keyboard key is down
    /// </summary>
    /// <param name="key">UnityEngine.InputSystem.Key.W</param>
    /// <returns></returns>
    public static bool isKeyDown(Key key)
    {
        if (aKey != null)
        {
            foreach (KeyControl k in aKey.allKeys)
            {
                 if (k.wasPressedThisFrame && k.keyCode == key)
                    if (kdown)
                        {
                            kdown = false;
                            Debug.Log("down");
                            return true;
                        }
            }
        }
        return false;
    }

    /// <summary>
    /// check for Keyboard key is down by his name as sting
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public static bool isKeyDown(string key)
    {
        if (aKey != null)
        {
            foreach (KeyControl k in aKey.allKeys)
            {
                if (k.wasPressedThisFrame)
                {
                    try
                    {

                    
                        if (k.shortDisplayName == key.ToUpper() || k.displayName == key.ToUpper())

                            if (kdown)
                            {
                                kdown = false;
                                return true;
                            }
                    }
                    catch (System.NullReferenceException e)
                    {
                        Debug.Log(e.StackTrace);

                    }
                }
            }
        }
        return false;
    }
    /// <summary>
    /// check for Keyboard key is Up
    /// </summary>
    /// <param name="key">UnityEngine.InputSystem.Key.W</param>
    /// <returns></returns>
    public static bool isKeyUp(Key key)
    {
        if (aKey != null)
        {
            foreach (KeyControl k in aKey.allKeys)
            {
                if (k.wasPressedThisFrame) if (k.keyCode == key) if (kup)
                        {
                            kup = false;
                            return true;
                        }
            }
        }
        return false;
    }
    /// <summary>
    /// check for Keyboard key is Up by his name as string
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public static bool isKeyUp(string key)
    {
        if (aKey != null)
        {
            foreach (KeyControl k in aKey.allKeys)
            {
                if (k.wasPressedThisFrame) if (k.shortDisplayName.ToUpper() == key.ToUpper() || k.displayName == key.ToUpper()) if (kup)
                        {
                            kup = false;
                            return true;
                        }
            }
        }
        return false;
    }
    /// <summary>
    /// Get displayed name of key
    /// </summary>
    /// <returns></returns>
    public static string getKeyboard()
    {
        if (aKey != null)
        {
            foreach (KeyControl k in aKey.allKeys)
            {
                if (k.wasPressedThisFrame) return k.displayName;
            }
        }
        return "null";
    }
#endregion
    public static  IEnumerator update()
    {
        Debug.Log("EZ-Input Debug update running");
        while (Application.isPlaying)
        {
            Update(); 
            if (controllerCursor) contCurs();
            yield return new WaitForEndOfFrame();
            if (controllerCursor) contCurs();
        }

        yield return null;
    }

    static bool tapOut;
    static void contCurs()
    {
        if (isKeyDown(e.escape)) tapOut = true;
        if (tapOut && A_ButtonDown(controllerCursorControllerIndex)) tapOut = false;

        if (!tapOut)
        {
            setMousePosition(Mouse_Position + (LeftStick(controllerCursorControllerIndex) * (controllerCursorMoveSpeed * 10)) * Time.deltaTime);

            if (A_ButtonDown(controllerCursorControllerIndex)) GhostClick(0);
            if (B_ButtonDown(controllerCursorControllerIndex)) GhostClick(1);
            if (Y_ButtonDown(controllerCursorControllerIndex)) GhostClick(2);
        }
        
    }

    static void Update()
    {

        

        if (DebugMouse)
        {

            if (dl && isMouseDown(0)) Debug.Log("left Down");
            if (dr && isMouseDown(1)) Debug.Log("right Down");
            if (dm && isMouseDown(2)) Debug.Log("middel Down");

            if (dl && isMouse(0)) Debug.Log("leftPressed");
            if (dr && isMouse(1)) Debug.Log("rightPressed");
            if (dm && isMouse(2)) Debug.Log("middelPressed");

            if (dl && isMouseUp(0)) Debug.Log("left Up");
            if (dr && isMouseUp(1)) Debug.Log("right Up");
            if (dm && isMouseUp(2)) Debug.Log("middel Up");

            if (db && MouseBack) Debug.Log("MouseBack");
            if (df && MouseForward) Debug.Log("MouseForward");   
            
            if (DebugPosition)
            {
                Debug.Log("Mouse X = " + MousePosition().x + "  Mouse Y = " + MousePosition().y);
            }

            if (DebugDelta)
            {
                Debug.Log("Mouse Delta X = " + MouseDelta().x + "  Mouse Delta Y = " + MouseDelta().y);
            }

            
            if(MouseWheel() != 0)Debug.Log("Wheel Value" + MouseWheel());
        }

        if (DebugKeyboard)
        {
            Debug.Log("Key = " + getKeyboard());


            if (isKey(debugKey)) Debug.Log(debugKey +" gedr??ckt");
            if (isKeyDown(debugKey)) Debug.Log(debugKey + " Down");
            if (isKeyUp(debugKey)) Debug.Log(debugKey + " Up");


        }
    }



}

#if UNITY_EDITOR
[CustomEditor(typeof(EZMONO))]
public class customInspecterEZ : Editor
{
    Texture2D icon,back,yt;
    Rect r;
    int mul = 1;

    public override void OnInspectorGUI()
    {
        if (icon == null)
        {
            icon = AssetDatabase.LoadAssetAtPath("Assets/EZ-Inputs/Textures/icon.png", typeof(Texture2D)) as Texture2D;
            back = AssetDatabase.LoadAssetAtPath("Assets/EZ-Inputs/Textures/Back.png", typeof(Texture2D)) as Texture2D;
            yt = AssetDatabase.LoadAssetAtPath("Assets/EZ-Inputs/Textures/YT.png", typeof(Texture2D)) as Texture2D;

        }

        var gs = new GUIStyle(GUI.skin.button);
        gs.richText = true;
        gs.fontStyle = FontStyle.Bold;

        r = EditorGUILayout.BeginVertical();
        r.xMin = 0;
        GUI.DrawTexture(r, back);
        GUI.DrawTexture(new Rect(0, 0, 250, EditorGUIUtility.singleLineHeight * 6), icon);

        EditorStyles.label.richText = true;
        EditorStyles.label.fontStyle = FontStyle.Bold;
        EditorStyles.linkLabel.richText = true;
        EditorStyles.linkLabel.fontStyle = FontStyle.Bold;
        
        if (EZ.DebugKeyboard && EZ.DebugMouse) mul = 5;
        else if (EZ.DebugMouse) mul = 4;
        else if (EZ.DebugKeyboard) mul = 1;
        else mul = 0;

        EditorGUI.DrawRect(new Rect(5, 5, 200, EditorGUIUtility.singleLineHeight * (3 + mul)), new Color(1, 1, 1, 0.5f));

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField(EZ.DebugMouse ? "<color=Black> Debug Mouse Inputs</color>" : "<color=grey> Debug Mouse Inputs<///lor>");
        if (GUILayout.Button(EZ.DebugMouse ? "<color=lime>Its Active</color>" : "Not Active", gs))
        {
           EZ.DebugMouse = !EZ.DebugMouse;
           EZ.DebugPosition = false;
           EZ.DebugDelta = false;
        }
        EditorGUILayout.EndHorizontal();

        if (EZ.DebugMouse)
        {
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField(EZ.DebugPosition ? "<color=Black> Debug Mouse Position</color>" : "<color=grey> Debug Mouse Position</color>");
            if (GUILayout.Button(EZ.DebugPosition ? "<color=lime>ON</color>" : "OFF", gs))
            {
                EZ.DebugPosition = !EZ.DebugPosition;
            }
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField(EZ.DebugDelta ? "<color=Black> Debug Mouse Delta</color>" : "<color=grey> Debug Mouse Delta</color>");
            if (GUILayout.Button(EZ.DebugDelta ? "<color=lime>ON</color>" : "OFF",gs))
            {
                EZ.DebugDelta = !EZ.DebugDelta;
            }
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.BeginHorizontal();
            
           
            if (GUILayout.Button(EZ.dl ? "<color=lime>Left</color>" : "Left", gs))
            {
                EZ.dl = !EZ.dl;
            }
            if (GUILayout.Button(EZ.dm ? "<color=lime>Middel</color>" : "Middel", gs))
            {
                EZ.dm = !EZ.dm;
            }
            if (GUILayout.Button(EZ.dr ? "<color=lime>Right</color>" : "Right", gs))
            {
                EZ.dr = !EZ.dr;
            }

            EditorGUILayout.EndHorizontal();
            EditorGUILayout.BeginHorizontal();

            if (GUILayout.Button(EZ.df ? "<color=lime>Forward</color>" : "Forward", gs))
            {
                EZ.df = !EZ.df;
            }
            if (GUILayout.Button(EZ.db ? "<color=lime>Back</color>" : "Back", gs))
            {
                EZ.db = !EZ.db;
            }
            EditorGUILayout.EndHorizontal();
        }

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField(EZ.DebugKeyboard ? "<color=black> Debug Keyboard Inputs</color>" : "<color=grey> Debug Keyborad Inputs</color>");
        if (GUILayout.Button(EZ.DebugKeyboard ? "<color=lime>Its Active</color>" : "Not Active",gs))
        {
            EZ.DebugKeyboard = !EZ.DebugKeyboard;
            EZ.debugKey = Key.None;
        }
        EditorGUILayout.EndHorizontal();

        if (EZ.DebugKeyboard)
        {
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("<color=black> Debug Key </color>");
            EZ.debugKey = (Key)EditorGUILayout.EnumPopup(EZ.debugKey);
            EditorGUILayout.EndHorizontal();

        }
        

        GUIStyle cs = new GUIStyle();
        cs.padding.left = 0;
        cs.padding.right = 0;
        cs.padding.top = 0;
        cs.padding.bottom = 0;
        
        if (GUI.Button(new Rect(5, (EditorGUIUtility.singleLineHeight * (4 + mul)), 25, 25), yt,cs)) Application.OpenURL("https:////ww.youtube.com/AzeS_YT");
        if (EditorGUI.LinkButton(new Rect(30, (EditorGUIUtility.singleLineHeight * (4 + mul)), 100, 25),"<color=black>AzeS</olor> //color=red>Youtube</color>")) Application.OpenURL("https://www.youtube.com/AzeS_YT");


        GUILayout.Space(60);
        EditorGUILayout.EndVertical();
        r = new Rect(0, 0, EditorGUIUtility.currentViewWidth, r.height +20);

        // DrawDefaultInspector();
    }

}
[InitializeOnLoad]
class MyHierarchyIcons 
{
    static Texture2D texturePanel;
    static Vector2 offset = new Vector2(25, 0);

    static MyHierarchyIcons()
    {
        
        texturePanel = AssetDatabase.LoadAssetAtPath("Assets/EZ-Inputs/Textures/icon.png", typeof(Texture2D)) as Texture2D;
        EditorApplication.hierarchyWindowItemOnGUI += HierarchyItemCB;
    }

    static void HierarchyItemCB(int instanceID, Rect selectionRect)
    {
       
        Rect r = new Rect(selectionRect);
        r.x =  53;
        r.y = r.y - 7;
        r.width = 30;
        r.height = 30;

        GameObject go = EditorUtility.InstanceIDToObject(instanceID) as GameObject;
        Color32 fontColor = new Color32(0, 155, 255, 255);


        if (go != null)
        {
            if (go.GetComponent<EZMONO>() != null)
            {
                EditorGUI.DrawRect(selectionRect, new Color32(56, 56, 56, 255)); 
                
                if (Selection.instanceIDs.Contains(instanceID))
                {
                    fontColor = Color.white;
                    EditorGUI.DrawRect(selectionRect, new Color(0.24f, 0.48f, 0.90f, 0.5f));
                }else EditorGUI.DrawRect(selectionRect, new Color32(56, 56, 56, 255));


                EditorGUIUtility.SetIconForObject(go, texturePanel);
                EditorGUI.LabelField(new Rect(selectionRect.position + offset, selectionRect.size), go.name, new GUIStyle()
                {
                    normal = new GUIStyleState() { textColor = fontColor},
                    fontStyle = FontStyle.BoldAndItalic
                }
                );

                GUI.Label(r, texturePanel);
            }
        }
    }
}

#endif