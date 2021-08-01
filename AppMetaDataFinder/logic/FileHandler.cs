using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ClosedXML.Excel;
using MobilityAppVersionFinder.data;

namespace MobilityAppVersionFinder.logic
{
    class FileHandler
    {
        public string FileName { get; set; }
        List<App> Apps;

        public List<App> ParseFile()
        {
            try
            {
                XLWorkbook workbook = new XLWorkbook(FileName);
                IXLWorksheet worksheet = workbook.Worksheet("Mobilitätsanwendungen");
                IXLTable table = worksheet.Table("Apps");

                Apps = new List<App>();

                foreach (IXLTableRow row in table.DataRange.Rows())
                {
                    App app = new App();
                    app.Name = row.Cell(1).GetString();
                    app.AndroidURL = row.Cell(7).GetString();
                    app.IOSURL = row.Cell(8).GetString();
                    app.AndroidVersionOld = row.Cell(9).GetString();
                    app.IOSVersionOld = row.Cell(10).GetString();

                    Apps.Add(app);
                }

                return Apps;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<App> CheckVersions()
        {
            foreach (App app in Apps)
            {
                if(!app.AndroidURL.Equals(""))
                {
                    using (WebClient client = new WebClient())
                    {
                        client.Encoding = System.Text.Encoding.UTF8;

                        string date = "";
                        string version = "";

                        string htmlCode = client.DownloadString(app.AndroidURL);

                        string patternDate = @"itemprop=""datePublished"">(.*?)<\/div>";
                        Match match = Regex.Match(htmlCode, patternDate);
                        date = match.Groups[1].Value;

                        string patternVersion = @"itemprop=""softwareVersion"">(.*?)<\/div>";
                        Match match2 = Regex.Match(htmlCode, patternVersion);
                        version = match2.Groups[1].Value.Trim();

                        app.AndroidVersionNew = date + " (Version " + version + ")";
                    }
                }
          
                if(!app.IOSURL.Equals(""))
                {
                    using (WebClient client = new WebClient())
                    {
                        client.Encoding = System.Text.Encoding.UTF8;

                        string date = "";
                        string version = "";

                        try
                        {
                            string htmlCode = client.DownloadString(app.IOSURL);

                            string patternDate = @"class=""version-history__item__release-date"">(.*?)<\/time>";
                            Match match = Regex.Match(htmlCode, patternDate);
                            date = match.Groups[1].Value;

                            string patternVersion = @"<h4 class=""version-history__item__version-number"">(.*?)<\/h4>";
                            Match match2 = Regex.Match(htmlCode, patternVersion);
                            version = match2.Groups[1].Value;

                            app.IOSVersionNew = date + " (Version " + version + ")";
                        } catch (Exception)
                        {

                        }
                    }
                }        
            }

            return Apps;
        }

        public bool UpdateFile()
        {
            try
            {
                XLWorkbook workbook = new XLWorkbook(FileName);
                IXLWorksheet worksheet = workbook.Worksheet("Mobilitätsanwendungen");
                IXLTable table = worksheet.Table("Apps");

                foreach (IXLTableRow row in table.DataRange.Rows())
                {
                    App app = Apps.Find(x => x.Name == row.Cell(1).GetString());
                    if(app != null)
                    {
                        row.Cell(9).Value = app.AndroidVersionNew;
                        row.Cell(10).Value = app.IOSVersionNew;
                    }
                }

                worksheet.Cell(1, 4).Value = "Letzte Versionsprüfung: " + DateTime.Now.ToString();
                workbook.SaveAs(FileName);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
