namespace CSharpDiscovery.Quest02
{
    public class SortTable_Exercice
    {
        public static int[] SortTable(int[] tab)
        {
            int temp;
  
            for (int i = 0; i < tab.Length - 1; i++){
                
                for (int j = i + 1; j < tab.Length; j++){
    
                    if (tab[i] > tab[j]) {
    
                        temp = tab[i];
                        tab[i] = tab[j];
                        tab[j] = temp;
                    }
                }
            }

            return tab ;
        }
    }
}