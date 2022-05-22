
namespace PrvníOkenníAplikace
{
    partial class Form
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
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnDef = new System.Windows.Forms.Button();
            this.btnRnd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btnEnd.Location = new System.Drawing.Point(18, 364);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(764, 71);
            this.btnEnd.TabIndex = 0;
            this.btnEnd.Text = "Konec";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnDef
            // 
            this.btnDef.BackColor = System.Drawing.Color.SlateBlue;
            this.btnDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btnDef.Location = new System.Drawing.Point(18, 168);
            this.btnDef.Name = "btnDef";
            this.btnDef.Size = new System.Drawing.Size(764, 113);
            this.btnDef.TabIndex = 1;
            this.btnDef.Text = "Default";
            this.btnDef.UseVisualStyleBackColor = false;
            this.btnDef.Click += new System.EventHandler(this.btnDef_Click);
            // 
            // btnRnd
            // 
            this.btnRnd.BackColor = System.Drawing.Color.Lime;
            this.btnRnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRnd.Location = new System.Drawing.Point(18, 50);
            this.btnRnd.Name = "btnRnd";
            this.btnRnd.Size = new System.Drawing.Size(764, 112);
            this.btnRnd.TabIndex = 2;
            this.btnRnd.Text = "Random";
            this.btnRnd.UseVisualStyleBackColor = false;
            this.btnRnd.Click += new System.EventHandler(this.btnRnd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dalibor Trampota";
            // 
            // Form
            // 
            this.AcceptButton = this.btnRnd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnEnd;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRnd);
            this.Controls.Add(this.btnDef);
            this.Controls.Add(this.btnEnd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikace";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnDef;
        private System.Windows.Forms.Button btnRnd;
        private System.Windows.Forms.Label label1;
    }
}

