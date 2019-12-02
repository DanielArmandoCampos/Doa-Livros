class Doador:Endereco{
  private string nome, email;
  private int cell;
  public Doador(string nome, int cell, string email, string rua, string cidade, string bairro, string estado, string pais, int numero):base(rua, cidade, bairro, estado, pais, numero){
    this.nome = nome;
    this.cell = cell;
    this.email = email;
  }

}