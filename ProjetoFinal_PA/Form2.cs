using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal_PA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult escolha;
            escolha = MessageBox.Show("Deseja voltar?", "Retornar a HOME", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Information);
            if(escolha.ToString().ToLower() == "yes")
            {
                this.Hide();
                Form1 home = new Form1();
                home.ShowDialog();
                this.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string codBarras, nome, descricao, preco, estoque, unidade, tipo;
                codBarras = textBox1.Text;
                nome = textBox2.Text;
                descricao = textBox3.Text;
                preco = textBox4.Text;
                estoque = textBox5.Text;
                unidade = textBox6.Text;
                tipo = comboBox1.Text;
                if(string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "Digite o código de barras")
                {
                    throw new Exception("Campo Codigo de Barras está vazio!");
                }
                try
                {
                    Convert.ToInt64(codBarras);
                }
                catch
                {
                    throw new Exception("Código de barras deve ser numérico!");
                }
                if (codBarras.Length != 13)
                {
                    throw new Exception("Código de barras deve ter 13 digitos!");
                }
                if (string.IsNullOrWhiteSpace(nome))
                {
                    throw new Exception("Campo nome vazio");
                }
                if (string.IsNullOrWhiteSpace(descricao))
                {
                    throw new Exception("Campo descrição vazio");
                }
                if (string.IsNullOrWhiteSpace(preco))
                {
                    throw new Exception("Campo preço vazio");
                }
                try
                {
                    Convert.ToDouble(preco);
                }
                catch
                {
                    throw new Exception("Preço deve ser numérico!");
                }
                if (string.IsNullOrWhiteSpace(estoque))
                {
                    throw new Exception("Campo estoque vazio");
                }
                try
                {
                    Convert.ToInt32(estoque);
                }
                catch
                {
                    throw new Exception("Estoque deve ser numérico!");
                }
                if (string.IsNullOrWhiteSpace(unidade))
                {
                    throw new Exception("Campo unidade vazio");
                }
                try
                {
                    Convert.ToInt32(unidade);
                }
                catch
                {
                    throw new Exception("Estoque deve ser numérico!");
                }
                if (string.IsNullOrWhiteSpace(tipo))
                {
                    throw new Exception("Campo tipo vazio");
                }
                MessageBox.Show("Cadastro efetuado com sucesso", "Sucesso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Digite o código de barras")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Digite o código de barras";
                textBox1.ForeColor = Color.Silver;
            }
        }
    }
}
