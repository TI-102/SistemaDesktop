using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace QrCode
{
    public partial class frmMesas : Form
    {
        public frmMesas()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisar abrir = new frmPesquisar();
            this.Hide();
            abrir.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }
        private string idPesquisado;
        private static string _fname;
        private static byte[] photo;
        private void limparTudo()
        {

            
            pctQrcode.Image = null;
            _fname = null;
            txtCodigo.Text = null;
            txtNumero.Text = null;
            txtNumero.Focus();
            btnCadastrar.Enabled = false;
        }
        private byte[] GetPhoto(string filePath)
        {

            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                photo = br.ReadBytes((int)fs.Length);

                br.Close();
                fs.Close();

            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Por favor, insira uma imagem.");
            }
            return photo;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlCommand comm = new MySqlCommand();
            photo = GetPhoto(_fname);
            try
            {
                comm.CommandText = "insert into tbmesas (numero,qrcode) values (@numero,@qrcode);";
                comm.CommandType = CommandType.Text;
                comm.Parameters.Clear();
                comm.Parameters.Add("@numero", MySqlDbType.Int32).Value = txtNumero.Text;
                if (photo != null)
                {
                comm.Parameters.Add("@qrcode", MySqlDbType.LongBlob, photo.Length).Value = photo;
                }
                comm.CommandType = CommandType.Text;
                comm.Connection = Conexao.obterConexao();
                int res = comm.ExecuteNonQuery();
                Conexao.fecharConexao();

            }
            catch(Exception erro)
            {
                Conexao.fecharConexao();
                    
                MessageBox.Show(erro.Message);
            }
            limparTudo();
        }
        
        

        private void btnInserir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Photo";
            dlg.Filter = "All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pctQrcode.Image = new Bitmap(dlg.OpenFile());
                    _fname = dlg.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to load file: " + ex.Message);
                }
            }
            dlg.Dispose();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "UPDATE tbmesas SET numero = @numero WHERE id = " + txtCodigo.Text;
                comm.CommandType = CommandType.Text;
                comm.Connection = Conexao.obterConexao();
                comm.Parameters.Clear();
                comm.Parameters.Add("@numero", MySqlDbType.Int32).Value =
                txtNumero.Text;
                int res = comm.ExecuteNonQuery();
                Conexao.fecharConexao();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocorreu uma falha: " + error.Message);

                Conexao.fecharConexao();
            }
            limparTudo();
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "DELETE FROM tbmesas WHERE id=@codigo";
                comm.CommandType = CommandType.Text;
                comm.Connection = Conexao.obterConexao();
                comm.Parameters.Clear();
                comm.Parameters.Add("@codigo", MySqlDbType.Int32).Value =
                txtCodigo.Text;
                DialogResult vresp;
                vresp = MessageBox.Show("Deseja Realizar a Exclusão?", "Mensagem do " +
                    "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
                if (vresp == DialogResult.Yes)
                {
                    int res = comm.ExecuteNonQuery();
                    MessageBox.Show("Registro Excluido com Sucesso!!! ");
                    comm.Parameters.Clear();
                    pctQrcode.Image = null;
                    btnInserir.Enabled = true;
                    btnInserir.Focus();
                    
                    btnCadastrar.Enabled = true;
                    txtCodigo.Text = null;
                }
                else if (vresp == DialogResult.No)
                {
                    comm.Parameters.Clear();
                    Conexao.fecharConexao();
                    btnInserir.Enabled = true;
                    
                    txtCodigo.Text = null;
                    txtNumero.Text = null;
                    pctQrcode.Image = null;
                }
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocorreu uma falha do tipo " + error.Message);

                Conexao.fecharConexao();

            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            if(txtNumero.Text != null)
            {
                btnCadastrar.Enabled = true;
            }
            else
            {
                btnCadastrar.Enabled = false;
            }
        }
        private void frmMesas_Load(object sender, EventArgs e)
        {
            limparTudo();
            txtNumero.Focus();
            frmPesquisar frmPesquisar = new frmPesquisar();
            idPesquisado = frmPesquisar.itemPesquisado;
            txtCodigo.Text = idPesquisado;


            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "select * from tbmesas where id=" + txtCodigo.Text;
                comm.CommandType = CommandType.Text;
                comm.Connection = Conexao.obterConexao();
                MySqlDataReader DR;
                DR = comm.ExecuteReader();


                while (DR.Read())
                {
                    txtNumero.Text = DR.GetString(1);
                    

                    byte[] img = (byte[])DR["qrcode"];

                    MemoryStream ms = new MemoryStream(img);

                    ms.Seek(0, SeekOrigin.Begin);

                    pctQrcode.Image = Image.FromStream(ms);


                }

            }
            catch (Exception erro)
            {
                
            }

            frmPesquisar.itemPesquisado = null;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals(null))
            {
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnInserir.Enabled = true;
                lblMsg.Text = "";
            }
            else
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnInserir.Enabled = false;
                lblMsg.Text = "Para Alterar imagem, clique em deletar.";
            }
        }
    }
}
