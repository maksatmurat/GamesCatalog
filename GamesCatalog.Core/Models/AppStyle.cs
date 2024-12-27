namespace GamesCatalog.Core.Models;

public class AppStyle
{
    public string Color { get; set; } = "green";
    public string Size { get; set; } = "65px";
    public List<string> WitcherWords { get; set; } = new List<string>()
    {
        new string ("Saw, Bla Bla Bla"),
        new string ("Saw, Bla Bla Bla 1"),
        new string ("Saw, Bla Bla Bla 2"),
    };
    public List<TableListModel> TableStyle { get; set; } = new List<TableListModel>()
    {
        new TableListModel(){
            Text="Table Dark",Value="table-dark" },        
        
        new TableListModel(){
            Text="Table striped",Value="table-striped" },        
        
        new TableListModel(){
            Text="Table bordered",Value="table-bordered" },        
        

    };
}
