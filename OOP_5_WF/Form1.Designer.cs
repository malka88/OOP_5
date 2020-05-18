namespace OOP_5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.galleryEllipse1 = new OOP_5.GalleryEllipse();
            this.gallery1 = new OOP_5.Gallery();
            this.SuspendLayout();
            // 
            // galleryEllipse1
            // 
            this.galleryEllipse1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galleryEllipse1.ForeColor = System.Drawing.Color.White;
            this.galleryEllipse1.Image = ((System.Drawing.Image)(resources.GetObject("galleryEllipse1.Image")));
            this.galleryEllipse1.Location = new System.Drawing.Point(12, 444);
            this.galleryEllipse1.Name = "galleryEllipse1";
            this.galleryEllipse1.Size = new System.Drawing.Size(776, 327);
            this.galleryEllipse1.TabIndex = 1;
            this.galleryEllipse1.Text = "galleryEllipse1";
            this.galleryEllipse1.UseVisualStyleBackColor = true;
            // 
            // gallery1
            // 
            this.gallery1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gallery1.ForeColor = System.Drawing.Color.White;
            this.gallery1.Image = ((System.Drawing.Image)(resources.GetObject("gallery1.Image")));
            this.gallery1.Location = new System.Drawing.Point(12, 12);
            this.gallery1.Name = "gallery1";
            this.gallery1.Size = new System.Drawing.Size(776, 426);
            this.gallery1.TabIndex = 0;
            this.gallery1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 783);
            this.Controls.Add(this.galleryEllipse1);
            this.Controls.Add(this.gallery1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Gallery gallery1;
        private GalleryEllipse galleryEllipse1;
    }
}

