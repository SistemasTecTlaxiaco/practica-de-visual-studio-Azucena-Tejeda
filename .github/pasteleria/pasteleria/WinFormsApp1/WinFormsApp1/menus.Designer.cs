
namespace WinFormsApp1
{
    partial class menus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menus));
            this.label1 = new System.Windows.Forms.Label();
            this.Especialidades = new System.Windows.Forms.Button();
            this.otrospostres = new System.Windows.Forms.Button();
            this.gelatinas = new System.Windows.Forms.Button();
            this.cpastel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(131, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // Especialidades
            // 
            this.Especialidades.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Especialidades.Location = new System.Drawing.Point(86, 128);
            this.Especialidades.Name = "Especialidades";
            this.Especialidades.Size = new System.Drawing.Size(198, 58);
            this.Especialidades.TabIndex = 3;
            this.Especialidades.Text = "Especialidades";
            this.Especialidades.UseVisualStyleBackColor = true;
            // 
            // otrospostres
            // 
            this.otrospostres.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.otrospostres.Location = new System.Drawing.Point(86, 374);
            this.otrospostres.Name = "otrospostres";
            this.otrospostres.Size = new System.Drawing.Size(198, 58);
            this.otrospostres.TabIndex = 8;
            this.otrospostres.Text = "Otros postres";
            this.otrospostres.UseVisualStyleBackColor = true;
            // 
            // gelatinas
            // 
            this.gelatinas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gelatinas.Location = new System.Drawing.Point(86, 290);
            this.gelatinas.Name = "gelatinas";
            this.gelatinas.Size = new System.Drawing.Size(198, 58);
            this.gelatinas.TabIndex = 7;
            this.gelatinas.Text = "Gelatinas";
            this.gelatinas.UseVisualStyleBackColor = true;
            // 
            // cpastel
            // 
            this.cpastel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpastel.Location = new System.Drawing.Point(86, 212);
            this.cpastel.Name = "cpastel";
            this.cpastel.Size = new System.Drawing.Size(198, 58);
            this.cpastel.TabIndex = 6;
            this.cpastel.Text = "Crea tu propio pastel";
            this.cpastel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 641);
            this.Controls.Add(this.otrospostres);
            this.Controls.Add(this.gelatinas);
            this.Controls.Add(this.cpastel);
            this.Controls.Add(this.Especialidades);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MENU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Especialidades;
        private System.Windows.Forms.Button otrospostres;
        private System.Windows.Forms.Button gelatinas;
        private System.Windows.Forms.Button cpastel;
    }
}