namespace brightTree{
    class AIbatch: Brightservice{
        string[] AIprogramlang;
        string AIcoursetime;
        int AIstdcount;
    
        public AIbatch(){
            Console.WriteLine("AI batch!");
            AIcoursetime = "9.30AM to 1.30PM";
            AIstdcount = 30;
            string[] AIprogramlang = {"C", "C++", "SQL", "PYTHON", "GITHUB"};
        }
    }
}