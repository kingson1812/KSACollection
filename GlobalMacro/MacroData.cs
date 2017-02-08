using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GlobalMacro
{
    public class MacroData
    {
        public static string solutionDir = Directory.GetCurrentDirectory() + "/../../../";
        public static string m_localizedData = "Data/LocalizationContent.xlsx";

        public static string[] m_listPrograms = new string[] 
        {
            "Mass rename",
            "Random lucky number"
        };

        public static string[] m_languageFlags = new string[]
        {
           MacroData.solutionDir + "Data/Flags/VI.png",
           MacroData.solutionDir +  "Data/Flags/EN.png"
        };
    }
}
