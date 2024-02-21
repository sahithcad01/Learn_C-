//Inheritance:
//4 Types:
//1.Single Inheritance--
//2.Hierarchical Inheritance--
//3.Multi-level --
//4.Multiple--

//SINGLE INHERITANCE---
using System;
class KRGI{
    public string location;
    public string position;

    public KRGI()
    {
        Console.WriteLine("Welcome to K.Ramakrishnan Group of Institutions!");
    }
    public string branch(string branchname){
        return "It has 3 branches & this is branch: "+ branchname;
    }
}

class KRCE : KRGI {
    public KRCE(string principal){
        location = "Trichy-Samayapuram";
        Console.WriteLine(branch(principal)+ " "+ location);
    }
}

class MKCE : KRGI {
    public MKCE(string principal){
        location = "Karur-Thalavapaalayam";
        Console.WriteLine(branch(principal)+ " "+ location);
    }
}

class KRCT : KRGI {
    public KRCT(string principal){
        location = "Trichy-Kariyamanikam_Road";
        Console.WriteLine(branch(principal)+ " "+ location);
    }
}

class Colleges{
    static void Main(string [] args){
        KRCE clg1 = new KRCE("Dr.D.Srinivaasan");
        KRCT clg2 = new KRCT("Dr.N.Vasudevan");
        MKCE clg3 = new MKCE("Dr.B.S.Murugan");
    }
}
