function fetchData() {
  return new Promise((resolve, reject) => {
    setTimeout(() => {
      const success = true; // Change to false to simulate failure

      if (success) {
        resolve("Data fetched successfully!"); // Resolve with a success message
      } else {
        reject("Failed to fetch data."); // Reject with an error message
      }
    }, 2000); // 2-second delay to simulate async operation
  });
}

// Async function using await to handle the Promise result
async function getData() {
  console.log("Fetching data...");

  try {
    // Await the fetchData Promise
    const result = await fetchData();
    console.log(result); // Logs "Data fetched successfully!" after 2 seconds
  } catch (error) {
    console.error(error); // If the Promise is rejected, this catches the error
  }

  console.log("Done.");
}

// Call the async function
getData();
