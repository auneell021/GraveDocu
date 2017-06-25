namespace Graveyard
{
    partial class frmDrawing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrawing));
            this.btnDraw = new System.Windows.Forms.Button();
            this.cmDrawTypes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(147, 12);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // cmDrawTypes
            // 
            this.cmDrawTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmDrawTypes.FormattingEnabled = true;
            this.cmDrawTypes.Items.AddRange(new object[] {
            "Straight Line",
            "Curves"});
            this.cmDrawTypes.Location = new System.Drawing.Point(17, 12);
            this.cmDrawTypes.Name = "cmDrawTypes";
            this.cmDrawTypes.Size = new System.Drawing.Size(121, 21);
            this.cmDrawTypes.TabIndex = 1;
            // 
            // frmDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(945, 609);
            this.Controls.Add(this.cmDrawTypes);
            this.Controls.Add(this.btnDraw);
            this.Name = "frmDrawing";
            this.Text = "frmDrawing";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmDrawing_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDrawing_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmDrawing_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmDrawing_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.ComboBox cmDrawTypes;
    }
}