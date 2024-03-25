// ./universidade.cs

public class Universidade{
    public string nome{get;set;}
    public string localizacao{get;set;}
    
    public List<Curso> cursos = new List<Curso>();

    public int anofundacao{get;set;}

    public void AdicionarCurso(Curso c){
        this.cursos.Add(c);
    }
}