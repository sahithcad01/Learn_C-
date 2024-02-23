namespace brightTree{
    class AIbatch: Brightservice{
        string[] programlang;
        string coursetime;
        int stdcount;
    
        public AIbatch(){
            Console.WriteLine("AI batch!");
            coursetime = "9.30AM to 1.30PM";
             stdcount = 30;
             string[] programlang = {"C", "C++", "SQL", "PYTHON", "GITHUB"};
        }
    }
}