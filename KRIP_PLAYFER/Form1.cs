using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRIP_PLAYFER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Shifr_Click(object sender, EventArgs e)
        {
            char[] text = Text.Text.ToCharArray();
            char[] shifr = Text.Text.ToCharArray();
            char[] ALPHA = "ABCDEFGHIJKLMNOPQRSTUVWXYZ 123456789".ToCharArray();
            char[] alpha = "abcdefghijklmnopqrstuvwxyz 123456789".ToCharArray();
            char[] alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя .,".ToCharArray();
            char[] ALPH = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ .,".ToCharArray();
            char[] key = keyBox.Text.ToCharArray();
            List<char> text_2 = new List<char>();

            char[,] table_lat = new char[6, 6];
            int k = 0, z = 0; bool check = false;
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < ALPHA.Length; j++)
                {
                    if(key[i] == ALPHA[j])
                    {
                        check = true;
                        table_lat[k, z] = key[i];
                        z++;
                        if(z == 6)
                        {
                            z = 0;
                            k++;
                        }
                    }
                }
            }

            if (check)
            {
                for (int i = 0; i < ALPHA.Length; i++)
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        if (key[j] == ALPHA[i])
                            check = false;
                    }
                    if (check)
                    {
                        table_lat[k, z] = ALPHA[i];
                        z++;
                        if (z == 6)
                        {
                            z = 0;
                            k++;
                        }
                    }
                    check = true;
                }
             
                for (int i = 0; i < text.Length;)
                {
                    if (i + 1 == text.Length)
                    {
                        text_2.Add(text[i]);
                        break;
                    }
                    if (text[i] == text[i + 1])
                    {
                        text_2.Add(text[i]);
                        text_2.Add('X');
                        i++;
                    }
                    else
                    {
                        text_2.Add(text[i]);
                        text_2.Add(text[i + 1]);
                        i = i + 2;
                    }
                }

                if (text_2.Count % 2 != 0)
                {
                    text_2.Add('X');
                }
            }

            k = 0; z = 0; check = false;
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < alpha.Length; j++)
                {
                    if (key[i] == alpha[j])
                    {
                        check = true;
                        table_lat[k, z] = key[i];
                        z++;
                        if (z == 6)
                        {
                            z = 0;
                            k++;
                        }
                    }
                }
            }

            if (check)
            {
                for (int i = 0; i < alpha.Length; i++)
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        if (key[j] == alpha[i])
                            check = false;
                    }
                    if (check)
                    {
                        table_lat[k, z] = alpha[i];
                        z++;
                        if (z == 6)
                        {
                            z = 0;
                            k++;
                        }
                    }
                    check = true;
                }

                for (int i = 0; i < text.Length;)
                {
                    if (i + 1 == text.Length)
                    {
                        text_2.Add(text[i]);
                        break;
                    }
                    if (text[i] == text[i + 1])
                    {
                        text_2.Add(text[i]);
                        text_2.Add('x');
                        i++;
                    }
                    else
                    {
                        text_2.Add(text[i]);
                        text_2.Add(text[i + 1]);
                        i = i + 2;
                    }
                }

                if (text_2.Count % 2 != 0)
                {
                    text_2.Add('x');
                }
            }

            k = 0; z = 0; check = false;
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < alph.Length; j++)
                {
                    if (key[i] == alph[j])
                    {
                        check = true;
                        table_lat[k, z] = key[i];
                        z++;
                        if (z == 6)
                        {
                            z = 0;
                            k++;
                        }
                    }
                }
            }

            if (check)
            {
                for (int i = 0; i < alph.Length; i++)
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        if (key[j] == alph[i])
                            check = false;
                    }
                    if (check)
                    {
                        table_lat[k, z] = alph[i];
                        z++;
                        if (z == 6)
                        {
                            z = 0;
                            k++;
                        }
                    }
                    check = true;
                }

                for (int i = 0; i < text.Length;)
                {
                    if (i + 1 == text.Length)
                    {
                        text_2.Add(text[i]);
                        break;
                    }
                    if (text[i] == text[i + 1])
                    {
                        text_2.Add(text[i]);
                        text_2.Add('х');
                        i++;
                    }
                    else
                    {
                        text_2.Add(text[i]);
                        text_2.Add(text[i + 1]);
                        i = i + 2;
                    }
                }

                if (text_2.Count % 2 != 0)
                {
                    text_2.Add('х');
                }
            }

            k = 0; z = 0; check = false;
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < ALPH.Length; j++)
                {
                    if (key[i] == ALPH[j])
                    {
                        check = true;
                        table_lat[k, z] = key[i];
                        z++;
                        if (z == 6)
                        {
                            z = 0;
                            k++;
                        }
                    }
                }
            }

            if (check)
            {
                for (int i = 0; i < ALPH.Length; i++)
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        if (key[j] == ALPH[i])
                            check = false;
                    }
                    if (check)
                    {
                        table_lat[k, z] = ALPH[i];
                        z++;
                        if (z == 6)
                        {
                            z = 0;
                            k++;
                        }
                    }
                    check = true;
                }

                for (int i = 0; i < text.Length;)
                {
                    if (i + 1 == text.Length)
                    {
                        text_2.Add(text[i]);
                        break;
                    }
                    if (text[i] == text[i + 1])
                    {
                        text_2.Add(text[i]);
                        text_2.Add('Х');
                        i++;
                    }
                    else
                    {
                        text_2.Add(text[i]);
                        text_2.Add(text[i + 1]);
                        i = i + 2;
                    }
                }

                if (text_2.Count % 2 != 0)
                {
                    text_2.Add('Х');
                }
            }

            char[] shifr_text = new char[text_2.Count];
            int j1 = 0, j2 = 0, k1 = 0, k2 = 0; z = 0; check = true;
            for(int i = 0; i < text_2.Count - 1; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (k = 0; k < 6; k++)
                    {
                        if (table_lat[j, k] == text_2[i])
                        {
                            j1 = j;
                            k1 = k;
                        }

                        if (table_lat[j, k] == text_2[i + 1])
                        {
                            j2 = j;
                            k2 = k;
                        }
                    }
                }
                    if (j1 == j2)
                    {
                        if (k1 + 1 == 6)
                            k1 = 0;
                        else
                            k1 = k1 + 1;

                        if (k2 + 1 == 6)
                            k2 = 0;
                        else
                            k2 = k2 + 1;
                        if (z == text_2.Count)
                            break;
                        shifr_text[z] = table_lat[j1, k1];
                        z++;
                        shifr_text[z] = table_lat[j2, k2];
                        z++;
                        check = false;
                    }

                    if(k1 == k2)
                    {
                        if (j1 == 5)
                            j1 = 0;
                        else
                            j1 = j1 + 1;

                        if (j2 == 5)
                            j2 = 0;
                        else
                            j2 = j2 + 1;
                        if (z == text_2.Count)
                            break;
                        shifr_text[z] = table_lat[j1, k1];
                        z++;
                        shifr_text[z] = table_lat[j2, k2];
                        z++;
                        check = false;
                    }

                    if (check)
                    {
                        if (z == text_2.Count)
                            break;
                        shifr_text[z] = table_lat[j1, k2];
                        z++;
                        shifr_text[z] = table_lat[j2, k1];
                        z++;
                    }
                    check = true;
                    i++;                
            }
            // IDIOCYOFTENLOOKSLIKEINTELLIGENCE


            string text1 = new string(shifr_text);
            ShifrText.Text = text1;
        }

        private void button_unShifr_Click(object sender, EventArgs e)
        {
            char[] shifr = Text.Text.ToCharArray();
          //  char[] text = Text.Text.ToCharArray();
            char[] ALPHA = "ABCDEFGHIJKLMNOPQRSTUVWXYZ 123456789".ToCharArray();
            char[] alpha = "abcdefghijklmnopqrstuvwxyz 123456789".ToCharArray();
            char[] alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя .,".ToCharArray();
            char[] ALPH = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ .,".ToCharArray();
            char[] key = keyBox.Text.ToCharArray();

            char[,] table_lat = new char[6, 6];
            int k = 0, z = 0; bool check = false;
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < ALPHA.Length; j++)
                {
                    if (key[i] == ALPHA[j])
                    {
                        check = true;
                        table_lat[k, z] = key[i];
                        z++;
                        if (z == 6)
                        {
                            z = 0;
                            k++;
                        }
                    }
                }
            }

            if (check)
            {
                for (int i = 0; i < ALPHA.Length; i++)
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        if (key[j] == ALPHA[i])
                            check = false;
                    }
                    if (check)
                    {
                        table_lat[k, z] = ALPHA[i];
                        z++;
                        if (z == 6)
                        {
                            z = 0;
                            k++;
                        }
                    }
                    check = true;
                }
            }

            k = 0; z = 0; check = false;
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < alpha.Length; j++)
                {
                    if (key[i] == alpha[j])
                    {
                        check = true;
                        table_lat[k, z] = key[i];
                        z++;
                        if (z == 6)
                        {
                            z = 0;
                            k++;
                        }
                    }
                }
            }

            if (check)
            {
                for (int i = 0; i < alpha.Length; i++)
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        if (key[j] == alpha[i])
                            check = false;
                    }
                    if (check)
                    {
                        table_lat[k, z] = alpha[i];
                        z++;
                        if (z == 6)
                        {
                            z = 0;
                            k++;
                        }
                    }
                    check = true;
                }
            }

            k = 0; z = 0; check = false;
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < alph.Length; j++)
                {
                    if (key[i] == alph[j])
                    {
                        check = true;
                        table_lat[k, z] = key[i];
                        z++;
                        if (z == 6)
                        {
                            z = 0;
                            k++;
                        }
                    }
                }
            }

            if (check)
            {
                for (int i = 0; i < alph.Length; i++)
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        if (key[j] == alph[i])
                            check = false;
                    }
                    if (check)
                    {
                        table_lat[k, z] = alph[i];
                        z++;
                        if (z == 6)
                        {
                            z = 0;
                            k++;
                        }
                    }
                    check = true;
                }
            }

            k = 0; z = 0; check = false;
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < ALPH.Length; j++)
                {
                    if (key[i] == ALPH[j])
                    {
                        check = true;
                        table_lat[k, z] = key[i];
                        z++;
                        if (z == 6)
                        {
                            z = 0;
                            k++;
                        }
                    }
                }
            }

            if (check)
            {
                for (int i = 0; i < ALPH.Length; i++)
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        if (key[j] == ALPH[i])
                            check = false;
                    }
                    if (check)
                    {
                        table_lat[k, z] = ALPH[i];
                        z++;
                        if (z == 6)
                        {
                            z = 0;
                            k++;
                        }
                    }
                    check = true;
                }
            }

            List<char> shifr_2 = new List<char>();
            for (int i = 0; i < shifr.Length; i++)
            {
                shifr_2.Add(shifr[i]);
            }



            char[] shifr_text = new char[shifr_2.Count];
            int j1 = 0, j2 = 0, k1 = 0, k2 = 0; z = 0; check = true;
            for (int i = 0; i < shifr_2.Count - 1; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (k = 0; k < 6; k++)
                    {
                        if (table_lat[j, k] == shifr_2[i])
                        {
                            j1 = j;
                            k1 = k;
                        }

                        if (table_lat[j, k] == shifr_2[i + 1])
                        {
                            j2 = j;
                            k2 = k;
                        }
                    }
                }
                if (j1 == j2)
                {
                    if (k1 == 0)
                        k1 = 5;
                    else
                        k1 = k1 - 1;

                    if (k2 == 0)
                        k2 = 5;
                    else
                        k2 = k2 - 1;
                    if (z == shifr_2.Count)
                        break;
                    shifr_text[z] = table_lat[j1, k1];
                    z++;
                    shifr_text[z] = table_lat[j2, k2];
                    z++;
                    check = false;
                }

                if (k1 == k2)
                {
                    if (j1 == 0)
                        j1 = 5;
                    else
                        j1 = j1 - 1;

                    if (j2 == 0)
                        j2 = 5;
                    else
                        j2 = j2 - 1;
                    if (z == shifr_2.Count)
                        break;
                    shifr_text[z] = table_lat[j1, k1];
                    z++;
                    shifr_text[z] = table_lat[j2, k2];
                    z++;
                    check = false;
                }

                if (check)
                {
                    if (z == shifr_2.Count)
                        break;
                    shifr_text[z] = table_lat[j1, k2];
                    z++;
                    shifr_text[z] = table_lat[j2, k1];
                    z++;
                }
                check = true;
                i++;
            }

            List<char> text_2 = new List<char>();
            for (int i = 0; i < shifr_text.Length; i++)
            {
                if(shifr_text[i] == 'X' || shifr_text[i] == 'x' || shifr_text[i] == 'Х' || shifr_text[i] == 'х')
                {
                    if (i + 1 == shifr_text.Length)
                        break;
                    text_2.Add(shifr_text[i + 1]);
                    i += 1;
                }
                else
                    text_2.Add(shifr_text[i]);
            
            }

            char[] text = new char[text_2.Count];
            for (int i = 0; i < text_2.Count; i++)
            {
                text[i] = text_2[i];
            }

                string text1 = new string(text);
            ShifrText.Text = text1;
        }
    }
}
