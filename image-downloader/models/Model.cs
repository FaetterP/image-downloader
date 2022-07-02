namespace image_downloader.models
{
    abstract class Model
    {
        abstract public string url
        {
            get;
        }
        abstract public int[] blacklistSizes
        {
            get;
        }
        abstract public int length
        {
            get;
        }
        abstract public string imgType
        {
            get;
        }

        abstract public string GenerateURL();
    }
}
