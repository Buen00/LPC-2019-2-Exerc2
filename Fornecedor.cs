namespace exercicio2
{
    public class Fornecedor
    {
        public int codigo;
        public string nome;
        public string endereco;
        public string cidade;
        public string estado;
        public int cep;
        public int telefone;
        public string pedfor;
        public int cnpj;

        public Fornecedor ( int codigo,
                            string nome,
                            string endereco,
                            string cidade,
                            string estado,
                            int cep,
                            int telefone,
                            string pedfor,
                            int cnpj)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.endereco = endereco;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
            this.telefone = telefone;
            this.pedfor = pedfor;
            this.cnpj = cnpj;
        }

        public void inserir (int cod, string name, string end, string ci, string uf, int ce, int fone, int cn){
            this.codigo = cod;
            this.nome = name;
            this.endereco = end;
            this.cidade = ci;
            this.estado = uf;
            this.cep = ce;
            this.telefone = fone;
            this.cnpj = cn;
        }

        public void excluir(int cod){
            this.codigo = cod;
        }

        public void consultar(int cod, string name){
            this.codigo = cod;
            this.nome = name;
        }

        public void alterar (int cod, string name, string end, string ci, string uf, int fone){
            this.codigo = cod;
            this.nome = name;
            this.endereco = end;
            this.cidade = ci;
            this.estado = uf;
            this.telefone = fone;
        }
    }
}