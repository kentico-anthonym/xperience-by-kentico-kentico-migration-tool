using CMS.ContentEngine.Internal;

namespace Migration.Tool.Source.Providers;

internal class ContentItemNameValidator : IContentItemNameValidator
{
    /// <inheritdoc />
    public bool IsUnique(string name) => IsUnique(0, name);


    /// <inheritdoc />
    public bool IsUnique(int id, string name)
    {
        var contentItemInfo = new ContentItemInfo { ContentItemID = id, ContentItemName = name };

        return contentItemInfo.CheckUniqueCodeName();
    }
}
