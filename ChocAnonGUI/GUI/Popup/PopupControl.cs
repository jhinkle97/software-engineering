using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocAnonGUI.GUI.Operator;
using ChocAnonGUI.GUI.Popup;


namespace ChocAnonGUI
{
    
    public class PopupControl
    {
        public static void printError(string value)
        {
            ErrorForm launchError = new ErrorForm(value);
            launchError.ShowDialog();
        }
        public static void printSuccess(string value)
        {
            SuccessForm launchSuccess = new SuccessForm(value);
            launchSuccess.ShowDialog();
        }
    }
}
