namespace exercicio2
{
    public class cliente
    {
       public int codigo;
       public string nome;
       public string endereco;
       public string cidade;
       public string estado;
       public int cep;
       public int telefone;
       public string pedcli;

        public cliente( int codigo,
                        string nome,
                        string endereco,
                        string cidade,
                        string estado,
                        int cep,
                        int telefone,
                        string pedcli)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.endereco = endereco;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
            this.telefone = telefone;
            this.pedcli = pedcli;
        }

        public void inserir (int cod, string nome, string end, string ci,string uf, int ce, int fone){
            this.codigo = cod;
            this.nome = nome;
            this.endereco = end;
            this.cidade = ci;
            this.estado = uf;
            this.cep = ce;
            this.telefone = fone;
        }

        public void consultar (string name){
            this.nome = name;
        }

        public void alterar (string name, string end, string ci, string uf, int ce, int fone){
            this.nome = name;
            this.endereco = end;
            this.cidade = ci;
            this.estado = uf;
            this.cep = ce;
            this.telefone = fone;
        }

        public void excluir (int cod){
            this.codigo = cod;
        }

        public void efetuarPedidoCliente (int cod, string ped){
            this.codigo = cod;
            this.pedcli = ped;
        }

        public void efetuarPagamento (string ped){
            this.pedcli = ped;
        }
    }
}