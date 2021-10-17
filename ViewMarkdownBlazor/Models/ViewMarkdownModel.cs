namespace ViewMarkdownBlazor.Models;
public class ViewMarkdownModel
{

    public string FolderName { get; set; }

    public string FolderPath { get; set; }

    public List<MarkdownItem> MarkdownItems { get; set; } = new();

    public int MarkdownCount
    {
        get {  return MarkdownItems.Count; }
    }
}

public class MarkdownItem
{
    public string Name { get; set; }

    public string FilePath { get; set; }

    public string FolderName {  get; set; }


}
