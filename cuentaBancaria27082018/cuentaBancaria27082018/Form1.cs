using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuentaBancaria27082018
{
    public partial class Form1 : Form
    {
        Cuenta user;
      
        public Form1()
        {
            user = new Cuenta();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            user.ingSaldo = 1200;
            tbSaldo.Text = ("$" + Convert.ToString(user.ingSaldo));
            user.nombre = "Fernando G. Fdz.";
            tbName.Text = user.nombre;
            
        }

        static void comprueba(object sender, EventArgs e)
        {
            Cuenta prueba = (Cuenta)sender;
            MessageBox.Show("El retiro fue mayor a 500");
        }

        static void deposita(object sender, EventArgs e)
        {
            Cuenta dep = (Cuenta)sender;
            MessageBox.Show("se deposito fue de:" );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                retiroDin = Convert.ToInt32(tbRetiro.Text); 
                user.cambio += new EventHandler(comprueba);
                tbSaldo.Text = ("$" + Convert.ToString(al));
                user.ingRetiro = retiroDin;
                
               // user.cambio += new EventHandler(comprueba);
                
            }catch(Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dep = Convert.ToInt32(tbDepositar.Text);
                user.ingresaDep(dep);
                
                MessageBox.Show("retiro exitoso :'v");
                user.deposita += new EventHandler(deposita);

            }
            catch(Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
    }
}
