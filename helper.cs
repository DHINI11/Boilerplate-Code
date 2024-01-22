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

