
namespace Calculator {
    partial class Form1 {
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
            this.lbDisplay = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbEquation = new System.Windows.Forms.Label();
            this.sqrt = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.powerOfN = new System.Windows.Forms.Button();
            this.leftParent = new System.Windows.Forms.Button();
            this.rightParent = new System.Windows.Forms.Button();
            this.ac = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.ans = new System.Windows.Forms.Button();
            this.PI = new System.Windows.Forms.Button();
            this.comma = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDisplay
            // 
            this.lbDisplay.BackColor = System.Drawing.Color.DimGray;
            this.lbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDisplay.Location = new System.Drawing.Point(6, 6);
            this.lbDisplay.Margin = new System.Windows.Forms.Padding(3);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(510, 61);
            this.lbDisplay.TabIndex = 0;
            this.lbDisplay.Text = "0";
            this.lbDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbEquation
            // 
            this.lbEquation.BackColor = System.Drawing.Color.DimGray;
            this.lbEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEquation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbEquation.Location = new System.Drawing.Point(6, 64);
            this.lbEquation.Margin = new System.Windows.Forms.Padding(3);
            this.lbEquation.Name = "lbEquation";
            this.lbEquation.Size = new System.Drawing.Size(510, 32);
            this.lbEquation.TabIndex = 1;
            this.lbEquation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sqrt
            // 
            this.sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrt.Location = new System.Drawing.Point(6, 134);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(98, 80);
            this.sqrt.TabIndex = 2;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.onOperatorClick);
            // 
            // square
            // 
            this.square.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square.Location = new System.Drawing.Point(110, 134);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(96, 80);
            this.square.TabIndex = 3;
            this.square.Text = "x²";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.onOperatorClick);
            // 
            // powerOfN
            // 
            this.powerOfN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerOfN.Location = new System.Drawing.Point(212, 134);
            this.powerOfN.Name = "powerOfN";
            this.powerOfN.Size = new System.Drawing.Size(96, 80);
            this.powerOfN.TabIndex = 4;
            this.powerOfN.Text = "xⁿ";
            this.powerOfN.UseVisualStyleBackColor = true;
            this.powerOfN.Click += new System.EventHandler(this.onOperatorClick);
            // 
            // leftParent
            // 
            this.leftParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftParent.Location = new System.Drawing.Point(314, 134);
            this.leftParent.Name = "leftParent";
            this.leftParent.Size = new System.Drawing.Size(98, 80);
            this.leftParent.TabIndex = 5;
            this.leftParent.Text = "(";
            this.leftParent.UseVisualStyleBackColor = true;
            this.leftParent.Click += new System.EventHandler(this.onOperatorClick);
            // 
            // rightParent
            // 
            this.rightParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightParent.Location = new System.Drawing.Point(418, 134);
            this.rightParent.Name = "rightParent";
            this.rightParent.Size = new System.Drawing.Size(98, 80);
            this.rightParent.TabIndex = 6;
            this.rightParent.Text = ")";
            this.rightParent.UseVisualStyleBackColor = true;
            this.rightParent.Click += new System.EventHandler(this.onOperatorClick);
            // 
            // ac
            // 
            this.ac.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ac.Location = new System.Drawing.Point(418, 220);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(98, 80);
            this.ac.TabIndex = 12;
            this.ac.Text = "AC";
            this.ac.UseVisualStyleBackColor = true;
            this.ac.Click += new System.EventHandler(this.clear);
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(314, 220);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(98, 80);
            this.del.TabIndex = 11;
            this.del.Text = "DEL";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.undo);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(212, 220);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(98, 80);
            this.button10.TabIndex = 10;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.onDigitClick);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(110, 220);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(98, 80);
            this.button11.TabIndex = 9;
            this.button11.Text = "8";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.onDigitClick);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(6, 220);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(98, 80);
            this.button12.TabIndex = 8;
            this.button12.Text = "7";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.onDigitClick);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(418, 306);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(98, 80);
            this.divide.TabIndex = 17;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.onOperatorClick);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(314, 306);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(98, 80);
            this.multiply.TabIndex = 16;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.onOperatorClick);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(212, 306);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(98, 80);
            this.button14.TabIndex = 15;
            this.button14.Text = "6";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.onDigitClick);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(110, 306);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(98, 80);
            this.button15.TabIndex = 14;
            this.button15.Text = "5";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.onDigitClick);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(6, 306);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(98, 80);
            this.button16.TabIndex = 13;
            this.button16.Text = "4";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.onDigitClick);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(418, 392);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(98, 80);
            this.minus.TabIndex = 22;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.onOperatorClick);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(314, 392);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(98, 80);
            this.plus.TabIndex = 21;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.onOperatorClick);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(212, 392);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(98, 80);
            this.button19.TabIndex = 20;
            this.button19.Text = "3";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.onDigitClick);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(110, 392);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(98, 80);
            this.button20.TabIndex = 19;
            this.button20.Text = "2";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.onDigitClick);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(6, 392);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(98, 80);
            this.button21.TabIndex = 18;
            this.button21.Text = "1";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.onDigitClick);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(418, 478);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(98, 80);
            this.equal.TabIndex = 27;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.evaluate);
            // 
            // ans
            // 
            this.ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans.Location = new System.Drawing.Point(314, 478);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(98, 80);
            this.ans.TabIndex = 26;
            this.ans.Text = "ANS";
            this.ans.UseVisualStyleBackColor = true;
            this.ans.Click += new System.EventHandler(this.onDigitClick);
            // 
            // PI
            // 
            this.PI.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PI.Location = new System.Drawing.Point(212, 478);
            this.PI.Name = "PI";
            this.PI.Size = new System.Drawing.Size(98, 80);
            this.PI.TabIndex = 25;
            this.PI.Text = "𝜋";
            this.PI.UseVisualStyleBackColor = true;
            this.PI.Click += new System.EventHandler(this.onDigitClick);
            // 
            // comma
            // 
            this.comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comma.Location = new System.Drawing.Point(110, 478);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(98, 80);
            this.comma.TabIndex = 24;
            this.comma.Text = ".";
            this.comma.UseVisualStyleBackColor = true;
            this.comma.Click += new System.EventHandler(this.onDigitClick);
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(6, 478);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(98, 80);
            this.button26.TabIndex = 23;
            this.button26.Text = "0";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.onDigitClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(845, 673);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.PI);
            this.Controls.Add(this.comma);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.ac);
            this.Controls.Add(this.del);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.rightParent);
            this.Controls.Add(this.leftParent);
            this.Controls.Add(this.powerOfN);
            this.Controls.Add(this.square);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.lbEquation);
            this.Controls.Add(this.lbDisplay);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDisplay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbEquation;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button powerOfN;
        private System.Windows.Forms.Button leftParent;
        private System.Windows.Forms.Button rightParent;
        private System.Windows.Forms.Button ac;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button ans;
        private System.Windows.Forms.Button PI;
        private System.Windows.Forms.Button comma;
        private System.Windows.Forms.Button button26;
    }
}

