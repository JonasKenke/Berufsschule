namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxKunden;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.Button buttonAddKunde;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxKunden = new System.Windows.Forms.ListBox();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.buttonAddKunde = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.listBoxKunden.FormattingEnabled = true;
            this.listBoxKunden.Location = new System.Drawing.Point(13, 13);
            this.listBoxKunden.Name = "listBoxKunden";
            this.listBoxKunden.Size = new System.Drawing.Size(259, 186);
            this.listBoxKunden.TabIndex = 0;

            this.textBoxVorname.Location = new System.Drawing.Point(13, 206);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(100, 20);
            this.textBoxVorname.TabIndex = 1;

            this.textBoxNachname.Location = new System.Drawing.Point(13, 233);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(100, 20);
            this.textBoxNachname.TabIndex = 2;

            this.buttonAddKunde.Location = new System.Drawing.Point(13, 260);
            this.buttonAddKunde.Name = "buttonAddKunde";
            this.buttonAddKunde.Size = new System.Drawing.Size(75, 23);
            this.buttonAddKunde.TabIndex = 3;
            this.buttonAddKunde.Text = "Add Kunde";
            this.buttonAddKunde.UseVisualStyleBackColor = true;
            this.buttonAddKunde.Click += new System.EventHandler(this.buttonAddKunde_Click);

            this.ClientSize = new System.Drawing.Size(284, 294);
            this.Controls.Add(this.buttonAddKunde);
            this.Controls.Add(this.textBoxNachname);
            this.Controls.Add(this.textBoxVorname);
            this.Controls.Add(this.listBoxKunden);
            this.Name = "Form1";
            this.Text = "Kundenverwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
