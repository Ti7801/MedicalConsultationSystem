namespace BibliotecaBusiness.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }    
        public DateTime Nascimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }

    }
}
