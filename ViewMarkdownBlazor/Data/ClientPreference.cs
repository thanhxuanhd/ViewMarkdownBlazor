namespace ViewMarkdownBlazor.Data
{
    public record ClientPreference : IPreference
    {
        public bool IsDarkMode { get; set; }
        public string LanguageCode { get; set; }
    }
}
