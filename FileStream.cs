namespace Paula
{
    internal class FileStream
    {
        private string v;
        private object createNew;

        public FileStream(string v, object createNew)
        {
            this.v = v;
            this.createNew = createNew;
        }
    }
}