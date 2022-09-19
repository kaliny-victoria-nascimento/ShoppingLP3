namespace ShoppingLP3.ViewModels;
public class LojaViewModel
{
    public int Id {get; set; }       
    public string Piso { get; set; }    
    public string Nome { get; set; } 
    public string Descricao { get; set; }
    public bool LojaKiosq { get; set; } 
    public string Email { get; set; }      
       
     
    public LojaViewModel(int id,string piso, string nome,  string descricao, bool lojaKiosq,  string email)
    {
        Id = id;
        Piso = piso;
        Nome = nome;
        Descricao = descricao;
        LojaKiosq = lojaKiosq;
        Email = email;
    }
}