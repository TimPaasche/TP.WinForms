namespace TP.WinForms.Libary;

partial class ConsoleDisplay {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        displayContent = new RichTextBox();
        SuspendLayout();
        // 
        // displayContent
        // 
        displayContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        displayContent.BackColor = Color.FromArgb(64, 64, 64);
        displayContent.BorderStyle = BorderStyle.None;
        displayContent.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        displayContent.ForeColor = SystemColors.Window;
        displayContent.Location = new Point(12, 12);
        displayContent.Name = "displayContent";
        displayContent.ReadOnly = true;
        displayContent.Size = new Size(776, 426);
        displayContent.TabIndex = 1;
        displayContent.Text = "";
        // 
        // ConsoleDisplay
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(64, 64, 64);
        ClientSize = new Size(800, 450);
        Controls.Add(displayContent);
        Name = "ConsoleDisplay";
        Text = "ConsoleDisplay";
        ResumeLayout(false);
    }

    #endregion

    private RichTextBox displayContent;
}