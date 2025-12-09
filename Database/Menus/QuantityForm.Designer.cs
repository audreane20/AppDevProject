using System.Windows.Forms;

namespace Menus
{
    partial class QuantityForm
    {
        private System.ComponentModel.IContainer components = null;
        private NumericUpDown EditValue;
        private Button btnOK;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuantityForm));
            this.EditValue = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EditValue)).BeginInit();
            this.SuspendLayout();
            // 
            // EditValue
            // 
            resources.ApplyResources(this.EditValue, "EditValue");
            this.EditValue.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.EditValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EditValue.Name = "EditValue";
            this.EditValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // QuantityForm
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(187)))), ((int)(((byte)(129)))));
            this.Controls.Add(this.EditValue);
            this.Controls.Add(this.btnOK);
            this.Name = "QuantityForm";
            ((System.ComponentModel.ISupportInitialize)(this.EditValue)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
