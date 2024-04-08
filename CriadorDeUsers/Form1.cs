using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CriadorDeUsers
{
    public partial class Form1 : Form
    {
        private string localArquivo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private Usuario montaUsuario()
        {
            Usuario usuario = new Usuario();
            try
            {
                usuario.Username = "ext_" + txtUsername.Text;
                usuario.PrimeiroNome = txtPrimeiroNome.Text;
                usuario.Sobrenome = txtSobrenome.Text;
                usuario.DisplayName = txtPrimeiroNome.Text + " " + txtSobrenome.Text;
                usuario.Extension = Convert.ToInt32(txtExtension.Text);
                usuario.Senha = "1234";
                usuario.NetworkID = usuario.Username;//netwok Id recebe o username
                                                     //verifica qual Role está selecionada
                if (rbtAgentAtento.Checked)
                {
                    usuario.Roles = "AgentAtento";
                }
                if (rbtAgentAtentoPoint.Checked)
                {
                    usuario.Roles = "AgentAtentoPoint";
                }
                if (rbtAgentConcentrix.Checked)
                {
                    usuario.Roles = "AgentConcentrix";
                }
                //verifica qual Workgroup está selecionado
                if (rbtAtento.Checked)
                {
                    usuario.Workgroups = rbtAtento.Text;
                }
                if (rbtPointAtento.Checked)
                {
                    usuario.Workgroups = rbtPointAtento.Text;
                }
                if (rbtConcentrix.Checked)
                {
                    usuario.Workgroups = rbtConcentrix.Text;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Falha ao cadastrar no método montaUsuario" + ex.ToString());
            }
            return usuario;
        }
        //limpa o formulário
        private void limpaFormulario()
        {
            txtUsername.Text = "";
            txtPrimeiroNome.Text = "";
            txtSobrenome.Text = "";
            txtExtension.Text = "";
            //txtExtension.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = montaUsuario();
                //Caso arquivo não exista, cria com os parametros
                if (!File.Exists(localArquivo))
                {
                    using (StreamWriter writer = new StreamWriter(localArquivo, true))
                    {
                        writer.WriteLine("User Name, First Name,Last Name,Display Name,Extension,DID," +
                                "Password, Network ID,MailBox,Roles,Workgroups,Station Name,Location");
                    }
                }
                using (StreamWriter writer = new StreamWriter(@localArquivo, true))
                {
                    writer.WriteLine(usuario.Username + "," + usuario.PrimeiroNome + "," + usuario.Sobrenome + "," +
                        usuario.DisplayName + "," + usuario.Extension + ",," + usuario.Senha + "," + usuario.NetworkID + ",," + usuario.Roles +
                        "," + usuario.Workgroups + ",,");
                }
                MessageBox.Show("Usuário cadastrado!");
                limpaFormulario();
            }catch(Exception ex)
            {
                MessageBox.Show("Erro no método click de cadastrar usuário" + ex.ToString());
            }
            
        }

        private void btnDiretorio_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            localArquivo = saveFileDialog1.FileName.ToString();
        }
    }
}
