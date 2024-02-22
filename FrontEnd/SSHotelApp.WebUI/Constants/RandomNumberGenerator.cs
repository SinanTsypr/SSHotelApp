namespace SSHotelApp.WebUI.Constants
{
    public static class RandomNumberGenerator
    {
        public static int Generator()
        {
            var rnd = new Random();
            return rnd.Next(1,5);
        }

        public static int GeneratorProgress()
        {
            var rnd = new Random();
            return rnd.Next(20, 101);
        }
    }
}
