namespace CSharpDiscovery.Quest02
{
    public class ContainsThisValue_Exercice
    {
        public static bool ContainsThisValue(int[] tab, int value)
        {
            if (tab != null) {

                foreach(int n in tab){
                    if(n == value){
                        return true;
                    }
                }
                return false;
            }else{
                return false;
            }
        }
    }
}