// Fetch and set value 

using System;
using AngleSharp;
using AngleSharp.Dom;

class Program
{
    static void Main()
    {
        // Your HTML content or URL goes here
        string html = "<html><body><div class='parent'><div class='flag'>Target Element</div><div>Last Child Value</div></div><div class='output'></div></body></html>";

        // Create a new browsing context
        var context = BrowsingContext.New(Configuration.Default);

        // Parse the HTML
        var document = context.OpenAsync(req => req.Content(html)).Result;

        // Find the element with class name "flag"
        var flagElement = document.QuerySelector(".flag");

        if (flagElement != null)
        {
            // Get the parent element
            var parentElement = flagElement.ParentElement;

            if (parentElement != null)
            {
                // Get the last child of the parent element
                var lastChild = parentElement.LastElementChild;

                if (lastChild != null)
                {
                    // Get the value/text content of the last child
                    string lastChildValue = lastChild.TextContent;

                    // Find the element where you want to set the value
                    var outputElement = document.QuerySelector(".output");

                    if (outputElement != null)
                    {
                        // Set the value of the output element
                        outputElement.TextContent = lastChildValue;

                        // Print the updated HTML
                        Console.WriteLine(document.DocumentElement.OuterHtml);
                    }
                    else
                    {
                        Console.WriteLine("Output element not found");
                    }
                }
                else
                {
                    Console.WriteLine("Parent element has no children");
                }
            }
            else
            {
                Console.WriteLine("Parent element not found");
            }
        }
        else
        {
            Console.WriteLine("Element with class name 'flag' not found");
        }
    }
}


//Get based on Flag 

using System;
using System.Linq;
using AngleSharp;
using AngleSharp.Dom;

class Program
{
    static void Main()
    {
        // Your HTML content or URL goes here
        string html = "<html><body><div class='parent'><div class='flag'>Target Element</div></div></body></html>";

        // Create a new browsing context
        var context = BrowsingContext.New(Configuration.Default);

        // Parse the HTML
        var document = context.OpenAsync(req => req.Content(html)).Result;

        // Find the element with class name "flag"
        var flagElement = document.QuerySelector(".flag");

        if (flagElement != null)
        {
            // Get the parent element
            var parentElement = flagElement.ParentElement;

            if (parentElement != null)
            {
                // Print the outer HTML of the parent element
                Console.WriteLine(parentElement.OuterHtml);
            }
            else
            {
                Console.WriteLine("Parent element not found");
            }
        }
        else
        {
            Console.WriteLine("Element with class name 'flag' not found");
        }
    }
}


// Get parents last child 

using System;
using System.Linq;
using AngleSharp;
using AngleSharp.Dom;

class Program
{
    static void Main()
    {
        // Your HTML content or URL goes here
        string html = "<html><body><div class='parent'><div class='flag'>Target Element</div><div>Last Child</div></div></body></html>";

        // Create a new browsing context
        var context = BrowsingContext.New(Configuration.Default);

        // Parse the HTML
        var document = context.OpenAsync(req => req.Content(html)).Result;

        // Find the element with class name "flag"
        var flagElement = document.QuerySelector(".flag");

        if (flagElement != null)
        {
            // Get the parent element
            var parentElement = flagElement.ParentElement;

            if (parentElement != null)
            {
                // Get the last child of the parent element
                var lastChild = parentElement.LastElementChild;

                if (lastChild != null)
                {
                    // Get the value/text content of the last child
                    string lastChildValue = lastChild.TextContent;
                    Console.WriteLine("Last Child Value: " + lastChildValue);
                }
                else
                {
                    Console.WriteLine("Parent element has no children");
                }
            }
            else
            {
                Console.WriteLine("Parent element not found");
            }
        }
        else
        {
            Console.WriteLine("Element with class name 'flag' not found");
        }
    }
}

//update value to span

using System;
using System.Linq;
using AngleSharp;
using AngleSharp.Dom;

class Program
{
    static void Main()
    {
        // Your HTML content or URL goes here
        string html = "<html><body><div class='parent'><span class='flag'>Old Value</span></div></body></html>";

        // Create a new browsing context
        var context = BrowsingContext.New(Configuration.Default);

        // Parse the HTML
        var document = context.OpenAsync(req => req.Content(html)).Result;

        // Find the element with class name "flag"
        var flagElement = document.QuerySelector(".flag");

        if (flagElement != null)
        {
            // Update the value of the span tag
            flagElement.TextContent = "New Value";

            // Print the updated HTML
            Console.WriteLine(document.DocumentElement.OuterHtml);
        }
        else
        {
            Console.WriteLine("Element with class name 'flag' not found");
        }
    }
}

// Get Custom attribute 

using System;
using AngleSharp;
using AngleSharp.Dom;

class Program
{
    static void Main()
    {
        // Your HTML content or URL goes here
        string html = "<html><body><div class='example' data-custom-attribute='custom-value'>Target Element</div></body></html>";

        // Create a new browsing context
        var context = BrowsingContext.New(Configuration.Default);

        // Parse the HTML
        var document = context.OpenAsync(req => req.Content(html)).Result;

        // Find the element with class name "example"
        var exampleElement = document.QuerySelector(".example");

        if (exampleElement != null)
        {
            // Get the value of the custom attribute "data-custom-attribute"
            string customAttributeValue = exampleElement.GetAttribute("data-custom-attribute");

            if (!string.IsNullOrEmpty(customAttributeValue))
            {
                Console.WriteLine("Custom Attribute Value: " + customAttributeValue);
            }
            else
            {
                Console.WriteLine("Custom attribute not found or has no value.");
            }
        }
        else
        {
            Console.WriteLine("Element with class name 'example' not found");
        }
    }
}

// set attribute 

using System;
using AngleSharp;
using AngleSharp.Dom;

class Program
{
    static void Main()
    {
        // Your HTML content or URL goes here
        string html = "<html><body><div data-custom-attribute='original-value'>Target Element</div></body></html>";

        // Create a new browsing context
        var context = BrowsingContext.New(Configuration.Default);

        // Parse the HTML
        var document = context.OpenAsync(req => req.Content(html)).Result;

        // Find the element by custom attribute
        var elementWithCustomAttribute = document.QuerySelector("[data-custom-attribute]");

        if (elementWithCustomAttribute != null)
        {
            // Set a new value for the custom attribute
            elementWithCustomAttribute.SetAttribute("data-custom-attribute", "new-value");

            // Print the updated HTML
            Console.WriteLine(document.DocumentElement.OuterHtml);
        }
        else
        {
            Console.WriteLine("Element with custom attribute not found");
        }
    }
}



// ssjson convert

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using ClosedXML.Excel;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Read the XLSX file
        using (var workbook = new XLWorkbook("input.xlsx"))
        {
            var ws = workbook.Worksheet(1); // Assuming data is in the first sheet

            // Step 2: Transform the data
            var ssjsonData = new List<Dictionary<string, object>>();
            var headers = new List<string>();

            foreach (var cell in ws.FirstRowUsed().Cells())
            {
                headers.Add(cell.Value.ToString());
            }

            foreach (var row in ws.RowsUsed().Skip(1)) // Skip header row
            {
                var rowData = new Dictionary<string, object>();

                for (int i = 0; i < headers.Count; i++)
                {
                    rowData.Add(headers[i], row.Cell(i + 1).Value);
                }

                ssjsonData.Add(rowData);
            }

            // Step 3: Serialize to SSJSON
            var ssjson = JsonConvert.SerializeObject(ssjsonData);

            // Write SSJSON to a file
            File.WriteAllText("output.ssjson", ssjson);

            Console.WriteLine("Conversion complete.");
        }
    }
}


// replace file ssjson

using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

public class SheetData
{
    public string Name { get; set; }
    public object Data { get; set; }
}

public class SSJSONFile
{
    public SheetData[] Sheets { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Read contents of both SSJSON files into C# objects
        string fileAPath = "path_to_file_A.ssjson";
        string fileBPath = "path_to_file_B.ssjson";

        SSJSONFile ssjsonA = JsonConvert.DeserializeObject<SSJSONFile>(File.ReadAllText(fileAPath));
        SSJSONFile ssjsonB = JsonConvert.DeserializeObject<SSJSONFile>(File.ReadAllText(fileBPath));

        // Find sheet1 data in file A
        var sheet1A = ssjsonA.Sheets.FirstOrDefault(sheet => sheet.Name == "sheet1");
        if (sheet1A != null)
        {
            // Replace sheet1 data in file B with data from file A
            var sheet1BIndex = Array.FindIndex(ssjsonB.Sheets, sheet => sheet.Name == "sheet1");
            if (sheet1BIndex != -1)
            {
                ssjsonB.Sheets[sheet1BIndex].Data = sheet1A.Data;
            }
            else
            {
                // Sheet1 not found in file B, you can handle this case accordingly
                Console.WriteLine("Sheet1 not found in file B.");
            }
        }
        else
        {
            // Sheet1 not found in file A, you can handle this case accordingly
            Console.WriteLine("Sheet1 not found in file A.");
        }

        // Write the modified data back to file B
        File.WriteAllText(fileBPath, JsonConvert.SerializeObject(ssjsonB));

        Console.WriteLine("Sheet1 data replaced successfully.");
    }
}
// open xml

using Newtonsoft.Json;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Read the XLSX file using OpenXML
        string filePath = "input.xlsx";
        var ssjsonData = new List<Dictionary<string, object>>();

        using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(filePath, false))
        {
            WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
            WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
            Worksheet worksheet = worksheetPart.Worksheet;
            SharedStringTablePart stringTablePart = workbookPart.SharedStringTablePart;
            SharedStringTable sharedStringTable = stringTablePart.SharedStringTable;

            // Step 2: Transform the data
            var headers = new List<string>();
            var rows = worksheet.Descendants<Row>().Skip(1); // Skip header row

            foreach (Cell cell in worksheetPart.Worksheet.Descendants<Cell>())
            {
                string cellValue = cell.CellValue?.InnerText;

                if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
                {
                    int.TryParse(cellValue, out int sharedStringIndex);
                    cellValue = sharedStringTable.ElementAt(sharedStringIndex).InnerText;
                }

                if (cell.RowIndex == 1)
                {
                    headers.Add(cellValue);
                }
                else
                {
                    int columnIndex = CellReferenceToIndex(cell.CellReference);
                    if (ssjsonData.Count < columnIndex + 1)
                    {
                        ssjsonData.Add(new Dictionary<string, object>());
                    }
                    ssjsonData[columnIndex].Add(headers[columnIndex], cellValue);
                }
            }
        }

        // Step 3: Serialize to SSJSON
        var ssjson = JsonConvert.SerializeObject(ssjsonData);

        // Write SSJSON to a file
        File.WriteAllText("output.ssjson", ssjson);

        Console.WriteLine("Conversion complete.");
    }

    static int CellReferenceToIndex(string cellReference)
    {
        int index = 0;
        foreach (char c in cellReference)
        {
            if (Char.IsLetter(c))
            {
                index = index * 26 + (c - 'A' + 1);
            }
            else
            {
                break;
            }
        }
        return index - 1;
    }
}


// new convert


using System;
using System.IO;
using System.Collections.Generic;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        string inputFilePath = "input.xlsx";
        string outputFilePath = "output.ssjson";

        // Load the Excel file
        using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(inputFilePath, false))
        {
            WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
            WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
            Worksheet worksheet = worksheetPart.Worksheet;
            SheetData sheetData = worksheet.GetFirstChild<SheetData>();

            // Parse the rows and cells to extract data
            List<Dictionary<string, string>> rowData = new List<Dictionary<string, string>>();
            foreach (Row row in sheetData.Elements<Row>())
            {
                Dictionary<string, string> cellData = new Dictionary<string, string>();
                foreach (Cell cell in row.Elements<Cell>())
                {
                    string columnName = GetColumnName(cell.CellReference);
                    string cellValue = GetCellValue(spreadsheetDocument, cell);
                    cellData.Add(columnName, cellValue);
                }
                rowData.Add(cellData);
            }

            // Serialize the data to SSJSON format
            string ssjson = JsonConvert.SerializeObject(rowData, Formatting.Indented);

            // Write the SSJSON data to the output file
            File.WriteAllText(outputFilePath, ssjson);
        }

        Console.WriteLine("Conversion completed.");
    }

    static string GetCellValue(SpreadsheetDocument document, Cell cell)
    {
        SharedStringTablePart stringTablePart = document.WorkbookPart.SharedStringTablePart;
        if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
        {
            return stringTablePart.SharedStringTable.ChildElements[int.Parse(cell.InnerText)].InnerText;
        }
        else
        {
            return cell.InnerText;
        }
    }

    static string GetColumnName(string cellReference)
    {
        // Excel cell references are in the form of letters followed by numbers
        // We extract letters to determine the column name
        string columnName = "";
        foreach (char c in cellReference)
        {
            if (char.IsLetter(c))
            {
                columnName += c;
            }
            else
            {
                break;
            }
        }
        return columnName;
    }
}