namespace TriLightResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pBoxImgRef = new System.Windows.Forms.PictureBox();
            this.pBoxImgEvaluation = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblPixelCount = new System.Windows.Forms.Label();
            this.lblTracer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImgRef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImgEvaluation)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxImgRef
            // 
            this.pBoxImgRef.Location = new System.Drawing.Point(12, 44);
            this.pBoxImgRef.Name = "pBoxImgRef";
            this.pBoxImgRef.Size = new System.Drawing.Size(500, 200);
            this.pBoxImgRef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxImgRef.TabIndex = 0;
            this.pBoxImgRef.TabStop = false;
            // 
            // pBoxImgEvaluation
            // 
            this.pBoxImgEvaluation.Location = new System.Drawing.Point(12, 303);
            this.pBoxImgEvaluation.Name = "pBoxImgEvaluation";
            this.pBoxImgEvaluation.Size = new System.Drawing.Size(500, 200);
            this.pBoxImgEvaluation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxImgEvaluation.TabIndex = 1;
            this.pBoxImgEvaluation.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image Reference:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Image Evaluation:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.Location = new System.Drawing.Point(11, 549);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(126, 32);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "STATUS";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblValue.Location = new System.Drawing.Point(12, 514);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(72, 25);
            this.lblValue.TabIndex = 5;
            this.lblValue.Text = "Result:";
            // 
            // lblPixelCount
            // 
            this.lblPixelCount.AutoSize = true;
            this.lblPixelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPixelCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPixelCount.Location = new System.Drawing.Point(223, 514);
            this.lblPixelCount.Name = "lblPixelCount";
            this.lblPixelCount.Size = new System.Drawing.Size(23, 25);
            this.lblPixelCount.TabIndex = 6;
            this.lblPixelCount.Text = "0";
            // 
            // lblTracer
            // 
            this.lblTracer.AutoSize = true;
            this.lblTracer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTracer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTracer.Location = new System.Drawing.Point(185, 275);
            this.lblTracer.Name = "lblTracer";
            this.lblTracer.Size = new System.Drawing.Size(93, 25);
            this.lblTracer.TabIndex = 7;
            this.lblTracer.Text = "TRACER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(521, 594);
            this.Controls.Add(this.lblTracer);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPixelCount);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBoxImgEvaluation);
            this.Controls.Add(this.pBoxImgRef);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrilightResult";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImgRef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImgEvaluation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxImgRef;
        private System.Windows.Forms.PictureBox pBoxImgEvaluation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblPixelCount;
        private System.Windows.Forms.Label lblTracer;
    }
}

