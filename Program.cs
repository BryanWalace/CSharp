//Instanciar uma Universidade
using Microsoft.VisualBasic;

Universidade objUniversidade = new Universidade();
objUniversidade.nome = "Up";
objUniversidade.localizacao = "Ecoville";
objUniversidade.anofundacao = 1990;

//Criar o curso ads e adicionar na universidade
Curso objCurso = new Curso();
objCurso.nome = "ADS";
objUniversidade.AdicionarCurso(objCurso);

//Criar o curso BSI e adicionar na universidade
objCurso = new Curso();
objCurso.nome="BSI";
objUniversidade.AdicionarCurso(objCurso);

Console.WriteLine(objUniversidade.nome);
foreach(var curso in objUniversidade.cursos){
    Console.WriteLine(curso.nome);
}