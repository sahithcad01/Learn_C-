namespace brightTree{
    class CADbatch: Brightservice{
        string[] programlang;
        string coursetime;
        int stdcount;

        public CADbatch(){
             Console.WriteLine("CAD batch!");
             coursetime = "2.00PM to 6.00PM";
             stdcount = 30;
             string[] programlang = {"HTML", "CSS", "SQL", "JAVASCRIPT", "C#", "NODEJS", ".NET", "GITHUB"};
        }
    }
}