using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP.WinForms.Libary;
public partial class ConsoleDisplay : Form {
    public ConsoleDisplay() {
        InitializeComponent();
    }

    public string Content {
        get {
            return displayContent.Text;
        }
        set {
            displayContent.Text = value;
            displayContent.Refresh();
        }
    }

    public void WriteLine(string text) {
        Content += text + Environment.NewLine;
    }
}
