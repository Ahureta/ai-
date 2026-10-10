using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, Lazy<AntdUI.IControl>> _pages =
            new Dictionary<string, Lazy<AntdUI.IControl>>(StringComparer.OrdinalIgnoreCase);
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        private void Init() {
            AntdUI.Select select3 = new AntdUI.Select();

            _pages["select3"] = new Lazy<AntdUI.IControl>(() => new AntdUI.Select());
            
            //select1.Items.Add(new AntdUI.SelectItem("two")
            //{ Sub = new List<object> { "five menu item", "six six six menu item" } });

            select1.Items.AddRange(new AntdUI.SelectItem[] {
                new AntdUI.SelectItem("one"){
                    Sub = new List<object>{
                        new AntdUI.SelectItem("子菜单1"){
                            Sub=new List<object>{ new AntdUI.SelectItem("sub menu") {
                                Sub=new List<object>{
                                    "one st menu item","two nd menu item","three rd menu item"
                                }
                            } }
                        }.SetText("子菜单1","Select.sub menu 1"),
                        new AntdUI.SelectItem("子菜单2").SetText("子菜单2","Select.sub menu 2")
                    }
                },
                new AntdUI.SelectItem("two"){ Sub=new List<object>{ "five menu item", "six six six menu item"} },
            });
        }


    }
}
