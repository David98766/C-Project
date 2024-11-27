using Microsoft.AspNetCore.Razor.TagHelpers;

namespace IS4439_Project_1.Views.Shared.TagHelpers
{
       // Create a custom TagHelper class that extends the base TagHelper class
    public class CexTagHelper : TagHelper
    {
        // Property to hold the URL to which the tag will link
        public String url { get; set; }
        
        // Property to hold the name or text that will be displayed in the link
        public String name { get; set; }
        
        // Override the Process method to define the behavior of the TagHelper
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            // Set the output tag name to "a" to create an anchor link
            output.TagName = "a"; 
            
            // Set the href attribute of the anchor tag to the provided URL
            output.Attributes.SetAttribute("href", url); // Set the attributes for the tag
            
            // Set the content of the anchor tag to the specified name
            output.Content.SetContent(name); // Set the Content
        }
    }
}