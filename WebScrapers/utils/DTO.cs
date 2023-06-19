public class ScrappedData {
    private string name;
    private string description; 

    // Constructor 
    public ScrappedData (string name ,string description){
        this.name = name;
        this.description = description;
    }

    public string Name{
        get { return name;}
        set {  name= value; }
    }

    public string Description{
        get { return description;}
        set {  description= value; }
    }
}