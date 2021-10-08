
namespace MasodikForm
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnKilepes = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.tbBevitel = new System.Windows.Forms.TextBox();
      this.btnSzamol = new System.Windows.Forms.Button();
      this.lblEredmeny = new System.Windows.Forms.Label();
      this.lbUzenetek = new System.Windows.Forms.ListBox();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnKilepes
      // 
      this.btnKilepes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnKilepes.Location = new System.Drawing.Point(98, 295);
      this.btnKilepes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnKilepes.Name = "btnKilepes";
      this.btnKilepes.Size = new System.Drawing.Size(188, 52);
      this.btnKilepes.TabIndex = 0;
      this.btnKilepes.Text = "Kilépés";
      this.btnKilepes.UseVisualStyleBackColor = true;
      this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(70, 47);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(186, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "Kérek egy egész számot:";
      // 
      // tbBevitel
      // 
      this.tbBevitel.Location = new System.Drawing.Point(74, 80);
      this.tbBevitel.Name = "tbBevitel";
      this.tbBevitel.Size = new System.Drawing.Size(263, 26);
      this.tbBevitel.TabIndex = 2;
      // 
      // btnSzamol
      // 
      this.btnSzamol.Location = new System.Drawing.Point(98, 204);
      this.btnSzamol.Name = "btnSzamol";
      this.btnSzamol.Size = new System.Drawing.Size(188, 52);
      this.btnSzamol.TabIndex = 3;
      this.btnSzamol.Text = "Számolás";
      this.btnSzamol.UseVisualStyleBackColor = true;
      this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
      // 
      // lblEredmeny
      // 
      this.lblEredmeny.AutoSize = true;
      this.lblEredmeny.Location = new System.Drawing.Point(70, 136);
      this.lblEredmeny.Name = "lblEredmeny";
      this.lblEredmeny.Size = new System.Drawing.Size(51, 20);
      this.lblEredmeny.TabIndex = 4;
      this.lblEredmeny.Text = "label2";
      // 
      // lbUzenetek
      // 
      this.lbUzenetek.FormattingEnabled = true;
      this.lbUzenetek.ItemHeight = 20;
      this.lbUzenetek.Location = new System.Drawing.Point(366, 47);
      this.lbUzenetek.Name = "lbUzenetek";
      this.lbUzenetek.Size = new System.Drawing.Size(268, 304);
      this.lbUzenetek.TabIndex = 5;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(366, 13);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(73, 20);
      this.label2.TabIndex = 6;
      this.label2.Text = "Üzentek:";
      // 
      // Form1
      // 
      this.AcceptButton = this.btnSzamol;
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnKilepes;
      this.ClientSize = new System.Drawing.Size(646, 361);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lbUzenetek);
      this.Controls.Add(this.lblEredmeny);
      this.Controls.Add(this.btnSzamol);
      this.Controls.Add(this.tbBevitel);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnKilepes);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Adatbevitel";
      this.Shown += new System.EventHandler(this.Form1_Shown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnKilepes;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbBevitel;
    private System.Windows.Forms.Button btnSzamol;
    private System.Windows.Forms.Label lblEredmeny;
    private System.Windows.Forms.ListBox lbUzenetek;
    private System.Windows.Forms.Label label2;
  }
}

