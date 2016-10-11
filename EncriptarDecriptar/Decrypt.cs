using System;
using System.Windows.Forms;
using ProjetoMaster.Infra.CrossCuting.Criptografar;

namespace RodarBaseDados
{
    public partial class Decrypt : Form
    {
        public Decrypt()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            Encriptar();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            Decriptar();
        }

        private void Encriptar()
        {
            txtValorResultado.Text = new Criptografia().Encrypt(txtValorRecebido.Text);
        }

        private void Decriptar()
        {
            txtValorResultado.Text = new Criptografia().Decrypt(txtValorRecebido.Text);
        }
    }
}
