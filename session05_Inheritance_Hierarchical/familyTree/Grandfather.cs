namespace familyTree{
    class Grandfather{
        string House,Grove,Location;
        public Grandfather(){ //Constructor
                Console.WriteLine("...I'm your Grand-Dad!...");
                House = "PoorvigaVeedu";
                Grove = "Vaalaithottam";
                Location = "SithuvarPatti";
                string[] Vehicle = {"TataSumo","Ambasitor","Trackor","MannuLorry"};
                string[] Property = {"PannaiVeedu","MattuThozhuvam","Semippukidangu","200acr-Vayal"};
        }

        public string GetHouse(){
        return House;
    }
    }

    

    class Grandmother{
         public Grandmother(){ //Constructor
                Console.WriteLine("...I'm your Grand-Mother!...");
        }
    }
}