﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.FolderMajor
{
    public class fsEdit
    {
        public string deleteCharacter1(string delete)
        {
            //ListViewItem:{need}

            string ItemLength = delete.Substring(17);
            string character = "ABCDFGHJKLQWERTYUIOPZXCVBNMabcdfghjklqwertyuiopzxcvbnm 0123456789/:@.-";


            string ItemChanged = "";
            for (int i = 0; i < ItemLength.Length; i++)
            {
                for (int j = 0; j < character.Length; j++)
                {
                    if (character[j] == ItemLength[i])
                    {
                        ItemChanged += character[j];
                        break;
                    }
                }
            }
            return ItemChanged;

        }

        public string deleteCharacter(string delete)
        {
            //ListViewItem:{need}

            string ItemLength = delete.Substring(17);
            string character = " ABCDFGHJKLQWERTYUIOPZXCVBNM01234567890";


            string ItemChanged = "";
            for (int i = 0; i < ItemLength.Length; i++)
            {
                for (int j = 0; j < character.Length; j++)
                {
                    if (character[j] == ItemLength[i])
                    {
                        ItemChanged += character[j];
                        break;
                    }
                }
            }
            return ItemChanged;
        }
    }
}