using TP.WinForms.Libary;

namespace TestEnvirement;

public partial class Form1 : Form {
    public Form1() {
        InitializeComponent();

        Task.Run(async () => {
            while (true) {
                await Task.Delay(1000);
            }
        });
    }

    private void testBtn_Click(object sender, EventArgs e) {
        var consoleDisplay = new ConsoleDisplay();
        consoleDisplay.Show();

        Task.Run(async () => {
            while (true) {
                await Task.Delay(1000);
                if (consoleDisplay.InvokeRequired) {
                    consoleDisplay.Invoke(new Action(() => consoleDisplay.WriteLine("Hello World")));
                } else {
                    consoleDisplay.WriteLine("Hello World");
                }
            }
        });
    }
}
