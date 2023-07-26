using System.IO.Compression;
using System.Linq.Expressions;

namespace gestioneFileSuServer
{
	public partial class Form1 : Form
	{
		public Form1() {
			InitializeComponent();
			/* genera cartella e file */
			button_cartellaPadre.Click += Button_cartellaPadre_Click;
			button_generateFolder.Click += Button_generateFolder_Click;
			button_generateFile.Click += Button_generateFile_Click;

			/* path iniziale */
			button_pathStart.Click += Button_pathStart_Click;
			button_pathEnd.Click += Button_pathEnd_Click;
			button_Submit.Click += Button_Submit_Click;

			comboBoxActions.SelectedIndexChanged += ComboBoxActions_SelectedIndexChanged;

		}

		private void ComboBoxActions_SelectedIndexChanged(object? sender, EventArgs e) {
			if(comboBoxActions.Text == "Elimina" ||
				comboBoxActions.Text == "Zippa" ||
				comboBoxActions.Text == "Unzippa") {
				button_pathEnd.Visible = false;
				pathEnd.Visible = false;
			}
			if(comboBoxActions.Text == "Rinomina") {
				button_pathEnd.Visible = false;
				labelNewName.Visible = true;
			}
			if(comboBoxActions.Text == "Copia" ||
				comboBoxActions.Text == "Sposta") {
				button_pathEnd.Visible = true;
				pathEnd.Visible = true;
				labelNewName.Visible = false;
			}
		}


		private void Button_Submit_Click(object? sender, EventArgs e) {
			if(comboBoxActions.Text == "Copia") {
				if(comboBoxTypeFile.Text == "File")
					FileCopy();
				if(comboBoxTypeFile.Text == "Cartella")
					DirectoryCopy();
			} else if(comboBoxActions.Text == "Sposta") {
				if(comboBoxTypeFile.Text == "File")
					FileMove();
				if(comboBoxTypeFile.Text == "Cartella")
					DirectoryMove();
			} else if(comboBoxActions.Text == "Elimina") {
				if(comboBoxTypeFile.Text == "File")
					FileDelete();
				if(comboBoxTypeFile.Text == "Cartella")
					DirectoryDelete();
			} else if(comboBoxActions.Text == "Rinomina") {
				if(comboBoxTypeFile.Text == "File")
					FileRename();
				if(comboBoxTypeFile.Text == "Cartella")
					DirectoryRename();
			} else if(comboBoxActions.Text == "Zippa") {
				DirectoryZip();
			} else if(comboBoxActions.Text == "Unzippa") {
				DirectoryUnzip();
			} else {
				MessageBox.Show("Scegliere un'azione da compiere");
			}
		}

		private void DirectoryUnzip() {
			try {
				string zipPath = pathStart.Text;
				if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
					string extractPath = folderBrowserDialog1.SelectedPath;
					ZipFile.ExtractToDirectory(zipPath, extractPath);
				}
			}
			catch(Exception e) {
				MessageBox.Show(e.Message);
			}

		}

		private void DirectoryZip() {
			try {
				string startPath = pathStart.Text;
				string zipPath = startPath + ".zip";
				if(File.Exists(zipPath)) {
					MessageBox.Show("esiste già un file zippato con questo nome");
				} else {
					ZipFile.CreateFromDirectory(startPath, zipPath);
					MessageBox.Show("file .zip creato");
				}
			}
			catch(Exception e) {
				MessageBox.Show(e.Message);
			}

		}

		private void DirectoryDelete() {
			var result = MessageBox.Show("vuoi eliminare la cartella?", "elimina", MessageBoxButtons.OKCancel);
			if(result == DialogResult.OK) {
				try {
					Directory.Delete(pathStart.Text, true);
					MessageBox.Show("cartella eliminata");
				}
				catch(Exception ex) {
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void FileDelete() {
			var result = MessageBox.Show("vuoi eliminare il file?", pathStart.Text, MessageBoxButtons.OKCancel);
			if(result == DialogResult.OK) {
				try {
					File.Delete(pathStart.Text);
					MessageBox.Show("file eliminato");
				}
				catch(Exception ex) {
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void DirectoryCopy() {
			try {
				var dir = new DirectoryInfo(pathStart.Text);

				// Check if the source directory exists
				if(!dir.Exists)
					throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

				// Create the destination directory
				string rootDirectory = Path.GetFileName(pathStart.Text);
				string destPath = Path.Combine(pathEnd.Text, rootDirectory);
				Directory.CreateDirectory(destPath);

				// Get the files in the source directory and copy to the destination directory
				foreach(FileInfo file in dir.GetFiles()) {
					string targetFilePath = Path.Combine(pathEnd.Text, file.Name);
					file.CopyTo(targetFilePath);
				}
				MessageBox.Show("cartella copiata");
			}
			catch(Exception e) {
				MessageBox.Show(e.Message);
			}
		}

		private void FileCopy() {
			try {
				string source = pathStart.Text;
				string dest = pathEnd.Text + $"\\{Path.GetFileName(source)}";
				File.Copy(source, dest);
				MessageBox.Show("file spostato");
			}
			catch(Exception e) {
				MessageBox.Show(e.Message);
			}
		}

		private void FileRename() {
			try {
				string source = pathStart.Text;
				string newName = Path.GetDirectoryName(pathStart.Text) + $"\\{pathEnd.Text}";
				File.Move(source, newName);
				MessageBox.Show("file rinominato");
			}
			catch(Exception e) {
				MessageBox.Show(e.Message);
			}
		}

		private void DirectoryRename() {
			string source = pathStart.Text;
			string newName = Path.GetDirectoryName(pathStart.Text) + $"\\{Path.GetFileName(pathEnd.Text)}";
			try {
				Directory.Move(source, newName);
				MessageBox.Show("cartella rinominata");
			}
			catch(Exception e) {
				MessageBox.Show(e.Message);
			}
		}

		private void DirectoryMove() {
			string source = pathStart.Text;
			string dest = pathEnd.Text + $"\\{Path.GetFileName(source)}";
			try {
				Directory.Move(source, dest);
				MessageBox.Show("cartella spostata");
			}
			catch(Exception e) {
				MessageBox.Show(e.Message);
			}
		}

		private void FileMove() {
			try {
				string source = pathStart.Text;
				string dest = pathEnd.Text + $"\\{Path.GetFileName(source)}";
				File.Move(source, dest);
				MessageBox.Show("file spostato");
			}
			catch(Exception e) {
				MessageBox.Show(e.Message);
			}
		}

		private void Button_pathEnd_Click(object? sender, EventArgs e) {
			if(comboBoxTypeFile.Text == "File" && comboBoxActions.Text == "Copia") {
				if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
					pathEnd.Text = folderBrowserDialog1.SelectedPath;
				}
			} else if(comboBoxTypeFile.Text == "File" && comboBoxActions.Text == "Sposta") {
				if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
					pathEnd.Text = folderBrowserDialog1.SelectedPath;
				}
			} else if(comboBoxTypeFile.Text == "Cartella") {
				if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
					pathEnd.Text = folderBrowserDialog1.SelectedPath;
				}
			} else if(comboBoxTypeFile.Text == "File") {
				if(openFileDialog1.ShowDialog() == DialogResult.OK) {
					pathEnd.Text = openFileDialog1.FileName;
				}
			} else {
				MessageBox.Show("Scegliere un tipo di file");
			}
		}

		private void Button_pathStart_Click(object? sender, EventArgs e) {
			if(comboBoxTypeFile.Text == "File") {
				if(openFileDialog1.ShowDialog() == DialogResult.OK) {
					pathStart.Text = openFileDialog1.FileName;
				}
			} else if(comboBoxTypeFile.Text == "Cartella") {
				if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
					pathStart.Text = folderBrowserDialog1.SelectedPath;
				}
			} else {
				MessageBox.Show("Scegliere un tipo di file");
			}
		}

		private void Button_generateFile_Click(object? sender, EventArgs e) {
			string path = path_cartellaOrigine.Text + $"\\{fileName.Text}.txt";
			string text = textBox_testoFile.Text;
			File.Create(path).Close();
			File.WriteAllText(path, text);
			MessageBox.Show("il file è stato creato");
		}

		private void Button_generateFolder_Click(object? sender, EventArgs e) {
			string path = path_cartellaOrigine.Text + $"\\{textBox_inputNameCartella.Text}";
			if(Directory.Exists(path)) {
				MessageBox.Show("il percorso esiste già");
				path_cartellaOrigine.Text = path;
			} else {
				Directory.CreateDirectory(path);
				MessageBox.Show("cartella creata");
				path_cartellaOrigine.Text = path;
			}
		}

		private void Button_cartellaPadre_Click(object? sender, EventArgs e) {
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
				path_cartellaOrigine.Text = folderBrowserDialog1.SelectedPath;
			}
		}
	}
}