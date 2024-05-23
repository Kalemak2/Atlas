namespace Animals
{
    class Program
    {
        public static void Main(string[] args) {
            string mammalspath = @"mammals.json";

            if (!File.Exists(mammalspath))
            {
                File.Create(mammalspath).Close();
                File.WriteAllText(mammalspath, "[]");
            }
            string fishpath = @"fish.json";

            if (!File.Exists(fishpath))
            {
                File.Create(fishpath).Close();
                File.WriteAllText(fishpath, "[]");
            }
            string birdspath = @"birds.json";

            if (!File.Exists(birdspath))
            {
                File.Create(birdspath).Close();
                File.WriteAllText(birdspath, "[]");
            }
            Menu.Menu.MenuSystem();
        }
    }
}