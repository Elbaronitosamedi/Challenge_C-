using System;

namespace CSharpDiscovery.Quest02
{
    public class FindLastIndex_Exercice
    {
        public static int? FindLastIndex(int[] tab, int a)
        {
           if (tab != null){
                int result = Array.LastIndexOf(tab, a);
                if (result == -1){
                    return null;
                }else {
                    return result;
                }
           } else {
               return null;
           }
        }
    }
}