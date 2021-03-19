using Bunifu.UI.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmClearance
    {
        public FrmClearance()
        {
            InitializeComponent();
            _TreeView1.Name = "TreeView1";
            _saveBunifuButton.Name = "saveBunifuButton";
            _noBunifuButton.Name = "noBunifuButton";
        }

        private void TouchButton1_Load(object sender, EventArgs e)
        {
            Label1.Text = "Saving permissions...";
            Label1.Refresh();
            // selectParentNode()
            MdlModifyData.saveClearance(My.MyProject.Forms.FrmEmployeeManagement.BunifuDataGridView1);
            Label1.Text = "Success";
            Label1.BackColor = Color.Green;
            Label1.Refresh();
            MdlControllerModifier.pause(500);
            Close();
        }

        private void selectParentNode()
        {
            foreach (TreeNode rootNode in TreeView1.Nodes)
            {
                int childNodeIndex = 0;
                foreach (TreeNode node in (IEnumerable)rootNode.Nodes)
                {
                    if (node.Text.Equals("See Employee Details"))
                    {
                        if (Conversions.ToBoolean(node.Nodes[0].Checked))
                        {
                            node.Nodes[childNodeIndex].Checked = true;
                        }
                    }

                    if (Conversions.ToBoolean(rootNode.Nodes[childNodeIndex].Checked))
                    {
                        rootNode.Checked = true;
                        break;
                    }

                    childNodeIndex += 1;
                }
            }
        }

        private BunifuDataGridView employeDataGridView;

        private void FrmClearance_Load(object sender, EventArgs e)
        {
            employeDataGridView = My.MyProject.Forms.FrmEmployeeManagement.BunifuDataGridView1;
            int selectedRow = employeDataGridView.CurrentCell.RowIndex;
            string firstName = Conversions.ToString(employeDataGridView.Rows[selectedRow].Cells[1].Value);
            string lastName = Conversions.ToString(employeDataGridView.Rows[selectedRow].Cells[2].Value);
            Label1.Text = "Check all functionalities you wish to grant to " + firstName + " " + lastName;
        }

        private bool selectAll = true;

        private void SelectChildNodes(TreeNode node, bool checkAllChild)
        {
            int childNodeIndex = 0;
            foreach (TreeNode childNode in node.Nodes)
            {
                if (checkAllChild)
                {
                    childNode.Checked = true;
                }
                else
                {
                    childNode.Checked = false;
                }

                childNodeIndex += 1;
            }

            selectAll = false;
        }

        private void TreeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {

            // If e.Node.Parent IsNot Nothing Then
            // e.Node.Parent.Checked = True
            // End If
            SelectChildNodes(e.Node, e.Node.Checked);
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}