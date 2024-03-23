using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerPigeon
{
    public class CaesarCipher
    {
        private string CodeEncode(string text, int k=7)
        {
            const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //добавляем в алфавит маленькие буквы
            var fullAlfabet = alfabet + alfabet.ToLower();
            int letterQty = fullAlfabet.Length;
            string retVal = "";
            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                var index = fullAlfabet.IndexOf(c);
                if (index < 0)
                {
                    //если символ не найден, то добавляем его в неизменном виде
                    retVal += c.ToString();
                }
                else
                {
                    var codeIndex = (letterQty + index + k) % letterQty;
                    retVal += fullAlfabet[codeIndex];
                }
            }

            return retVal;
        }

        //шифрование текста
        public string Encrypt(string plainMessage)
            => CodeEncode(plainMessage);

        //дешифрование текста
        public string Decrypt(string encryptedMessage)
            => CodeEncode(encryptedMessage, -7);
    }
}
