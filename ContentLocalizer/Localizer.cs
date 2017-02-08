using Independentsoft.Office.Spreadsheet;
using System;

namespace ContentLocalizer
{
    public class Localizer
    {
        static Worksheet tmpSheet = null;
        public Worksheet GetLocalizedFile()
        {
            if (tmpSheet == null)
            {
                Workbook tmpBook= new Workbook(GlobalMacro.MacroData.solutionDir + GlobalMacro.MacroData.m_localizedData);
                tmpSheet = (Worksheet)tmpBook.Sheets[0];
                if (tmpSheet == null)
                {
                    Console.WriteLine("Localized file is NULL");
                }
            }
            return tmpSheet;
        }
    }
}
