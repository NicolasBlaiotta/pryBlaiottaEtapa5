namespace pryBlaiottaEtapa5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pctVehiculo = new PictureBox();
            btnCrear = new Button();
            ((System.ComponentModel.ISupportInitialize)pctVehiculo).BeginInit();
            SuspendLayout();
            // 
            // pctVehiculo
            // 
            pctVehiculo.Location = new Point(8, 1);
            pctVehiculo.Name = "pctVehiculo";
            pctVehiculo.Size = new Size(780, 402);
            pctVehiculo.TabIndex = 0;
            pctVehiculo.TabStop = false;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(300, 415);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(145, 23);
            btnCrear.TabIndex = 1;
            btnCrear.Text = "Crear vehiculo";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCrear);
            Controls.Add(pctVehiculo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pctVehiculo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctVehiculo;
        private Button btnCrear;
    }
}