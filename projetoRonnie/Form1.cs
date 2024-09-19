//Usado para trabalhar com aquivo externo
using System.IO;


namespace projetoRonnie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text != "") && (txtFone.Text != "") && (comboSexo.Text != ""))
            {
                if (MessageBox.Show(
                    "Deseja inserir esse registro?",
                    "Informação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    listBox.Items.Add(txtNome.Text + "|" + txtFone.Text + "|" + comboSexo.Text);
                    //Primeira forma
                    btnNovo.PerformClick();

                    //Segunda forma
                    btnNovo_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show(
                    "Preencha todos os campos do formulário",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtFone.Text = string.Empty;
            comboSexo.Text = "";

            txtNome.Focus();//Colocar o cursor no campo nome
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItems.Count > 0)
            {
                if (MessageBox.Show(
                    "Deseja remover o item selecionado?",
                    "Informação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                {
                    listBox.Items.RemoveAt(listBox.SelectedIndex);
                    MessageBox.Show("Sucesso na remoção do item!");
                }
                else
                {
                    MessageBox.Show(
                    "Processo cancelado pelo usuário!",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Selecione um item da lista!",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex >= 0)
            {
                if (MessageBox.Show(
                    "Deseja restaurar o item selecionado?",
                    "Informação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string[] campos = listBox.SelectedItem.ToString().Split('|');


                    txtNome.Text = campos[0];
                    txtFone.Text = campos[1];
                    comboSexo.Text = campos[2];
                }
            }
            else
            {
                MessageBox.Show(
                    "Selecione um item da lista!",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimparContato_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Deseja remover todos os itens da lista?",
                    "Informação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ) == DialogResult.Yes)
            {
                listBox.Items.Clear();
            }
            else
            {
                MessageBox.Show(
                    "Processo cancelado pelo usuário!",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            //Cria um aquivo chamdao bkLIsta que ira salvar a lista na mesma parta do projeto
            FileInfo salvarAquivo = new FileInfo(@".\bkLista.txt");

            //Verifica se o arquivo ja existe 
            if (!salvarAquivo.Exists)
            {
                using (StreamWriter sa = salvarAquivo.CreateText())
                {
                    //Percorre todos os itens da lista
                    for (int i = 0; i < listBox.Items.Count; i++)
                    {
                        //Pega cada item da lista e salva no sa que envia pra o aquivo criado
                        sa.WriteLine(listBox.Items[i].ToString());
                    }
                };
            }
            else
            {
                if (MessageBox.Show(
                    "Arquivo já existente!Deseja sobrepor?",
                    "Informação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (StreamWriter sa = salvarAquivo.CreateText())
                    {
                        //Percorre todos os itens da lista
                        for (int i = 0; i < listBox.Items.Count; i++)
                        {
                            //Pega cada item da lista e salva no sa que envia pra o aquivo criado
                            sa.WriteLine(listBox.Items[i].ToString());
                        }
                    }
                    MessageBox.Show(
                        "Backup realizado com sucesso!",
                        "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
                else
                {
                    MessageBox.Show(
                        "Backup cancelado pelo usuário!",
                        "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
            }
        }

        private void brnIMportar_Click(object sender, EventArgs e)
        {
            FileInfo abrirArquivo = new FileInfo(@".\bkLista.txt");
            if (abrirArquivo.Exists)
            {
                using (StreamReader aa = abrirArquivo.OpenText())
                {
                    //Limpar itens da agenda
                    listBox.Items.Clear();

                    string linha = null;
                    //Ler todas as linhas do arquivo
                    //Le enquanto linha for diferente de vazio
                    while((linha = aa.ReadLine()) != null)
                    {
                        //Adiciona o conteudo da linha na listBox se for diferente de vazio
                        listBox.Items.Add(linha);   
                    }
                }

                MessageBox.Show(
                        "Importação concluída com sucesso!",
                        "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
            }
            else
            {
                MessageBox.Show(
                        "Backup não encontrado!",
                        "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
            }
        }
    }
}
