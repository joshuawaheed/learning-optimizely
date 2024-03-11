using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Pages
{
    [ContentType(
        Description = "The home page for a website with an area for blocks and potential pages.",
        DisplayName = "Start",
        GroupName = SiteGroupNames.Specialized,
        GUID = "3F2197A7-3AE9-4756-8C74-98A2411D2453",
        Order = 10)]
    [SiteStartIcon]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Description = "If the Heading is not set, the page falls back to showing the Name.",
            Name = "Heading",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Description = "The main body uses the XHTML-editor so you can insert, for example text, images, and tables.",
            GroupName = SystemTabNames.Content,
            Name = "Main body",
            Order = 20)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(
            Description = "The main content area contains an ordered collection to content references, for example blocks, media assets, and pages.",
            GroupName = SystemTabNames.Content,
            Name = "Main content area",
            Order = 30)]
        public virtual ContentArea MainContentArea { get; set; }

        [CultureSpecific]
        [Display(
            Description = "The footer text will be shown at the bottom of every page.",
            GroupName = SiteTabNames.SiteSettings,
            Name = "Footer text",
            Order = 10)]
        public virtual string FooterText { get; set; }
    }
}
