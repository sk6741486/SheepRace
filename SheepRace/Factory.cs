namespace SheepRace
{
    public static class Factory
    {
        // Decides which class to instantiate
        public static Punter GetAPunter(int id)
        {
            switch (id)
            { 
                case 0: return new Ali();
                case 1: return new JoJo();
                case 2: return new Moto();
                default: return null;
            }
        }

    }
}
