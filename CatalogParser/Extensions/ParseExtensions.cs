using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using OfficeOpenXml.Style;

namespace CatalogParser.Extensions
{
    public static class ParseExtensions
    {
        public static IEnumerable<T> Parse<T>(this Stream stream, object bindObject, int row = 2)
        {
            var items = new List<T>();
            MethodInfo convert;
            MethodInfo[] converts = typeof(Convert).GetMethods();
            PropertyInfo prop;
            PropertyInfo[] props = typeof(T).GetProperties();
            PropertyInfo[] bindingProps = bindObject.GetType().GetProperties();

            using (var p = new ExcelPackage(stream))
            {
                try
                {
                    using (var ws = p.Workbook.Worksheets.FirstOrDefault())
                    {
                        if (ws == null)
                            throw new Exception("Nothing to parse");

                        while (ws.Cells[row, 1].Value != null)
                        {
                            var item = Activator.CreateInstance<T>();
                            foreach (var t in props)
                            {
                                convert = converts.FirstOrDefault(x => x.Name == $"To{t.PropertyType.Name}");
                                if (convert != null)
                                {
                                    var cell = (int)bindingProps.First(x => x.Name == t.Name).GetValue(bindObject);
                                    var value = ws.Cells[row, cell].Value;
                                    t.SetValue(item, convert.Invoke(null, new[] { value }));
                                }
                                else throw new Exception();
                            }
                            items.Add(item);
                            row++;
                        }
                    }
                    return items;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public static MemoryStream ExportToExcel<T>(this IEnumerable<T> collection, List<string> headers = null)
        {
            if (collection == null) return new MemoryStream();
            using (var fs = new MemoryStream())
            {
                using (var p = new ExcelPackage())
                {
                    try
                    {
                        var ws = p.Workbook.Worksheets.Add("Sheet 1");

                        var props = typeof(T).GetProperties();

                        //date column styling
                        for (int i = 0; i < props.Length; i++)
                        {
                            if (props[i].GetValue(collection.First()) is DateTime)
                                ws.Column(i + 1).Style.Numberformat.Format = "dd.mm.yyyy";
                            if (props[i].GetValue(collection.First()) is float)
                                ws.Column(i + 1).Style.Numberformat.Format = "0.00";
                            ws.Cells[1, i + 1].Value = headers[i];
                        }

                        ws.Cells[2, 1].LoadFromCollection(collection);
                        //data styling
                        for (int i = 2; i <= collection.Count() + 1; i++)
                        {
                            for (int j = 1; j <= headers.Count; j++)
                            {
                                ws.Cells[i, j].Style.Border.BorderAround(ExcelBorderStyle.Thin, Color.Black);
                            }
                        }
                        //headers styling
                        for (int i = 1; i <= headers.Count; i++)
                        {
                            ws.Cells[1, i].Style.Border.BorderAround(ExcelBorderStyle.Medium, Color.Black);
                            ws.Cells[1, i].Style.Font.Bold = true;
                        }
                        ws.Cells.AutoFitColumns();
                        p.SaveAs(fs);
                        return fs;
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }

                }
            }
        }
    }
}