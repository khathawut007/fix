using System;
class Student : Person {
    private string studentID;

    public Student(string name, string adddress,string citizenID, string gender, string age, string studentID):base(name,adddress,citizenID,age,gender){
        this.studentID = studentID;
    }
    
}