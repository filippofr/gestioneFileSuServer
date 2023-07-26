namespace gestioneFileSuServer
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
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			button_cartellaPadre = new Button();
			path_cartellaOrigine = new TextBox();
			textBox_inputNameCartella = new TextBox();
			label1 = new Label();
			textBox_testoFile = new TextBox();
			label2 = new Label();
			folderBrowserDialog1 = new FolderBrowserDialog();
			openFileDialog1 = new OpenFileDialog();
			button_generateFolder = new Button();
			fileName = new TextBox();
			button_generateFile = new Button();
			comboBoxTypeFile = new ComboBox();
			pathStart = new TextBox();
			button_pathStart = new Button();
			pathEnd = new TextBox();
			button_pathEnd = new Button();
			button_Submit = new Button();
			comboBoxActions = new ComboBox();
			label3 = new Label();
			label4 = new Label();
			labelNewName = new Label();
			SuspendLayout();
			// 
			// button_cartellaPadre
			// 
			button_cartellaPadre.Location = new Point(43, 37);
			button_cartellaPadre.Name = "button_cartellaPadre";
			button_cartellaPadre.Size = new Size(115, 29);
			button_cartellaPadre.TabIndex = 0;
			button_cartellaPadre.Text = "Cartella Padre";
			button_cartellaPadre.UseVisualStyleBackColor = true;
			// 
			// path_cartellaOrigine
			// 
			path_cartellaOrigine.Location = new Point(43, 72);
			path_cartellaOrigine.Name = "path_cartellaOrigine";
			path_cartellaOrigine.Size = new Size(275, 27);
			path_cartellaOrigine.TabIndex = 1;
			// 
			// textBox_inputNameCartella
			// 
			textBox_inputNameCartella.Location = new Point(193, 37);
			textBox_inputNameCartella.Name = "textBox_inputNameCartella";
			textBox_inputNameCartella.Size = new Size(125, 27);
			textBox_inputNameCartella.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(193, 9);
			label1.Name = "label1";
			label1.Size = new Size(105, 20);
			label1.TabIndex = 3;
			label1.Text = "Nome Cartella";
			// 
			// textBox_testoFile
			// 
			textBox_testoFile.Location = new Point(428, 37);
			textBox_testoFile.Multiline = true;
			textBox_testoFile.Name = "textBox_testoFile";
			textBox_testoFile.Size = new Size(464, 152);
			textBox_testoFile.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(428, 9);
			label2.Name = "label2";
			label2.Size = new Size(94, 20);
			label2.TabIndex = 5;
			label2.Text = "Testo del file";
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// button_generateFolder
			// 
			button_generateFolder.Location = new Point(116, 105);
			button_generateFolder.Name = "button_generateFolder";
			button_generateFolder.Size = new Size(123, 29);
			button_generateFolder.TabIndex = 6;
			button_generateFolder.Text = "Genera Cartella";
			button_generateFolder.UseVisualStyleBackColor = true;
			// 
			// fileName
			// 
			fileName.Location = new Point(670, 6);
			fileName.Name = "fileName";
			fileName.PlaceholderText = "Nome File";
			fileName.Size = new Size(222, 27);
			fileName.TabIndex = 7;
			// 
			// button_generateFile
			// 
			button_generateFile.Location = new Point(898, 105);
			button_generateFile.Name = "button_generateFile";
			button_generateFile.Size = new Size(94, 29);
			button_generateFile.TabIndex = 8;
			button_generateFile.Text = "Genera File";
			button_generateFile.UseVisualStyleBackColor = true;
			// 
			// comboBoxTypeFile
			// 
			comboBoxTypeFile.FormattingEnabled = true;
			comboBoxTypeFile.Items.AddRange(new object[] { "Cartella", "File" });
			comboBoxTypeFile.Location = new Point(358, 305);
			comboBoxTypeFile.Name = "comboBoxTypeFile";
			comboBoxTypeFile.Size = new Size(151, 28);
			comboBoxTypeFile.TabIndex = 29;
			// 
			// pathStart
			// 
			pathStart.Location = new Point(440, 369);
			pathStart.Name = "pathStart";
			pathStart.Size = new Size(288, 27);
			pathStart.TabIndex = 31;
			// 
			// button_pathStart
			// 
			button_pathStart.Location = new Point(340, 357);
			button_pathStart.Name = "button_pathStart";
			button_pathStart.Size = new Size(94, 50);
			button_pathStart.TabIndex = 30;
			button_pathStart.Text = "Path di partenza";
			button_pathStart.UseVisualStyleBackColor = true;
			// 
			// pathEnd
			// 
			pathEnd.Location = new Point(440, 425);
			pathEnd.Name = "pathEnd";
			pathEnd.Size = new Size(288, 27);
			pathEnd.TabIndex = 33;
			// 
			// button_pathEnd
			// 
			button_pathEnd.Location = new Point(340, 413);
			button_pathEnd.Name = "button_pathEnd";
			button_pathEnd.Size = new Size(94, 50);
			button_pathEnd.TabIndex = 32;
			button_pathEnd.Text = "Path di arrivo";
			button_pathEnd.UseVisualStyleBackColor = true;
			// 
			// button_Submit
			// 
			button_Submit.Location = new Point(508, 470);
			button_Submit.Name = "button_Submit";
			button_Submit.Size = new Size(94, 50);
			button_Submit.TabIndex = 34;
			button_Submit.Text = "Esegui";
			button_Submit.UseVisualStyleBackColor = true;
			// 
			// comboBoxActions
			// 
			comboBoxActions.FormattingEnabled = true;
			comboBoxActions.Items.AddRange(new object[] { "Copia", "Sposta", "Elimina", "Rinomina", "Zippa", "Unzippa" });
			comboBoxActions.Location = new Point(556, 305);
			comboBoxActions.Name = "comboBoxActions";
			comboBoxActions.Size = new Size(151, 28);
			comboBoxActions.TabIndex = 35;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(358, 280);
			label3.Name = "label3";
			label3.Size = new Size(83, 20);
			label3.TabIndex = 36;
			label3.Text = "Tipo di File";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(556, 282);
			label4.Name = "label4";
			label4.Size = new Size(55, 20);
			label4.TabIndex = 37;
			label4.Text = "Azione";
			// 
			// labelNewName
			// 
			labelNewName.AutoSize = true;
			labelNewName.Location = new Point(743, 432);
			labelNewName.Name = "labelNewName";
			labelNewName.Size = new Size(148, 20);
			labelNewName.TabIndex = 38;
			labelNewName.Text = "Inserisci nuovo nome";
			labelNewName.Visible = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1132, 728);
			Controls.Add(labelNewName);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(comboBoxActions);
			Controls.Add(button_Submit);
			Controls.Add(pathEnd);
			Controls.Add(button_pathEnd);
			Controls.Add(pathStart);
			Controls.Add(button_pathStart);
			Controls.Add(comboBoxTypeFile);
			Controls.Add(button_generateFile);
			Controls.Add(fileName);
			Controls.Add(button_generateFolder);
			Controls.Add(label2);
			Controls.Add(textBox_testoFile);
			Controls.Add(label1);
			Controls.Add(textBox_inputNameCartella);
			Controls.Add(path_cartellaOrigine);
			Controls.Add(button_cartellaPadre);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button_cartellaPadre;
		private TextBox path_cartellaOrigine;
		private TextBox textBox_inputNameCartella;
		private Label label1;
		private TextBox textBox_testoFile;
		private Label label2;
		private FolderBrowserDialog folderBrowserDialog1;
		private OpenFileDialog openFileDialog1;
		private Button button_generateFolder;
		private TextBox fileName;
		private Button button_generateFile;
		private ComboBox comboBoxTypeFile;
		private TextBox pathStart;
		private Button button_pathStart;
		private TextBox pathEnd;
		private Button button_pathEnd;
		private Button button_Submit;
		private ComboBox comboBoxActions;
		private Label label3;
		private Label label4;
		private Label labelNewName;
	}
}