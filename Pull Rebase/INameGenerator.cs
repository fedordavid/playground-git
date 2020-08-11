namespace Pull_Rebase
{
    public interface INameGenerator
    {
        public string Name { get; set; }

        public string NewName();
    }
}