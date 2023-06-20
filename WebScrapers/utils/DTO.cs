public class ScrappedData {
    private string name;
    private string description; 

    private string url;
    // Constructor 
    public ScrappedData (string url,string name ,string description){
        this.name = name;
        this.description = description;
        this.url = url;
    }

    public string Name{
        get { return name;}
        set {  name= value; }
    }

    public string Description{
        get { return description;}
        set {  description= value; }
    }

    public string Url{
        get{return url;}
        set{url= value;}
    }
}