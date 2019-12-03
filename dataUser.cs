class dataUser{

  public string Nome;
  public string Telefone ;
  public string Localidade ;
  public string Titulo ;
  public string Edicao ;
  public string CadastroLivro;
  public string Contador;

  public void setContador(string cont){
    Contador = cont;
  }
  public string getContador(){
    return Contador;
  }
  
  public void setNome(string nome){
    Nome = nome;
  }
  public string getNome(){
    return Nome;
  }

  public void setTelefone(string telefone){
    Telefone = telefone;
  }
  public string getTelefone(){
    return Telefone;
  }

  public void setLocalidade(string localidade){
    Localidade = localidade;
  }
  public string getLocalidade(){
    return Localidade;
  }

  public void setTitulo(string titulo){
    Titulo = titulo;
  }
  public string getTitulo(){
    return Titulo;
  }

  public void setEdicao(string edicao){
    Edicao = edicao;
  }
  public string getEdicao(){
    return Edicao;
  }


  public void setCadastroLivro(string cadLivro){
    CadastroLivro = cadLivro;
  }
  public string getCadastroLivro(){
    return CadastroLivro;
  }


  public dataUser (string nome, string telefone, string localidade, string titulo, string edicao, string cont){
    Contador = cont;
    Nome = nome;
    Telefone = telefone;
    Localidade = localidade;
    Titulo = titulo;
    Edicao = edicao;
  }
  
  
}