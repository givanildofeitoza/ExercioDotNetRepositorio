using System.Security.Cryptography.X509Certificates;
using Data;
using Busines.Models;

namespace ServicoVeiculos
{
    public partial class Form1 : Form
    {
       private ServicoCarro    _ServicoCarro = new ServicoCarro();
       private ServicoCaminhao _ServicoCaminhao = new ServicoCaminhao();
       private int incCod = 0; 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            c.Codigo = incCod + 1;
            c.Placa = "PDF-3373";
            c.Descricao = "WolksVagen Fox";
            c.OcupacaoMaxima = 5;

            incCod+= 1;

            _ServicoCarro.InserirVeiculo(c);
            MessageBox.Show("Incluido com sucesso!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GridCarro.DataSource = _ServicoCarro.ObterListaVeiculo();
        }
    }
}