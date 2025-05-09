namespace CotL_AP_Randomizer.Archipelago
{
    public class Check
    {
        public static Items Item;
        public static Locations Location;

        public static bool IsHinted;
        public static bool IsCompleted;
        
        public static void Discover()
        {
            IsHinted = true;
        }
        
        public static void Complete()
        {
            IsCompleted = true;
        }
    }
} 
