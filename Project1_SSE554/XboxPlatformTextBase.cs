using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_SSE554
{
    public partial class XboxPlatformTextBase : Form
    {
        public XboxPlatformTextBase()
        {
            InitializeComponent();
        }
    }

    public interface controls
    {
        string home();
        string x();
        string y();
        string a();
        string b();
        string lt();
        string rt();
        string leftD();
        string rightD();
        string upD();
        string downD();
    }

    public class XboxOneControllerLayout : controls
    {
        public string home()
        {
            return "Do you want to turn off the Xbox or restart the game?";
        }

        public string x()
        {
            return "Attack Left";
        }

        public string y()
        {
            return "Attack Up";
        }

        public string a()
        {
            return "Attack Down";
        }

        public string b()
        {
            return "Attack Right";
        }

        public string lt()
        {
            return "Use Item";
        }

        public string rt()
        {
            return "Use Super";
        }

        public string leftD()
        {
            return "Moved Left";
        }

        public string rightD()
        {
            return "Moved Right";
        }

        public string upD()
        {
            return "Moved Up";
        }

        public string downD()
        {
            return "Moved Down";
        }
    }

    public interface buttonPress
    {
        string press();
    }

    #region Command classes
    public class pressHome: buttonPress
    {
        controls hButton;

        public pressHome(controls newHButton)
        {
            hButton = newHButton;
        }

        public string press()
        {
            return hButton.home();
        }
    }

    public class pressX : buttonPress
    {
        controls xButton;

        public pressX(controls newHButton)
        {
            xButton = newHButton;
        }

        public string press()
        {
            return xButton.x();
        }
    }

    public class pressY : buttonPress
    {
        controls yButton;

        public pressY(controls newYButton)
        {
            yButton = newYButton;
        }

        public string press()
        {
            return yButton.y();
        }
    }

    public class pressA : buttonPress
    {
        controls aButton;

        public pressA(controls newHButton)
        {
            aButton = newHButton;
        }

        public string press()
        {
            return aButton.a();
        }
    }

    public class pressB : buttonPress
    {
        controls bButton;

        public pressB(controls newBButton)
        {
            bButton = newBButton;
        }

        public string press()
        {
            return bButton.b();
        }
    }

    public class pressLT : buttonPress
    {
        controls ltButton;

        public pressLT(controls newLTButton)
        {
            ltButton = newLTButton;
        }

        public string press()
        {
            return ltButton.lt();
        }
    }

    public class pressRT : buttonPress
    {
        controls rtButton;

        public pressRT(controls newRTButton)
        {
            rtButton = newRTButton;
        }

        public string press()
        {
            return rtButton.rt();
        }
    }

    public class pressLeftD : buttonPress
    {
        controls leftDButton;

        public pressLeftD(controls newLeftDButton)
        {
            leftDButton = newLeftDButton;
        }

        public string press()
        {
            return leftDButton.leftD();
        }
    }

    public class pressRightD : buttonPress
    {
        controls rightDButton;

        public pressRightD(controls newRightDButton)
        {
            rightDButton = newRightDButton;
        }

        public string press()
        {
            return rightDButton.rightD();
        }
    }

    public class pressUpD : buttonPress
    {
        controls upDButton;

        public pressUpD(controls newupDButton)
        {
            upDButton = newupDButton;
        }

        public string press()
        {
            return upDButton.upD();
        }
    }

    public class pressDownD : buttonPress
    {
        controls downDButton;

        public pressDownD(controls newDownDButton)
        {
            downDButton = newDownDButton;
        }

        public string press()
        {
            return downDButton.downD();
        }
    }

    #endregion

    public class XboxButton
    {
        buttonPress controlsPressed;
        public XboxButton(buttonPress newControlsPressed)
        {
            controlsPressed = newControlsPressed;
        }

        public string press()
        {
            return controlsPressed.press();
        }
    }

    public class getcontrollerLayoutXbox
    {
        public static controls getButton()
        {
            return new XboxOneControllerLayout();
        }
    }
}
