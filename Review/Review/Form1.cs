using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Review
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

        private void button1_Click(object sender, EventArgs e)
        {
            Character npc = new Player();
            //Player player = new Player();//ON FINAL must have new keyword
        }
    }

    class Character
    {
        private string name; //member variable/field

        //Property
        public string Name
        {
            get { return name; }
        }

        public string GetName()
        {
            return name;
        }

        public virtual void Attack() //has to be virtual for children to inherit
        {

        }

        public void Attack(int damage)//overloaded function
        {

        }


    }

    class Player : Character
    {
        public override void Attack() //Overrides and virtuals, needed for inheriting from parent class
        {

        }
        
    }
}
