using System.Windows.Forms;

namespace System
{
    internal class KeyPressEventHandler
    {
        private Action<object, KeyPressEventArgs> intTextBox_KeyPress;

        public KeyPressEventHandler(Action<object, KeyPressEventArgs> intTextBox_KeyPress)
        {
            this.intTextBox_KeyPress = intTextBox_KeyPress;
        }
    }
}