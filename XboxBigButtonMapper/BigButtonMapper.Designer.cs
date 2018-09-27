namespace XboxBigButtonMapper
{
    partial class BigButtonMapper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.controllerLabel = new System.Windows.Forms.Label();
            this.buttonLabel = new System.Windows.Forms.Label();
            this.currentControllerLabel = new System.Windows.Forms.Label();
            this.currentButtonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // controllerLabel
            // 
            this.controllerLabel.AutoSize = true;
            this.controllerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controllerLabel.Location = new System.Drawing.Point(12, 9);
            this.controllerLabel.Name = "controllerLabel";
            this.controllerLabel.Size = new System.Drawing.Size(245, 55);
            this.controllerLabel.TabIndex = 0;
            this.controllerLabel.Text = "Controller:";
            // 
            // buttonLabel
            // 
            this.buttonLabel.AutoSize = true;
            this.buttonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLabel.Location = new System.Drawing.Point(12, 175);
            this.buttonLabel.Name = "buttonLabel";
            this.buttonLabel.Size = new System.Drawing.Size(176, 55);
            this.buttonLabel.TabIndex = 1;
            this.buttonLabel.Text = "Button:";
            // 
            // currentControllerLabel
            // 
            this.currentControllerLabel.AutoSize = true;
            this.currentControllerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentControllerLabel.Location = new System.Drawing.Point(263, 9);
            this.currentControllerLabel.Name = "currentControllerLabel";
            this.currentControllerLabel.Size = new System.Drawing.Size(104, 55);
            this.currentControllerLabel.TabIndex = 2;
            this.currentControllerLabel.Text = "N/A";
            // 
            // currentButtonLabel
            // 
            this.currentButtonLabel.AutoSize = true;
            this.currentButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentButtonLabel.Location = new System.Drawing.Point(263, 175);
            this.currentButtonLabel.Name = "currentButtonLabel";
            this.currentButtonLabel.Size = new System.Drawing.Size(104, 55);
            this.currentButtonLabel.TabIndex = 3;
            this.currentButtonLabel.Text = "N/A";
            // 
            // BigButtonMapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currentButtonLabel);
            this.Controls.Add(this.currentControllerLabel);
            this.Controls.Add(this.buttonLabel);
            this.Controls.Add(this.controllerLabel);
            this.Name = "BigButtonMapper";
            this.Text = "Xbox Big Button Controller Mapper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label controllerLabel;
        private System.Windows.Forms.Label buttonLabel;
        private System.Windows.Forms.Label currentControllerLabel;
        private System.Windows.Forms.Label currentButtonLabel;
    }
}

