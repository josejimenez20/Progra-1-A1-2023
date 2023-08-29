
namespace Parcial1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRespuestaConversores = new System.Windows.Forms.Label();
            this.lblCantidadConversores = new System.Windows.Forms.Label();
            this.cboAConversores = new System.Windows.Forms.ComboBox();
            this.lblAConversores = new System.Windows.Forms.Label();
            this.txtCantidadConversores = new System.Windows.Forms.TextBox();
            this.cboDeConversores = new System.Windows.Forms.ComboBox();
            this.lblDeConversores = new System.Windows.Forms.Label();
            this.btnConvertirConversores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRespuestaConversores
            // 
            this.lblRespuestaConversores.AutoSize = true;
            this.lblRespuestaConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestaConversores.Location = new System.Drawing.Point(263, 224);
            this.lblRespuestaConversores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRespuestaConversores.Name = "lblRespuestaConversores";
            this.lblRespuestaConversores.Size = new System.Drawing.Size(154, 27);
            this.lblRespuestaConversores.TabIndex = 25;
            this.lblRespuestaConversores.Text = "Respuesta: ?";
            // 
            // lblCantidadConversores
            // 
            this.lblCantidadConversores.AutoSize = true;
            this.lblCantidadConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadConversores.Location = new System.Drawing.Point(263, 160);
            this.lblCantidadConversores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadConversores.Name = "lblCantidadConversores";
            this.lblCantidadConversores.Size = new System.Drawing.Size(116, 27);
            this.lblCantidadConversores.TabIndex = 24;
            this.lblCantidadConversores.Text = "Cantidad:";
            // 
            // cboAConversores
            // 
            this.cboAConversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAConversores.FormattingEnabled = true;
            this.cboAConversores.Items.AddRange(new object[] {
            "Pie Cuadrado",
            "Vara Cuadrada ",
            "Yarda Cuadrada ",
            "Metro Cuadrado ",
            "Tarea ",
            "Manzana ",
            "Hectarea "});
            this.cboAConversores.Location = new System.Drawing.Point(345, 102);
            this.cboAConversores.Margin = new System.Windows.Forms.Padding(4);
            this.cboAConversores.Name = "cboAConversores";
            this.cboAConversores.Size = new System.Drawing.Size(193, 24);
            this.cboAConversores.TabIndex = 23;
            // 
            // lblAConversores
            // 
            this.lblAConversores.AutoSize = true;
            this.lblAConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAConversores.Location = new System.Drawing.Point(281, 102);
            this.lblAConversores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAConversores.Name = "lblAConversores";
            this.lblAConversores.Size = new System.Drawing.Size(34, 27);
            this.lblAConversores.TabIndex = 22;
            this.lblAConversores.Text = "A:";
            // 
            // txtCantidadConversores
            // 
            this.txtCantidadConversores.Location = new System.Drawing.Point(391, 165);
            this.txtCantidadConversores.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadConversores.Name = "txtCantidadConversores";
            this.txtCantidadConversores.Size = new System.Drawing.Size(132, 22);
            this.txtCantidadConversores.TabIndex = 21;
            // 
            // cboDeConversores
            // 
            this.cboDeConversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeConversores.FormattingEnabled = true;
            this.cboDeConversores.Items.AddRange(new object[] {
            "Pie Cuadrado",
            "Vara Cuadrada ",
            "Yarda Cuadrada ",
            "Metro Cuadrado ",
            "Tarea ",
            "Manzana ",
            "Hectarea "});
            this.cboDeConversores.Location = new System.Drawing.Point(345, 46);
            this.cboDeConversores.Margin = new System.Windows.Forms.Padding(4);
            this.cboDeConversores.Name = "cboDeConversores";
            this.cboDeConversores.Size = new System.Drawing.Size(193, 24);
            this.cboDeConversores.TabIndex = 20;
            
            // 
            // lblDeConversores
            // 
            this.lblDeConversores.AutoSize = true;
            this.lblDeConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeConversores.Location = new System.Drawing.Point(272, 46);
            this.lblDeConversores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeConversores.Name = "lblDeConversores";
            this.lblDeConversores.Size = new System.Drawing.Size(52, 27);
            this.lblDeConversores.TabIndex = 19;
            this.lblDeConversores.Text = "DE:";
            // 
            // btnConvertirConversores
            // 
            this.btnConvertirConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirConversores.Location = new System.Drawing.Point(268, 291);
            this.btnConvertirConversores.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvertirConversores.Name = "btnConvertirConversores";
            this.btnConvertirConversores.Size = new System.Drawing.Size(256, 113);
            this.btnConvertirConversores.TabIndex = 18;
            this.btnConvertirConversores.Text = "Convertir";
            this.btnConvertirConversores.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRespuestaConversores);
            this.Controls.Add(this.lblCantidadConversores);
            this.Controls.Add(this.cboAConversores);
            this.Controls.Add(this.lblAConversores);
            this.Controls.Add(this.txtCantidadConversores);
            this.Controls.Add(this.cboDeConversores);
            this.Controls.Add(this.lblDeConversores);
            this.Controls.Add(this.btnConvertirConversores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRespuestaConversores;
        private System.Windows.Forms.Label lblCantidadConversores;
        private System.Windows.Forms.ComboBox cboAConversores;
        private System.Windows.Forms.Label lblAConversores;
        private System.Windows.Forms.TextBox txtCantidadConversores;
        private System.Windows.Forms.ComboBox cboDeConversores;
        private System.Windows.Forms.Label lblDeConversores;
        private System.Windows.Forms.Button btnConvertirConversores;
    }
}

