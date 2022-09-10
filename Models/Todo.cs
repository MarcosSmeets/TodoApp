using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyTodoApp.Models
{
    public class Todo
    {
        public int id { get; set; }
        [DisplayName("Título")]
        [Required(ErrorMessage="Campo Obrigatório")]
        public string Title { get; set; }
        [DisplayName("Concluído")]
        public bool Done { get; set; }
        [DisplayName("Criado Em")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [DisplayName("Última atualização")]
        public DateTime LastUpdateAt { get; set; } = DateTime.Now;
        [DisplayName("Usuario")]
        public string User { get; set; }
    }
}