using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentManagementSystem.Controller
{
    internal class ValidationClass 
    {
        public bool valkalimat(string inp)
        {
            for(int i = 0; i < inp.Length; i++)
            {
                if (inp[0] == ' ' || inp[inp.Length - 1] == ' ')
                {
                    MessageBox.Show("Input String field", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (inp[i] == ' ' && inp[i + 1] == ' ')
                {
                    MessageBox.Show("Input String field", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        public bool valHp(string inp)
        {
            for (int a = 0; a < 13;a++)
            {
                if (inp.Length >= 13)
                {
                    MessageBox.Show("Input Phone field", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }         
            return true;

        }
        public bool valCodeComp(string x)
        {
            if(x.Length == 2)
            {
                MessageBox.Show("Input CodeCompetency field", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        public bool valName(string name)
        {
            for(int a = 0;a < name.Length; a++)
            {
                if ((name[a] >= '0' && name[a] <= '9') || name[0] == ' ' || name[name.Length - 1] == ' ' || name[a] == ':' ||
                    name[a] == ',' || name[0] == '-' || name[name.Length - 1] == '-' || name[a] == '/' || name[a] == '\\' || name[a] == '?')
                {
                    MessageBox.Show("Input Name field", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        public bool valAlamat(string alamat)
        {
            for (int a = 0; a < alamat.Length; a++)
            {
                if ((alamat[a] >= '0' && alamat[a] <= '9') || alamat[0] == ' ' || alamat[alamat.Length - 1] == ' ' || alamat[a] == ':' ||
                    alamat[a] == ',' || alamat[0] == '-' || alamat[alamat.Length - 1] == '-' || alamat[a] == '/' || alamat[a] == '\\' || alamat[a] == '?')
                {
                    MessageBox.Show("Input Address/Kota field", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        public bool score(string score)
        {
            if (score.Length >= 2)
            {
                MessageBox.Show("Input score field", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
             return true;
        }
        public bool valNis(string nis)
        {
            for (int i = 0; i <= nis.Length + 1; i++)
            {
                if (nis.Length == 10)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Input NIS field", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;                   
                }
            }
            return true;
        }

        public bool valNip(string nip)
        {
            for (int i = 0; i <= nip.Length; i++)
            {
                if (nip.Length == 9)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Input NIP field", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        public bool valcodSubj(string n)
        {
            for (int i = 0; i <= n.Length; i++)
            {
                if (n.Length <= 3)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Input Code Subjects field", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        public bool hour (string h)
        {
            for (int a = 0; a < h.Length; a++)
            {
                if (h.Length >=2 )
                {
                    MessageBox.Show("Input Hour field", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

    }
}
