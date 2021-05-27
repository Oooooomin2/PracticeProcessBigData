using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace PracticeProcessBigData
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false
            };
            using (var reader = new StreamReader("./Data/KEN_ALL.CSV", Encoding.GetEncoding("SHIFT_JIS")))
            {
                using var csv = new CsvReader(reader, config);
                int i = 0;
                foreach (var selectedDatum in csv.GetRecords<YuubinBangouModel>())
                {
                    i++;
                    if (selectedDatum.YuubinBangou == "3660052")
                    {
                        Console.WriteLine("住所情報： {0} {1} {2}", selectedDatum.YuubinBangou, selectedDatum.Ken, selectedDatum.Gou);
                    }
                }
                Console.WriteLine("全部で{0}行あります。", i);
            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine($"時間は　{ts.Hours}時間 {ts.Minutes}分 {ts.Seconds}秒 {ts.Milliseconds}ミリ秒 です。");
            Console.ReadLine();
        }
    }
}
