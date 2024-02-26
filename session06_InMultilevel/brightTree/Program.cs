namespace brightTree{
    class Multilevel{
        static void Main(string [] args){
            Console.WriteLine("Hello Bright-------Tree!");
            Brightservice bs = new Brightservice();
            Console.WriteLine("Bright Service Location: "+ bs.Getlocation());
            Console.WriteLine("Bright Service FounderName: "+ bs.Getfoundername());
            // Console.WriteLine("Bright Service Officethings: "+ string.Join(" ", Getofficethings()));\
            
            Console.WriteLine("*************************************");
            CADbatch cb = new CADbatch();
            Console.WriteLine("*************************************");
            AIbatch ab = new AIbatch();
            Console.WriteLine("*************************************");
            Nightwork nw = new Nightwork();
            Console.WriteLine("*************************************");
            Student std = new Student();
        }
    }
}
