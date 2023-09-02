using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilManager
{
    static class StructHolder
    {
        public struct SelectedItem
        {
            public int row;
            public string name;
            public Label label;
            public void Select(int _Row, string _Name, Label _Label)
            {
                row = _Row;
                name = _Name.Trim();
                label = _Label;
                label.Text = _Name.Trim();
            }
            public void Select(int _Row, string _Name)
            {
                row = _Row;
                name = _Name.Trim();
                label.Text = _Name.Trim();
            }
            public void Reset()
            {
                name = "-";
                row = -1;
            }

            public bool IsNull()
            {
                if (name == "-")
                {
                    return true;
                }
                return false;
            }

        }

    }
}
