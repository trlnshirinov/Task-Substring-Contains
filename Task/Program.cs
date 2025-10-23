

#region CustomSubstring methodu
internal class Program
{
    static string CustomSubstring(string text, int startIndex)
    {
        string result = "";

        for (int i = startIndex; i < text.Length; i++)
        {
            
              


            result += text[i];
        }
        return result;


    }


    static void Main()
    {
        string text = "Azerbaycan respublikasi";

        string newText = CustomSubstring(text, 11);

        Console.WriteLine(newText);
    }
}
#endregion

#region CustomContains methodu
//using System;

//class Program
//{
//    static bool CustomContains(string soz, string herf)
//    {
//        soz = CustomToLower(soz); 
//        herf = CustomToLower(herf); 

//        if (herf.Length > soz.Length)
//            return false;

//        for (int i = 0; i <= soz.Length - herf.Length; i++)
//        {
//            bool found = true;

//            for (int j = 0; j < herf.Length; j++)
//            {
//                if (soz[i + j] != herf[j])
//                {
//                    found = false;
//                    break;
//                }
//            }

//            if (found)
//                return true;
//        }

//        return false;
//    }

//    public static string CustomToLower(string soz)
//    {
//        string result = "";

//        foreach (char c in soz)
//        {
//            if (c >= 'A' && c <= 'Z')
//            {
//                result += (char)(c + 32);
//            }
//            else
//            {
//                result += c;
//            }
//        }

//        return result;
//    }

//    static void Main()
//    {
//        string cumle = "Bu bir custom contains methodudur";
//        string soz = "b";

//        bool netice = CustomContains(cumle, soz);

//        Console.WriteLine(netice);
//    }
//}
#endregion