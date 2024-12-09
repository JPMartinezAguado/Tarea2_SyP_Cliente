namespace Tarea2_SyP_Cliente
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
            components = new System.ComponentModel.Container();
            conectar = new Button();
            mensajeEntrada = new TextBox();
            encenderCalculadora = new Button();
            abrirNotepad = new Button();
            abrirPrediccion = new Button();
            apagar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            hora = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // conectar
            // 
            conectar.BackColor = Color.DarkOliveGreen;
            conectar.ForeColor = Color.Cornsilk;
            conectar.Location = new Point(12, 12);
            conectar.Name = "conectar";
            conectar.Size = new Size(156, 23);
            conectar.TabIndex = 0;
            conectar.Text = "conectar al oraculo";
            conectar.UseVisualStyleBackColor = false;
            conectar.Click += conectar_Click;
            // 
            // mensajeEntrada
            // 
            mensajeEntrada.Location = new Point(49, 70);
            mensajeEntrada.Multiline = true;
            mensajeEntrada.Name = "mensajeEntrada";
            mensajeEntrada.Size = new Size(708, 140);
            mensajeEntrada.TabIndex = 1;
            mensajeEntrada.TextChanged += mensajeEntrada_TextChanged;
            // 
            // encenderCalculadora
            // 
            encenderCalculadora.Location = new Point(49, 276);
            encenderCalculadora.Name = "encenderCalculadora";
            encenderCalculadora.Size = new Size(170, 108);
            encenderCalculadora.TabIndex = 2;
            encenderCalculadora.Text = "Encender Calculadora";
            encenderCalculadora.UseVisualStyleBackColor = true;
            encenderCalculadora.Click += encenderCalculadora_Click;
            // 
            // abrirNotepad
            // 
            abrirNotepad.Location = new Point(256, 276);
            abrirNotepad.Name = "abrirNotepad";
            abrirNotepad.Size = new Size(152, 108);
            abrirNotepad.TabIndex = 3;
            abrirNotepad.Text = "Abrir Notepad";
            abrirNotepad.UseVisualStyleBackColor = true;
            abrirNotepad.Click += abrirNotepad_Click;
            // 
            // abrirPrediccion
            // 
            abrirPrediccion.Location = new Point(581, 330);
            abrirPrediccion.Name = "abrirPrediccion";
            abrirPrediccion.Size = new Size(176, 89);
            abrirPrediccion.TabIndex = 4;
            abrirPrediccion.Text = "Comprobar prediccion";
            abrirPrediccion.UseVisualStyleBackColor = true;
            abrirPrediccion.Click += abrirPrediccion_Click;
            // 
            // apagar
            // 
            apagar.BackColor = Color.Coral;
            apagar.ForeColor = Color.Cornsilk;
            apagar.Location = new Point(713, 12);
            apagar.Name = "apagar";
            apagar.Size = new Size(75, 23);
            apagar.TabIndex = 5;
            apagar.Text = "Apagar";
            apagar.UseVisualStyleBackColor = false;
            apagar.Click += apagar_Click;
            // 
            // hora
            // 
            hora.Location = new Point(581, 228);
            hora.Name = "hora";
            hora.Size = new Size(134, 48);
            hora.TabIndex = 6;
            hora.Text = "capturar hora actual";
            hora.UseVisualStyleBackColor = true;
            hora.Click += hora_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(581, 282);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(hora);
            Controls.Add(apagar);
            Controls.Add(abrirPrediccion);
            Controls.Add(abrirNotepad);
            Controls.Add(encenderCalculadora);
            Controls.Add(mensajeEntrada);
            Controls.Add(conectar);
            ForeColor = Color.CornflowerBlue;
            Name = "Form1";
            Text = "Cliente";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button conectar;
        private TextBox mensajeEntrada;
        private Button encenderCalculadora;
        private Button abrirNotepad;
        private Button abrirPrediccion;
        private Button apagar;
        private System.Windows.Forms.Timer timer1;
        private Button hora;
        private Label label1;
    }
}
