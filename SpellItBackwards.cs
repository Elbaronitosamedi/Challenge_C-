namespace CSharpDiscovery.Quest01
{
    public class SpellItBackwards_Exercice
    {
        public static string SpellItBackward(string str)
        {
            char[] arr;
            arr = str.ToCharArray();
            string reverse = "";
            for (int i = arr.Length - 1; i > -1; i--)
            {
                reverse += arr[i];
            }
            return(reverse);
            }
        }
}