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



