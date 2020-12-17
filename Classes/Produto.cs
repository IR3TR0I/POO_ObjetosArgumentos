namespace Objeto_Argumento.Classes
{
    public class Produtos
    {
        private int v1;
        private string v2;
        private float v3;

        //Atributos 
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        
        // Primeiro método construtor(Não leva argumento)
        public Produtos() {

        }

        //Segundo método Construtor(Recebe valor como argumento e atribui a instancia que foi criada)
        public Produtos(int _codigo, string _nome, float _preco, float v) {
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;
        }

        public Produtos(int v1, string v2, float v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }
}