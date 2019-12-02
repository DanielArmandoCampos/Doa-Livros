class Livro{
  private string nome, editora, autor;
  private int anoDePublicacao = 0;

  public Livro(string nome, string editora, string autor, int anoDePublicacao){
    this.nome = nome;
    this.editora = editora;
    this.autor = autor;
    this.anoDePublicacao = anoDePublicacao;
  }
}