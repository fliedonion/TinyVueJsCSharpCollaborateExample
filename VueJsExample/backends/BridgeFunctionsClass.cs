using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VueJsExample.backends {
    [ComVisible(true)]
    public class BridgeFunctionsClass {
        public void CsMessageBox(string value) {
            MessageBox.Show(value, "I'm C# MessageBox!", MessageBoxButtons.OK);
        }
    }
}
