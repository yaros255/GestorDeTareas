namespace GestorDeTareasWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string titulo = titulo_field.Text;
            string desc = desc_field.Text;
            DateTime fecha = datetime_field.Value;
            bool prioritaria = priority_chkbox.Checked;

            Tarea t = new Tarea(titulo, desc, false, fecha, prioritaria);

            listBox1.Items.Add(t);
        }

        private void complete_btn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is not Tarea tarea)
            {
                MessageBox.Show("Selecciona una tarea para marcar como completada.");
                return;
            }
            tarea.MarcarComoCompletada();
            listBox1.Items[listBox1.SelectedIndex] = tarea;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una tarea para eliminar.");
                return;
            }
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            //se añadirá más adelante
        }
    }
}
