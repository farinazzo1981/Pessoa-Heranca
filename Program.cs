using Pessoa_Herança;

Pessoa.numeroPessoa = 10;

Aluno aluno = new Aluno();

aluno.RA = "G4613G-7";
aluno.curso = "ADS";

Professor professor = new Professor();

professor.funcional = "Professor de programação oo";

Cadastro c = new Cadastro();
c.AddPessoa(aluno);
c.AddPessoa(professor);

Console.WriteLine(aluno.GetIdentificacao());

IPessoa P = new Professor();
P.GetIdentificacao();

Console.WriteLine(professor.GetIdentificacao());