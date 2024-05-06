using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace DocsReader
{
    public partial class Form1 : Form
    {
        private string _xmlPath;
        private XDocument _doc;
        private string _nodePath;
        private string _node;
        private int _icon;
        public Form1()
        {
            InitializeComponent();
            _xmlPath = @"..\..\Docs\TestDoc\Content.xml";
            _doc = XDocument.Load( _xmlPath );
        }

        private void LoadContent()
        {
            var root = _doc.Element( "root" );
            TreeNode rootNode = new TreeNode(root.Attribute("name").Value);
            var chapters = root.Elements("chapter");
            foreach ( var chapter in chapters )
            {
                TreeNode chapterNode = new TreeNode(chapter.Attribute("name").Value);

                var paragraphs = chapter.Elements("paragraph");
                foreach ( var paragraph in paragraphs )
                {
                    TreeNode paragraphNode = new TreeNode(paragraph.Attribute("name").Value);
                    chapterNode.Nodes.Add(paragraphNode);
                }
                rootNode.Nodes.Add(chapterNode);
            }

            ContentView.Nodes.Add(rootNode);
            ContentView.ExpandAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadContent();
        }

        private void ContentView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _node = ContentView.SelectedNode.Text;
            _nodePath = @"..\..\Docs\TestDoc\" + _node + ".rtf";
            if (!File.Exists(_nodePath))
            {
                MessageBox.Show("Selected chapter does not exist");
            }
            else
            {
                TextView.LoadFile(_nodePath);
            }

        }
    }
}
