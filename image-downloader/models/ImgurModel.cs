namespace image_downloader.models
{
    class ImgurModel : Model
    {
        public override string url
        {
            get => "https://i.imgur.com/";
        }
        public override int[] blacklistSizes
        {
            get => new int[] { 7 };
        }
        public override int length
        {
            get => 7;
        }
        public override string imgType
        {
            get => ".png";
        }

        public override string GenerateURL()
        {
            string ret = url;
            ret += utils.GenerateRandomString(length);
            ret += imgType;

            return ret;
        }
    }
}
