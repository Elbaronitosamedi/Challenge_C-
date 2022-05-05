using System;
using System.Collections.Generic;
using System.Collections;

namespace CSharpDiscovery.Quest02
{
    public class SecretSanta_Exercice
    {
        public static Dictionary<string,string> SecretSantaDraw(HashSet<string> people)
        {
            Dictionary<string,string> output = new Dictionary<string, string>();
            string[] people2 = new string[8];
            people.CopyTo(people2);
            int[] randomIndex = Rand();
            for(int i=0; i<8; i++){
                output.Add(people2[i], people2[randomIndex[i]]);
            }
            return output;
        }

        private static int[] Rand()
        {
            HashSet<int> hash = new HashSet<int>{};
            int[] output = new int[8];

            Random i = new Random();
            while(hash.Count!=8){
                hash.Add(i.Next(8));
            }
            hash.CopyTo(output);
            for(int num=0; num<8; num++){
                if(num==output[num]){
                    output = Rand();
                    break;
                }
            }
            return output;
        }
    }
}