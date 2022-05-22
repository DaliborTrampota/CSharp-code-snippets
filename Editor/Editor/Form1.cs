using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Editor {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private bool changed = false;
        private string path = "";

        private bool save(bool saveAs = false, bool changes = true) {
            if (changes) { 
                DialogResult saveRes = MessageBox.Show("Do you want to save the changes?", "Save changes", MessageBoxButtons.YesNoCancel);
                switch (saveRes) {
                    case DialogResult.Yes:
                        break;

                    case DialogResult.No:
                        return true;

                    case DialogResult.Cancel:
                        return false;
                }
            }
            
            if(path.Length == 0 || saveAs) {
                DialogResult res = saveFileDialog1.ShowDialog();
                if(res == DialogResult.OK) {
                    this.path = saveFileDialog1.FileName;
                    using (StreamWriter W = new StreamWriter(this.path)) {
                        W.Write(tb.Text);
                    }
                    this.Text = "Text editor: " + this.path;
                }
            } else {
                using (StreamWriter W = new StreamWriter(this.path)) {
                    W.Write(tb.Text);
                }
                this.Text = "Text editor: " + this.path;
            }
            return true;
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            DialogResult res = openFileDialog1.ShowDialog();
            if(res == DialogResult.OK) {
                this.path = openFileDialog1.FileName;
                using (StreamReader R = new StreamReader(this.path)) {
                    tb.Text = R.ReadToEnd();
                }
                this.Text = "Text editor: " + this.path;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            bool res = this.save(true, false);
            if (!res) return;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            bool res = this.save(false, false);
            if (!res) return;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            if (changed) {
                bool res = this.save();
                if (!res) return;
            }
            tb.Text = "";
            this.path = "";
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e) {
            tb.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e) {
            tb.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
            tb.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) {
            tb.Paste();
        }

        private void wordwrapToolStripMenuItem_Click(object sender, EventArgs e) {
            wordwrapToolStripMenuItem.Checked = !wordwrapToolStripMenuItem.Checked;
            tb.WordWrap = wordwrapToolStripMenuItem.Checked;
        }

        private void gDOToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Made by Dalibor Trampota", "Credits");
        }

        private void tb_TextChanged(object sender, EventArgs e) {
            this.changed = true;
        }

    }
}
