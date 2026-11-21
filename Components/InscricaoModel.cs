using System.ComponentModel.DataAnnotations;

namespace SistemaInscricaoCursosBlazor.Components.Models
{
    public class InscricaoModel
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Insira um endereço de e-mail válido (ex: nome@dominio.com).")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Idade é obrigatório.")]
        [Range(16, 100, ErrorMessage = "A idade deve estar entre 16 e 100 anos.")]
        public int Idade { get; set; } = 16;

        [Required(ErrorMessage = "Por favor, selecione um curso.")]
        public string CursoId { get; set; } = string.Empty;
    }
}