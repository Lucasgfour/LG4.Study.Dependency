using LG4.Study.ApplicationDesktop.Controllers;
using LG4.Study.ApplicationDesktop.Interfaces;
using LG4.Study.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LG4.Study.ApplicationDesktop.Forms {
    public partial class A001_Home_Page : Form {

        private readonly IPessoaController _pessoaController;

        private Pessoa? pessoa;

        public A001_Home_Page(IPessoaController pessoaController) {
            
            _pessoaController = pessoaController;

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e) {

            pessoa = _pessoaController.GetById(int.Parse(txt_codigo.Text));

            ShowInfo();

        }

        private void ShowInfo() {

            if(pessoa == null) {

                this.Controls.OfType<TextBox>().ToList().ForEach((txt) => {
                    txt.Text = "";
                });

                return;

            }

            txt_codigo.Text = pessoa.id.ToString();

            txt_nome.Text = pessoa.name;

            txt_email.Text = pessoa.email;

            txt_telefone.Text = pessoa.phone;

        }

        private void button2_Click(object sender, EventArgs e) {

            _pessoaController.Delete(int.Parse(txt_codigo.Text));

            pessoa = null;

            ShowInfo();

        }

        private void button3_Click(object sender, EventArgs e) {

            if (pessoa == null)
                return;

            pessoa.id = 0;
            pessoa.name = txt_nome.Text;
            pessoa.email = txt_email.Text;
            pessoa.phone = txt_telefone.Text;

            _pessoaController.Add(pessoa);

        }

        private void button4_Click(object sender, EventArgs e) {

            if (pessoa == null)
                return;

            pessoa.name = txt_nome.Text;
            pessoa.email = txt_email.Text;
            pessoa.phone = txt_telefone.Text;

            _pessoaController.Update(pessoa);

            button1.PerformClick();

        }
    }
}
