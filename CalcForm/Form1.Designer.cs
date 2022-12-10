namespace CalcForm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.field1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.field2 = new System.Windows.Forms.TextBox();
            this.operations = new System.Windows.Forms.ComboBox();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // field1
            // 
            this.field1.Location = new System.Drawing.Point(156, 100);
            this.field1.Name = "field1";
            this.field1.Size = new System.Drawing.Size(86, 20);
            this.field1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // field2
            // 
            this.field2.Location = new System.Drawing.Point(363, 99);
            this.field2.Name = "field2";
            this.field2.Size = new System.Drawing.Size(86, 20);
            this.field2.TabIndex = 3;
            // 
            // operations
            // 
            this.operations.FormattingEnabled = true;
            this.operations.Location = new System.Drawing.Point(261, 99);
            this.operations.Name = "operations";
            this.operations.Size = new System.Drawing.Size(86, 21);
            this.operations.TabIndex = 4;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(554, 102);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(79, 19);
            this.result.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.operations);
            this.Controls.Add(this.field2);
            this.Controls.Add(this.field1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox field1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox field2;
        private System.Windows.Forms.ComboBox operations;
        private System.Windows.Forms.Label result;
    }
}

