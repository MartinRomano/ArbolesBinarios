using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles
{
    public partial class Form1 : Form
    {

        Nodo Raiz = new Nodo("A", new Nodo("B", new Nodo("D", null, null), new Nodo("E", null, null)), new Nodo("C", new Nodo("F", null, null), new Nodo("G", null, null)));

        public Form1()
        {
            InitializeComponent();
        }

        private void RecorridoPreOrden(Nodo pNodo)
        {
            if (pNodo != null)
            {
                //V 
                this.txtPreOrden.Text += pNodo.Nombre + " - ";
                //Izquierda
                this.RecorridoPreOrden(pNodo.Izq);
                //Derecha
                this.RecorridoPreOrden(pNodo.Der);
            }
        }

        private void RecorridoPosOrden(Nodo pNodo)
        {
            if (pNodo != null)
            {
                //Izquierda
                this.RecorridoPosOrden(pNodo.Izq);              
                //Derecha
                this.RecorridoPosOrden(pNodo.Der);
                //V 
                this.txtPosOrden.Text += pNodo.Nombre + " - ";
            }
        }

        private void RecorridoInOrden(Nodo pNodo)
        {
            if (pNodo != null)
            {
                //Izquierda
                this.RecorridoInOrden(pNodo.Izq);
                //V 
                this.txtInOrden.Text += pNodo.Nombre + " - ";                
                //Derecha
                this.RecorridoInOrden(pNodo.Der);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.txtPreOrden.Clear();
            this.RecorridoPreOrden(this.Raiz);
            this.txtPreOrden.Text = this.txtPreOrden.Text.Substring(0, this.txtPreOrden.TextLength - 2);
            this.TreeView3.Nodes.Clear();
            this.MostrarTreeView(this.Raiz, null, this.TreeView3);
            this.TreeView3.ExpandAll();
        }

        private void MostrarTreeView(Nodo pNodo, TreeNode pTreeNode, TreeView pTreeView)
        {
            if (pNodo != null)
            {
                TreeNode NodoTemp = new TreeNode(pNodo.Nombre);
                if (pTreeNode == null)
                {
                    pTreeView.Nodes.Add(NodoTemp);
                }
                else
                {
                    pTreeNode.Nodes.Add(NodoTemp);
                }
                this.MostrarTreeView(pNodo.Der, NodoTemp, pTreeView);
                this.MostrarTreeView(pNodo.Izq, NodoTemp, pTreeView);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.TreeView1.Nodes.Clear();

            TreeNode AA = new TreeNode("A");
            TreeNode BB = new TreeNode("B");
            TreeNode CC = new TreeNode("C");
            TreeNode DD = new TreeNode("D");
            TreeNode EE = new TreeNode("E");
            TreeNode FF = new TreeNode("F");
            TreeNode GG = new TreeNode("G");

            AA.Nodes.Add(CC);
            AA.Nodes.Add(BB);
            BB.Nodes.Add(EE);
            BB.Nodes.Add(DD);
            CC.Nodes.Add(GG);
            CC.Nodes.Add(FF);
            
            this.TreeView1.Nodes.Add(AA);
            AA.ExpandAll();
        }

        private void Button2_Click(object sender, EventArgs e)
        {            
            if ((this.TreeView2.SelectedNode != null))
            {
                this.TreeView2.SelectedNode.Nodes.Add(new TreeNode(Interaction.InputBox("Ingrese Nombre")));
            }
            else
            {
                this.TreeView2.Nodes.Add(new TreeNode(Interaction.InputBox("Ingrese Nombre")));
            }
            this.TreeView2.ExpandAll();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if ((this.TreeView2.SelectedNode != null))
            {
                this.TreeView2.SelectedNode.Remove();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.txtInOrden.Clear();
            this.RecorridoInOrden(this.Raiz);
            this.txtInOrden.Text = this.txtInOrden.Text.Substring(0, this.txtInOrden.TextLength - 2);
            this.TreeView4.Nodes.Clear();
            this.MostrarTreeView(this.Raiz, null, this.TreeView4);
            this.TreeView4.ExpandAll();
        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.txtPosOrden.Clear();
            this.RecorridoPosOrden(this.Raiz);
            this.txtPosOrden.Text = this.txtPosOrden.Text.Substring(0, this.txtPosOrden.TextLength - 2);
            this.TreeView5.Nodes.Clear();
            this.MostrarTreeView(this.Raiz, null, this.TreeView5);
            this.TreeView5.ExpandAll();
        }
    }
}
