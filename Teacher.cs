class Teacher : Person {
    private string employeeID;

    public Teacher(string name, string adddress,string citizenID, string gender, string age, string studentID,string employeeID):base(name,adddress,citizenID,age,gender){
        this.employeeID = employeeID;
    }


}