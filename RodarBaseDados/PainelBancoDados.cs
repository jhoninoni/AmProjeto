using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Infra.CrossCuting.Criptografar;
using ProjetoMaster.Infra.Data.Contexto;
using ProjetoMaster.Infra.Data.Repositories;
using RodarBaseDados.Properties;

namespace RodarBaseDados
{
    public partial class PainelBancoDados : Form
    {
        #region Declaracao de Variaveis

        //private ClienteRepository _clienteRepository;
        private UsuarioRepository _usuarioRepository;
        private const string SenhaPadrao = "testeSenha101010";

        #endregion

        public PainelBancoDados()
        {
            InitializeComponent();
        }

        private void btnDroparBanco_Click(object sender, EventArgs e)
        {
            //DeletarBase();
        }

        private void btnCriaBaseDados_Click(object sender, EventArgs e)
        {
            CriarBaseDados();
        }

        private void btnRodaMassaDados_Click(object sender, EventArgs e)
        {
            GeraMassaDados();
        }

        #region Metodos de Acao

        private void DeletarBase()
        {
            var contexto = new ContextDb();

            try
            {
                contexto.Database.Delete();
                lblMensagem.Text = Resources.BaseDeletadaComSucesso;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = Resources.ErroDeletarBase;
            }
        }

        private void CriarBaseDados()
        {
            var contexto = new ContextDb();

            try
            {
                contexto.Database.CreateIfNotExists();
                lblMensagem.Text = Resources.MensagemBaseCriadaComSucesso;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = Resources.MensagemErroCriarBase;
            }
        }

        private void GeraMassaDados()
        {
            var contexto = new ContextDb();

            try
            {
                contexto.Database.CreateIfNotExists();

                CriarMassaDadosProduto();
                CriarMassaDadosCliente();
                CriarMassaUsuario();

                lblMensagem.Text = Resources.MassaDadosMapeadaSucesso;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = Resources.ErroMapearMassaDados;
            }
        }

        private void CriarMassaDadosProduto()
        {
            //var produto = new PessoaDomain() { Nome = "Cadeira"};
            //var produto1 = new PessoaDomain() { Nome = "Mesa"};
            //var produto2 = new PessoaDomain() { Nome = "Sofa" };

            //_produtoRepository = new ProdutoRepository();
            //_produtoRepository.Add(produto);
            //_produtoRepository.Add(produto1);
            //_produtoRepository.Add(produto2);
        }

        private void CriarMassaDadosCliente()
        {
            //var cliente = new Cliente()
            //{
            //    Nome = "Jhoni",
            //    Sobrenome = "Oliveira",
            //    Email = "Jhoni_jk@hotmail.com",
            //    Ativo = true,
            //    DataNascimento = new DateTime(),
            //    ProdutoId = 1,
            //    Produto = new Produto() { Nome = "Cadeira", Valor = 25 }
            //};

            //var cliente1 = new Cliente()
            //{
            //    Nome = "Jean", 
            //    Sobrenome = "Oliveira", 
            //    Email = "Jean@hotmail.com", 
            //    Ativo = true,
            //    DataNascimento = new DateTime(),
            //    ProdutoId = 11,
            //    Produto = new Produto() { Nome = "Mesa", Valor = 50 }
            //};

            //var cliente2 = new Cliente()
            //{
            //    Nome = "Nicolas", 
            //    Sobrenome = "Oliveira", 
            //    Email = "Nicolas@hotmail.com", 
            //    Ativo = false,
            //    DataNascimento = new DateTime(),
            //    ProdutoId = 11,
            //    Produto = new Produto() { Nome = "Sofa", Valor = 100 }
            //};

            //_clienteRepository = new ClienteRepository();
            //_clienteRepository.Add(cliente);
            //_clienteRepository.Add(cliente1);
            //_clienteRepository.Add(cliente2);
        }

        private void CriarMassaUsuario()
        {
            //var usuario = new UsuarioDomain()
            //{
            //    Nome = "Jhoni de Oliveira Barros",
            //    Cpf = 42053581888,
            //    Email = "Jhoni_jk@hotmail.com",
            //    DataPrimeiroAcesso = DateTime.Now,
            //    DataUltimoAcesso = DateTime.Now,
            //    PrimeiroAcesso = true,
            //    Senha = new Criptografia().Encrypt(SenhaPadrao)
            //};

            _usuarioRepository = new UsuarioRepository();
            //_usuarioRepository.Add(usuario);
        }

        #endregion
    }
}
