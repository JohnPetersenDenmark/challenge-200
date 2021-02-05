using System;
using System.Collections.Generic;
using System.Text;

namespace BLUEFRAGMENT.Challenge100
{
    class Challenge200
    {

        public string Maskify(string stringToMaskify)
        {
            if (stringToMaskify.Length < 4)
                return stringToMaskify;

            string StringNotToMask = stringToMaskify.Substring(stringToMaskify.Length - 4);
            return StringNotToMask.PadLeft(stringToMaskify.Length, '#');
        }

        public string isPrime(int[] primeNumbers, int integerToTestIfPrime)
        {
            Array.Sort(primeNumbers);

            if (Array.BinarySearch(primeNumbers, integerToTestIfPrime) > (-1))
            {
                return "yes";
            }

            return "no";
        }

        public int Potatoes(string potatoString)
        {
            int index = 0;
            int lastPosInSourceString = potatoString.Length - 1;
            string searchTerm = "potato";
            int numberOfOccurences = 0;

            while (true)
            {
                int pos = potatoString.IndexOf(searchTerm, index, StringComparison.InvariantCultureIgnoreCase);
                if (pos == (-1))
                {
                    break;
                }
                else
                {
                    numberOfOccurences++;
                    index = pos + searchTerm.Length;
                    if (index >= lastPosInSourceString)
                    {
                        break;
                    }
                }
            }
            return numberOfOccurences;
        }

        public int[] Encrypt(string stringToEncrypt)
        {
           
            int[] encryptedArray = new int[stringToEncrypt.Length];
            int index = 0;

            char[] arrToEncrypt = stringToEncrypt.ToCharArray();

            foreach (var character in arrToEncrypt)
            {
                if ( index == 0)
                {
                    encryptedArray[index] = (int)character;
                }
                else
                {
                    encryptedArray[index] = (int)character - (int)arrToEncrypt[index - 1];
                }
                index++;
            }

            return encryptedArray;
        }

        public string decrypt(int[] arrayToDecrypt)
        {
            int index = 0;
            char[] decryptedArray = new char[arrayToDecrypt.Length];

            foreach (var integerValue in arrayToDecrypt)
            {
                if (index == 0)
                {
                    decryptedArray[index] = (char)(integerValue);
                }
                else
                {
                    int tmpInt = decryptedArray[index - 1]  + integerValue;

                    char tmpChar = (char)tmpInt;
                    decryptedArray[index] = tmpChar;
                }
                index++;
            }

            string tmpStr = String.Join("", decryptedArray);
            return String.Join( "",decryptedArray);
        }

    }
}
