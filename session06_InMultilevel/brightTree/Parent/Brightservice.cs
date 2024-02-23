namespace brightTree{

    class Brightservice{
        string location,foundername;
        string [] officethings,labs,course,jobs;
        public Brightservice(){
            Console.WriteLine("Hello BrightService!");
            location = "Chathiram";
            foundername = "Durai";
            string[] officethings = {"AC","chairs","Fans","Tables","Systems","Biometric-Attendance","Watercan"};
            string[] labs = {"LABRoom_01","LABRoom_02","ClassRoom"};
            string[] course = {"AI Course","CAD Course","SoftSkills","Placement Training"};
            string[] jobs = {"AR voice Call Associate","Data Entry","Student Administrator","Trainer","Placement Co-ordinator"};
            // foreach(var item in officethings)
            // {
            //     Console.WriteLine(item.ToString());
            // }
            }

        public string Getlocation(){
            return location;
        }

        public string Getfoundername(){
            return foundername;
        }
    }
}