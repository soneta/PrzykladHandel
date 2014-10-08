using System.Collections;

namespace PrzykladHandel
{
	/// <summary>
	/// Summary description for ListaForm.
	/// </summary>
	public class ListaForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox listBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ListaForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox1.Location = new System.Drawing.Point(0, 0);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(380, 329);
			this.listBox1.TabIndex = 0;
			// 
			// ListaForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(380, 330);
			this.Controls.Add(this.listBox1);
			this.Name = "ListaForm";
			this.Text = "Rezultat";
			this.ResumeLayout(false);

		}
		#endregion

		ArrayList lista = null;

		public ArrayList Lista {
			get { return lista; }
			set { 
				lista = value;
				listBox1.DataSource = lista;
			}
		}
	}
}
