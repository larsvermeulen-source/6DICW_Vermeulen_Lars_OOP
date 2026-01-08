// See https://aka.ms/new-console-template for more information
class Smartphone
{
    private String _telnummer;
    private String _pincode;
    public Smartphone(String telnummer, String pincode)
    {
        _telnummer = telnummer;
        _pincode = pincode;
    }
    // definieer hier de Property Telnummer
    public String Telnummer
    {
        get { return _telnummer; }
        set { _telnummer = value; }
    }
    // definieer hier de Property Pincode
    public String Pincode
    {
        get { return _pincode; }
        set { _pincode = value; }
    }
    static void Main(string[] args)
    {
        Smartphone dimGSM = new Smartphone("nummer", "1234");
        dimGSM.Telnummer = "0467046154";
        dimGSM.Pincode = "8954";
        Console.WriteLine(dimGSM.Pincode);
        Console.WriteLine(dimGSM.Telnummer);
        Console.ReadLine();
    }
}


