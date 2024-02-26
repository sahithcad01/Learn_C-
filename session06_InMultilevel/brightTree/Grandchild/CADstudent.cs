namespace brightTree{
    class Student: CADbatch{
        string stdlocation,stdname,stdgender,stdusername,stdpassword;
        int rollno;
        public Student(){
            Console.WriteLine("We are Student for CAD batch!");
            rollno = 1001;
            stdname = "Shahith";
            stdgender= "Male";
            stdlocation= "Trichy";
            stdusername = "sahithcad01";
            stdpassword = "BRIGHT@2024ps";
        }
    }
}