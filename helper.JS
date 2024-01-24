// Generate Unique ID 

var spread = new GC.Spread.Sheets.Workbook(document.getElementById('spreadjs-container'));
var activeSheet = spread.getActiveSheet();

// Function to generate a unique identifier
function generateUniqueId() {
    // Implement your own logic to generate a unique identifier
    return Math.random().toString(36).substring(2, 15) + Math.random().toString(36).substring(2, 15);
}

// Attach an event listener to the cellChanged event
activeSheet.bind(GC.Spread.Sheets.Events.CellChanged, function (e, args) {
    var cell = args.cell;

    // Check if the cell has a custom identifier
    if (!cell.tag || !cell.tag.uniqueId) {
        // Assign a unique identifier to the cell
        cell.tag = {
            uniqueId: generateUniqueId()
        };

        console.log('Assigned Unique ID to Cell:', cell.tag.uniqueId);
    } else {
        console.log('Existing Unique ID of Cell:', cell.tag.uniqueId);
    }
});

// While Copy operation remove cell tag 

var spread = new GC.Spread.Sheets.Workbook(document.getElementById('spreadjs-container'));
var activeSheet = spread.getActiveSheet();

// Attach an event listener to the clipboardChanging event
spread.bind(GC.Spread.Sheets.Events.ClipboardChanging, function (e, args) {
    var ranges = args.ranges;
    var isCutting = args.isCutting;

    // Check if it's a copy operation and not a cut operation
    if (!isCutting) {
        for (var i = 0; i < ranges.length; i++) {
            var range = ranges[i];
            for (var row = range.row; row < range.row + range.rowCount; row++) {
                for (var col = range.col; col < range.col + range.colCount; col++) {
                    var cell = activeSheet.getCell(row, col);

                    // Remove the 'tag' property from the copied data
                    if (cell.tag) {
                        delete cell.tag;
                    }
                }
            }
        }
    }
});

// Example: Assign a tag to a cell
activeSheet.getCell(0, 0).tag = { uniqueId: '123' };



//Add custom attribute as unique id 


var spread = new GC.Spread.Sheets.Workbook(document.getElementById('spreadjs-container'));
var activeSheet = spread.getActiveSheet();

// Attach an event listener to the clipboardChanging event
spread.bind(GC.Spread.Sheets.Events.ClipboardChanging, function (e, args) {
    var ranges = args.ranges;
    var isCutting = args.isCutting;
    var clipboardData = args.clipboardData;

    // Check if it's a copy operation and not a cut operation
    if (!isCutting) {
        // Iterate through the selected ranges
        for (var i = 0; i < ranges.length; i++) {
            var range = ranges[i];

            // Create a container to hold the HTML content
            var htmlContent = document.createElement('div');

            // Iterate through the cells in the range
            for (var row = range.row; row < range.row + range.rowCount; row++) {
                for (var col = range.col; col < range.col + range.colCount; col++) {
                    var cell = activeSheet.getCell(row, col);

                    // Check if the cell has a 'tag' property with a 'uniqueId'
                    if (cell.tag && cell.tag.uniqueId) {
                        // Create a <div> element for the cell content
                        var cellContent = document.createElement('div');
                        
                        // Add the uniqueId as a custom attribute (e.g., data-unique-id)
                        cellContent.setAttribute('data-unique-id', cell.tag.uniqueId);

                        // Set the innerHTML of the cellContent
                        cellContent.innerHTML = cell.text();

                        // Append the cellContent to the htmlContent container
                        htmlContent.appendChild(cellContent);
                    }
                }
            }

            // Set the modified HTML content to the clipboardData
            clipboardData.html = htmlContent.innerHTML;
        }
    }
});

// Example: Assign a tag to a cell
activeSheet.getCell(0, 0).tag = { uniqueId: '123' };


// Maintain in local storage cell tag 

// Function to set unique ID for a cell and save to localStorage
function setCellUniqueId(row, col, uniqueId) {
    var cellAddress = row + '-' + col;
    localStorage.setItem(cellAddress, uniqueId);
}

// Function to get unique ID for a cell from localStorage
function getCellUniqueId(row, col) {
    var cellAddress = row + '-' + col;
    return localStorage.getItem(cellAddress);
}

var row = 0, col = 0, uniqueId = '123';

// Set unique ID for a cell and save to localStorage
setCellUniqueId(row, col, uniqueId);

// Retrieve unique ID for a cell from localStorage
var retrievedUniqueId = getCellUniqueId(row, col);
console.log('Retrieved Unique ID:', retrievedUniqueId);

// ---------------------------------------------------------------------------- Add name property 
// Assuming you have a Spread instance
var spread = new GC.Spread.Sheets.Workbook(document.getElementById("ss"));

// Assuming you have a sheet instance
var sheet = spread.getSheet(0);

// Assuming you want to add a name to cell at row 1, column 1
var cell = sheet.getCell(0, 0);

// Create a named style
var namedStyle = new GC.Spread.Sheets.Style();
namedStyle.name = "MyNamedStyle"; // Set the name for the style
namedStyle.backColor = "yellow"; // Set other style properties as needed

// Add the named style to the workbook
spread.addNamedStyle(namedStyle);

// Apply the named style to the cell
cell.setStyle("MyNamedStyle");

///------------------------------------Altername to add name

// Assuming you have a Spread instance
var spread = new GC.Spread.Sheets.Workbook(document.getElementById("ss"));

// Assuming you have a sheet instance
var sheet = spread.getSheet(0);

// Assuming you want to set a name to the cell at row 1, column 1
var cell = sheet.getCell(0, 0);

// Set the name property for the cell's style
cell.s('name', 'MyCellName');





