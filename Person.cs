
class Person{
    protected string name;
    protected string adddress;
    protected string citizenID;
    protected string gender;
    protected string age;

    public Person(string name, string adddress,string citizenID, string gender, string age ){
        this.name = name;
        this.adddress = adddress;
        this.citizenID = citizenID;
        this.gender = gender;
        this.age = age;
    }

    public string GetName(){
        return this.name;
    }
}