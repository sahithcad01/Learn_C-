namespace familyTree{ //namespace ---
    
    class Program{
        static void Main(string [] args){
            Console.WriteLine("Welcome to Our Family!");
            Grandfather house = new Grandfather();
            Grandfather gf = new Grandfather();
            Grandmother gm = new Grandmother();
            Father fr= new Father(); //Object1--
            Son sn= new Son(); //Object2--

            Console.WriteLine("GHouse "+ house.GetHouse());
        }
    }
}