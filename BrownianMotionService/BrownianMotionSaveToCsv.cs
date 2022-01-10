using BrownianMotionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrownianMotionService
{
    public class BrownianMotionSaveToCsv
    {
        public const char separator = ';';

        public Result SaveDataToCsvFile(string filePath, List<BrownPoint> points, decimal vector)
        {
            if (string.IsNullOrEmpty(filePath))
                return Result.Fail("Podano pustą ścieżkę.");

            if(filePath.EndsWith(".csv") == false)
            {
                filePath += ".csv";
            }

            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Wygenerowano {points.Count} punktow{separator}Wektor ={separator}{vector}");
            builder.AppendLine($"Numer punktu{separator}X{separator}Y");

            for (int i = 0; i < points.ToList().Count; i++)
            {
                var point = points.ElementAt(i);
                builder.AppendLine($"\"{i+1}\"{separator}\"{point.X}\"{separator}\"{point.Y}\"");
            }

            try
            {
                using (var writeStream = new System.IO.FileStream(filePath, System.IO.FileMode.OpenOrCreate))
                {
                    var bytes = new UTF8Encoding(true).GetBytes(builder.ToString());
                    writeStream.Write(bytes, 0, bytes.Length);
                }

                return Result.Ok();
            }
            catch (Exception ex)
            {
                return Result.Fail("Wystąpił błąd przy zapisywaniu pliku:\r\n" + ex.Message);
            }
        }
    }
}
